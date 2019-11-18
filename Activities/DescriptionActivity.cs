using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Quizz_App.Helper;

namespace Quizz_App.Activities
{
    [Activity(Label = "DescriptionActivity", Theme = "@style/AppTheme")]
    public class DescriptionActivity : AppCompatActivity
    {
        TextView quizTopicTextview;
        TextView descriptionTextview;
        Button startQuizButton;
        ImageView quizImageView;

        //topic string variables
        String quizTopic;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.selected_topic);

            quizTopicTextview = FindViewById<TextView>(Resource.Id.quizTopicText);
            descriptionTextview = FindViewById<TextView>(Resource.Id.quizDescriptionText);
            startQuizButton = FindViewById<Button>(Resource.Id.startQuizButton);
            quizImageView = FindViewById<ImageView>(Resource.Id.quizImage);
            quizTopic = Intent.GetStringExtra("topic");

            //Setup the custom activity / get and set the values of the views
            QuizzHelper quizzHelper = new QuizzHelper();
            quizTopicTextview.Text = quizTopic;
            quizImageView.SetImageResource(quizzHelper.GetImage(quizTopic));
            descriptionTextview.Text = quizzHelper.GetTopicDescription(quizTopic);

            startQuizButton.Click += StartQuizButton_Click;


        }

        private void StartQuizButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizActivity));
            intent.PutExtra("topic", quizTopic);
            StartActivity(intent);
            Finish();
        }
    }
}