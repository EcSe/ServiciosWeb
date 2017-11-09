using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ServiceReference1.CalculatorSoapClient servicio;
        private ServiceReference2.WebService01SoapClient servicio1;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void suma(object sender, EventArgs e)
        {
           
            servicio = new ServiceReference1.CalculatorSoapClient();
            int n1 = int.Parse(txtn1.Text);
            int n2 = int.Parse(txtn2.Text);
            //int n1 = Convert.ToInt32(txtn1.Text);
            //int n2 = Convert.ToInt32(txtn2.Text);
            lblresultado.Text = servicio.Add(n1, n2).ToString();
        }

        protected void resta(object sender, EventArgs e)
        {
            servicio = new ServiceReference1.CalculatorSoapClient();
            int n1 = int.Parse(txtn1.Text);
            int n2 = int.Parse(txtn2.Text);
            lblresultado.Text = servicio.Subtract(n1, n2).ToString();
        }

        protected void multi(object sender, EventArgs e)
        {

        }

        protected void div(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio1 = new ServiceReference2.WebService01SoapClient();
            int n1 = int.Parse(txtn1.Text);
            int n2 = int.Parse(txtn2.Text);
            lblresultado.Text = servicio1.Suma(n1, n2).ToString();
        }
    }
}