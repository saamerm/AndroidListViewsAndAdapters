using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidListViews
{
	[Activity(Label = "List Views", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			var studentList = FindViewById<ListView>(Resource.Id.studentListView);
			studentList.ItemClick += StudentList_ItemClick;
			// Get our button from the layout resource,
			// and attach an event to it
			studentList.Adapter = new ArrayAdapter<Student>(this, Android.Resource.Layout.SimpleListItem1, StudentData.Students);
		}

		void StudentList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			var student = StudentData.Students[e.Position];
			var dialog = new AlertDialog.Builder(this);
			dialog.SetMessage(student.Name);
			dialog.SetNeutralButton("OK", delegate { });
			dialog.Show();
		}

	}
}

