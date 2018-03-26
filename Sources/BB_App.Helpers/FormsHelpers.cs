using System.Windows.Forms;

namespace BB_App.Helpers
{
	public class FormsHelpers
	{
		
		/// <summary>
		/// Load form into the container control
		/// </summary>
		/// <param name="container">Container of the form</param>
		/// <param name="form">Form to load</param>
		public static void LoadForm(Control container, Control form)
		{
			container.Controls.Clear();
			form.Dock = DockStyle.Fill;
			container.Controls.Add(form);
		}

	}
}
