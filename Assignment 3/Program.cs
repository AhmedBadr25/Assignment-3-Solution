namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1
            //Write a program that allows the user to enter a number then print it.

            int Number;
            Console.WriteLine("Enter Number");
            Number = int.Parse(Console.ReadLine());
            Console.WriteLine(Number);
        



    #endregion

    #region Q2

    //Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen

    String Input = "123ABC";
    int Result =Convert.ToInt32(Input);





            #endregion

            #region Q3

            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            double num1 = 0.1;
            double num2 = 0.2;
            double sum= num1 + num2;
            Console.WriteLine($"Sum = {sum}"); //0.3

            #endregion

            #region Q4

            //Write C# program that Extract a substring from a given string.

            string String = "Hello World";
            string SubString = String.Substring(5);
            Console.WriteLine($"Substring = {SubString}");


            #endregion


            #region Q5

            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int X = 1;
            int Y = 2;

            X = Y; //X=2 //Y=2

            X = 5; //5

            Console.WriteLine($"X = {X}  Y = {Y}");


            #endregion


            #region Q6
            //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            int[] arr01 = { 1, 2, 3 };

            int[] arr02 = arr01;

            arr02[0] = 5;

            Console.WriteLine( $" Arr01 ={arr01[0]}  Arr02 ={arr02[0]}");

            #endregion


            #region Q7
            //Write C# program that take two string variables and print them as one variable 

            string str01 = "Hello";
            string str02 = "world";

            Console.WriteLine($"{str01} {str02}");




            #endregion


            #region Q8
            // 8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            double principal = 1000.0;
            double rate = 2.0;
            double time = 5.0;

            double interest = (principal * rate * time) / 100;
            Console.WriteLine($"interest = {interest}");



            #endregion

            #region Q9
            //9 - Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            double Weight = 70.0;
            double Height = 1.90;

            double BMI = (Weight) / (Height * Height);

            Console.WriteLine($"BMI = {BMI}");






            #endregion

            #region Q10
            // 10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in variable then display the result.Assume that below 10 degrees is "Too Cold", above 30 degrees is "Too Hot", and anything else is "Just Good".

            double Temp = 8.0;

            string Message = Temp < 10 ? "too cold" : Temp > 30 ? "Too Hot" : "Just Good";

            Console.WriteLine(Message);



            #endregion


            #region Q11
            //11 - Write a program that takes the date from user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001

            DateTime dateTime = DateTime.Now;

            string Fromate01 = $"{dateTime.Day} , {dateTime.Month} , {dateTime.Year}";
            string Fromate02 = $"{dateTime.Day} / {dateTime.Month} / {dateTime.Year}";
            string Fromate03 = $"{dateTime.Day} - {dateTime.Month} - {dateTime.Year}";

            Console.WriteLine(Fromate01);
            Console.WriteLine(Fromate02);
            Console.WriteLine(Fromate03);


            #endregion


            #region Q12
            // Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            int Number;
            bool flage;

            do {

               Console.WriteLine("Enter Number");
                flage = int.TryParse(Console.ReadLine(), out Number);


            }while (!flage);

            if(Number %3==0 && Number % 4 == 0)
            {
               Console.WriteLine("Yes");
            }
            else
               Console.WriteLine("No");


            #endregion

            #region Q13
            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            int Number;
            bool flage;

            do
            {

                Console.WriteLine("Enter Number");
               flage = int.TryParse(Console.ReadLine(), out Number);


            } while (!flage);

            if (Number < 0)
               Console.WriteLine("Negative");
            else if (Number > 0)
                Console.WriteLine("Positive");
            else
               Console.WriteLine("Zero");


            #endregion


            #region Q14
            // Write a program that takes 3 integers from the user then prints the max element and the min element.
            int Number1;
            bool flage1;

            do
            {

               Console.WriteLine("Enter Number1");
               flage1 = int.TryParse(Console.ReadLine(), out Number1);


            } while (!flage1);
            int Number2;
            bool flage2;

            do
            {

               Console.WriteLine("Enter Number2");
               flage2 = int.TryParse(Console.ReadLine(), out Number2);


            } while (!flage2);
            int Number3;
            bool flage3;

            do
            {

              Console.WriteLine("Enter Number3");
                flage3 = int.TryParse(Console.ReadLine(), out Number3);


            } while (!flage3);

            if (Number1 > Number2 && Number1 > Number3)
            {
               if (Number2 > Number3)
                   Console.WriteLine($"Max = {Number1} and Min ={Number3}");
               else
                    Console.WriteLine($"Max = {Number1} and Min ={Number2}");

            }
            else if (Number2 > Number1 && Number2 > Number3)
            {
               if (Number1 > Number3)
                   Console.WriteLine($"Max = {Number2} and Min ={Number3}");
                else
                    Console.WriteLine($"Max = {Number2} and Min ={Number1}");

            }
            else if (Number3 > Number1 && Number3 > Number2)
            {
               if (Number1 > Number2)
                   Console.WriteLine($"Max = {Number3} and Min ={Number2}");
                else
                    Console.WriteLine($"Max = {Number3} and Min ={Number1}");
            }
            else
                Console.WriteLine("Numbers are Equale");


            #endregion

            #region Q15
            //Write a program that allows the user to insert an integer number then check If a number is even or odd.

            int Number;
            bool flage;

            do
            {

               Console.WriteLine("Enter Number");
               flage = int.TryParse(Console.ReadLine(), out Number);


            } while (!flage);

            if (Number % 2 == 0)
               Console.WriteLine("Even");
            else
              Console.WriteLine("Odd");


            #endregion


            #region Q16
            // Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            char C;
            bool flage;

            do
            {
               Console.WriteLine("Enter Character");
               flage = char.TryParse(Console.ReadLine().ToLower(), out C);

            } while (!flage);

            switch (C)
            {
               case 'a':
               case 'e':
               case 'u':
               case 'i':
               case 'o':
                   Console.WriteLine("Vowel");
                   break;
               default:
                   Console.WriteLine("consonant");
                   break;


            }


            #endregion


            #region Q17
            //11- Write a program to input the month number and print the number of days in that month.

            int Month;
            bool flage;

            do
            {

                Console.WriteLine("Enter Month Number");
               flage = int.TryParse(Console.ReadLine(), out Month);


            } while (!flage);

            switch (Month)
            {
              case 1:
              case 3:
              case 5:
              case 7:
              case 8:
              case 10:
              case 12:
                  Console.WriteLine("Number of days in this month = 31");
                   break;

               case 2:
                   Console.WriteLine("Number of days in this month = 28");
                    break;
                default:
                Console.WriteLine("Number of days in this month = 30");
                break;

            }


            #endregion

            #region Q18
            //12- Write a program to create a Simple Calculator.

            int Number1;
            bool flage1;

            do
            {

                Console.WriteLine("Enter Number 01");
                flage1 = int.TryParse(Console.ReadLine(), out Number1);


            } while (!flage1);

             char OP;
            bool flage;

            do
            {

                Console.WriteLine("Enter Operator");
                flage = char.TryParse(Console.ReadLine(), out OP);


            } while (!flage);

            int Number2;
            bool flage2;

            do
            {

                Console.WriteLine("Enter Number 02");
                flage2 = int.TryParse(Console.ReadLine(), out Number2);


            } while (!flage2);

            switch (OP)
            {
                case '+':
                    Console.WriteLine($"{Number1} {OP} {Number2} = {Number1+Number2}");
                    break;

                case '-':
                    Console.WriteLine($"{Number1} {OP} {Number2}  = {Number1 - Number2}");
                    break;

                case '*':
                    Console.WriteLine($"{Number1} {OP} {Number2} = {Number1 * Number2}");
                    break;

                case '/':
                    Console.WriteLine($"{Number1} {OP} {Number2} = {Number1 / Number2}"); break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }


            #endregion

            #region Q19
            // Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            int Number;
            bool flage;

            do
            {

                Console.WriteLine("Enter Number");
                flage = int.TryParse(Console.ReadLine(), out Number);


            } while (!flage);

            for (int i= 1; i <= Number; i++)
                Console.WriteLine(i);


            #endregion


            #region Q20
            // Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            int Number;
            bool flage;

            do
            {

                Console.WriteLine("Enter Number");
               flage = int.TryParse(Console.ReadLine(), out Number);


            } while (!flage);

            for (int i = 0; i <=12; i++)
               Console.WriteLine($"{i} * {Number} = {i*Number}");


            #endregion


            #region Q21
            // Write a program that allows to user to insert number then print all even numbers between 1 to this number
            int Number;
            bool flage;

            do
            {

                Console.WriteLine("Enter Number");
               flage = int.TryParse(Console.ReadLine(), out Number);


            } while (!flage);
            if (Number > 0)
            {
                for (int i = 1; i <= Number; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);

                }
            }
            else if (Number < 0)
            {
                for (int i = Number; i <= 1; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);

                }


            }



            #endregion

            #region Q22
            // Write a program that takes two integers then prints the power.

            int Base;
            bool flage1;

             do
             {

                 Console.WriteLine("Enter Number Base");
                 flage1 = int.TryParse(Console.ReadLine(), out Base);


             } while (!flage1);
             int Power;
             bool flage2;
             double Result=1;
             do
             {

                 Console.WriteLine("Enter Number Power");
                 flage2 = int.TryParse(Console.ReadLine(), out Power);


             } while (!flage2);

             if (Power > 0)
             {
                 for (int i = 0; i < Power; i++)
                {
                    Result *= Base;
                }
                Console.WriteLine($"{Base} ^ {Power} = {Result}");

             }
            else  if(Power < 0)
             {
                 for(int i = Power; i<0; i++)
                 {
                     Result *= Base;
                 }
                 Console.WriteLine($"{Base} ^ {Power} = {1/Result}");

            }
             else
                 Console.WriteLine($"{Base} ^ {Power} = 1");


            #endregion

            #region Q23
            // Write a program to allow the user to enter a string and print the REVERSE of it.

            //Hello -->olleH


            string word;
            Console.WriteLine("Enter A string");
            word = Console.ReadLine();

            for(int i = word.Length-1 ; i>=0 ; i--)
            {
                Console.Write(word[i]); 
            }


            #endregion
           
            
            #region Q24
            // Write a program in C# Sharp to find prime numbers within a range of numbers.
              // Test Data:
            //                 Input starting number of range: 1
            //     Input ending number of range: 50
            //     Expected Output :
            //     The prime number between 1 and 50 are:
            //                 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47


            int Start;
            bool flage;


            do
            {

                Console.WriteLine("Enter Number");
                flage = int.TryParse(Console.ReadLine(), out Start);


            } while (!flage);

            int End;
            bool flage02;


            do
            {

               Console.WriteLine("Enter Number");
               flage02 = int.TryParse(Console.ReadLine(), out End);


            } while (!flage02);



            for (int i = Start; i <= End; i++)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }


                }
                if (count == 0 & i !=1)
                    Console.WriteLine(i);

            }






            #endregion



            #region Q25
            //.Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //      Test Data:
            //                  Enter a number to convert: 25
            //      Expected Output :
            //      The Binary of 25 is 11001.

            //8/2=0
            //4/2=0
            //2/2=0
            //1/2=1

            int Number;
            bool flage;

            string Result = " ";

            do
            {

                Console.WriteLine("Enter Number");
                flage = int.TryParse(Console.ReadLine(), out Number);


            } while (!flage);


            for (int i = 0; Number > 0; i++)
            {                 //1     +000
                Result = (Number % 2) + Result; // 1000
                Number /= 2;

            }
            Console.WriteLine(Result);


            #endregion

            #region Q26
            //Write a program in C# Sharp to find the sum of all elements of the array.
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("The sum of the array elements is: " + sum);

            #endregion
        }
    }
}





