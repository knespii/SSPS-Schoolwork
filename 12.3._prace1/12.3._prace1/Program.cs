kniha rur = new kniha();
Autor capek = new Autor();
capek.jmeno = "autor";
rur.nazev = "R.U.R";

class Autor
{
    public string jmeno;
    public int narozeni;
}

class kniha
{
    public string nazev;
    public int rokVydani;
   Autor autor;
}

