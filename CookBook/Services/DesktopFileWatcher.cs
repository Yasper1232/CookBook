using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Services
{
    public class DesktopFileWatcher
    {

        private static volatile DesktopFileWatcher _instance; //private instance
        private static readonly object _lock = new object();
        private BackgroundWorker _fileCheckWorker;
        public static DesktopFileWatcher Instance   // public instance
        {
            get
            {

                if (_instance == null) //double check locking , preventing from unnecessary  locking 
                {
                    lock (_lock)
                    {

                        if (_instance == null)
                        {
                            _instance = new DesktopFileWatcher();
                        }
                    }

                }
               
                return _instance;
            }



        }

        private DesktopFileWatcher() //private constructor
        {
            _fileCheckWorker = new BackgroundWorker();
            _fileCheckWorker.DoWork += FileCheckWorker_DoWork;
            _fileCheckWorker.RunWorkerAsync();
        }

        private void FileCheckWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
           
           string desktopPath  = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = Path.Combine(desktopPath, "ShoppingList.txt");


            while (true) 
            {

                bool fileExists = File.Exists(filePath);
                //TODO ; send notification about file status
                Thread.Sleep(5000);
            }


        }
    }
}
