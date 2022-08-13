
struct questiontype
{
 public string Savol ;
 public int Togrijavobindeksi;
 public List <string> Varinantlar;
 public questiontype(string savol , int togrijavobindeksi, List<string> variantlar )
 {
    Varinantlar = variantlar;
    Savol = savol;
    Togrijavobindeksi = togrijavobindeksi;
 }
}