﻿using Microsoft.VisualBasic;
using System.Text.Json.Serialization;

namespace MIX_QUASTIONS;

public class Quastion
{
    public string Text { get; set; } = null!;
    [JsonPropertyName("answer")]
    public List<Variant> Variants { get; set; } = [];
}