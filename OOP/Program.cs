// See https://aka.ms/new-console-template for more information

using OOP;

IClass1 class1 = new Class1();
Class2 class2 = new(class1);
s ss = new s();
class2.print2(ss.x.ToString());


struct s
{
    public int x;
    public s()
    {
        x = 1;
    }
    public int y(int s)
    {
        return s;
    }
}


