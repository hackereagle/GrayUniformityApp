using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScLib
{
    class Log
    {
        public void WriteLog(string Message)
        {
            try
            {
                if (!Directory.Exists("Log"))
                    Directory.CreateDirectory("Log");

                System.DateTime currentTime = new System.DateTime();
                currentTime = System.DateTime.Now;
                string LogFilePath, FileName;
                FileName = currentTime.ToString("yyyyMMdd") + "Log.log";
                LogFilePath = "Log\\" + FileName;
                FileStream logFile = new FileStream(LogFilePath, FileMode.Append);//.OpenOrCreate
                byte[] Msg = System.Text.Encoding.Default.GetBytes("\r\n" + currentTime.ToString("s") + ": " + Message); // "\r\n" 是C#中換行的跳脫字元
                logFile.Write(Msg, 0, Msg.Length);
                logFile.Flush();
                logFile.Close();
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Log file write error!");

                System.DateTime currentTime = new System.DateTime();
                currentTime = System.DateTime.Now;
                string LogFilePath;
                LogFilePath = currentTime.ToString("yyyyMMdd") + "Log.log";
                FileStream logFile = new FileStream(LogFilePath, FileMode.OpenOrCreate);
                byte[] Msg = System.Text.Encoding.Default.GetBytes(currentTime.ToString("s") + ": Creating folder is fail!");
                logFile.Write(Msg, 0, Msg.Length);
                logFile.Flush();
                logFile.Close();
            }
        }
    }
}
