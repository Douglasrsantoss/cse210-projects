
class Reference
{
    public string _book = "Proverbs";
    public int _chapter = 3;
    public int _verse = 5;
    public int _endVerse = 6;



    public string Display()
    {
       return $"Scripture Reference: {this._book} {this._chapter}:{this._verse}-{this._endVerse} ";
    }
}
