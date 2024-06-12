using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIX_QUASTIONS;

public class FileWriter : IDisposable
{
    public string FileName { get; set; }
    private StreamWriter _writer;
    private ListShuffler _shuffler;
    public FileWriter(string fileName)
    {
        FileName = fileName;
        _writer = new StreamWriter(fileName);
        _shuffler = new ListShuffler();
    }
    public void Start(List<Quastion> quastions, bool shuffle = false)
    {
        if(shuffle) _shuffler.Shuffle(quastions);

        for (int i = 0; i < quastions.Count; i++)
        {
            _writer.WriteLine($"{i+1}{quastions[i].Text}");
            int z = 0;
            for(char j = 'A'; j <= 'E'; j++)
            {
                _writer.WriteLine($"{j}. {quastions[i].Variants[z].Text}");
                z++;
            }
            _writer.WriteLine();
        }
    }

    public void Dispose()
    {
        _writer.Dispose();
    }
}
