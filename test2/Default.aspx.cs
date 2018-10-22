using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


public partial class _Default : System.Web.UI.Page
{
    static Random rnd = new Random();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public class random
    {
        int n = rnd.Next(1,45);
      
        //string n = "test";
        public int getRan()
        {
            return n;
        }
    }


        //protected void btnGo_Click(object sender, EventArgs e)
        //{
            
        //    //lblMessage.Text = txtDate.Text;
        //}
    protected void btnLottoNumbers_Click(object sender, EventArgs e)
    {
        string newRn = "";
        for (int i = 0; i <= 6; i++)
        {
            random newNum = new random();
            int rn = newNum.getRan();
            newRn = rn.ToString() + "-" + newRn ;
            
            
        }
        lblMessage.Text = newRn;
        
            //random newNum = new random();
            //int rn = newNum.getRan();
            //string newRn = rn.ToString();
            //lblMessage.Text  = newRn;
        

    }
}
   


//    protected void Button1_Click(object sender, EventArgs e)
//    {

//        //for (int i = 0; i < 5; i++)
//        //{
//        //    float r = random(0, 45);
//        //    stroke(abs(r * 5));
//        //    Response.Write(r);
//        //}

//        //for (int i = 0; i <= 5; i++)
//        //{
//        //    int iNum = RandomNumber(0, 45);
//        //    Response.Write(iNum);
//        //}

       
//    }



//    //private int RandomNumber(int min, int max)
//    //{
//    //    Random random = new Random();
//    //    return random.Next(min, max);
//    //}
//    //protected void btnLottoNumbers_Click(object sender, EventArgs e)
//    //{
//    //    string sRnum = "";
//    //    string sMessage = "";
//    //    //int[] iArrLotto = new int[10]; 

//    //    //for (int i = 1; i < 6; i++)
//    //    //{
//    //        int iRnumber = RandomNumber(1, 45);
//    //        sMessage = iRnumber.ToString();

//    //        //iArrLotto[i] = iRnumber;
//    //       // sMessage =iArrLotto[i].ToString();
//    //        //sRnum = iRnumber.ToString();
//    //        //sMessage  += sRnum  ;
           
//    //    //}

//    //    //lblMessage.Text = iArrLotto[0].ToString();
//    //    //lblMessage.Text = iArrLotto[1].ToString();
//    //    //lblMessage.Text = iArrLotto[2].ToString();
//    //     lblMessage.Text = sMessage;
//    //}
//}
