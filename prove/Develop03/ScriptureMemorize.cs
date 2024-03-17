using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptureWord
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }

    public ScriptureWord(string text)
    {
        Text = text;
        IsHidden = false;
    }
}

public class Scripture
{
    public string Reference { get; }
    private List<ScriptureWord> Words { get; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new ScriptureWord(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        foreach (var word in Words)
        {
            if (word.IsHidden)
            {
                Console.Write(new string('*', word.Text.Length) + " ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
        var unhiddenWords = Words.Where(word => !word.IsHidden).ToList();
        if (unhiddenWords.Count == 0)
            return false; // All words are hidden

        var random = new Random();
        var randomIndex = random.Next(0, unhiddenWords.Count);
        unhiddenWords[randomIndex].IsHidden = true;
        return true;
    }
}
