using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Fredag.Codes.SystemIO
{
    internal class IOHandler
    {
        private static string _userFolderUrl;
        private static string _parentFolderUrl;
        private static FileSystemWatcher Watcher { get; set; }
        static IOHandler()
        {
            _userFolderUrl = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            _parentFolderUrl = Path.Combine(_userFolderUrl, "H1GP");

            Watcher = new FileSystemWatcher(_parentFolderUrl);
            Watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime
                                    | NotifyFilters.DirectoryName
                                    | NotifyFilters.FileName
                                    | NotifyFilters.LastAccess
                                    | NotifyFilters.LastWrite;
            Watcher.Changed += Watcher_Changed;
            Watcher.Filter = "*.txt";
            Watcher.IncludeSubdirectories = true;
            Watcher.EnableRaisingEvents = true;
        }
        private static void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Følgende fil blev ændret: {e.FullPath}");
        }
        private static void ReadDir(string url)
        {
            string[] directories = Directory.GetDirectories(url);
            foreach (string directory in directories)
            {
                Console.WriteLine($"Directory: {directory}");

                string[] subDirectories = Directory.GetDirectories(directory);
                foreach (string subDirectory in subDirectories)
                {
                    Console.WriteLine($"Directory: {subDirectory}");
                    ReadDir(subDirectory);
                }
                string[] files = Directory.GetFiles(directory);
                foreach (string file in files)
                {
                    Console.WriteLine($"File: {file}");
                }
            }
        }
        public static string HandleDir(string? dirName, string? newDirName, CrudOperation operationType)
        {
            if (!Directory.Exists(_parentFolderUrl))
                return "Directory does not exists.";

            string dirUrl = dirName != null ? Path.Combine(_parentFolderUrl, dirName) : _parentFolderUrl;
            string? newDirUrl = newDirName != null ? Path.Combine(_parentFolderUrl, newDirName) : null;

            string msg = "";
            switch (operationType)
            {
                case CrudOperation.Create:
                    msg = "Directory allready exist!";
                    if (!Directory.Exists(dirUrl))
                    {
                        Directory.CreateDirectory(dirUrl);
                        msg = "Success!";
                    }
                    break;
                case CrudOperation.Read:
                    msg = "Success";
                    try
                    {
                        ReadDir(dirUrl);
                    }
                    catch (Exception exc)
                    {
                        msg = exc.Message;
                    }
                    break;
                case CrudOperation.Update:
                    if (newDirUrl != null)
                    {
                        Directory.Move(dirUrl, newDirUrl);
                        msg = "Success!";
                    }
                    break;
                case CrudOperation.Delete:
                    if (Directory.Exists(dirUrl))
                        Directory.Delete(dirUrl, true);
                    break;
            }
            return msg;
        }
        public static string HandleFile(string fileName, CrudOperation operationType, string? text)
        {
            if (!Directory.Exists(_parentFolderUrl))
                return "Directory does not exists.";

            string? fileUrl = fileName != null ? Path.Combine(_parentFolderUrl, fileName) : null;

            string msg = "";
            switch (operationType)
            {
                case CrudOperation.Create:
                    msg = "File allready exist!";
                    if (!File.Exists(fileUrl) && fileUrl != null)
                    {
                        using FileStream fs = File.Create(fileUrl);
                        msg = "Success!";
                    }
                    break;
                case CrudOperation.Read:
                    if (!File.Exists(fileUrl) && fileUrl != null)
                    {
                        string allText = File.ReadAllText(fileUrl, Encoding.UTF8);
                        Console.WriteLine(allText);
                    }
                    break;
                case CrudOperation.Update:
                    msg = "Specified file does not exist!";
                    if (File.Exists(fileUrl))
                    {
                        if (text != null)
                        {
                            using StreamWriter sw = File.AppendText(fileUrl);
                            sw.WriteLine(text);
                        }
                        msg = "Success!";
                    }
                    break;
                case CrudOperation.Delete:
                    if (File.Exists(fileUrl))
                    {
                        File.Delete(fileUrl);
                        msg = "Success!";
                    }
                    break;
            }
            return msg;
        }
    }
}