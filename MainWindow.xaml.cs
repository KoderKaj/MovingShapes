﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MovingShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer t;
        Ellipse ellipse;
        public MainWindow()
        {
            InitializeComponent();
            ellipse = new Ellipse();
            ellipse.Height = 30; ellipse.Width = 20;
            ellipse.Fill = new SolidColorBrush(Colors.OrangeRed);
            ellipse.RenderTransform = new TranslateTransform(60, 70);
            cnvsMain.Children.Add(ellipse);
            ellipse.LayoutTransform = new RotateTransform(45);
            Ellipse circle = new Ellipse();
            circle.Width = 20; circle.Height = 20;
            circle.Stroke = Brushes.Blue;
            cnvsMain.Children.Add(circle);
            SetTimer();
        } 
        
        private void SetTimer()
        {
            t = new Timer(100);
            t.Elapsed += TimerEvent;
            t.Enabled = true;
        }
        double angle = 0;
        private void TimerEvent(Object source, ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                ellipse.LayoutTransform = new RotateTransform(angle+=10);
            });
            
        }
    }
}
