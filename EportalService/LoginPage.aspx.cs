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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // do nothing on initial page load
            }
        }
        protected async void btnsubmit_Click(object sender, EventArgs e)
        {
            var email = Request.Form["email"];
            var password = Request.Form["password"];


            //Replace this with api service url
            var base_url = "http://localhost:3639";
            using (var client = new HttpClient())
            {
                var request = new { Email = email, Password = password };
                var content = new StringContent(JsonConvert.SerializeObject(request),
                                                System.Text.Encoding.UTF8,
                                                "application/json");
                var response = await client.PostAsync(base_url +"/ api/User", content);

                if (response.IsSuccessStatusCode)
                {
                    var log = await response.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<LoginResponseModel>(log);
                    Session["Id"] = user.Id;
                    Response.Redirect("Dashboard.aspx");
                }
                //else
                //{
                //    lblMessage.Text = "Invalid email or password";
                //}
            }
        }
    }
}