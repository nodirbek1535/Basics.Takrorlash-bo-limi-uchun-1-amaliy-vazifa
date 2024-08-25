// Basics.Takrorlash bo’limi uchun 1-amaliy vazifa
// 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga chiqaradigan dastur tuzing. While loop dan foydalaning!
using System.Collections;
using System.Data;
using System.Diagnostics;

Console.WriteLine("Siz 1-dasturdasiz!");
Console.WriteLine("nechigacha bolgan sonlar yigindisi kerak");
int num=int.Parse(Console.ReadLine());
Console.WriteLine("qanday yigindi kerak toq,juft yoki umumiy");
string s=Console.ReadLine();
// s=s.ToLower();
switch(s)
{
    case "juft":
    int i=0;
    int sum=0;
    while(i<=num)
    {
        sum=sum+i;
        i+=2;
       
    } 
    Console.WriteLine(num+" gacha bo'lgan juft sonlar yig'indisi="+sum);
    break;
    case "toq":
    int it=1;
    int sumt=0;
    while(it<=num)
    {
        sumt=sumt+it;
        it+=2;
       
    } 
    Console.WriteLine(num+" gacha bo'lgan toq sonlar yig'indisi="+sumt);
    break;
    case "umumiy":
    int iu=0;
    int sumu=0;
    while(iu<=num)
    {
        sumu=sumu+iu;
        iu++;
       
    } 
    Console.WriteLine(num+" gacha bo'lgan barcha  sonlar yig'indisi="+sumu);
    break;
}
Console.WriteLine("1-dastur yakunlanni");
//Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini ekranga chiqaradigan dastur tuzing. For loop dan foydalaning!
Console.WriteLine("Siz 2-dasturdasiz:");
Console.WriteLine("array elemenntlar sonini kiriting:");
int lengthy=int.Parse(Console.ReadLine());
int[] arr=new int[lengthy];
for(int i=0;i<arr.Length;i++)
{
    Console.WriteLine((i+1)+"-elementni kiriting:");
    arr[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("max*min="+(arr.Max()*arr.Min()));
Console.WriteLine("2-dastur yakunlandi!");
// Consolga int tipidagi butun son kiritilgan => int x
// x! (x factorial) ni hisoblaydigan dastur tuzing.
Console.WriteLine("Siz 3-dasturdasiz!");
Console.WriteLine("x=");
int x=int.Parse(Console.ReadLine());
int summa=1;
for(int i=1;i<=x;i++)
{
    summa*=i;
}
Console.WriteLine(x+"dastur yakunlanndi");