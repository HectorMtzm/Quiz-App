using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Quizz_App.Fragments
{
    public class FeedbackFragment : Android.Support.V4.App.DialogFragment
    {
        Button goHomeButton;
        ImageView imageFeedbackImageView;
        TextView numOfCorrectAnsersTextView, feedback;

        private int numOfCorrectAns;
        private int numOfQuestions;

        private double rightPercentage;

        public FeedbackFragment(int numOfCorrectAns, int numOfQuestions)
        {
            this.numOfCorrectAns = numOfCorrectAns;
            this.numOfQuestions = numOfQuestions;
        }

        public event EventHandler goToHome;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            int image;
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View view = inflater.Inflate(Resource.Layout.goHome, container, false);

            goHomeButton = view.FindViewById<Button>(Resource.Id.goHomeButton);
            numOfCorrectAnsersTextView = view.FindViewById<TextView>(Resource.Id.numOfCorrectAnsersTextView);
            feedback = view.FindViewById<TextView>(Resource.Id.feedback);
            imageFeedbackImageView = view.FindViewById<ImageView>(Resource.Id.imageFeedbackImageView);

            numOfCorrectAnsersTextView.Text = numOfCorrectAns + "/" + numOfQuestions;

            rightPercentage = ((double)numOfCorrectAns / (double)numOfQuestions) * 100;

            Console.WriteLine(rightPercentage);

            if (rightPercentage > 70)
                feedback.Text = "You should teach\nthis stuff!";
            else if (rightPercentage > 50)
                feedback.Text = "You know the stuff!";
            else if (rightPercentage == 50)
                feedback.Text = "You baerly made it!";
            else
            {
                imageFeedbackImageView.SetImageResource(Resource.Drawable.sad);
                feedback.Text = "You failed :(\nBut you can try again!";
            }

            goHomeButton.Click += GoHomeButton_Click;
            return view;
        }

        private void GoHomeButton_Click(object sender, EventArgs e)
        {
            this.Dismiss();

            //event invoker. tells quiz activity the button was clicked
            //and it should move to the next question (correctAnswer())
            goToHome?.Invoke(this, new EventArgs());

        }
    }
}