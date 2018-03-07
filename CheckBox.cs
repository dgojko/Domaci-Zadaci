 [Test]

        public void Cas34CheckBox()
        {
            //idemo na stranicu za checkbox
            GoTOURL("http://www.seleniumeasy.com/test/basic-checkbox-demo.html");
            Sleep(5);

            //definisemo element
            IWebElement chkBox1 = driver.FindElement(By.Id("isAgeSelected"));

            //potvrda prisutnosti elementa i ispis u fajl
            bool sChkBox = chkBox1.Displayed;
            isDisplayed = Convert.ToString(sChkBox);
            System.IO.File.AppendAllText("g:\\QA testing - Rajak\\Results\\34.txt", "TC 001 Step 001 - Single CheckBox is displayed - " + isDisplayed + Environment.NewLine);

            //selektujemo checkbox
            chkBox1.Click();

            //proveravamo property elementa
            bool chk1 = chkBox1.Selected;
            if (chk1)
            {
                System.IO.File.AppendAllText("g:\\QA testing - Rajak\\Results\\34.txt", "TC 001 Step 002 - Single CheckBox is checked " + Environment.NewLine);
            }
            else
                System.IO.File.AppendAllText("g:\\QA testing - Rajak\\Results\\34.txt", "TC 001 Step 002 - Single CheckBox is NOT checked " + Environment.NewLine);

            //provera poruke
            IWebElement chbText = driver.FindElement(By.Id("txtAge"));
           
            bool chk2 = chbText.Displayed;
            if (chk2)
            {
                System.IO.File.AppendAllText("g:\\QA testing - Rajak\\Results\\34.txt", "TC 001 Step 003 - Message: Success - Check box is checked is displayed " + Environment.NewLine);
            }
            else
                System.IO.File.AppendAllText("g:\\QA testing - Rajak\\Results\\34.txt", "TC 001 Step 003 - Message: Success - Check box is checked is NOT displayed " + Environment.NewLine);

            //Click on 'Check All' to check all checkboxes at once.
            IWebElement allButton1 = WaitForElement(By.XPath("//input[@id='check1' and @value='Check All']"), 3);
            allButton1.Click();
            Sleep(1);

            //IWebElement allButton2 = driver.FindElement(By.XPath("//input[@id='check1' and @value='Uncheck All']"));
            //allButton2.Click();
            //Sleep(1);

            //provera 4 checkBox-a da li su selektovani nakon klika na check all
            IWebElement chkBox3 = driver.FindElement(By.XPath("//div[@class='checkbox'][1]/label/input[@class='cb1-element']"));
            IWebElement chkBox4 = driver.FindElement(By.XPath("//div[@class='checkbox'][2]/label/input[@class='cb1-element']"));
            IWebElement chkBox5 = driver.FindElement(By.XPath("//div[@class='checkbox'][3]/label/input[@class='cb1-element']"));
            IWebElement chkBox6 = driver.FindElement(By.XPath("//div[@class='checkbox'][4]/label/input[@class='cb1-element']"));

            bool chk3 = chkBox3.Selected;
            bool chk4 = chkBox4.Selected;
            bool chk5 = chkBox5.Selected;
            bool chk6 = chkBox6.Selected;

            if (chk3 && chk4 && chk5 && chk6)
            {
                System.IO.File.AppendAllText("g:\\QA testing - Rajak\\Results\\34.txt", "TC 001 Step 004 - Check box Option 1,2,3 i 4 is checked" + Environment.NewLine);
            }
            else
                System.IO.File.AppendAllText("g:\\QA testing - Rajak\\Results\\34.txt", "TC 001 Step 004 - Check box Option 1,2,3 i4 is NOT checked" + Environment.NewLine);

            //When you check all the checkboxes, button will change to 'Uncheck All'
            IWebElement allButton2 = driver.FindElement(By.XPath("//input[@id='check1' and @value='Uncheck All']"));

            bool sAllButton2 = allButton2.Displayed;
            isDisplayed = Convert.ToString(sAllButton2);
            System.IO.File.AppendAllText("g:\\QA testing - Rajak\\Results\\34.txt", "TC 001 Step 005 - Button UNCHECK ALL is displayed - " + isDisplayed + Environment.NewLine);

            // When you uncheck at least one checkbox, button will change to 'Check All'
            chkBox4.Click();

            bool sAllButton1 = allButton1.Displayed;
            isDisplayed = Convert.ToString(sAllButton1);
            System.IO.File.AppendAllText("g:\\QA testing - Rajak\\Results\\34.txt", "TC 001 Step 006 - Button CHECK ALL is displayed - " + isDisplayed + Environment.NewLine);

            Sleep(3);
        }