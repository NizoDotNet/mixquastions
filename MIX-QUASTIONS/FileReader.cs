using System.Text;

namespace MIX_QUASTIONS;

public class FileReader : IDisposable
{
    
    public string FileName { get; set; }
    public List<Quastion> Quastions { get; set; } = [];
    private StreamReader _reader;
    private string[] _variantForms = ["a)", "b)", "c)", "d)", "e)", "a.", "b.", "c.", "d.", "e.", "A)", "B)", "C)", "D)", "E)", "A.", "B.", "C.", "D.", "E."];
    public FileReader(string fileName)
    {
        if (!CheckFileName(fileName)) throw new Exception("File must be in .txt format");
        if (!File.Exists(fileName)) throw new Exception("There is no file with such name");
        FileName = fileName;
        _reader = new StreamReader(fileName);
        
    }

    private bool CheckFileName(string fileName)
    {
        return fileName.EndsWith(".txt");
    }

    public void StartParsing()
    {
        while (!_reader.EndOfStream) 
        {
            string line = _reader.ReadLine();
            if (line.Length > 0 && char.IsNumber(line[0]))
            {
                Quastion quastion = new Quastion();
                int index = line.IndexOf('.');
                quastion.Text = line[index..];
                for (int i = 0; i < 5;)
                {
                    line = _reader.ReadLine();
                    if (line.Length > 2 && _variantForms.Contains(line[0..2]))
                    {
                        i++;
                        quastion.Variants.Add(new(line[2..]));
                    }
                    else if (!string.IsNullOrEmpty(line)) quastion.Text += line;
                }
                
                Quastions.Add(quastion);
            }
        }
    }

    public void Dispose()
    {
        _reader.Dispose();
    }
}
