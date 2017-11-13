using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using example2_xamarin.Fragments;

namespace example2_xamarin.Activities
{
    [Activity(Label = "example2_xamarin", MainLauncher = true)]
    public class MainActivity : RootActivity
    {
        private Fragment1 fragment1;
        private Fragment2 fragment2;
        private Fragment3 fragment3;

        private static string MESSAGE1 = "Este es un mensaje estatico 1";
        private string message2;
        private string message3;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            message2 = "I know what you did last summer";
            message3 = "OH NO!";

            Bundle bundle = new Bundle();

            bundle.PutString("parametro1", MESSAGE1);
            fragment1 = new Fragment1();
            fragment1.Arguments = bundle;
            Android.Support.V4.App.FragmentManager fragmentManager = SupportFragmentManager;
            Android.Support.V4.App.FragmentTransaction fragmentTransaction = fragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.frame1, fragment1, null).AddToBackStack("frame1").Commit();

            bundle = new Bundle();
            bundle.PutString("parametro2", message2);
            fragment2 = new Fragment2();
            fragment2.Arguments = bundle;
            fragmentTransaction = fragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.frame2, fragment2, null).AddToBackStack("frame2").Commit();

            bundle = new Bundle();
            bundle.PutString("parametro3", message3);
            fragment3 = new Fragment3();
            fragment3.Arguments = bundle;
            fragmentTransaction = fragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.frame3, fragment3, null).AddToBackStack("frame3").Commit();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

