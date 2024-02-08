/*
string name = "Aghanim";

int age = 10000;

System.Console.WriteLine($"Hello {name}! Your age is {age}");

System.Console.WriteLine(age + " ");

8 в 7 степени
double result = Math.Pow(8, 7);
System.Console.WriteLine(result);

 2 в 4 степени
int a = 487;
int y = a % 10;
int x = a / 10 % 10;
int score = 1;
int count = 0;
while (count < y)
    {
        score = score * x;
        count++;
    }
System.Console.WriteLine(score);
*/
До тех пор, пока...
int a = 487;
int y = a % 10;
int x = a / 10 % 10;
int score = 1;
for (int i =0; i < y; i++)
    {
        score *= x;
    }
System.Console.WriteLine(score);