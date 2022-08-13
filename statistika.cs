
struct statistika
{


  public  string Username;
  public   int correctanswercount;
  public   int allquestioncount;
    public statistika( string user, int truecount, int questioncount)
    {
        allquestioncount = questioncount;
        correctanswercount = truecount;
        Username = user;
    }
    public double ToPercent()
    {
        return ((double)correctanswercount/allquestioncount)*100;
    }
}