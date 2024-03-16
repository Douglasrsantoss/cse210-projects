
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    //first, setting a list of words so we can hide one by one
    public readonly List<Word> _words = new List<Word>();
    //the reference part
    public Reference reference;
    public  string _text;
    //setting a table so it doesn't count as words
    //public char _table = [' ', ',', '.',';'];

    public void Text(string text)
    {
        this._text = text;
        //creating a char to englobe the separation marks so it doesn't count as words:
        string[] _wordArray = text.Split(new char[] { ' ', ',','.',';'});

        //adding the word to the list
        foreach (string word in _wordArray)
        {
            this._words.Add(new Word { _word = word, _isHidden = false });
        }
    }

//this is the hidder part
    public void HideRandomWords(int count)
    {
        //this will randomly chose and hide a word from the list created
        Random random = new Random();
        int hiddenCount = 0;
        
        //if the word is already hidden, junp to the next
        //as long as there is word to hide, it will continue.
        if(count >= this._words.Count(word => !word._isHidden))
        {count = this._words.Count(word => !word._isHidden);}
                
        while (hiddenCount < count)
        {
            int index = random.Next(0, this._words.Count);

            if (!this._words[index]._isHidden)
            {
                this._words[index]._isHidden = true;
                hiddenCount++;
            }
        }
    }
//this checks if all the words are already hidden
    public bool isCompletelyHidden(){
        return !this._words.Any(word => !word._isHidden);
    }

//this is the display part:
    public void Display()
    {
        //Console.WriteLine(reference.Display());
        Console.WriteLine();

        foreach (Word word in this._words)
        {
            if (word._isHidden)
                Console.Write($"|---| ");
            else
                Console.Write($"{word._word} ");
        }
        Console.WriteLine();
    }
}
