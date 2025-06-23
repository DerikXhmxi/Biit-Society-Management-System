using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DataHandlers.ErrorLog
{
    internal class LogFile
    {

        public static void SqlErrorLog(String error)
        {
            FileStream fileStream = new FileStream("E:\\SocietyProject\\ErrorLogFiles\\SqlErrorLog.txt", FileMode.OpenOrCreate, FileAccess.Write);
           
            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            streamWriter.WriteLine(error+"#"+DateTime.Now);
            streamWriter.Close();
           



            }
        public static void InputErrorLog(String error)
        {
            FileStream fileStream = new FileStream("E:\\SocietyProject\\ErrorLogFiles\\InputErrorLog.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            streamWriter.WriteLine(error+"#"+DateTime.Now);
            streamWriter.Close();




        }
    }
}
