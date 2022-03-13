using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anonymous_Method_For_Event_Handler
{
      // ####################################################################################################################
      // #                               
      // #
      // #   With anonymous Methods delegate parameters are optional. This means the below code
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
                  Button bt=new Button();
                  bt.Text= "Click Me";
                  //bt.Click +=new EventHandler(bt_Click);
                  //bt.Click+= delegate(object send, EventArgs eg)
                  //{
                  //      MessageBox.Show("  Hello, you just clicked me using anonymous method");
                  //};

                  // anonymous methods delegate parameters are optional
                  bt.Click+= delegate
                  {
                        MessageBox.Show("  Hello, you just clicked me using anonymous method");
                  };


                  this.Controls.Add(bt);
            }

            //void bt_Click(object sender, EventArgs e)
            //{
            //      MessageBox.Show(" Hello, you just clicked me");
            //}
      }
}
