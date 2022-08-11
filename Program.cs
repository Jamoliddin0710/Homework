
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
    uzbek["answer"] = "Sizning javobingiz : ";
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


    List<List<string>> questions = new List<List<string>>();
    var statistics = new List<Tuple<double, string, int, int>>();
    string parol = "12345";
    addDefaultquestions(questions);

  // tillar tanlash menusi
  begin();


 // 1- testni boshlash
    void beginTests()
{
    double foiz = default;
    int index = 0;
    List<string> xatosavol = new List<string>();
    List<string> trueanswer = new List<string>();
    List<string> useranswer = new List<string>();

    string user;
    int testresult = 0;

    Console.WriteLine(applang["username"] );
    user = Console.ReadLine();

    char answerkey = 'A';
    Console.WriteLine(applang["starttests"]);
    for (var i = 0; i < questions.Count; i++)
    {

        for (var j = 0; j < questions[i].Count; j++)
        {
            if (j == 0)
            {
                Console.WriteLine($"{applang["question"]} {questions[i][j]}");
            }
            else if (j != questions[i].Count - 1)
            {
                if (answerkey == 'E') answerkey = 'A';
                Console.Write($"{answerkey++}) {questions[i][j]}  ");
            }
        }
        Console.Write($"\n{applang["chooseansewer"]}");
        var youranswer = Console.ReadLine()!;
        if (youranswer == questions[i][questions[i].Count - 1])
        {
            testresult++;
            Console.WriteLine(applang["correct"]);
        }
        else
        {
            trueanswer.Add(questions[i][questions[i].Count - 1]);
            xatosavol.Add(questions[i][0]);
            useranswer.Add(youranswer);
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

        for (var i = 0; i < index; i++)
        {
            Console.WriteLine($" {applang["question"]}{xatosavol[i]}");
            Console.WriteLine($"{applang["answer"]} {useranswer[i]}");
            Console.WriteLine($"{applang["correctanswer"]} {trueanswer[i]}");
        }
    }

    var statistika = new Tuple<double, string, int, int>(foiz, user, testresult, questions.Count);

    statistics.Add(statistika);
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



    void addDefaultquestions(List<List<string>> questions)
{

    questions.Add(new List<string>() { "2 + 3 = ?", "5", "4", "2", "1", "A" });
    questions.Add(new List<string>() { "1 * 2 = ?", "3", "2", "1", "4", "B" });
    questions.Add(new List<string>() { "4 * 9 = ?", "37", "25", "12", "36", "D" });
    questions.Add(new List<string>() { "7 * 8 = ?", "56", "24", "98", "23", "A" });
    questions.Add(new List<string>() { "98 / 14 = ?", "9", "8", "7", "3", "C" });

}


    void clearStatistics()
{
    Console.WriteLine(applang["clear"]);
    
    statistics.Clear();
    close();
}






     void addQuestion()
  {
     Console.Write(applang["password"]);
     string password = Console.ReadLine();

     if (password != parol)
     {
        
        Console.WriteLine(applang["unallowed"] );
        close();
     }

       Console.Write(applang["questioncount"]);

      int n = int.Parse(Console.ReadLine()!);
    for (var i = 0; i < n; i++)
    {
         List<string> addquestions = new List<string>();

         Console.WriteLine(applang["manual"]);
         Console.Write(applang["question"]);

         addquestions.Add(Console.ReadLine()!);
         Console.Write(applang["testkey"]);

         addquestions.Add(Console.ReadLine()!);
         addquestions.Add(Console.ReadLine()!);
         addquestions.Add(Console.ReadLine()!);
         addquestions.Add(Console.ReadLine()!);
         Console.Write(applang["insertanswer"]);
         addquestions.Add(Console.ReadLine()!);
         questions.Add(addquestions);
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
    List<int> tj = new List<int>();
    statistics = statistics!.OrderByDescending(s => s.Item1).ToList();

    if (statistics!.Count > 0)
    {
        for (var i = 0; i < statistics.Count; i++)
        {
            var (foiz, ism, togrijavobsoni, barchasavol) = statistics[i];
            Console.WriteLine($"{ism} {(Convert.ToDouble(togrijavobsoni) / barchasavol):P0} ({togrijavobsoni}/{barchasavol})");

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




