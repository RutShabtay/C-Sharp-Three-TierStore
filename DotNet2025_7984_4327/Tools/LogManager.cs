namespace Tools;
using System.IO;

public static class LogManager
{
    private const string path = "Log";

    public static string GetCurrentDirectoryPath()
    {
        return $@"{Directory.GetCurrentDirectory()}/{path}/{DateTime.Now.ToString("yyyy-MM")}";

    }


    public static string GetCurrentFilePath()
    {
        return Path.Combine(GetCurrentDirectoryPath(), $@"{DateTime.Now.ToString("yyyy-MM-dd")}.txt");
    }

    public static void WriteToLog(string projectName, string funcName, string message)
    {
        try
        {
            if (Directory.Exists(GetCurrentDirectoryPath()))
                if (File.Exists(GetCurrentFilePath()))
                    File.AppendAllText(GetCurrentFilePath(), $"{DateTime.Now}\t{projectName}\t.{funcName}:\t{message}");
                else

                    File.WriteAllText(GetCurrentFilePath(), $@"{DateTime.Now}");
            else
            {
                Directory.CreateDirectory(GetCurrentDirectoryPath());
                File.WriteAllText(GetCurrentFilePath(), $@"{DateTime.Now}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error File{e.ToString()}");
        }


    }

    public static void DeleteOldDirectorys()
    {
        foreach (var dir in Directory.GetDirectories(GetCurrentDirectoryPath()))
        {
            if (Directory.GetCreationTime(dir) < DateTime.Now.AddMonths(-2))
            {
                Directory.Delete(dir, true);
            }
        }

    }


}

