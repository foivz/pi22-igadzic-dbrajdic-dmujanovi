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
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            process.StartInfo = startInfo;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            process.StandardInput.Write("cd");
        }
    }
}
