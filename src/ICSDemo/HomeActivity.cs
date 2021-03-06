using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ICSDemo
{
	[Activity (Label = "ICSDemo", MainLauncher = true)]
	public class HomeActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				Intent intent = new Intent();
				intent.SetClass (this, typeof(CatalogActivity));
				StartActivity(intent);
			};
			
		}
	}
}


