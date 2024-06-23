using System.Text.Json.Serialization;

namespace MIX_QUASTIONS;

public class Variant
{
    public string Text { get; set; } = null!;
    public bool IsCorrect { get; set; }

    public Variant(string text, bool isCorrect)
    {
        Text = text;
        IsCorrect = isCorrect;
    }

    public Variant()
    {
        
    }
}