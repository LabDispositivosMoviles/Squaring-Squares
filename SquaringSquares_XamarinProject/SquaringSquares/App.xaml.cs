﻿using System;

using Xamarin.Forms;

namespace SquaringSquares
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
                GameScreen = new GameScreen();
            else
                GameScreen = new GameScreen();
        }
    }
}
