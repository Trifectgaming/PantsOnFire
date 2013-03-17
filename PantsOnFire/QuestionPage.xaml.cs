using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PantsOnFire
{
    public partial class QuestionPage : PhoneApplicationPage
    {
        public QuestionPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            _imageBrush = new ImageBrush { ImageSource = StateBag.CurrentImage };
            PictureRect.Fill = _imageBrush;
        }

        private ImageBrush _imageBrush;
    }
}