using System;
using System.ComponentModel;
using System.IO;

namespace RenameFile.Utils
{
    class FileManager
    {
        public static int CountFileNumber(string sourceDirName, bool isProcSubfolder)
        {
            int count = 0;
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                return count;
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                count++;
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (isProcSubfolder)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    count += CountFileNumber(subdir.FullName, isProcSubfolder);
                }
            }

            return count;
        }

        public static int AppendFileName(string sourceDirName, string appendText, bool isAppendEnd, 
            bool isProcSubfolder, BackgroundWorker bgw, int curIndex)
        {
            if (bgw != null)
            {
                OutputManager.OutputContent(bgw, "Renaming files under " + sourceDirName);
            }

            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            if (!dir.Exists)
            {
                OutputManager.OutputContent(bgw, "Directory doesn't exist: " + sourceDirName, curIndex);
                return curIndex;
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                try
                {
                    string targetFileName = file.Name;
                    if (isAppendEnd)
                    {
                        targetFileName += appendText;
                    }
                    else
                    {
                        targetFileName = appendText + targetFileName;
                    }

                    File.Move(file.FullName, file.DirectoryName + "\\" + targetFileName);

                    curIndex++;
                    if (bgw != null)
                    {
                        OutputManager.OutputContent(bgw, "Renaming file " + file.Name, curIndex);
                    }
                }
                catch (Exception ex)
                {
                    if (bgw != null)
                    {
                        OutputManager.OutputContent(bgw, "Renamed file failed with exception: " + ex.Message);
                        return curIndex;
                    }
                }
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (isProcSubfolder)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo subdir in dirs)
                {
                    curIndex = AppendFileName(subdir.FullName, 
                        appendText, isAppendEnd, isProcSubfolder, bgw, curIndex);
                }
            }

            return curIndex;
        }

        public static int ReplaceFileName(string sourceDirName, string originalText, string replaceText, bool isAppendEnd,
            bool isProcSubfolder, BackgroundWorker bgw, int curIndex)
        {
            if (bgw != null)
            {
                OutputManager.OutputContent(bgw, "Renaming files under " + sourceDirName);
            }

            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            if (!dir.Exists)
            {
                OutputManager.OutputContent(bgw, "Directory doesn't exist: " + sourceDirName, curIndex);
                return curIndex;
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                try
                {
                    string targetFileName = file.Name.Replace(originalText, replaceText);

                    File.Move(file.FullName, file.DirectoryName + "\\" + targetFileName);

                    curIndex++;
                    if (bgw != null)
                    {
                        OutputManager.OutputContent(bgw, "Renaming file " + file.Name, curIndex);
                    }
                }
                catch (Exception ex)
                {
                    if (bgw != null)
                    {
                        OutputManager.OutputContent(bgw, "Renamed file failed with exception: " + ex.Message);
                        return curIndex;
                    }
                }
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (isProcSubfolder)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo subdir in dirs)
                {
                    curIndex = ReplaceFileName(subdir.FullName, originalText,
                        replaceText, isAppendEnd, isProcSubfolder, bgw, curIndex);
                }
            }

            return curIndex;
        }
    }
}
