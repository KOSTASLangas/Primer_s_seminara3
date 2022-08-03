// Напишите программу, 
//которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int stepen = 2;
double n = Math.Sqrt((Math.Pow(x2-x1, stepen)) + (Math.Pow(y2-y1, stepen)));
Console.WriteLine(n);
