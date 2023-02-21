class Terning
{

    public int Værdi { get; private set; }

    // AFKOBLING
    private ITilfældighedGenerator generator;

    public Terning(ITilfældighedGenerator generator = null)
    {
        if (generator == null)
            generator = new TilfældighedsGeneratorRandom();

        this.generator = generator;
        Ryst();
    }

    public void Skriv()
    {
        Console.WriteLine("[" + Værdi + "]");
    }

    public void Ryst()
    {
        Værdi = generator.FindTal(1, 7);
    }


}

public interface ITilfældighedGenerator
{
    int FindTal(int min, int max);
}

public class TilfældighedsGeneratorRandom : ITilfældighedGenerator
{
    private Random random;
    public TilfældighedsGeneratorRandom()
    {
        random = new Random();
    }
    public int FindTal(int min, int max)
    {
        return random.Next(min, max);
    }
}

public class TilfældighedsGeneratorMock : ITilfældighedGenerator
{


    public int FindTal(int min, int max)
    {
        return 6;
    }
}


