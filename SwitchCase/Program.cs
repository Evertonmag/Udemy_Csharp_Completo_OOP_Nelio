using System.Globalization;

namespace TopicosEspeciaisEmCSharp;

internal class Program
{
    static void Main(String[] args)
    {
        //SwitchCaseXIfElseIf();
        //ExpressaoCondicionalTernaria();
        //FuncoesParaString();
        //Date_Time();
        //Time_Span();
        //PropriedadesOperacoesDateTime();
        //PropriedadesOperacoesTimeSpan();
        DateTimeKind_ISO8601();
    }

    static void SwitchCaseXIfElseIf()
    {
        int x = int.Parse(Console.ReadLine());
        string day;

        if (x == 1)
            day = "Sunday";
        else if (x == 2)
            day = "Monday";
        else if (x == 3)
            day = "Tuesday";
        else if (x == 4)
            day = "Wednesday";
        else if (x == 5)
            day = "Thursday";
        else if (x == 6)
            day = "Friday";
        else if (x == 7)
            day = "Saturday";
        else
            day = "Invalid value";

        Console.WriteLine("day: " + day);
        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
        switch (x)
        {
            case 1:
                day = "Sunday";
                break;
            case 2:
                day = "Monday";
                break;
            case 3:
                day = "Tuesday";
                break;
            case 4:
                day = "Wednesday";
                break;
            case 5:
                day = "Thursday";
                break;
            case 6:
                day = "Friday";
                break;
            case 7:
                day = "Saturday";
                break;
            default:
                day = "Invalid value";
                break;
        }

        Console.WriteLine("day: " + day);
    }

    static void ExpressaoCondicionalTernaria()
    {
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

        Console.WriteLine(desconto);
    }

    static void FuncoesParaString()
    {
        string original = "abcde FGHIJ ABC abc DEFG    ";

        string s1 = original.ToUpper();
        string s2 = original.ToLower();
        string s3 = original.Trim();

        int n1 = original.IndexOf("bc");
        int n2 = original.LastIndexOf("bc");

        string s4 = original.Substring(3);
        string s5 = original.Substring(3, 5);

        string s6 = original.Replace('a', 'x');
        string s7 = original.Replace("abc", "xy");

        bool b1 = String.IsNullOrEmpty(original);
        bool b2 = String.IsNullOrWhiteSpace(original);

        Console.WriteLine("Original: " + original + "-");
        Console.WriteLine("ToUpper: " + s1 + "-");
        Console.WriteLine("ToLower: " + s2 + "-");
        Console.WriteLine("Trim: " + s3 + "-");
        Console.WriteLine("IndexOf('bc'): " + n1);
        Console.WriteLine("LastIndexOf('bc'): " + n2);
        Console.WriteLine("Substring(3): " + s4);
        Console.WriteLine("Substring(3, 5): " + s5);
        Console.WriteLine("Replace ('a', 'x'): " + s6);
        Console.WriteLine("Replace ('abc', 'xy'): " + s7);
        Console.WriteLine("IsNullOrEmpty: " + b1);
        Console.WriteLine("IsNullOrWhiteSpace: " + b2);
    }

    static void Date_Time()
    {
        DateTime d1 = new DateTime(2018, 11, 25);
        DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
        DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

        DateTime d4 = DateTime.Now;
        DateTime d5 = DateTime.Today;
        DateTime d6 = DateTime.UtcNow;

        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);
        Console.WriteLine(d5);
        Console.WriteLine(d6);

        //DateTime Parse
        DateTime d7 = DateTime.Parse("2000-08-15");
        DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
        DateTime d9 = DateTime.Parse("15/08/2000");
        DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

        Console.WriteLine(d7);
        Console.WriteLine(d8);
        Console.WriteLine(d9);
        Console.WriteLine(d10);

