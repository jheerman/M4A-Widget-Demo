using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ICSDemo
{
	[Activity (Label = "CatalogActivity")]			
	public class CatalogActivity : ListActivity
	{
		readonly string[] names = {"Larry", "Moe", "Curly"};
		
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			ListAdapter = new ArrayAdapter(this, Resource.Layout.ListItem, names);
		}
	}
}