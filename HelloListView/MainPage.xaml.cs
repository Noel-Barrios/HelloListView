﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var listView = new ListView
            {
                RowHeight = 40
            };
            listView.ItemsSource = new string[]
            {
                "Buy pears", "Buy oranges", "Buy mangos", "Buy apples", "Buy bananas"
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };

        }


    }
}
