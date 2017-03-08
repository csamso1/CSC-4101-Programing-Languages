/**
 * this is a java program to test CSC 4101 HW 3 Q3
 */
package csc4101hw3;

public class CSC4101HW3
{
    public static void main(String[] args) 
    {
        class C {
            public int foo(C p) { return 1; }
        }
        class D extends C {
            public int foo(C p) { return 2; }
            public int foo(D p) { return 3; }
        }
        C p = new C();
        C q = new D();
        D r = new D();
        int i = p.foo(r);
        int j = q.foo(q);
        int k = q.foo(r);
        System.out.printf("i = %d%n", i);
        System.out.printf("j = %d%n", j);
        System.out.printf("k = %d%n", k);
    }
}