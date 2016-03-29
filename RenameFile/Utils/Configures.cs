using RenameFile.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameFile.Utils
{
    class Configures
    {
        public static string GetFilePath()
        {
            return Settings.Default[Constants.KeyFilePath].ToString();
        }

        public static void SaveFilePath(string value)
        {
            Settings.Default[Constants.KeyFilePath] = value;
            Settings.Default.Save();
        }

        public static bool IsProcessSubfolder()
        {
            bool value = (bool)Settings.Default[Constants.KeyIsProcessSubFolder];
            return value;
        }

        public static void SaveIsProcessSubfolder(bool value)
        {
            Settings.Default[Constants.KeyIsProcessSubFolder] = value;
            Settings.Default.Save();
        }

        public static string GetTextAppend()
        {
            return Settings.Default[Constants.KeyTextAppend].ToString();
        }

        public static void SaveTextAppend(string value)
        {
            Settings.Default[Constants.KeyTextAppend] = value;
            Settings.Default.Save();
        }

        public static bool IsAppendEnd()
        {
            bool value = (bool)Settings.Default[Constants.KeyIsAppendEnd];
            return value;
        }

        public static void SaveIsAppendEnd(bool value)
        {
            Settings.Default[Constants.KeyIsAppendEnd] = value;
            Settings.Default.Save();
        }

        public static string GetOriginalText()
        {
            return Settings.Default[Constants.KeyOriginalText].ToString();
        }

        public static void SaveOriginalText(string value)
        {
            Settings.Default[Constants.KeyOriginalText] = value;
            Settings.Default.Save();
        }

        public static string GetReplaceText()
        {
            return Settings.Default[Constants.KeyReplaceText].ToString();
        }

        public static void SaveReplaceText(string value)
        {
            Settings.Default[Constants.KeyReplaceText] = value;
            Settings.Default.Save();
        }
    }
}
