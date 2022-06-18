using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace E_videoteka
{
    public class PokretacServisa : IDisposable
    {
        private Process cmdProcess;
        private StreamWriter streamWriter;
        private AutoResetEvent outputMainHandel;
        private string cmdOutput;

        string trenutniDirektorijPrograma = Path.GetDirectoryName(Application.ExecutablePath);
        string prviDio = "sc create WorkerService binpath=";
        string drugiDio = "WorkerService.exe start=\"demand\" displayname=\"e-Videoteka\"";

        public PokretacServisa(string cmdPath)
        {
            cmdProcess = new Process();
            outputMainHandel = new AutoResetEvent(false);
            cmdOutput = string.Empty;

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = cmdPath;
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;

            cmdProcess.StartInfo = processStartInfo;
            cmdProcess.Start();

            streamWriter = cmdProcess.StandardInput;
            cmdProcess.BeginOutputReadLine();
        }

        public string ExecuteCommand(string command)
        {
            cmdOutput = string.Empty;

            streamWriter.WriteLine(command);
            streamWriter.WriteLine(prviDio + trenutniDirektorijPrograma + drugiDio);
            outputMainHandel.WaitOne();
            return cmdOutput;
        }

        public void Dispose()
        {
            cmdProcess.Close();
            cmdProcess.Dispose();

            streamWriter.Close();
            streamWriter.Dispose();
        }
    }
}
