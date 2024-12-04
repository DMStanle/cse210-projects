using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (var word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var hidingWord = new HashSet<int>();
        while (hidingWord.Count < numberToHide && hidingWord.Count < _words.Count)
        {
            hidingWord.Add(_random.Next(_words.Count));
        }
        foreach (var i in hidingWord)
        {
            _words[i].Hide();
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words);
    }

}
