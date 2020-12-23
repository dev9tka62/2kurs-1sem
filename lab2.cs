using System;

public class A{
    public int a;
    public int b;
    
    public A(int a, int b){
        this.a = a;
        this.b = b;
    }

    public int c{
        get{return a - b;}
    }
}

public class B: A{
    public int d;
    private int answ = 0;

    public B(int a, int b, int d) : base(a, b){
        this.d = d;
    }

    public int c2{
        set{
            for(int i=0; i<=10; i++){
                answ = a + b - d + i;
            }
        }
        get{return answ;}
    }
}

public class Program{
    static void Main(){
        B B_Obj = new B(3, 2, 5);
        B_Obj.c2 = B_Obj.c2; // activate the SET of the c2 property
        System.Console.WriteLine(B_Obj.c2);
    }
}
