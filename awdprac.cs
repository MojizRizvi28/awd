// 1.a Create an application to print on screen the output of adding, subtracting, multiplying and
dividing two numbers entered by the user in C#.

using System;
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter Values for Number1 and Number2:");
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                int sum = number1 + number2;
                Console.WriteLine("The sum is: " + sum);
                int subtraction = number1 - number2;
                Console.WriteLine("The subtraction is: " + subtraction);
                int multiplication = number1 * number2;
                Console.WriteLine("The multiplication is: " + multiplication);
                int division = number1 / number2;
                Console.WriteLine("The division is: " + division);
                int modulus = number1 % number2;
                Console.WriteLine("The modulus is: " + modulus);
                Console.ReadKey();
            }
        }


// 1.b Create an application to print Floyd’s triangle till n rows in C#.

  
  using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter the number of rows:");
        int n=int.Parse(Console.ReadLine());
        int i, j, k = 1;
        for(i=1;i<=n;i++)
        {
            for(j=1;j<i+1;j++)
            {
                Console.Write(k++ + " ");

            }
            Console.Write("\n");
        }
        Console.ReadLine();
    }
        }

    
  // 1.c Create an application to demonstrate following operations i. Generate Fibonacci series. ii. Test for prime numbers.

using System;

class Program
{
    public static void fibonacci()
    {
        Console.WriteLine("Enter the number of terms for Fibonacci series:");
        int n = Convert.ToInt32(Console.ReadLine());
        int t1 = 0, t2 = 1, t3;
        Console.Write(t1 + " " + t2 + " ");
        for (int i = 2; i < n; ++i)
        {
            t3 = t1 + t2;
            Console.Write(t3 + " ");
            t1 = t2;
            t2 = t3;
        }
    }
    public static void prime()
    {
        Console.WriteLine("Enter a number to check if it's prime:");
        int num = Convert.ToInt32(Console.ReadLine());
        int a=0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                a++;
            }
        }
        if (a == 2)
        {
            Console.WriteLine(num + " is a prime number.");
        }
        else
        {
            Console.WriteLine(num + " is not a prime number.");
        }
    }
    public static void Main(string[] args)
    {
        int choice;
        Console.WriteLine("Choose an option:\n1. Fibonacci Series\n2. Prime Number Check");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                fibonacci();
                break;
            case 2:
                prime();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}


// 2.a Create a simple application to demonstrate the concepts boxing and unboxing.

using System;

class Program
{
    static void Main()
    {
        int num = 50;
        object boxedNum = num;
        Console.WriteLine("Boxed Value: " + boxedNum);

        
        object obj = 100;
        int unboxedNum = (int)obj;
        Console.WriteLine("Unboxed Value: " + unboxedNum);
    }
}


// 2.b Create a simple application to perform addition and subtraction using delegate.

using System;

class Program
{
    public delegate int MathOperation(int a, int b);

    
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        MathOperation addDelegate = new MathOperation(Add);
        MathOperation subDelegate = new MathOperation(Subtract);

        int num1 = 20, num2 = 10;

        Console.WriteLine("Addition using Delegate: " + addDelegate(num1, num2));
        Console.WriteLine("Subtraction using Delegate: " + subDelegate(num1, num2));
    }
}


//2.c  Create a simple application to demonstrate use of the concepts of interfaces.

using System;
interface operations
{
    void add();
    void sub();

}
class A : operations
{
    public void add()
    {
        int n1=10, n2=20;
        int sum=n1+n2;
        Console.WriteLine("ADDITION IS :"+sum);
    }
    public void sub()
    {
        int n1=20, n2=10;
        int sub=n1-n2;
        Console.WriteLine("SUBTRACTION IS :"+sub);
    }

    static void Main()
    {
        A o1 = new A();
        o1.add();
        o1.sub();
    }
}


// 3.a Create a simple web page with various server controls to demonstrate setting and use of their properties. (Example : AutoPostBack)
//WebForm1.aspx
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Name: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Select Color: "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Click Me" OnClick="Button1_Click" />
            <br /><br />
            <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

//WebForm1.aspx.cs
using System;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            LabelResult.Text = "Hello, " + TextBox1.Text;

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelResult.Text = "You selected color: " + DropDownList1.SelectedItem.Text;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LabelResult.Text = "Button was clicked!";

        }
    }
}

// 4.b ADROTATOR

<Advertisements>
  <Ad>
    <ImageUrl>~/Images/travel.jpg</ImageUrl>
    <NavigateUrl>https://www.travel.com</NavigateUrl>
    <AlternateText>Plan Your Trip!</AlternateText>
    <Impressions>50</Impressions>
  </Ad>

  <Ad>
    <ImageUrl>~/Images/food.jpg</ImageUrl>
    <NavigateUrl>https://www.foodie.com</NavigateUrl>
    <AlternateText>Best Food Deals</AlternateText>
    <Impressions>50</Impressions>
  </Ad>

  <Ad>
    <ImageUrl>~/Images/shopping.jpg</ImageUrl>
    <NavigateUrl>https://www.shopping.com</NavigateUrl>
    <AlternateText>Exciting Shopping Offers</AlternateText>
    <Impressions>50</Impressions>
  </Ad>
</Advertisements>


