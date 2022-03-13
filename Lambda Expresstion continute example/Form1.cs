using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda_Expresstion_continute_example
{
      // ####################################################################################################################
      // #                                 
      // # In most of the cases Lambda expressions supersedes anonymous methods. To my knowledge, the only time I prefer to use
      // # anonymous methods over lambdas is, When whe have to omit the parameter list when it's not used within the body.  
      // #     
      // # Anonymous methods allow the parameter list to be omitted entirely when it's not used within the body, where as  
      // # whith lambda expressions this is not the case  
      // #      
      // # For example, with anonymous method notice that we have omitted the parameter list as we are not using them within the body  
      // #
      // #   Button1.Click += delegate {  MessageBox.Show ( "Button Clicked ")};
      // #   
      // # The above code can be rewritten using lambda expression as shown below. Notice that with lambda we cannot omit the parameter list
      // #   
      // #   Button1.Click += (eventSender, eventAgrs) => { MessageBox.Show (" Button clicked")};
      // #
      // ####################################################################################################################

      public partial class Form1: Form
      {
            public Form1()
            {
                  InitializeComponent();
            }
            
            private void Form1_Load(object sender, EventArgs e)
            {
                  Button bt  = new Button();
                  bt.Text = "Click me";


                  //bt.Click += delegate { 
                  //      MessageBox.Show(" you just clicked me");
                  //};


                  bt.Click += (sender1, e1) => {
                    MessageBox.Show(" you just clicked me");
                  };
                  this.Controls.Add(bt);
            }
      }
}
