using System.Reflection;
using System.Linq;

// Write a program that finds all words that have a meaning when spelled backwards.
// List of English words is available in words.txt

// read words
var words = ReadWords();

// get list of reverse words
var reverseWords = words.Select(_ => new string(_.Reverse().ToArray())).ToList();

// get intersection of the two sets
var palindromes = words.Intersect(reverseWords).OrderBy(_ => _.Length);

foreach (var i in palindromes)
{
    Console.WriteLine(i);
}

IEnumerable<string> ReadWords()
{
    string file = Path.Combine(Assembly.GetExecutingAssembly().Location, "..", "words.txt");
    using var r = new StreamReader(file);
    var words = new List<string>();
    while (true)
    {
        var line = r.ReadLine();
        if (line is null) break;
        var word = line.Trim().ToLower();
        words.Add(word);
    }
    return words;
}
