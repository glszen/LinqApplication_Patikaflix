using LinqApplication_Patikaflix;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
 
List<Series> series = new List<Series>();
List<Comedy> comedyList = new List<Comedy>();

Start:
Console.WriteLine("Please enter a series.");

while (true)
{
    Console.Write("Title: ");
    string title = Console.ReadLine();
    if (string.IsNullOrEmpty(title))
    {
        Console.WriteLine("Please enter a title.");
        continue;
    }
   
    Constraction:
    Console.Write("ConstructionYear: ");
    int construction;
    string constructionInput = Console.ReadLine();
    if (!int.TryParse(constructionInput, out construction))
    {
        Console.WriteLine("Please enter valid a year.");
        goto Constraction;
    }
   
    Console.Write("Genre: ");
    string genre = Console.ReadLine().ToUpper();
    if (string.IsNullOrEmpty(genre))
    {
        Console.WriteLine("Please enter a genre.");
        continue;
    }

    Released:
    Console.Write("Released Year: ");
    int released; 
    string releasedInput = Console.ReadLine();
    if (!int.TryParse(releasedInput, out released))
    {
        Console.WriteLine("Please enter a year.");
        goto Released;
    }
    
    Console.Write("Director: ");
    string director = Console.ReadLine();
    if (string.IsNullOrEmpty(director))
    {
        Console.WriteLine("Please enter a director.");
        continue;
    }
   
    Console.Write("First Platform: ");
    string platform = Console.ReadLine();
    if (string.IsNullOrEmpty(platform))
    {
        Console.WriteLine("Please enter a platform.");
        continue;
    }

    Series newSeries = new Series
    {
        Title = title,
        ConstructionYear = construction,
        Genre = genre,
        ReleasedYear = released,
        Directors = director,
        FirstPlatform = platform,

    };

    series.Add(newSeries);

    if (genre == "COMEDY" || genre == "KOMEDİ")
    {
        Comedy newComedy = new Comedy
        {
            TitleC = title,
            GenreC = genre,
            DirectorsC = director,
        };
        comedyList.Add(newComedy);
     }

Start2:
    Console.Write("Do you want to add another movie?(Y/N): ");
    string answer = Console.ReadLine().ToUpper(); ;
    
    if (answer == "Y")
        goto Start;

    else if (answer == "N")
    {
        foreach (var s in series)

        {
            Console.WriteLine("\nSerie: " + s.Title + " " + s.ConstructionYear + " " + s.Genre + " " + s.ReleasedYear + " " + s.Directors + " "+ s.FirstPlatform); //First list.
        }
        foreach (var c in comedyList.OrderBy(c => c.TitleC).ThenBy(c => c.DirectorsC)) //Sorted by name first, then director with ThenBy.
        {
            Console.WriteLine("\nComedy Serie: " + c.TitleC + " " + c.DirectorsC + " " + c.GenreC); //Comedy genre is another new addition to the list. Second list.
        }
        break;
    }
    else
    {
        Console.Write("Incorrect enter, please enter a valid enter. (Y/N): ");
        goto Start2;
    }
}



