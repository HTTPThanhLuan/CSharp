using System;
using System.Collections.Generic;

// ############################################################################################################################################################
// #                                MULTICAST DELEGATES
// #
// # A Multicast delegate is a delegate that has references to more than one function. When you invoke a multicast delegate,
// # all the functions the delegate is pointing to, are invoked
// #   
// #  THERE ARE 2 APPROACHES TO CREATE A MULTICAST DELEGATE. DEPENDING ON THE APPROACH YOU USE.    
// #  1. + or += to register a method with the delegate
// #  2. - or -= to un-register a method with the delegate
// #      
// #   NOTE: A multicast delegate. invokes the methods in the invocation list, in the same order in which they are added
// #  
// #  3. If the delegate has a return type other than void and if the delegate is a multicast delegate, only the value of the 
// #     last invoked method will be returned. Along the same lines. if the delegate has an out parameter, the value of the
// #     output parameter, will be the value assigned by the last method.   
// #   
// #   Common interview question - Where do you use multicast delegate?
// #   Multicast delegate makes implementation of observer design pattern very simple. Observer pattem is also called as publish/ subscribe pattern
// #
// ############################################################################################################################################################

public delegate void sampleDelegateOne();
public delegate int sampleDelegateTwo();
public delegate void sampleDelegateThree(out int interger);
class Program
{
      //###############################################################################################
      //#                                   Delegate not return value
      //static void Main(string[] args)
      //{
      //      //sampleDelegateOne sam1, sam2, sam3, sam4;
      //      //sam1 = new sampleDelegate(sampleMethodOne);
      //      //sam2 = new sampleDelegate(sampleMethodTwo);
      //      //sam3 = new sampleDelegate(sampleMethodThree);
      //      //sam4 =sam1+sam2+sam3-sam2;
      //      //sam4();

      //      //sampleDelegateOne sam = new sampleDelegateOne(sampleMethodOne);
      //      //sam+=sampleMethodTwo;
      //      //sam+=sampleMethodThree;
      //      //sam-=sampleMethodOne;
      //      //sam();
      //}
      //public static void sampleMethodOne()
      //{
      //      Console.WriteLine("Method One");
      //}
      //public static void sampleMethodTwo()
      //{
      //      Console.WriteLine("Method Two");
      //}
      //public static void sampleMethodThree()
      //{
      //      Console.WriteLine("Method Three");
      //}

      //###############################################################################################
      //#                                 Delegate return value
      //#
      //static void Main(string[] args)
      //{
      //      sampleDelegateTwo sam = new sampleDelegateTwo(sampleMethodOne);
      //      sam += sampleMethodTwo;
      //      int result = sam(); // the value of last invoked method will be returned = 2
      //      Console.WriteLine(result);
      //}
      //public static int sampleMethodOne()
      //{
      //      return 1;
      //}
      //public static int sampleMethodTwo()
      //{
      //      return 2;
      //}
      //###############################################################################################
      //#                                 delegate has an out parameter
      //#
      static void Main(string[] args)
      {
            sampleDelegateThree sam = new sampleDelegateThree(sampleMethodOne);
            sam += sampleMethodTwo;
            int intergerOutPut=-1;
            sam(out intergerOutPut); // the value of the output parametter will be the value assigned by last method
            Console.WriteLine(intergerOutPut);
      }
      public static void sampleMethodOne(out int interger)
      {
            interger= 1;
      }
      public static void sampleMethodTwo(out int interger)
      {
            interger= 7;
      }

}
