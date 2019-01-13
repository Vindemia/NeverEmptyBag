using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeverEmptyBag.FormulaireCreation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormUnivers : ContentPage
	{
		public FormUnivers ()
		{
			InitializeComponent ();
		}

		private void Btn_valider_Clicked(object sender, EventArgs e)
		{

		}
	}
}