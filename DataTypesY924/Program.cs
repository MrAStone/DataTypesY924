namespace DataTypesY924
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // datatype identifier (optional assignment)
            int myInteger;
            myInteger = 42;
            Console.WriteLine(myInteger);
            int anotherInteger = 25;
            Console.WriteLine(myInteger + anotherInteger);
            
            double myDouble = 7.1976;
            Console.WriteLine(myDouble);

            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            char myChar = '#';
            char anotherChar = 'A';
            Console.WriteLine(myChar);
            Console.WriteLine(anotherChar);
            Console.WriteLine(myChar+anotherChar); // adds the ASCII values together

            string myString = "This is a string";
            string anotherString = "and so is this";
            Console.WriteLine(myString);
            Console.WriteLine(anotherString);
            Console.WriteLine(myString+anotherString);//concatenate
            Console.WriteLine(myString+myChar); // Concatenates the string with the char

            const string bestTeacher = "Mr Naylor";
           

        }
     

    }
}
