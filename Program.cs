namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (Film movie = new Film("Inception", "Warner Bros. Pictures", "Sci-Fi", 148, 2010))
            {
                movie.DisplayInfo();
            }

            List<string> actors = new List<string> { "Johnny Depp", "Angelina Jolie", "Leonardo DiCaprio" };

            Play play = new Play("Romeo and Juliet", "Royal Shakespeare Theatre", "Drama", 180, actors);
        }
    }
}

class Film : IDisposable
{
    // Поля класу
    private string title;
    private string studioName;
    private string genre;
    private int duration;
    private int year;

    // Конструктор класу
    public Film(string title, string studioName, string genre, int duration, int year)
    {
        this.title = title;
        this.studioName = studioName;
        this.genre = genre;
        this.duration = duration;
        this.year = year;
    }

    // Властивості для доступу до полів класу
    public string Title { get { return title; } }
    public string StudioName { get { return studioName; } }
    public string Genre { get { return genre; } }
    public int Duration { get { return duration; } }
    public int Year { get { return year; } }

    // Метод класу
    public void DisplayInfo()
    {
        Console.WriteLine($"Назва: {title}");
        Console.WriteLine($"Кіностудія: {studioName}");
        Console.WriteLine($"Жанр: {genre}");
        Console.WriteLine($"Тривалість: {duration} хв");
        Console.WriteLine($"Рік: {year}");
    }

    // Реалізація інтерфейсу IDisposable
    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Виконуємо вивільнення ресурсів, які необхідно вивільнити вручну
                Console.WriteLine($"Ресурси класу Film вивільнено.");
            }
            disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~Film()
    {
        Dispose(false);
    }
}
class Play : IDisposable
{
    
    private string title;
    private string theaterName;
    private string genre;
    private int duration;
    private List<string> actors;

    
    public Play(string title, string theaterName, string genre, int duration, List<string> actors)
    {
        this.title = title;
        this.theaterName = theaterName;
        this.genre = genre;
        this.duration = duration;
        this.actors = actors;
    }

    
    public string Title { get { return title; } }
    public string TheaterName { get { return theaterName; } }
    public string Genre { get { return genre; } }
    public int Duration { get { return duration; } }
    public List<string> Actors { get { return actors; } }

    
    public void DisplayInfo()
    {
        Console.WriteLine($"Назва спектаклю: {title}");
        Console.WriteLine($"Театр: {theaterName}");
        Console.WriteLine($"Жанр: {genre}");
        Console.WriteLine($"Тривалість: {duration} хв");
        Console.WriteLine("Актори:");
        foreach (string actor in actors)
        {
            Console.WriteLine($"- {actor}");
        }
    }

    
    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
               
                Console.WriteLine($"Ресурси класу Play вивільнено.");
            }
            disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~Play()
    {
        Dispose(false);
    }
}