namespace G_NET_33_OOP_5;

public class Program
{
    public static void Main(string[] args)
    {
        #region Theoretical Questions

        //Q1 : What is an interface in C#? Why do we use interfaces instead of depending on concrete classes directly? Mention at least three benefits of using interfaces.

        /*
        
        -- An interface in C# is a contract that defines a set of methods, properties, or events without providing their implementation. Any class that implements the interface must provide the implementation for all its members.


        -- Interfaces help make the code more flexible, maintainable, and loosely coupled. Instead of depending on a specific class, the code depends on a general contract.
        
        
        -- 1- Loose Coupling
           2- Multiple Implementations
           3- Better Testability
           4- Supports Dependency Injection
        */



        /*

                Q2 : Look at the following code and answer the questions below:

            interface IEnglishSpeaker
            {
            void Greet();
            }

            interface IArabicSpeaker
            {
            void Greet();
            }

            class Translator : IEnglishSpeaker, IArabicSpeaker
            {
            public void Greet()
            {
                Console.WriteLine("Hello / Ahlan");
            }
            }
            a) What is the problem with this design? Both interfaces have a method called Greet() — how does the class handle it currently?
            b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan"? What is this technique called?
            c) After applying your fix, can you call Greet() directly on a Translator object (e.g. translator.Greet())? Why or why not? How do you call each version?

            */


        /*

        -- The problem is that both interfaces IEnglishSpeaker and IArabicSpeaker contain a method with the same name Greet

        -- Currently, the Translator class implements one method only, so the same implementation will be used for both interfaces


        -- We can fix this by using Explicit Interface Implementation . This allows the class to provide separate implementations for each interface method.


        class Translator : IEnglishSpeaker, IArabicSpeaker
        {
        void IEnglishSpeaker.Greet()
        {
            Console.WriteLine("Hello");
        }

        void IArabicSpeaker.Greet()
        {
            Console.WriteLine("Ahlan");
        }
        }


        This technique is called Explicit Interface Implementation.



        -- No, you cannot call translator.Greet() directly.

    This is because explicit interface methods are only accessible through the interface reference, not the class itself.


        -- Translator translator = new Translator();

            ((IEnglishSpeaker)translator).Greet();
        ((IArabicSpeaker)translator).Greet();

        */






        #endregion
    }
}