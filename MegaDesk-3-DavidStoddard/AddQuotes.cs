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

    private void widthVal_Validating(object sender, CancelEventArgs e)
    {
      string errorMsg;
      if (!ValidSize(widthVal.Text, 24, 96, out errorMsg))
      {
        // Cancel the event and select the text to be corrected by the user.
        e.Cancel = true;
        widthVal.Select(0, widthVal.Text.Length);

        // Set the ErrorProvider error with the text to display. 
        this.widthErrorProvider.SetError(widthVal, errorMsg);
      }
    }

    private void widthVal_Validated(object sender, EventArgs e)
    {
      // If all conditions have been met, clear the ErrorProvider of errors.
      widthErrorProvider.SetError(widthVal, "");
    }

    public bool ValidSize(string numberValue, int min, int max, out string errorMessage)
    {
      // Confirm that the email address string is not empty.
      if (numberValue == null )
      {
        errorMessage = "A number is required.";
        return false;
      }

      int validValue;

      if (Int32.TryParse(numberValue, out validValue))
      {
        if (validValue < min)
        {
          errorMessage = "The number must at least be " + min + ".";
          return false;
        } else if (validValue > max) {
          errorMessage = "The number must at most be " + max + ".";
          return false;
        } else {
          errorMessage = "";
          return true;
        }
      } else
      {
        errorMessage = "An integer is required.";
        return false;
      }
    }

  }
}
