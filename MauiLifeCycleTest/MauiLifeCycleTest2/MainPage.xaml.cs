using System;
using Microsoft.Maui.Controls;

namespace MauiLifeCycleTest2
{
    public partial class MainPage : ContentPage
    {
        private bool isTemplate1 = true;

        public MainPage()
        {
            InitializeComponent();
            ShowTemplateOne();  
        }

        private void OnToggleTemplateClicked(object sender, EventArgs e)
        {
            if (isTemplate1)
                ShowTemplateTwo();
            else
                ShowTemplateOne();

            isTemplate1 = !isTemplate1;
        }

        

        private void ShowTemplateOne()
        {
            var view = new Template1();
            Container.Content = view;
        }

        private void ShowTemplateTwo()
        {
            var view = new Template2();
            Container.Content = view;
        }

        private void OnOpenPageClicked(object sender, EventArgs e)
        {
            App.NavigationPage.Navigation.PushAsync(new MainPage());
        }
    }
}
