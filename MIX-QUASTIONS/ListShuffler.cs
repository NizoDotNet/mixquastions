using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIX_QUASTIONS;

internal class ListShuffler
{
    Random _rand;
    public ListShuffler()
    {
        _rand = new Random();   
    }
    public List<Quastion> Shuffle(List<Quastion> listToShuffle)
    {

        for (int i = listToShuffle.Count - 1; i > 0; i--)
        {
            listToShuffle[i].Variants = Shuffle(listToShuffle[i].Variants); 
            var k = _rand.Next(i + 1);
            var value = listToShuffle[k];
            listToShuffle[k] = listToShuffle[i];
            listToShuffle[i] = value;
        }
        return listToShuffle;
    }
    public List<Variant> Shuffle(List<Variant> listToShuffle)
    {

        for (int i = listToShuffle.Count - 1; i > 0; i--)
        {
            var k = _rand.Next(i + 1);
            var value = listToShuffle[k];
            listToShuffle[k] = listToShuffle[i];
            listToShuffle[i] = value;
        }
        return listToShuffle;
    }
}
