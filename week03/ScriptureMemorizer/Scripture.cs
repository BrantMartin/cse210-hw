using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitter = text.Split(" ");
        for (int i = 0; i < splitter.Length; i++)
        {
            _words.Add(new Word(splitter[i]));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int wordNum = 0;
        Random rand = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            wordNum = rand.Next(0, _words.Count());
            _words[wordNum].Hide();
        }

    }

    public string GetDisplayText()
    {
        string text = $"{_reference.GetDisplayText() }";
        for (int i = 0; i < _words.Count(); i++)
        {
            text += $"{_words[i].GetDisplayText()} ";
        }
        return text;
    }

    public bool IsCompletelyHidden()
    {
        int hiddenCount = 0;
        for (int i = 0; i < _words.Count(); i++)
        {
            if (_words[i].IsHidden() == true)
            {
                hiddenCount += 1;
            }
        }
        if (hiddenCount == _words.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}