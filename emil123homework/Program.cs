//int eded= int.Parse(Console.ReadLine());
//static int Kvadrat(int eded)
//{
//    return eded * eded;
//}
//int netice = Kvadrat(eded);
//Console.WriteLine(netice);

//Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod
//int b =int.Parse(Console.ReadLine());
//int[] ededler = new int[b];
//for (int i=0;i<b;i++)
//{
//    ededler[i] = int.Parse(Console.ReadLine());
//}
//static int[] Yeniarray(int[] ededler)
//{
//    int[] yeniededler = new int[ededler.Length];
//    for (int j = 0; j < ededler.Length; j++)
//    {
//        int neded = ededler[j]*ededler[j];
//        yeniededler[j] = neded;
//    }
//    return yeniededler;
//}
//int[] netice = Yeniarray(ededler);
//Console.WriteLine(netice);

//string BosluqsuzEt(string metn)
//{
//    string yeni = "";

//    foreach (char c in metn)
//    {
//        if (c != ' ')
//        {
//            yeni += c;
//        }
//    }

//    return yeni;
//}

//int n = int.Parse(Console.ReadLine());

//if (n % 3 == 0 && n % 7 == 0)
//    Console.WriteLine("3-e ve 7-ye bolunur");
//else
//    Console.WriteLine("Bolunmur");



//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());

//int say = 0;

//for (int i = n; i <= m; i++)
//{
//    if (i % 2 != 0)
//        say++;
//}

//Console.WriteLine(say);


//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());

//int cem = 0;

//for (int i = n; i <= m; i++)
//{
//    if (i % 2 != 0)
//        cem += i;
//}

//Console.WriteLine(cem);

//int n = int.Parse(Console.ReadLine());

//bool sade = true;

//if (n < 2)
//    sade = false;

//for (int i = 2; i < n; i++)
//{
//    if (n % i == 0)
//    {
//        sade = false;
//        break;
//    }
//}

//if (sade)
//    Console.WriteLine("Sade ededdir");
//else
//    Console.WriteLine("Murekkeb ededdir");


//int[] ededler = { 1, 2, 3, 4, 5, 6 };

//int cem = 0;

//foreach (int x in ededler)
//{
//    if (x % 2 == 0)
//        cem += x;
//}

//Console.WriteLine(cem);


// 8
//string[] sozler = { "salam", "necesen", "program", "sagol" };

//char herf = 'a';

//int netice = HerfSay(sozler, herf);

//Console.WriteLine(netice);

//int HerfSay(string[] sozler, char herf)
//{
//    int say = 0;

//    foreach (string soz in sozler)
//    {
//        foreach (char c in soz)
//        {
//            if (c == herf)
//                say++;
//        }
//    }

//    return say;
//}

//9


//string metn = "   salam necesen?   ";

//string netice = EvvelBosluqSil(metn);

//Console.WriteLine(netice);

//string EvvelBosluqSil(string metn)
//{
//    int i = 0;

//    while (i < metn.Length && metn[i] == ' ')
//    {
//        i++;
//    }

//    string yeni = "";

//    for (int j = i; j < metn.Length; j++)
//    {
//        yeni += metn[j];
//    }

//    return yeni;
//}


//string metn = Console.ReadLine();

//int say = 0;

//foreach (char c in metn)
//{
//    if (c == 'A' || c == 'a')
//        say++;
//}

//Console.WriteLine(say);

//int n;

//while (true)
//{
//    n = int.Parse(Console.ReadLine());

//    if (n > 0 && n % 2 == 0)
//        break;

//    Console.WriteLine("Musbet cut eded daxil et!");
//}

//int kvadrat = n * n;

//Console.WriteLine(kvadrat);

//int[] arr = { 7, 12, 5, 8 };

//int[] netice = EnKiciyiSil(arr);

//foreach (int x in netice)
//{
//    Console.WriteLine(x);
//}

//int[] EnKiciyiSil(int[] arr)
//{
//    int min = arr[0];

//    foreach (int x in arr)
//    {
//        if (x < min)
//            min = x;
//    }

//    int[] yeni = new int[arr.Length - 1];
//    int index = 0;

//    foreach (int x in arr)
//    {
//        if (x != min)
//        {
//            yeni[index] = x;
//            index++;
//        }
//    }

//    return yeni;
//}


//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());

//PolindromlariCapEt(n, m);

//void PolindromlariCapEt(int n, int m)
//{
//    for (int i = n; i <= m; i++)
//    {
//        int temp = i;
//        int ters = 0;

//        while (temp > 0)
//        {
//            ters = ters * 10 + temp % 10;
//            temp /= 10;
//        }

//        if (i == ters)
//            Console.WriteLine(i);
//    }
//}
