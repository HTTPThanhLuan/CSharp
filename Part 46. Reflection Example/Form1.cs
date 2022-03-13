using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reflection;

namespace Part_46.Reflection_Example
{
      public partial class Form1: Form
      {
            public Form1()
            {
                  InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                  Type T = Type.GetType(textBox1.Text);

                 // Type T=typeof(Customer);

                  //Customer cs=new Customer();
                  //Type T=cs.GetType();

                  Console.WriteLine("Full name = {0}", T.FullName);
                  Console.WriteLine("Just the Name = {0}", T.Name);
                  Console.WriteLine("Just the Namespace = {0}", T.Namespace);
                  Console.WriteLine();
                  Console.WriteLine("Properties in Customer");
                  PropertyInfo[] properties = T.GetProperties();
                  foreach(PropertyInfo property in properties)
                  {
                       listBox1.Items.Add(property.PropertyType.Name + " " + property.Name);
                  }
                  Console.WriteLine();
                  Console.WriteLine("Method in Customer");
                  MethodInfo[] methods = T.GetMethods();
                  foreach(MethodInfo method in methods)
                  {
                        listBox2.Items.Add(method.ReturnType.Name + " " + method.Name);
                  }
                  Console.WriteLine();
                  Console.WriteLine("Constructor in Customer");
                  ConstructorInfo[] constructors = T.GetConstructors();
                  foreach(ConstructorInfo constructor in constructors)
                  {
                        listBox3.Items.Add(constructor.ToString());
                  }
            }
      }
}
