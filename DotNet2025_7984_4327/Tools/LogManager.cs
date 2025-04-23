
namespace Tools;
using System.IO;

public static class LogManager
{
    private const string path = "Log";

    public static string getCurrentDirectoryPath()
    {
        return $@"{Directory.GetCurrentDirectory()}/{path}/{DateTime.Now.ToString("yyyy-MM")}";

    }


    public static string getCurrentFilePath()
    {
        return Path.Combine(getCurrentDirectoryPath(), $@"{DateTime.Now.ToString("yyyy-MM-dd")}.txt");
    }

    public static void writeToLog(string projectName, string funcName, string message)
    {
        try
        {
            if (Directory.Exists(getCurrentDirectoryPath()))
                if (File.Exists(getCurrentFilePath()))
                    File.AppendAllText(getCurrentFilePath(), $"{DateTime.Now}\t{projectName}\t.{funcName}:\t{message}");
                else

                    File.WriteAllText(getCurrentFilePath(), $@"{DateTime.Now}");
            else
            {
                Directory.CreateDirectory(getCurrentDirectoryPath());
                File.WriteAllText(getCurrentFilePath(), $@"{DateTime.Now}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error File{e.ToString()}");
        }


    }

    public static void DeleteOldDirectorys()
    {
        foreach (var dir in Directory.GetDirectories(getCurrentDirectoryPath()))
        {
            if (Directory.GetCreationTime(dir) < DateTime.Now.AddMonths(-2))
            {
                Directory.Delete(dir, true);
            }
        }

    }


}

