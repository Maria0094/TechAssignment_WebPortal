using EportalService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EportalService
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] == null)
            {
                Response.Redirect("LoginPage.aspx", false);
            }
            else
            {
                // Call backend API to get user data
                // and set session variables for name, email, and mobile
                //Replace this with api service url
                var base_url = "http://localhost:3639";
                using (var client = new HttpClient())
                {
                var response = await client.GetAsync(base_url+"/api/User/" + Session["Id"]);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var user = JsonConvert.DeserializeObject<DashboardResponseModel>(content);
                        userType.InnerText = user.UserType;
                        name.InnerText = user.Name;
                        email.InnerText = user.Email;
                        mobile.InnerText = user.Mobile;
                    }
                    else
                    {
                        error.InnerText ="Service not available";
                    }
                }
                // ...

                //lblName.Text = Session["name"].ToString();
                //lblEmail.Text = Session["email"].ToString();
                //lblMobile.Text = Session["mobile"].ToString();
            }
        }
    }
}