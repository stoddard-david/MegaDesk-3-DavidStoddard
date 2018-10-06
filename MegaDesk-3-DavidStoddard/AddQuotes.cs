using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_DavidStoddard
{
  public partial class AddQuotes : Form
  {
    private bool CancelPress = false;

    public AddQuotes()
    {
      InitializeComponent();
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
      var MainMenu = (MainMenu)Tag;
      MainMenu.Show();
      CancelPress = true;
      Close();
    }

    private void SubFormClosing(object sender, FormClosedEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && !CancelPress)
      {
        Environment.Exit(1);
      }
    }

    private void value_Enter(object sender, EventArgs e)
    {
      //Select the whole answer in the NumbericUpDown control
      NumericUpDown valueBox = sender as NumericUpDown;

      if (valueBox != null)
      {
        int lengthOfAnswer = valueBox.Value.ToString().Length;
        valueBox.Select(0, lengthOfAnswer);
      }
    }
  }
}
