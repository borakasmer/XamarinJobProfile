using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using DataLibrary;

namespace JobProfile
{
    [Activity(Label = "JobProfile", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {        
        Button buttonNext;
        Button buttonPrev;
        TextView txtTitle;
        TextView txtDescription;
        ImageView imgPerson;
        LibraryManager libManager;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            buttonNext = FindViewById<Button>(Resource.Id.btnNext);
            buttonPrev = FindViewById<Button>(Resource.Id.btnPrev);
            txtTitle = FindViewById<TextView>(Resource.Id.txtTitle);
            txtDescription = FindViewById<TextView>(Resource.Id.textDescription);
            imgPerson = FindViewById<ImageView>(Resource.Id.imgProfile);

            buttonPrev.Click += ButtonPrev_Click;
            buttonNext.Click += ButtonNext_Click;
            libManager = new LibraryManager();
            libManager.MoveFirst();
            UpdateUI();
            // Get our button from the layout resource,
            // and attach an event to it            
        }
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            libManager.MoveNext();
            UpdateUI();
            /*txtTitle.Text = "Jonh Nash";
            txtDescription.Text = "He is web developer for 10 years";
            imgPerson.SetImageResource(Resource.Drawable.Hubbar);*/
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            libManager.MovePrev();
            UpdateUI();
            /*txtTitle.Text = "Willim Harsh..";
            txtDescription.Text = "Breath taking jobs and success...";
            imgPerson.SetImageResource(Resource.Drawable.name);*/
        }
        private void UpdateUI()
        {
            txtTitle.Text = libManager.Current.Title;
            txtDescription.Text = libManager.Current.Description;
            imgPerson.SetImageResource(ResourceHelper.TranslateDrawableWithReflection(libManager.Current.Image));
            
            buttonNext.Enabled = libManager.CanMoveNext;
            buttonPrev.Enabled = libManager.CanMovePrev;
        }
    }
}

