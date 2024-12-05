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
        numberToHide = Math.Min(numberToHide, _words.Count);
        var hidingWord = new HashSet<int>();
        while (hidingWord.Count < numberToHide)
        {
            int randomIndex = _random.Next(_words.Count);

            if (!_words[randomIndex].IsHidden)
            {
                hidingWord.Add(randomIndex);
            }
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

    public bool AllWordsAreGone()
    {
        return _words.All(word => word.IsHidden);
    }

    public int CountWords()
    {
        return _words.Count(word => !word.IsHidden);
    }


}
