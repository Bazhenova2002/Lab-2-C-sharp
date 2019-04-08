using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Kvadrat
{
    protected int storona;

    public Kvadrat()
    {
        storona = 0;
    }

    public Kvadrat(int st)
    {
        storona = st;
    }

    public int Storona
    {
        get { return storona; }
        set { storona = value; }
    }

    public virtual string Info()
    {
        return string.Format("Kvadrat");
    }

    public virtual int Area()
    {
        return storona * storona;
    }

    public virtual int Perimeter()
    {
        return 4 * storona;
    }

    public virtual double Diagonal()
    {
        return Math.Sqrt(2 * storona * storona);
    }
};

class Prizma : Kvadrat
{
    protected int visota;
    public Prizma()
        : base()
    {
        visota = 0;
    }

    public Prizma(int st, int vst)
        : base(st)
    {
        visota = vst;
    }
    public int Visota
    {
        get { return visota; }
        set { visota = value; }
    }

    public override string Info()
    {
        return string.Format("Prizma");
    }

    public override int Area()
    {
        return base.Area() * 2 + visota * storona * 4;
    }
    public override int Perimeter()
    {
        return base.Perimeter() * 2 + visota * 4;
    }
    public override double Diagonal()
    {
        return Math.Sqrt(base.Diagonal() * base.Diagonal() + visota * visota);
    }
    public double Objom()
    {
        return storona * storona * visota;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int storona;
        Console.WriteLine("Введите длину стороны :");
        storona = Convert.ToInt32(Console.ReadLine());
        Kvadrat kv1 = new Kvadrat(storona);

        Console.WriteLine(kv1.Info());
        Console.WriteLine("Area {0}", kv1.Area());
        Console.WriteLine("Perimeter {0}", kv1.Perimeter());
        Console.WriteLine("Diagonal {0}", kv1.Diagonal());
        Console.WriteLine();

        int visota;
        Console.WriteLine("Введите длину высоты :");
        visota = Convert.ToInt32(Console.ReadLine());

        Prizma pr1 = new Prizma(storona, visota);
        Console.WriteLine(pr1.Info());
        Console.WriteLine("Area {0}", pr1.Area());
        Console.WriteLine("Perimeter {0}", pr1.Perimeter());
        Console.WriteLine("Diagonal {0}", pr1.Diagonal());
        Console.WriteLine("Objom {0}", pr1.Objom());

        Console.ReadKey();
    }
}