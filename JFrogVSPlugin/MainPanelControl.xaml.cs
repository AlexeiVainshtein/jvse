﻿namespace JFrogVSPlugin
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MainPanelControl.
    /// </summary>
    public partial class MainPanelControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPanelControl"/> class.
        /// </summary>
        public MainPanelControl()
        {
            this.InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "MainPanel");
        }

        private void onSelectedChanged(object sender, RoutedEventArgs e)
        {
            //demo for direct Routed Event
            MessageBox.Show("ok");
        }

        private void MyCustomControl_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("It is the custom routed event of your custom control");
        }
    }
}