﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXAutoFillData
{
    public static class UserConfig
    {
        public static void setUTargetUrl(string target)
        {
            Properties.Settings.Default.UURLTarget = target;
            Properties.Settings.Default.Save();
        }
        public static void setUPassword(string password)
        {
            Properties.Settings.Default.UPassword = password;
            Properties.Settings.Default.Save();
        }
        public static void setUAutoLogin(bool b)
        {
            Properties.Settings.Default.UAutoLogin = b;
            Properties.Settings.Default.Save();
        }

        public static void setSAutoSubmit(bool b)
        {
            Properties.Settings.Default.SAutoSubmit = b;
            Properties.Settings.Default.Save();
        }
        public static void setSAutoCloseForm(bool b)
        {
            Properties.Settings.Default.SAutoCloseForm = b;
            Properties.Settings.Default.Save();
        }
        public static void setSAutoEnterData(bool b)
        {
            Properties.Settings.Default.SAutoEnterData = b;
            Properties.Settings.Default.Save();
        }
        public static void setSAutoClearCache(bool b)
        {
            Properties.Settings.Default.SAutoClearCache = b;
            Properties.Settings.Default.Save();
        }
        public static void setTimeLeft(int time)
        {
            Properties.Settings.Default.TimeLeft = time;
            Properties.Settings.Default.Save();
        }
        public static void setIsActive(bool b)
        {
            Properties.Settings.Default.IsActive = b;
            Properties.Settings.Default.Save();
        }
        public static void setSActiveTab(int b)
        {
            Properties.Settings.Default.SActiveTab = b;
            Properties.Settings.Default.Save();
        }
        public static int getSActiveTab()
        {
            return Properties.Settings.Default.SActiveTab;
        }
        public static bool getSAutoSubmit()
        {
            return Properties.Settings.Default.SAutoSubmit;
        }
        public static string getUTargetUrl()
        {
            return Properties.Settings.Default.UURLTarget;
        }
        public static string getUPassword()
        {
            return Properties.Settings.Default.UPassword;
        }
        public static bool getUAutoLogin()
        {
            return Properties.Settings.Default.UAutoLogin;
        }
       
       
        public static bool getSAutoCloseForm()
        {
            return Properties.Settings.Default.SAutoCloseForm;
        }
        public static bool getSAutoEnterData()
        {
            return Properties.Settings.Default.SAutoEnterData;
        }
        public static bool getSAutoClearCache()
        {
            return Properties.Settings.Default.SAutoClearCache;
        }
        public static bool getIsActive()
        {
            return Properties.Settings.Default.IsActive;
        }
        public static int getTimeLeft()
        {
            return Properties.Settings.Default.TimeLeft;
        }
    }
}
