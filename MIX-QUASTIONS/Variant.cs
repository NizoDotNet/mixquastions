using System.Text.Json.Serialization;

namespace MIX_QUASTIONS;

public class Variant
{
    public string Text { get; set; } = null!;
    public bool IsTrue { get; set; }

    public Variant(string text)
    {
        Text = text;
    }

    public Variant()
    {
        
    }
}