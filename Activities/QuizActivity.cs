using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Quizz_App.DataModels;
using Quizz_App.Fragments;
using Quizz_App.Helper;

namespace Quizz_App.Activities
{
    [Activity(Label = "QuizActivity", NoHistory = true)]
    public class QuizActivity : AppCompatActivity
    {
        RadioButton optionARadio, optionBRadio, optionCRadio, optionDRadio;
        TextView optionATextView, optionBTextView, optionCTextView, optionDTextView;
        TextView questionTextView, questionNumTextView, timerTextView;
        Button proceedButton;
        Android.Support.V7.Widget.Toolbar toolbar;

        List<Questions> questionList = new List<Questions>();
        QuizzHelper quizHelper = new QuizzHelper();

        System.Timers.Timer countdown = new System.Timers.Timer();
        DateTime dateTime;

        int timerCountdown = 0;
        int quizPosition;
        int numOfCorrectAns;

        string quizTopic;


        bool feedbackShown = false;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.quiz_page);

            quizTopic = Intent.GetStringExtra("topic");

            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.quizToolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = quizTopic + " Quiz";
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.outline_arrowback);
            actionBar.SetDisplayHomeAsUpEnabled(true);

            //Connect views
            optionARadio = FindViewById<RadioButton>(Resource.Id.optionARadio);
            optionBRadio = FindViewById<RadioButton>(Resource.Id.optionBRadio);
            optionCRadio = FindViewById<RadioButton>(Resource.Id.optionCRadio);
            optionDRadio = FindViewById<RadioButton>(Resource.Id.optionDRadio);

            optionARadio.Click += OptionARadio_Click;
            optionBRadio.Click += OptionBRadio_Click;
            optionCRadio.Click += OptionCRadio_Click;
            optionDRadio.Click += OptionDRadio_Click;

            optionATextView = FindViewById<TextView>(Resource.Id.optionATextView); 
            optionBTextView = FindViewById<TextView>(Resource.Id.optionBTextView);
            optionCTextView = FindViewById<TextView>(Resource.Id.optionCTextView);
            optionDTextView = FindViewById<TextView>(Resource.Id.optionDTextView);

            questionTextView = FindViewById<TextView>(Resource.Id.questionDescriptionTextView);
            questionNumTextView = FindViewById<TextView>(Resource.Id.questionNumTextView);
            timerTextView = FindViewById<TextView>(Resource.Id.timerTextView);

            proceedButton = FindViewById<Button>(Resource.Id.proceedButton);
            proceedButton.Click += ProceedButton_Click;

            BeginQuiz();

            countdown.Interval = 1000;
            countdown.Elapsed += Countdown_Elapsed;
            timerTextView.Text = dateTime.ToString("mm:ss");

            countdown.Enabled = true;


        }

        private void Countdown_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timerCountdown++;
            DateTime dt = new DateTime();
            dt = dateTime.AddSeconds(-1);

            var dateDifference = dateTime.Subtract(dt);
            dateTime = dateTime - dateDifference;

            RunOnUiThread(() =>
            {
                timerTextView.Text = dateTime.ToString("mm:ss");
            });

            //end of quiz if timer reaches 0
            if(timerCountdown >= 120)
            {
                countdown.Enabled = false;
                quizPosition = questionList.Count();
                goHomeFragment();
            }
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if (!optionARadio.Checked && !optionBRadio.Checked && !optionCRadio.Checked && !optionDRadio.Checked)
                Snackbar.Make((View)sender, "Please select an option", Snackbar.LengthShort).Show();
            //Toast.MakeText(this, "Please select an option", ToastLength.Short).Show();

            else if (optionARadio.Checked)
            {
                if (optionATextView.Text == questionList[quizPosition - 1].Answer)
                {
                    numOfCorrectAns++;
                    correctAnswer();
                }
                else
                    incorrectAnswer();
            }
            else if (optionBRadio.Checked)
            {
                if (optionBTextView.Text == questionList[quizPosition - 1].Answer)
                {
                    numOfCorrectAns++;
                    correctAnswer();
                }
                else
                    incorrectAnswer();
            }
            else if (optionCRadio.Checked)
            {
                if (optionCTextView.Text == questionList[quizPosition - 1].Answer)
                {
                    numOfCorrectAns++;
                    correctAnswer();
                }
                else
                    incorrectAnswer();
            }
            else if (optionDRadio.Checked)
            {
                if (optionDTextView.Text == questionList[quizPosition - 1].Answer)
                {
                    numOfCorrectAns++;
                    correctAnswer();
                }
                else
                    incorrectAnswer();
            }

        }

        private void OptionDRadio_Click(object sender, EventArgs e)
        {
            clearSelections();
            optionDRadio.Checked = true;
        }

        private void OptionCRadio_Click(object sender, EventArgs e)
        {
            clearSelections();
            optionCRadio.Checked = true;
        }

        private void OptionBRadio_Click(object sender, EventArgs e)
        {
            clearSelections();
            optionBRadio.Checked = true;
        }

        private void OptionARadio_Click(object sender, EventArgs e)
        {
            clearSelections();
            optionARadio.Checked = true;
        }

        void clearSelections()
        {
            optionARadio.Checked = false;
            optionBRadio.Checked = false;
            optionCRadio.Checked = false;
            optionDRadio.Checked = false;
        }

        void BeginQuiz()
        {
            quizPosition = 1;
            questionList = quizHelper.GetQuizQuestions(quizTopic);
            questionTextView.Text = questionList[0].QuizQuestion;
            optionATextView.Text = questionList[0].OptionA;
            optionBTextView.Text = questionList[0].OptionB;
            optionCTextView.Text = questionList[0].OptionC;
            optionDTextView.Text = questionList[0].OptionD;

            questionNumTextView.Text = "Question " + quizPosition.ToString() + "/" + questionList.Count();
            dateTime = new DateTime();
            dateTime = dateTime.AddMinutes(2);
        }

        void correctAnswer()
        {
            CorrectFragment correctFragment = new CorrectFragment();
            var trans = SupportFragmentManager.BeginTransaction();
            correctFragment.Cancelable = false;
            correctFragment.Show(trans, "Correct");
            correctFragment.nextQuestion += CorrectFragment_nextQuestion;
        }

        void incorrectAnswer()
        {
            IncorrectFragment incorrectFragment = new IncorrectFragment(questionList[quizPosition-1].Answer);
            var trans = SupportFragmentManager.BeginTransaction();
            incorrectFragment.Cancelable = false;
            incorrectFragment.Show(trans, "Incorrect");
            incorrectFragment.nextQuestion += CorrectFragment_nextQuestion;
        }

        void goHomeFragment()
        {
            FeedbackFragment feedbackFragment = new FeedbackFragment(numOfCorrectAns, questionList.Count());
            var trans = SupportFragmentManager.BeginTransaction();
            feedbackShown = true;
            feedbackFragment.Cancelable = false;
            feedbackFragment.Show(trans, "Go Home");
            feedbackFragment.goToHome += CorrectFragment_nextQuestion;
        }

        //Works for both buttons. it just go to the next question.
        private void CorrectFragment_nextQuestion(object sender, EventArgs e)
        {
            quizPosition++;

            if (quizPosition > questionList.Count())
            {
                if (!feedbackShown)
                    goHomeFragment();
                else
                    this.Finish();
            }
            else
            {
                //index for the next question. number of the question
                int index = quizPosition - 1;

                clearSelections();

                questionNumTextView.Text = "Question " + quizPosition + "/ " + questionList.Count();
                questionTextView.Text = questionList[index].QuizQuestion;

                optionATextView.Text = questionList[index].OptionA;
                optionBTextView.Text = questionList[index].OptionB;
                optionCTextView.Text = questionList[index].OptionC;
                optionDTextView.Text = questionList[index].OptionD;
            }
        }
    }
}