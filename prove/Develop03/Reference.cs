
class Reference
{



    private string _book;
    private int _chapter;

    private int _verse1;
    private int? _verse2;

    public Reference(string book, int chapter, int verse1, int? verse2)
    {
        _book = book;
        _chapter = chapter;
        _verse1 = verse1;
        _verse2 = verse2;
    }

    public string GetDisplayText()
    {
        if (_verse2.HasValue)
        {
            return $"{_book} {_chapter}:{_verse1}-{_verse2}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse1}";
        }
    }

}
