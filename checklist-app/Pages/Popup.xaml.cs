using checklist_app.Views;

namespace checklist_app.Pages;

public partial class Popup : ContentPage
{
	public Popup(string msg)
	{
		BindingContext = new PopupViewModel(msg);
		InitializeComponent();
	}
}