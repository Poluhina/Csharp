using System;
using System.Threading;

    Console.WriteLine("Hello, Jerry");

    void PrintABC()
     {
         Console.WriteLine("A");
         Console.WriteLine("B");
         Console.WriteLine("C");
    }

    for (int i = 0; i < 3; i++)
    {
        PrintABC();
        Thread.Sleep(500); // задержка 0.5 сек
    }

    
    void B()
    {
        Console.WriteLine("Это функция B");
    }

    void C()
    {
        Console.WriteLine("Это функция C");
    }

    void A()
    {
        B();
        C();
    }

    A();
    A();


