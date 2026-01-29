using System.Xml.Schema;

class telefon {
    public string vyrobce;
    public int rokVydani;
    public int pocetAplikaci;

    public telefon (string vyrobce, int rokVydani, int pocetAplikaci)
    {
        vyrobce = vyrobce;
        rokVydani = rokVydani;
        pocetAplikaci = pocetAplikaci;
    }public virtual void vypisInfo()
    {
        Console.WriteLine($"{vyrobce} {rokVydani} ")
    }
}