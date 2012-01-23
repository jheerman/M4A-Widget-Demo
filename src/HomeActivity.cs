using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace M4AWidgetDemo
{
	[Activity (Label = "M4A-Widget-Demo", MainLauncher = true)]
	public class HomeActivity : ListActivity
	{
		readonly string[] names = {"Larry", "Moe", "Curly"};
		
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
		
			var myList = FindViewById<ListView>(Resource.Id.myList);
			myList.Adapter = new ArrayAdapter(this, Resource.Layout.Main, names);
			
		}
	}
}


