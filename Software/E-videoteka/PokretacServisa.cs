using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_videoteka
{
    public class PokretacServisa
    {
        public void PokreniServer()
        {
            string trenutniDirektorijPrograma = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string prviDio = "sc create WorkerService binpath=";
            string drugiDio = "WorkerService.exe start=\"demand\" displayname=\"e-Videoteka\"";

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.Write("sc");
            process.StandardInput.Flush();
            process.StandardInput.WriteLine("sc create WorkerService binpath=" + trenutniDirektorijPrograma + "WorkerService.exe start=\"demand\" displayname=\"e-Videoteka\"");
            process.StandardInput.Flush();
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            process.StandardInput.Close();
            //process.WaitForExit();
        }
    }
}
