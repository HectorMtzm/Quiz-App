using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Quizz_App.Activities;
using Android.Views;

namespace Quizz_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        Android.Support.V4.Widget.DrawerLayout drawerLayout;
        Android.Support.Design.Widget.NavigationView navigationView;

        LinearLayout historylayout;
        LinearLayout spacelayout;
        LinearLayout geographylayout;
        LinearLayout businesslayout;
        LinearLayout programminglayout;
        LinearLayout engineeringlayout;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.toolbar);
            drawerLayout = FindViewById<Android.Support.V4.Widget.DrawerLayout>(Resource.Id.drawerLayout);
            navigationView = FindViewById<Android.Support.Design.Widget.NavigationView>(Resource.Id.navview);
            navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;

            //setup toolbar
            SetSupportActionBar(toolbar);

            //title of the action bar
            SupportActionBar.Title = "Topics";

            //add icon of the action bar with press animation
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.menuaction);
            actionBar.SetDisplayHomeAsUpEnabled(true);

            //Views setupps
            historylayout = FindViewById<LinearLayout>(Resource.Id.historyLayout);
            spacelayout = FindViewById<LinearLayout>(Resource.Id.spaceLayout);
            geographylayout = FindViewById<LinearLayout>(Resource.Id.geographyLayout);
            businesslayout = FindViewById<LinearLayout>(Resource.Id.businessLayout);
            programminglayout = FindViewById<LinearLayout>(Resource.Id.programmingLayout);
            engineeringlayout = FindViewById<LinearLayout>(Resource.Id.engineeringLayout);

            //Click event handlers
            historylayout.Click += Historylayout_Click;
            spacelayout.Click += Spacelayout_Click;
            geographylayout.Click += Geographylayout_Click;
            businesslayout.Click += Businesslayout_Click;
            programminglayout.Click += Programminglayout_Click;
            engineeringlayout.Click += Engineeringlayout_Click;



        }

        private void NavigationView_NavigationItemSelected(object sender, Android.Support.Design.Widget.NavigationView.NavigationItemSelectedEventArgs e)
        {
            Intent intent = new Intent(this, typeof(DescriptionActivity));
            switch (e.MenuItem.ItemId)
            {
                case Resource.Id.navHistory:
                    initHistory();
                    drawerLayout.CloseDrawers();
                    break;

                case Resource.Id.navGeography:
                    initGeography();
                    drawerLayout.CloseDrawers();
                    break;

                case Resource.Id.navSpace:
                    initSpace();
                    drawerLayout.CloseDrawers();
                    break;

                case Resource.Id.navEngineering:
                    initEngineering();
                    drawerLayout.CloseDrawers();
                    break;

                case Resource.Id.navProgramming:
                    initProgramming();
                    drawerLayout.CloseDrawers();
                    break;

                case Resource.Id.navBusiness:
                    initBusiness();
                    drawerLayout.CloseDrawers();
                    break;

            }
        }

        private void Engineeringlayout_Click(object sender, System.EventArgs e)
        {
            initEngineering();
        }

        private void Programminglayout_Click(object sender, System.EventArgs e)
        {
            initProgramming();
        }

        private void Businesslayout_Click(object sender, System.EventArgs e)
        {
            initBusiness();
        }

        private void Geographylayout_Click(object sender, System.EventArgs e)
        {
            initGeography();
        }

        private void Spacelayout_Click(object sender, System.EventArgs e)
        {
            initSpace();
        }

        private void Historylayout_Click(object sender, System.EventArgs e)
        {
            initHistory();
        }


        //private string 

        //activities initiators
        private void initHistory()
        {
            Intent intent = new Intent(this, typeof(DescriptionActivity));

            //Pass the data so it create the right description
            intent.PutExtra("topic", "History");

            StartActivity(intent);
        }

        private void initSpace()
        {
            Intent intent = new Intent(this, typeof(DescriptionActivity));
            intent.PutExtra("topic", "Space");
            StartActivity(intent);
        }

        private void initGeography()
        {
            Intent intent = new Intent(this, typeof(DescriptionActivity));
            intent.PutExtra("topic", "Geography");
            StartActivity(intent);
        }

        private void initBusiness()
        {
            Intent intent = new Intent(this, typeof(DescriptionActivity));
            intent.PutExtra("topic", "Business");
            StartActivity(intent);
        }

        private void initProgramming()
        {
            Intent intent = new Intent(this, typeof(DescriptionActivity));
            intent.PutExtra("topic", "Programming");
            StartActivity(intent);
        }

        private void initEngineering()
        {
            Intent intent = new Intent(this, typeof(DescriptionActivity));
            intent.PutExtra("topic", "Engineering");
            StartActivity(intent);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer((int)GravityFlags.Left);
                    return true;

                default:
                    return base.OnOptionsItemSelected(item);

            }
        }
        public override void OnBackPressed()
        {
            if (drawerLayout.IsDrawerOpen(Android.Support.V4.View.GravityCompat.Start))
                drawerLayout.CloseDrawers();
            
            else
                base.OnBackPressed();
        }
    }
}