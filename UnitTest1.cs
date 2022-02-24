using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace Tests
{
    public class Tests
    {
        public static AppiumDriver<IWebElement> appiumDriver;
        [SetUp]
        public void Setup()
        {
            DriverOptions caps = new AppiumOptions();
            caps.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            caps.AddAdditionalCapability(MobileCapabilityType.App, "/home/runner/work/clarus-android/clarus-android/android-automation/apk/app-debug.apk");
            caps.AddAdditionalCapability("automationName", "UiAutomator2");
            caps.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "com.example.myapplication");

            caps.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "com.example.myapplication.MainActivity");

            caps.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            caps.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 180);
            caps.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidDeviceReadyTimeout, 30000);
            caps.AddAdditionalCapability(AndroidMobileCapabilityType.DeviceReadyTimeout, 30000);
            caps.AddAdditionalCapability(AndroidMobileCapabilityType.AppWaitDuration, 30000);
            caps.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidInstallTimeout, 30000);
            caps.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidInstallTimeout, 30000);
            appiumDriver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), caps, TimeSpan.FromMinutes(4));
            string path = System.AppContext.BaseDirectory;
        }

        [Test]
        public void Test1()
        {
           if(appiumDriver.FindElementById("com.example.myapplication:id/textview_first").Displayed)
            {
                NUnit.Framework.Assert.Pass();
            }
           else
            {
                NUnit.Framework.Assert.Fail();
            }
        }
    }
}