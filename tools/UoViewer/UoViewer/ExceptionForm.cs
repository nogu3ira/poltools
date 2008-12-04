/***************************************************************************
 *
 * $Author: Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

using System;
using System.Windows.Forms;

namespace UoViewer
{
    public partial class ExceptionForm : Form
    {
        public ExceptionForm(Exception err)
        {
            InitializeComponent();

            richTextBox.Text = "";
            if (err.InnerException!=null)
                richTextBox.Text = err.InnerException.Message + "\n" + err.InnerException.GetType().ToString();
            richTextBox.Text = richTextBox.Text+"\n\n"+err.Message+"\n\n"+err.StackTrace;
        }

        private void onclick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}