//delegate int FindTalDelegate(int min, int max);
class Terning
{
    //public FindTalDelegate findTalDelegate;
    public Func<int, int, int> findTalDelegate;
    public Action<string> skrivDelegate;
    public event Action<int> erSekserDelegate;
    private int antalSeksere = 0;

    public int Værdi { get; private set; }

    public void Skriv()
    {
        //if (skrivDelegate != null)
        //    skrivDelegate("[" + Værdi + "]");
        
        skrivDelegate?.Invoke("[" + Værdi + "]");
    }

    public void Ryst()
    {
        if (findTalDelegate == null)
            throw new ApplicationException("Mangler find tal");
        Værdi = findTalDelegate(1, 7);
        if (Værdi == 6)
            antalSeksere++;

        if (Værdi == 6 && erSekserDelegate != null)
            //erSekserDelegate.Invoke(antalSeksere);
            erSekserDelegate(antalSeksere);


    }

    public Terning()
    {
        Værdi = 1;
    }
}


