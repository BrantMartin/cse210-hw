using System;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    
    public void SetText(string changeText){
        _text = changeText;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (IsHidden() == true)
        {
            string hiddenString = "";
            for (int i = 0; i < _text.Length; i++)
            {
                hiddenString += "_";
            }
            return hiddenString;
        }
        else
        {
            return _text;
        }
    }
}