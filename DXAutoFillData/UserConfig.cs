using System;
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
            Properties.Settings.Default.UTargetUrl = target;
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
        public static void setSAutoChooseOptions(bool b)
        {
            Properties.Settings.Default.SAutoChooseOptions = b;
            Properties.Settings.Default.Save();
        }

        public static string getUTargetUrl()
        {
            return Properties.Settings.Default.UTargetUrl;
        }
        public static string getUPassword()
        {
            return Properties.Settings.Default.UPassword;
        }
        public static bool getUAutoLogin()
        {
            return Properties.Settings.Default.UAutoLogin;
        }


        public static bool getSAutoSubmit()
        {
            return Properties.Settings.Default.SAutoSubmit;
        }
        public static bool getSAutoCloseForm()
        {
            return Properties.Settings.Default.SAutoCloseForm;
        }
        public static bool getSAutoChooseOptions()
        {
            return Properties.Settings.Default.SAutoChooseOptions;
        }


    }
}
