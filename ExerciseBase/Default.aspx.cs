using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace ExerciseBase
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ///a. numbers 1-10
                ///
                //for(int x = 1; x<=10; x++){
                //    this.lblCounting.Text += x.ToString() + ", " ;
                //}            

                ///b. numbers 1-10 (1 number per line)
                ///
                //for (int x = 1; x <= 10; x++)
                //{
                //    this.lblCounting.Text += x.ToString() + "<br/> ";
                //}

                ///c. List of Six Names
                ///
                List<string> oNames = new List<string>();
                oNames.Add("Roland");
                oNames.Add("FLOR");
                oNames.Add("Froiland");
                oNames.Add("EUNICE LOIS");
                oNames.Add("LEKCHEM");
                oNames.Add("Thereedzo");
                
                //c.ii. Lists only UPPERCASE Names
                //c.iii. x number of records found...
                int x = 0;

                foreach(string sName in oNames)
                {
                    if (sName.ToUpper() == sName)
                    {
                        this.lblList.Text += sName + ", ";
                        x++;
                    }                    
                }

                this.lblList.Text += " <br/> (" + x.ToString() + ") records found...";

                //d. List of Five Numbers
                List<int> oNumbers = new List<int>();
                oNumbers.Add(2150);
                oNumbers.Add(34698);
                oNumbers.Add(101);
                oNumbers.Add(5);
                oNumbers.Add(12);

                int sum = 0;

                foreach (int iNumbers in oNumbers)
                {
                    this.lblCounting.Text += iNumbers.ToString() + "XYZ <br/>" ;

                    sum += iNumbers;
                }

                this.lblCounting.Text += "============= <br/>" + sum.ToString() ;

            }
            catch (Exception ex)
            {
                this.lblList.Text = ex.Message;
            }
        }
    }
}