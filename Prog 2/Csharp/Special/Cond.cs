// Cond -- Parse tree node strategy for printing the special form cond

using System;

namespace Tree
{
    public class Cond : Special
    {
	public Cond() { }

        public override void print(Node t, int n, bool p)
        { 
            Printer.printCond(t, n, p);
        }

        public override Node eval(Node a, Environment e) 
        {
           Node condE = a.getCdr();

           while((!(condE.getCar()).getCar().eval(e).getBoolean()) && (!condE.isNull())) {
               condE = condE.getCdr();
           }
           if (condE.isNull()) {
               return new Nil();
           } else {
               return (condE.getCar().getCdr().getCar().eval(e));
           }
        }

    }
}