        //DateTime ParseExact
        DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        Console.WriteLine(d11);
        Console.WriteLine(d12);
    }

    static void Time_Span()
    {
        TimeSpan t0 = new TimeSpan(0, 1, 30);

        Console.WriteLine(t0);
        Console.WriteLine(t0.Ticks);

        TimeSpan t1 = new TimeSpan();
        TimeSpan t2 = new TimeSpan(900000000L);
        TimeSpan t3 = new TimeSpan(2, 11, 21);
        TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
        TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
        Console.WriteLine(t4);
        Console.WriteLine(t5);

        TimeSpan t6 = TimeSpan.FromDays(1.5);
        TimeSpan t7 = TimeSpan.FromHours(1.5);
        TimeSpan t8 = TimeSpan.FromMinutes(1.5);
        TimeSpan t9 = TimeSpan.FromSeconds(1.5);
        TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
        TimeSpan t11 = TimeSpan.FromTicks(900000000L);

        Console.WriteLine(t6);
        Console.WriteLine(t7);
        Console.WriteLine(t8);
        Console.WriteLine(t9);
        Console.WriteLine(t10);
        Console.WriteLine(t11);
    }

    static void PropriedadesOperacoesDateTime()
    {
        DateTime d = new DateTime(2001, 08, 15, 13, 45, 58);

        #region Propriedades

        Console.WriteLine(d);

        Console.WriteLine("1) Date: " + d.Date);
        Console.WriteLine("2) Day: " + d.Day);
        Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
        Console.WriteLine("4) DayOfWeek: " + d.DayOfYear);
        Console.WriteLine("5) DayOfWeek: " + d.Hour);
        Console.WriteLine("6) DayOfWeek: " + d.Kind);
        Console.WriteLine("7) DayOfWeek: " + d.Millisecond);
        Console.WriteLine("8) DayOfWeek: " + d.Minute);
        Console.WriteLine("9) DayOfWeek: " + d.Month);
        Console.WriteLine("10) DayOfWeek: " + d.Second);
        Console.WriteLine("11) DayOfWeek: " + d.Ticks);
        Console.WriteLine("12) DayOfWeek: " + d.TimeOfDay);
        Console.WriteLine("13) DayOfWeek: " + d.Year);

        string s1 = d.ToLongDateString();
        string s2 = d.ToLongTimeString();
        string s3 = d.ToShortDateString();
        string s4 = d.ToShortTimeString();

        string s5 = d.ToString();

        string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
        string s7 = d.ToString("yyyy-MM-dd HH:mm:ss:fff");

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
        Console.WriteLine(s6);
        Console.WriteLine(s7);
        #endregion

        Console.WriteLine("\n-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n");

        #region Operacoes
        DateTime d2 = d.AddHours(2);
        DateTime d3 = d.AddMinutes(3);
        DateTime Boleto = DateTime.Now;
        DateTime BoletoVencimento = Boleto.AddDays(7);

        DateTime d4 = new DateTime(2000, 10, 15);
        DateTime d5 = new DateTime(2000, 10, 18);

        TimeSpan t = d5.Subtract(d4);

        Console.WriteLine(d);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine("-+-+-+-+-+-+-+-+-");
        Console.WriteLine(Boleto);
        Console.WriteLine(BoletoVencimento);
        Console.WriteLine("-+-+-+-+-+-+-+-+-");
        Console.WriteLine(t);
        #endregion

    }

    static void PropriedadesOperacoesTimeSpan()
    {
        #region Exemplo
        TimeSpan t01 = TimeSpan.MaxValue;
        TimeSpan t02 = TimeSpan.MinValue;
        TimeSpan t03 = TimeSpan.Zero;

        Console.WriteLine(t01);
        Console.WriteLine(t02);
        Console.WriteLine(t03);
        #endregion

        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-");

        #region Propriedades
        TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

        Console.WriteLine(t);

        Console.WriteLine("Days: " + t.Days);
        Console.WriteLine("Hours: " + t.Hours);
        Console.WriteLine("Minutes: " + t.Minutes);
        Console.WriteLine("Miliseconds: " + t.Milliseconds);
        Console.WriteLine("Seconds: " + t.Seconds);
        Console.WriteLine("Ticks: " + t.Ticks);

        Console.WriteLine("TotalDays: " + t.TotalDays);
        Console.WriteLine("TotalHours: " + t.TotalHours);
        Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
        Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
        Console.WriteLine("TotalMiliseconds: " + t.TotalMilliseconds);
        #endregion

        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-");

        #region Operacoes
        TimeSpan t1 = new TimeSpan(1, 30, 10);

        TimeSpan t2 = new TimeSpan(0, 10, 5);

        Console.WriteLine("TimeSpan Original T1" + t1);
        Console.WriteLine("TimeSpan Original T2" + t2);

        TimeSpan sum = t1.Add(t2);
        TimeSpan dif = t1.Subtract(t2);
        TimeSpan mult = t2.Multiply(2.0);
        TimeSpan div = t2.Divide(2.0);

        Console.WriteLine("Soma entre T1 e T2: " + sum);
        Console.WriteLine("Subtração entre T1 e T2" + dif);
        Console.WriteLine("Multiplicação de T2 por 2" + mult);
        Console.WriteLine("Divisão de T2 por 2" + div);
        #endregion

    }

    static void DateTimeKind_ISO8601()
    {
        #region DateTimeKind
        DateTime d01 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

        DateTime d02 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

        DateTime d03 = new DateTime(2000, 8, 15, 13, 5, 58);

        Console.WriteLine("d1: " + d01);
        Console.WriteLine("d1 (Kind): " + d01.Kind);
        Console.WriteLine("d1 (ToLocal): " + d01.ToLocalTime());
        Console.WriteLine("d1 (ToUtc): " + d01.ToUniversalTime());
        Console.WriteLine("\nd2: " + d02);
        Console.WriteLine("d2 (Kind): " + d02.Kind);
        Console.WriteLine("d2 (ToLocal): " + d02.ToLocalTime());
        Console.WriteLine("d2 (ToUtc): " + d02.ToUniversalTime());
        Console.WriteLine("\nd3: " + d03);
        Console.WriteLine("d3 (Kind): " + d03.Kind);
        Console.WriteLine("d3 (ToLocal): " + d03.ToLocalTime());
        Console.WriteLine("d3 (ToUtc): " + d03.ToUniversalTime());
        #endregion

        Console.WriteLine("\n-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n");

        #region ISO8601

        DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
        DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

        Console.WriteLine("d1: " + d1);
        Console.WriteLine("d1 (Kind): " + d1.Kind);
        Console.WriteLine("d1 (ToLocal): " + d1.ToLocalTime());
        Console.WriteLine("d1 (ToUtc): " + d1.ToUniversalTime());
        Console.WriteLine("\nd2: " + d2);
        Console.WriteLine("d2 (Kind): " + d2.Kind);
        Console.WriteLine("d2 (ToLocal): " + d2.ToLocalTime());
        Console.WriteLine("d2 (ToUtc): " + d2.ToUniversalTime());

        Console.WriteLine();
        Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
        // cuidado nao converter data para o formato ISO 8601
        // sem saber se a data ja esta no formato universal
        // (fazer igual abaixo para ter a certeza)
        Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));


        #endregion

    }
}