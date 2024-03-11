using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace GoldenGuardians.Pages
{
    public class LoginModel : PageModel
	{
		[BindProperty]
		public required LoginModel log { get; set; }
		public void OnPost()
		{
			string email = Request.Form["email"];
			string password = Request.Form["pass"];

			using (MySqlConnection con = new MySqlConnection("server=localhost;username=root;database=gyg;port=3306;password=sau@271202"))
			{
				//opening connection
				con.Open();

				string query = "select * from log where email = ?email;";

				MySqlCommand cmd = new MySqlCommand(query, con);

				con.Close();
			}
		}
	}
}

