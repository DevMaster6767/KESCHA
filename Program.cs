//satr turi

//satr uzunligin olish
/*string myText = "Hello";
int value = myText.Length;
Console.WriteLine(value);*/

//CompareTo() – berilgan satrni boshqa bir satr bilan solishtiradi va bizga bool ya’ni True/False qiymatda javob qaytaradi
/*string str1 = "Hello";
string str2 = "World";
bool IsSame = str1.CompareTo(str2) == 0;
Console.WriteLine(IsSame);*/

//ToLower() – berilgan satrdagi barcha harflarni kichik harflarga o’zgartiradi
/*string str1 = "Hello, WORLD !";
string str2 = str1.ToLower();
Console.Write(str2);*/

//ToUpper() – berilgan satrdagi barcha harflarni katta harflarga o’zgartiradi
/*string str1 = "Hello, World !";
string str2 = str1.ToUpper();
Console.Write(str2);*/

//Split() – berilgan satrni biz kiritgan belgi ajratib turgan qismlarga bo'ladi va yangi massivga yuklaydi:
/*string satr="satr,ustun,katakcha";
string [] massiv=satr.Split(',');
foreach (string a in massiv)
Console.WriteLine(a);*/

//StartsWith() – berilgan satr biz kiritgan satr bilan boshlanganmi yoki yo'qligini tekshiradi. bool tipida qiymat qaytaradi.
/*string str1 = "Hello World";
string str2 = "He";
bool result = str1.StartsWith(str2);
Console.WriteLine(result);*/

//Contains() – berilgan satr tarkibida ko’rsatilgan satr yoki belgi bor yoki yo’qligini tekshiradi. Agar bor bo'lsa true, aks holda false qiymat qaytaradi.
/*string str1 = "Hello World";
string str2 = "bye";
bool result = str1.Contains(str2);
Console.WriteLine(result);   //output: False
Console.WriteLine(str1.Contains("rld"));  // output: True
Console.WriteLine(str1.Contains('a')); // output: False*/

//IndexOf() – berilgan satr tarkibida kor’rsatilgan satrni indeksini topib, bizga int tipida qaytarib beradi. Agar berilgan satr tarkibida biz ko'rsatgan satr mavjud bo'lmasa, -1 ni qaytaradi.
/*string str1 = "Hello World";
string str2 = "lo";
int result = str1.IndexOf(str2);
Console.WriteLine(result);*/

//Substring() – berilgan satrning ko’rsatilgan diapazondagi qismini qirqib olib, bizga qaytaradi
/*string str1 = "Hello World";
string str2 = str1.Substring(1, 4);
Console.WriteLine(str2);*/

//IsNullOrEmpty() – berilgan satrni bo’sh yoki null ekanligini tekshiradi. Agar satr bo'sh bo'lsa yoki qiymati null ga teng bo'lsa true, aks holda false qiymat qaytaradi.
/*string name = "";
bool IsEmpty = String.IsNullOrEmpty(name);
Console.WriteLine(IsEmpty);*/

//Concat() – berilgan ikki satrnni birlashtiruvchi funksiya
/*string a = "Farrukh ";
string b = "Kholmatov";
string name = string.Concat(a, b);
Console.WriteLine(name);*/

//String.Format && "$" - satr va obyektlar ustida bir vaqtning o’zida ishlash imkonini beradi
/*string name = "Petr";
int year = 45;
string str = String.Format("Hello {0}, {1}", name, year);
Console.WriteLine(str);
// str = "Hello Petr, 45"
int a = 5;
int b = 7;
string result = $"{a} + {b} = {a + b}";
Console.WriteLine(result);*/

//C# dasturlash tilida "+" (qo’shish) operatori orqali ham qo’shish ham birlashtirish mumkin.
/*int num1 = 5;
int num2 = 12;
int result = num1 + num2;
Console.WriteLine(result);

string str1 = "6";
string str2 = "9";
string result1 = str1 + str2;
Console.WriteLine(result1);*/

/*Console.WriteLine("Salom, yangi foydalanuvchi");
Console.WriteLine("iltimos ismingizni keriting:");
string name=Console.ReadLine();
Console.Write(name);
Console.WriteLine(", Juda yaxshi bizga ismingiz tanish!");
Console.Write("alik");*/

//butun sonlar short,int,long
//o'lchami size
// Console.WriteLine(sizeof(short));
// Console.WriteLine(sizeof(int));
// Console.WriteLine(sizeof(long));
// //range
// Console.WriteLine("short");
// Console.WriteLine(short.MinValue);
// Console.WriteLine(short.MaxValue);
// Console.WriteLine("int");
// Console.WriteLine(int.MinValue);
// Console.WriteLine(int.MaxValue);
// Console.WriteLine("long");
// Console.WriteLine(long.MinValue);
// Console.WriteLine(long.MaxValue);

//mashq
// string myname="Dilso'z";
// Console.WriteLine($"--salom, mening ismim {myname} sizning ismingiz nima?");
// Console.Write("--mening ismim ");
// string ism=Console.ReadLine();
// Console.WriteLine($"--{ism} tanishgaimdan xursandman, yoshingiz nechada?");
// Console.Write("--yoshim ");
// int yosh=int.Parse(Console.ReadLine());
// short kurs=2;
// Console.WriteLine($"--siz {kurs}-kurs bo'lsangiz kerak. ");
// Console.Write("-- ");
// string javob=Console.ReadLine();

//double, float, decimal
// float -6 -9
// double -15 -16
// decimal -26 -29 hisob kitobda ancha to'g'ri hisoblab beradi

// float width = 3.3f;
// double height=3.3;
// decimal length = 3.3m;

// double a=3.2;
// double b =0.2;
// double c = 3.4;
// Console.WriteLine(a+b==c);

//boolean turi
// bool isBoy=true;
// bool isGirl = false;
// Console.WriteLine(isGirl);

//ma'lumot turlarini boshqa ma'lumot turlariga o'tkazish
// int floraTypes = 3232;
// short smallFloraTypes = (short)floraTypes;
// Convert.ToInt32("23");
//int=> int32
//short=> int16
//long => int64

Console.Write("ismigizni keriting:- ");
string name = Console.ReadLine();
string greeting = $"Salom, {name}";
Console.WriteLine(greeting);
Console.Write("yoshingizni keriting:- ");
string ageAstring = Console.ReadLine();
Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAstring);
Console.WriteLine($"Succesfulliy converted! {age}");
// //FEATURE
int KESCHAage=2;
int yoshFarqi = age-KESCHAage;
Console.WriteLine($"yosh farqi: {yoshFarqi}");
if (age < KESCHAage)
{
    Console.WriteLine("sizning yoshingiz KESCHAning yoshidan kichik");
}
else if (age == KESCHAage)
{
    Console.WriteLine("sizning yoshiz KESCHAning yoshiga teng");
}
else 
{
    Console.WriteLine("sizning yoshingiz KESCHAning yoshidan katta");
}

