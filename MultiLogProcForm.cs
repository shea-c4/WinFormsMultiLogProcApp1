using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMultiLogProcApp1
{
   public partial class MultiLogProcForm : Form
   {
      public MultiLogProcForm()
      {
         InitializeComponent();
      }

      private async void BtnStart_Click(object sender, EventArgs e)
      {
         Button b = sender as Button;
         if (b == null)
         {
            return;
         }

         b.Enabled = false;

         await StartProcess(textBoxCommand.Text, textBoxArgs.Text);

         b.Enabled = true;
      }

      private StreamWriter logFileWriter;
      Process process;
      private async Task StartProcess(string cmd, string cmdArgs = null)
      {
         process = new Process
         {
            StartInfo = new ProcessStartInfo
            {
               FileName = cmd,
               Arguments = cmdArgs,
               RedirectStandardOutput = true,
               RedirectStandardError = true,
               UseShellExecute = false,
               CreateNoWindow = true
            },
            EnableRaisingEvents = true
         };

         process.OutputDataReceived += (sender, args) => LogOutput(args.Data);
         process.ErrorDataReceived += (sender, args) => LogOutput(args.Data);
         process.Exited += (sender, args) =>
         {
            Invoke((Action)(() =>
            {
               MessageBox.Show("The process has exited", "Process Exit", MessageBoxButtons.OK);
               btnStart.Enabled = true;
               if (logFileWriter != null)
               {
                  logFileWriter.Close();
               }
            }));
         };

         var logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "process.log");
         logFileWriter = new StreamWriter(logFilePath, true) { AutoFlush = true };
         richTextBox1.Clear();
         process.Start();
         process.BeginOutputReadLine();
         process.BeginErrorReadLine();

         await Task.Run(() => process.WaitForExit());
      }

      private void LogOutput(string data)
      {
         if (!string.IsNullOrEmpty(data))
         {
            Console.WriteLine(data);
            Debug.WriteLine(data);
            logFileWriter.WriteLine(data);
            Invoke((Action)(() =>
            {
               richTextBox1.AppendText(data);
               richTextBox1.AppendText(Environment.NewLine);
            }));
         }
      }
   }
}
