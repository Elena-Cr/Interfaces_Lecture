
namespace lec09proj;

public class Processor : IImportFile
{
    public List<FileInfo> ImportFile()
    {
       string filePath="C:/C#/Interfaces_Lecture/film.csv";
       string[] lines = File.ReadAllLines(filePath);
       return null;
    }
}