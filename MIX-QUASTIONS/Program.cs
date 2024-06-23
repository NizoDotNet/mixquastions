using MIX_QUASTIONS;
using System.Text.Json;

using FileReader fileReader = new("q.txt");
fileReader.StartParsing();
Subject subject = new();
subject.Quastions = fileReader.Quastions;
/*var options = new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};*/
/*string json = JsonSerializer.Serialize(subject, options);


File.WriteAllText("./x.json", json);*/
using FileWriter fileWriter = new("m.txt");
ListShuffler shuffler = new();
for (int i = 0; i < fileReader.Quastions.Count; i++)
{
    fileReader.Quastions[i].Variants = shuffler.Shuffle(fileReader.Quastions[i].Variants);
}
fileWriter.Start(fileReader.Quastions);
