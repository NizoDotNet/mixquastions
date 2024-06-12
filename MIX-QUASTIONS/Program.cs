using MIX_QUASTIONS;

using FileReader fileReader = new("q.txt");
fileReader.StartParsing();
/*foreach (var item in fileReader.Quastions)
{
    ConsoleColor color = Console.BackgroundColor;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine(new string('-', 5));
    Console.BackgroundColor = color;
    Console.WriteLine(item.Text);
    foreach (var item1 in item.Variants)
    {
        Console.WriteLine(item1.Text);
    }
}
*/
using FileWriter fileWriter = new("m.txt");
ListShuffler shuffler = new();
for (int i = 0; i < fileReader.Quastions.Count; i++)
{
    fileReader.Quastions[i].Variants = shuffler.Shuffle(fileReader.Quastions[i].Variants);
}
fileWriter.Start(fileReader.Quastions);
