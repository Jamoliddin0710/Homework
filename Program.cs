
using System;
using System.Net.NetworkInformation;

List<List<string>> questions = new List<List<string>>();
var statistics = new List<Tuple<double  ,string, int, int >>();
string parol = "12345";
addDefaultquestions(questions);


start();

  
void beginTests()
{
    double foiz = default;
    int index = 0;
   List<string> xatosavol = new List<string>();
   List<string> trueanswer = new List<string>();
   List<string> useranswer = new List<string>();

     string user ;
    int testresult = 0;
   
   Console.WriteLine($"Username kiriting : ");
    user = Console.ReadLine()!;
       
   string youranswer;

   char answerkey = 'A';
    Console.WriteLine($"Testni yechishni  boshlang ");
    for (var i = 0; i < questions.Count; i++)
    {
        
        for (var j = 0; j < questions[i].Count; j++)
        {
         if(j == 0)
         {
            Console.WriteLine($"Savol : {questions[i][j]}");
         }
        else if(j != questions[i].Count - 1)
         {
            if(answerkey == 'E') answerkey = 'A';
              Console.Write($"{answerkey++}) {questions[i][j]}  ");
         }
        }
        Console.Write($"\nJavobingizni tanlang : "); 
        youranswer = Console.ReadLine()!;
         if(youranswer == questions[i][questions[i].Count-1])
        {
            testresult ++;
            Console.WriteLine($"Javobingiz to'g'ri");
        }
        else
        {
            trueanswer.Add(questions[i][questions[i].Count-1]);
             xatosavol.Add(questions[i][0]);
             useranswer.Add(youranswer);
            Console.WriteLine($"Javobingiz noto'g'ri");
            index++;
        }
        
        if(i == questions.Count - 1)
        {
         
         
         Console.WriteLine($"Test yakunlandi natijani ko'rish uchun 'Enter'ni bosing");
         Console.ReadKey();
         Console.WriteLine($"Siznig natijangiz {(Convert.ToDouble(testresult)/questions.Count):P3} ({testresult}/{questions.Count}) ");
        foiz =(Convert.ToDouble(testresult)/questions.Count);
        }
    }
    if(index != 0)
    {
 Console.WriteLine($"\n Xato testlaringiz tahlili  ");
 
    for (var i = 0; i < index; i++)
    {
        Console.WriteLine($"Savol : {xatosavol[i]}");
        Console.WriteLine($"Sizning javobingiz : {useranswer[i]}");
        Console.WriteLine($"To'g'ri javob : {trueanswer[i]}");

    }
    }
    
    var statistika = new Tuple<double ,string , int, int>(foiz,user,testresult,questions.Count);
    
    statistics.Add(statistika);
    close();
}


void close() 
{
  Console.WriteLine($"Dasturdan chiqish uchun '0' ni  menuga qaytish uchun '1' ni bosing");
  int buttton = int.Parse(Console.ReadLine()!);
  if(buttton == 0)
  {
    return ;
  }
  else
  {
    start();
  }
}



void addDefaultquestions(List<List<string>> questions)
{  
    
       questions.Add(new List<string>() {"2 + 3 = ?","5","4", "2","1","A"});
       questions.Add(new List<string>(){"1 * 2 = ?", "3", "2", "1","4","B"});
       questions.Add(new List<string>(){"4 * 9 = ?", "37", "25", "12","36","D"});
       questions.Add(new List<string>(){"7 * 8 = ?", "56", "24", "98","23","A"});
       questions.Add(new List<string>(){"98 / 14 = ?", "9", "8", "7","3","C"});
   
}


void clearStatistics()
{
    statistics.Clear();   
    close();
}



void chooseMenu()
{
    var input = (Menu)int.Parse(Console.ReadLine()!);  
   switch(input)
   {
    case Menu.beginTests : beginTests(); break;
    case Menu.addQuestion : addQuestion(); break;
    case Menu.Dashboard :   Dashboard(); break;
    case Menu.Statistics :  Statistics(); break;
    case Menu.clearStatistics: clearStatistics(); break;
    default : Console.WriteLine($"Bunday menu mavjud emas");
    start(); break;
   } 
}




 void addQuestion()
 {
    Console.Write($"Parol kiriting ");
    string password = Console.ReadLine();

    if(password == "12345")
    {
    Console.Write($"Nechta savol qo'shmoqchisiz : n = ");
    
    int n = int.Parse(Console.ReadLine()!);
    for(var i = 0; i < n ; i++)
    {
   List<string>addquestions = new List<string>(); 
     
    Console.WriteLine($"Qo'llanma : 1 - qatorda  savol \n keyingi 4 ta - qatorda kalitlar  \n 6 - qatorda to'g'ri javob(A,B,C,D) ");
    Console.Write($"Savol : ");
    
    addquestions.Add(Console.ReadLine()!);
        Console.Write($"Kalitlar (1 ta qatorda 1 ta ) ");

    addquestions.Add(Console.ReadLine()!);
    addquestions.Add(Console.ReadLine()!);
    addquestions.Add(Console.ReadLine()!);
    addquestions.Add(Console.ReadLine()!);
    Console.Write($"To'g'ri javob (A , B , C , D) ");
    addquestions.Add(Console.ReadLine()!);
       questions.Add(addquestions); 
    }
   
 }
 else
 {
    Console.WriteLine($"Siz savol qo'sha olmaysiz");
 }
   close();
 }





void   Dashboard()
  {
    Console.WriteLine($"Test savollar soni {questions.Count} ta");
    close();
  }


 void  Statistics()
 {
    List<int>tj = new List<int>();
   statistics = statistics!.OrderByDescending(s => s.Item1).ToList();

  if(statistics!.Count > 0)
  {
    for (var i = 0; i < statistics.Count; i++)
    {
         var (foiz , ism , togrijavobsoni , barchasavol) = statistics[i];
         Console.WriteLine($"{ism} {(Convert.ToDouble(togrijavobsoni)/barchasavol):P0} ({togrijavobsoni}/{barchasavol})");
         
    }
   
  }
  else
  {
    Console.WriteLine($"Hali hech kim test yechmagan.");
    
  }
    close();
 }




void start()
{ 
    showMenu(Menu.beginTests);
    showMenu(Menu.addQuestion);
    showMenu(Menu.Dashboard);
    showMenu(Menu.Statistics);
    showMenu(Menu.clearStatistics);
    chooseMenu();
}
 
 void showMenu(Menu menu)
 {
    Console.WriteLine($"{(int)menu}.{menu}");
 }



enum Menu
{
    beginTests = 1,
    addQuestion, 
    Dashboard,
    Statistics,
    clearStatistics,
};



