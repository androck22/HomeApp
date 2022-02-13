using System;
using Xamarin.Forms;

namespace HomeApp.Pages
{
    public partial class WebPage : ContentPage
    {
        public WebPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик навигации
        /// </summary>
        void NavigateToPage(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(urlEntry.Text))
            {
                DisplayAlert("Уведомление", "Введите запрос", "OK");
            }
            else
            {
                // переход по ссылке с автодополнением при необходимости
                webView.Source = new UrlWebViewSource { Url = urlEntry.Text.Contains("http") ? urlEntry.Text : $"https://{urlEntry.Text}" };
            }


        }
    }
}