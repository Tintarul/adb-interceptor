using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Check if there are parameters passed to the program
        if (args.Length > 0)
        {
            // Start a child process (adbGround.exe) with the same parameters
            StartChildProcess(args);
        }
        else
        {
            Console.WriteLine("No parameters provided.");
        }
    }

    static void StartChildProcess(string[] args)
    {
        try
        {
            Process process = new Process();
            process.StartInfo.FileName = "adbGround.exe";
            process.StartInfo.Arguments = string.Join(" ", args);
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            string strOutFilePath = "./LogsADB.txt";

            try
            {
                using (StreamWriter writer = File.AppendText(strOutFilePath))
                {
                    writer.WriteLine($"RUN {process.StartInfo.FileName} {process.StartInfo.Arguments}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Redirect the standard output of the process
            process.StartInfo.RedirectStandardOutput = true;
            process.OutputDataReceived += new DataReceivedEventHandler(OutputDataReceived);

            // Start the process
            process.Start();

            // Asynchronously read the standard output of the process
            process.BeginOutputReadLine();

            process.WaitForExit();
            process.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void OutputDataReceived(object sender, DataReceivedEventArgs e)
    {
        // Log the standard output to StrOutADB.txt file
        string strOutFilePath = "./LogsADB.txt";

        try
        {
            using (StreamWriter writer = File.AppendText(strOutFilePath))
            {
                writer.WriteLine($"OUTPUT {e.Data}");
                Console.WriteLine(e.Data);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}