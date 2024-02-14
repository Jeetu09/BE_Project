using UnityEngine;
using System.Diagnostics;

public class RunPythonScript : MonoBehaviour
{
    void Start()
    {
        // Path to your Python executable
        string pythonPath = "C:\\Users\\jeets\\AppData\\Local\\Programs\\Python\\Python311\\python.exe";

        // Path to your Python script
        string scriptPath = "Assets\\main.py";

        // Create a process to run the Python script
        ProcessStartInfo startInfo = new ProcessStartInfo(pythonPath);
        startInfo.Arguments = scriptPath;
        startInfo.RedirectStandardOutput = true;
        startInfo.UseShellExecute = false;
        startInfo.CreateNoWindow = true;

        Process process = new Process();
        process.StartInfo = startInfo;
        process.Start();

        // Optional: Read the output of the Python script
        string output = process.StandardOutput.ReadToEnd();
        UnityEngine.Debug.Log(output);

        // process.WaitForExit();
        process.Close();
    }
}
