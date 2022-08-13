
using System.Linq;
   using System;
using System.Net.NetworkInformation;

     
    Dictionary<string,string> uzbek = new Dictionary<string, string>();     
    Dictionary<string,string> russian = new Dictionary<string, string>();     
    Dictionary<string,string> english = new Dictionary<string, string>();     
    Dictionary<string,string> applang = new Dictionary<string, string>();     
  /// Tillar tarjimasi boshlandi :
    uzbek["password"] = "Parolni kiriting : ";
     english["password"] = "Enter password : ";
      russian["password"] = "Введите пароль: ";
    uzbek["username"] = "Username kiriting";
     english["username"] = "Enter Username";
      russian["username"] = "Введите имя пользователя";
    uzbek["starttests"] = "Testni yechishni  boshlang";
     english["starttests"] = "Start solving the test";
      russian["starttests"] = "Начать решение теста";
    uzbek["question"] = "Savol : ";
     english["question"] = "Question : ";
      russian["question"] = "Вопрос: ";
    uzbek["chooseansewer"] = "Javobingizni tanlang ";
     english["chooseansewer"] = "Choose your answer ";
      russian["chooseansewer"] = "Выберите ответ";
    uzbek["correct"] = "Javobingizni to'gri ✅";
     english["correct"] = "Your answer is correct ✅";
      russian["correct"] = "Ваш ответ правильный ✅";
    uzbek["incorrect"] = "Javobingizni noto'gri ❓";
     english["incorrect"] = "Your answer is incorrect ❓";
      russian["incorrect"] = "Ваш ответ неверен ❓";
    uzbek["analysistest"] = " \n Xato testlaringiz tahlili  :";
     english["analysistest"] = " \n Analysis of your error tests :";
      russian["analysistest"] = "\n Анализ ваших тестов на ошибки:";
    uzbek["resultbutton"] = "Test yakunlandi natijani ko'rish uchun 'Enter'ni bosing";
     english["resultbutton"] = "Test completed, press 'Enter' to see the result";
      russian["resultbutton"] = "Тест завершен, нажмите Enter, чтобы увидеть результат";
    uzbek["result"] = "Siznig natijangiz ";
     english["result"] = "Your result ";
      russian["result"] = "Ваш результат";
    uzbek["answer"] = "Sizning javobingiz :";
     english["answer"] = "Your answer : ";
      russian["answer"] = "Ваш ответ: ";
    uzbek["correctanswer"] = "To'g'ri javob : ";
     english["correctanswer"] = "Correct answer : ";
      russian["correctanswer"] = "Правильный ответ: ";
    uzbek["chooseclose"] = "Dasturdan chiqish uchun '0' ni  menuga qaytish uchun '1' ni bosing";
     english["chooseclose"] = "Press '0' to exit the program, '1' to return to the menu";
      russian["chooseclose"] = "Нажмите '0' для выхода из программы, '1' для возврата в меню";
    uzbek["absentmenu"] = "Bunday menu mavjud emas";
     english["absentmenu"] = "This menu does not exist";
      russian["absentmenu"] = "Этого меню не существует";
    uzbek["unallowed"]  = "Siz savol qo'sha olmaysiz";
     english["unallowed"] = "You cannot add a question";
      russian["unallowed"] = "Вы не можете добавить вопрос";
    uzbek["questioncount"] = "Nechta savol qo'shmoqchisiz : n = ";
     english["questioncount"] = "How many questions do you want to add: n = ";
      russian["questioncount"] = "Сколько вопросов вы хотите добавить: n = ";
    uzbek["manual"] = "Qo'llanma : 1 - qatorda  savol \n keyingi 4 ta - qatorda kalitlar  \n 6 - qatorda to'g'ri javob(A,B,C,D) ";
     english["manual"] = "Manual: question in the 1st line \n keys in the next 4 lines \n correct answer in the 6th line (A,B,C,D) ";
      russian["manual"] = "Руководство: вопрос в 1-й строке \n ключей в следующих 4-х строках \n правильный ответ в 6-й строке (A,B,C,D)";
    uzbek["testkey"] = "Kalitlar (1 ta qatorda 1 ta ) ";
     english["testkey"] = "Keys (1 in 1 row) ";
      russian["testkey"] = "Ключи (1 в 1 ряду)";
    uzbek["insertanswer"] = "To'g'ri javob (A , B , C , D) ";
     english["insertanswer"] = "The correct answer is (A, B, C, D) ";
      russian["insertanswer"] = "Правильный ответ: (A, B, C, D)";
    uzbek["testcount"] = "Test savollar soni ";
     english["testcount"] = "Number of test questions ";
      russian["testcount"] = "Количество тестовых вопросов ";
    uzbek["notsolutiontest"] = "Hali hech kim test yechmagan.";
     english["notsolutiontest"] = "No one has solved the test yet.";
      russian["notsolutiontest"] = "Еще никто не решил тест.";
    uzbek["clear"] = "Statistika tozalandi."; 
     english["clear"] = "Statistics cleared.";
      russian["clear"] = "Статистика очищена.";
    
    // Tillar tarjimasi yakunlandi


    List<questiontype> questions = new List<questiontype>();
    var statistics = new List<statistika>();
    Tuple<double, string, int, int> analyst;
    string parol = "12345";
    addDefaultquestions();

  // tillar tanlash menusi
  begin();


 // 1- testni boshlash
    void beginTests()
{
    double foiz = default;
    int index = 0;
    List<notquestion> Xatosavol = new List<notquestion>();
   notquestion ob1 = new notquestion();
    string user;
    int testresult = 0;

    Console.WriteLine(applang["username"] );
    user = Console.ReadLine()!;
   var errorresolved = new List<Tuple <string , string , string >>();

    char answerkey = 'A';
    Console.WriteLine(applang["starttests"]);
    for (var i = 0; i < questions.Count; i++)
    {
    Console.WriteLine($"{applang["question"]} {questions[i].Savol}");
    for (int j = 0; j < questions[i].Varinantlar.Count; j++)
    {
     Console.Write($"{(j + 1)}){questions[i].Varinantlar[j]} ");
    }
           
          
        
        Console.Write($"\n{applang["chooseansewer"]}");
        var youranswer = int.Parse(Console.ReadLine()!);
        if (youranswer == questions[i].Togrijavobindeksi)
        {
            testresult++;
            Console.WriteLine(applang["correct"]);
        }
        else
        {
          ob1.Youranswer = questions[i].Varinantlar[youranswer-1];
          
          
          ob1.Question = questions[i].Savol;
          
          ob1.Percent = questions[i].Varinantlar[questions[i].Togrijavobindeksi-1];
          Xatosavol.Add(ob1);
          
          
            Console.Write(applang["incorrect"]);
            Console.WriteLine($"");
            
            
            index++;
        }

        if (i == questions.Count - 1)
        {


            Console.WriteLine(applang["resultbutton"]);
            Console.ReadKey();
            Console.WriteLine($"{applang["result"]} {(Convert.ToDouble(testresult) / questions.Count):P3} ({testresult}/{questions.Count}) ");
            foiz = (Convert.ToDouble(testresult) / questions.Count);
        }
    }
    if (index != 0)
    {
        Console.WriteLine(applang["analysistest"]);

        foreach (var item in Xatosavol)
        {
         Console.WriteLine($"{item.Question}  Sizning javobingiz : {item.Youranswer} , To'g'ri javob: {item.Percent} ");
          
        }
    }

    statistika st = new statistika(user,testresult,questions.Count);
    statistics!.Add(st);
    close();
}


    void close()
{
    Console.WriteLine(applang["chooseclose"]);
    int buttton = int.Parse(Console.ReadLine()!);
    if (buttton == 0)
    {
        return;
    }
    else
    {
        start();
    }
}



    void addDefaultquestions()
{
  var Varinantlar1 = new List<string>(){"1","2","3","0"};
  var question1 = new questiontype("15 % 4 = ?",3,Varinantlar1);
  questions.Add(question1);
  var Varinantlar2 = new List<string>(){"60","12","70","64"};
  var question2 = new questiontype("15 * 4 = ?",1,Varinantlar2);
  questions.Add(question2);
  var Varinantlar3 = new List<string>(){"124","122","132","121"};
  var question3 = new questiontype("11^2 = ?",4,Varinantlar3);
  questions.Add(question3);
}


    void clearStatistics()
{
    Console.WriteLine(applang["clear"]);
    
    statistics!.Clear();
    close();
}






     void addQuestion()
  {
     Console.Write(applang["password"]);
     string password = Console.ReadLine()!;

     if (password != parol)
     {
        
        Console.WriteLine(applang["unallowed"] );
        close();
     }

       Console.Write(applang["questioncount"]);

      int n = int.Parse(Console.ReadLine()!);
    for (var i = questions.Count; i <= n ; i++)
    {
      List<string> variant  = new List<string>();
       questiontype type = new questiontype();    
       
         Console.WriteLine(applang["manual"]);
         Console.Write(applang["question"]);
       type.Savol = Console.ReadLine()!;
         
       Console.Write(applang["testkey"]);
       Console.WriteLine($"Nechta variant qo'shmoqchisiz ");
       
       type.Varinantlar = Console.ReadLine()!.Split(',').ToList();
         Console.Write(applang["insertanswer"]);
         
         type.Togrijavobindeksi = int.Parse(Console.ReadLine()!);
         
         questions.Add(type);
     }

     close();
     }


   void Dashboard()
{
    Console.WriteLine($"{applang["testcount"]} {questions.Count} ");
    close();
}


   void Statistics()
{
    
    if (statistics!.Count > 0)
    {
        foreach (var item in statistics)
        {
          Console.WriteLine($"{item.Username} {(item.ToPercent()):P0} ({item.correctanswercount}/{item.allquestioncount})");
 
        } 
    }
    else
    {
        Console.WriteLine(applang["notsolutiontest"]);

    }
    close();
}


    void chooseMenu()
  {
     var input = (Menu)int.Parse(Console.ReadLine()!);
     switch (input)
     {
         case Menu.BeginTests: beginTests(); break;
         case Menu.AddQuestion: addQuestion(); break;
         case Menu.Dashboard: Dashboard(); break;
         case Menu.Statistics: Statistics(); break;
         case Menu.ClearStatistics: clearStatistics(); break;
         case Menu.Close: close(); break;
         case Menu.Lang: begin(); break;
         default:
            Console.WriteLine(applang["absentmenu"]);
            start(); break;
    }
  }



   void start()
   {
     showMenu(Menu.BeginTests);
     showMenu(Menu.AddQuestion);
     showMenu(Menu.Dashboard);
     showMenu(Menu.Statistics);
     showMenu(Menu.ClearStatistics);
     showMenu(Menu.Close);
     showMenu(Menu.Lang);

     chooseMenu();
   }

   void showMenu(Menu menu)
{
    Console.WriteLine($"{(int)menu}.{menu}");
}

 void chooseLang()
 {
   var  kirit = (Lang)int.Parse(Console.ReadLine()!);
   switch (kirit)
   {
    case Lang.uzbek : applang = uzbek; break;
    case Lang.english : applang = english; break;
    case Lang.russian : applang = russian; break;
    default: applang = uzbek; break; 
   } 
 }

 void begin()
 {
  showLang(Lang.uzbek);
  showLang(Lang.english);
  showLang(Lang.russian);
  chooseLang();  
  start();  
 }
void showLang(Lang lang)
{
    Console.WriteLine($"{(int)lang}.{lang}");
    
}

   enum Menu
   {
     BeginTests = 1,
     AddQuestion,
     Dashboard,
     Statistics,
     ClearStatistics,
     Close,
     Lang  
   };
 
 

   enum Lang
   {
    uzbek = 1,
    english,
    russian
   }



