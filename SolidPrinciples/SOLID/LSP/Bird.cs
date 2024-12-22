using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolidPrinciples.SOLID.LSP;

namespace SolidPrinciples.SOLID.LSP
{
    public class Bird
    {
        public virtual void Eat(){
            Console.WriteLine("Eating ...");
        }
        public virtual void Fly(){
            Console.WriteLine("Flying ...");
        }
    }
}
public class Eagle : Bird{
    public override void Eat(){
        Console.WriteLine("Eagle Eating ...");
    }
    public override void Fly(){
        Console.WriteLine("Eagle Flying ...");
    }
}
public class Ostrich : Bird{
    public override void Eat(){
        Console.WriteLine("Ostrich Eating ...");
    }
    public  override void Fly(){
        throw new NotSupportedException("Ostriches Can't fly");
    }
}