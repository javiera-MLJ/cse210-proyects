public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

    }
    public Scripture(string text)
    {
        _reference = null;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide = 1)
    {
        var _wordsToHide = _words.Where(w => !w.IsHidden()).ToList();
        if (_wordsToHide.Count == 0)
        {
            return;
        }
        Random random = new Random();
        for (int i = 0; i < numberToHide && _wordsToHide.Count > 0; i++)
        {
            int index = random.Next(_wordsToHide.Count);
            _wordsToHide[index].Hide();
            _wordsToHide.RemoveAt(index);
        }
    }
    public string getDisplayText()
    {
        if (_reference == null)
        {
            return string.Join(" ", _words.Select(w => w.GetDisplayText()));
        }
        else
        {
            return $"{_reference.GetDisplayText()} \n {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}