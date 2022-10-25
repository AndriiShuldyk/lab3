using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

class A
{
    static void Main(string[] args)
    {
        C c = new C(1);
        D d = new D(2, 3);
        E e = new E(4, 5, 6);

        B b = new B();
        b.String(c);
        b.String(d);
        b.String(e);
    }
}


class B
{
    public void String(C c)
    {
        c.String();
    }
}


class C 
{
    public int FirstString { get; set; }
    public C(int firstString)
    {
        FirstString = firstString;
    }
    public virtual void String()
    {
        Console.WriteLine(FirstString);
    }

}

class D : C
{
    public int SecondString;
    public D(int firstString, int secondString) : base(firstString)
    {
        SecondString = secondString;
    }
    public override void String()
    {
        base.String();
        Console.WriteLine(SecondString);
    }
}

class E : C
{
    public int SecondString;
    public int ThirdString;
    public E(int firstString, int secondString, int thirdString) : base(firstString)
    {
        SecondString = secondString;
        ThirdString = thirdString;
    }
    public override void String()
    {
        base.String();
        Console.WriteLine(SecondString);
        Console.WriteLine(ThirdString);
    }
}