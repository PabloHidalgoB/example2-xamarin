﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace example2_xamarin.Fragments
{
    class Fragment2 : Android.Support.V4.App.Fragment
    {
        private LinearLayout mLayout;
        private String mMessage;
        private TextView mTextView;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View mLayout = inflater.Inflate(Resource.Layout.fragment_fragment2, container, false);

            mTextView = mLayout.FindViewById<TextView>(Resource.Id.txt_message);

            if (Arguments != null)
            {
                mMessage = Arguments.GetString("parametro2");
                mTextView.Text = mMessage;
            }

            return mLayout;
        }
    }
}