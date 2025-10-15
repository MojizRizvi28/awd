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

// 6 A, 8 A
//aspx


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prac6aand8a.aspx.cs" Inherits="prac6.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 411px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Enter name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <div>

        </div>
        <asp:Label ID="Label2" runat="server" Text="Enter rollno"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="INSERT" />
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Enter rno to delete record"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="DELETE" />
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

// cs file

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=kada;Integrated Security=True;Pooling=False;Encrypt=False;");

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = TextBox1.Text;
                int n = Convert.ToInt32(TextBox2.Text);
                SqlCommand cmd = new SqlCommand("insert into dbo.Table_1 values(@s,@n)", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@s", s);
                cmd.Parameters.AddWithValue("@n", n);
                con.Open();
                cmd.ExecuteNonQuery();
                Label3.Text = "Data Inserted Successfully";
                Label3.ForeColor = System.Drawing.Color.Green;
            }
            catch(Exception ex)
            {
                Label3.Text = "ERROR:" + ex.Message;
                Label3.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n2 = Convert.ToInt32(TextBox3.Text);
                SqlCommand cmd = new SqlCommand("delete from dbo.Table_1 where id=@n2", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@n2", n2);
                con.Open();
                cmd.ExecuteNonQuery();
                Label5.Text = "Data Deleted Successfully";
                Label5.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            { 
                Label5.Text = "Error Deleting Data:"+ex.Message;
                Label5.ForeColor = System.Drawing.Color.Red;
            }
        }

        }
    }


// 8 b 
//aspx
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prac8b.aspx.cs" Inherits="prac6.WebForm4" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Defined Exception Demo</title>
    <style>
        body { font-family: Arial; margin: 30px; }
        input, button { margin: 5px; padding: 5px; }
        h2 { color: #2a4d69; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Enter Your Age</h2>
        Age: <asp:TextBox ID="txtAge" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br /><br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>

// cs file

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserDefinedExceptionDemo;

namespace prac6
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(txtAge.Text);

                // Throw custom exception if age < 18
                if (age < 18)
                    throw new InvalidAgeException("Age must be 18 or above to proceed.");

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Age accepted: " + age;
            }
            catch (InvalidAgeException ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Custom Exception: " + ex.Message;
            }
            catch (FormatException)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please enter a valid numeric age.";
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Error: " + ex.Message;

            }
        }
    }
}

// class1.cs

using System;

namespace UserDefinedExceptionDemo
{
    // Custom exception for invalid age
    public class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException() : base() { }

        public InvalidAgeException(string message) : base(message) { }
    }
}




// 10 B AJAX
//aspx
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="prac6.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            !-- Enables AJAX -->
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <!-- Only this section will refresh -->
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update Time (AJAX)" OnClick="btnUpdate_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>

//cs file

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac6
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblTime.Text = "Updated Time (AJAX): " + DateTime.Now.ToString();

        }
    }
}

//10 A BOOTSTRAP

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="prac6.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" /> 
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>BOOTSTRAP DEMO</h2>
            <input type="button" id="mb" class="btn btn-primary" value="clcik me" />
            <p id="message" class="mt-3"</p>
            <script>
                document.getElementById("mb").addEventListener("Click",function(){
                    document.getElementById("message").textContent= "Button clicked! Hello, Bootstrap!";
                })
            </script>
        </div>
    </form>
</body>
</html>


//9 B 
//aspx
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prac9b.aspx.cs" Inherits="prac6.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView ID="FormView1" runat="server" DataKeyNames="rno" >
                <ItemTemplate>
                    stu_name:<%# Eval("stu_name") %><br /><br />rno:<%# Eval("rno") %>
                </ItemTemplate>
                
            </asp:FormView>

            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="FORMVIEW" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AllowPaging="True" OnPageIndexChanging="DetailsView1_PageIndexChanging">
            </asp:DetailsView>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="DETAILSVIEW" />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />

        </div>
    </form>
</body>
</html>

// cs file

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac6
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=mojiz\\sqlexpress;Initial Catalog=mojiz;Integrated Security=True;Pooling=False;Encrypt=False;");

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM table2", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                FormView1.DataSource = dt;
                FormView1.DataBind();
                Label1.Text = "Data Retrieved Successfully";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                Label1.Text = "Error: " + ex.Message;
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from dbo.table2", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                DetailsView1.DataSource = dt;
                DetailsView1.DataBind();
                Label2.Text = "Data Retrieved Successfully";
                Label2.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                Label2.Text = "Error: " + ex.Message;
                Label2.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            DetailsView1.PageIndex = e.NewPageIndex;
            
        }
    }
}

// 6 B 
//aspx

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prac6b.aspx.cs" Inherits="prac6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>

//cs file

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=kada;Integrated Security=True;Pooling=False;Encrypt=False;");
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from dbo.Table_1", con);
                SqlDataAdapter ad=new SqlDataAdapter(cmd);
                DataTable dt=new DataTable();
                ad.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Label1.Text = "Data Retrieved Successfully";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                Label1.Text = "Error: " + ex.Message;
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}

//9 A
//aspx

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prac9a.aspx.cs" Inherits="prac6.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mojizConnectionString %>"
                SelectCommand="SELECT * FROM [table2]"
                UpdateCommand="update table2 set stu_name=@stu_name where rno=@rno"
                 DeleteCommand="delete from table2 where rno=@rno"
                 InsertCommand=""></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" 
                AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" 
                DataSourceID="SqlDataSource1" EnablePersistedSelection="True" 
                EnableSortingAndPagingCallbacks="True" AllowPaging="True" 
                DataKeyNames="rno" PageSize="5" >
            </asp:GridView>
        </div>
    </form>
</body>
</html>
