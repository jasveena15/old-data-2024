using static System.Convert;
using static SplashKitSDK.SplashKit;
string l1, l2, o, fst, snd, yesorno;
//l1,l2 for receiving length from user. 
//o,fst,snd for switch cases.
//yesorno for receiving the  "Y" or"N" from the user
double mlength1, mlength2, rf, rm;
//mlength1, mlength2 for storing converted length in double
//rf, rm result in feet and meter.

WriteLine("Welcome to the Advanced Unit Converter and Calculator!");
do//do while loop
{
    Write("For your first input, would you like Feet (F) or Meters (M)? ");
    fst = ReadLine();
    while (fst != "F" && fst != "M")
    {
        WriteLine("Invalid choice. Please choose either F or M.");
        fst = ReadLine();
    }

    switch (fst)//switch case
    {
        case "F":
            Write("Enter the length in feet: ");
            l1 = ReadLine();
            while (!IsDouble(l1))
            {
                Write("please enter a valid number");
                l1 = ReadLine();
            }
            mlength1 = ToDouble(l1) * 0.3048;
            break;
        case "M":
            Write("Enter the length in meters: ");
            l1 = ReadLine();
            while (!IsDouble(l1))
            {
                Write("please enter a valid number");
                l1 = ReadLine();
            }
            mlength1 = ToDouble(l1);
            break;
        default:
            WriteLine("Invalid choice. Please choose either F or M.");
            continue;
    }

    Write("For your second input, would you like Feet (F) or Meters (M)? ");
    snd = ReadLine();
    while (snd != "F" && snd != "M")
    {
        WriteLine("Invalid choice. Please choose either F or M.");
        snd = ReadLine();
    }

    switch (snd)
    {
        case "F":
            Write("Enter the length in feet: ");
            l2 = ReadLine();
            while (!IsDouble(l2))
            {
                Write("please enter a valid number");
                l2 = ReadLine();
            }
            mlength2 = ToDouble(l2) * 0.3048;
            break;
        case "M":
            Write("Enter the length in meters: ");
            l2 = ReadLine();
            while (!IsDouble(l2))
            {
                Write("please enter a valid number");
                l2 = ReadLine();
            }
            mlength2 = ToDouble(l2);
            break;
        default:
            continue;
    }

    Write("What operation would you like to perform? (Multiply (M), Divide (D), Add (A), Subtract (S))? ");//operation performing
    o = ReadLine();
    while (o != "M" && o != "D" && o != "A" && o != "S")
    {
        WriteLine("Invalid choice. Please choose either M or D or A or S.");
        o = ReadLine(); 
    }

    switch (o)
    {
        case "M":
            rm = mlength1 * mlength2;
            rf = rm * 10.764; 
            WriteLine($"The result is: {rm} square meters and {rf} square feet");
            break;
        case "D":
            if(mlength2==0)
             {WriteLine("division by 0 is not possible");
             }
            else
             {  
             rm = mlength1 / mlength2;
             rf = rm * 3.2808; 
             WriteLine($"The result is: {rm} meters and {rf} feet");
             }
            break; 
        case "A":
            rm = mlength1 + mlength2;
            rf = rm * 3.2808; 
            WriteLine($"The result is: {rm} meters and {rf} feet");
            break;
        case "S":
            rm = mlength1 - mlength2;
            rf = rm * 3.2808; 
            WriteLine($"The result is: {rm} meters and {rf} feet");
            break;
        default:
            break;
    }

    Write("Would you like to perform another calculation? (Y/N): ");
    yesorno = ReadLine();
    fst = yesorno;
}
while (fst == "Y");
