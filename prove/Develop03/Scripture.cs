class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - {_words.Select(word => word.GetDisplayText()).Aggregate((a, b) => a + " " + b)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}




