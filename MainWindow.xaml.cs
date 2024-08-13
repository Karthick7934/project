using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;

namespace Configure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        private string TextboxRuntimeip
        {
            get
            {
                return _textboxRuntimeip;
            }
            set
            {
                var regexItem = new System.Text.RegularExpressions.Regex("[^0-9.]");
                if (regexItem.IsMatch(value))
                    return;
                if(_textboxRuntimeip == value)
                {
                     _textboxRuntimeip = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(TextboxRuntimeip)));

                }
            }
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        Notifier notifier = new Notifier(cfg =>
        {
            cfg.PositionProvider = new WindowPositionProvider(
                parentWindow: Application.Current.MainWindow,
                corner: Corner.BottomRight,
                offsetX: 25,
                offsetY: 20);

            cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                notificationLifetime: TimeSpan.FromSeconds(4),
                maximumNotificationCount: MaximumNotificationCount.FromCount(5));

            cfg.Dispatcher = Application.Current.Dispatcher;
            cfg.DisplayOptions.TopMost = false;
            cfg.DisplayOptions.Width = 250;
        });
        private string _textboxRuntimeip;

        private void infobtn_click(object sender,RoutedEventArgs e)
        {
            notifier.ShowInformation("information");
        }
        private void Sucessbtn_click(object sender,RoutedEventArgs e)
        {
            notifier.ShowSuccess("Sucess");
        }

      
    }
}
