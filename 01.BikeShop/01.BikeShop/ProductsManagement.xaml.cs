﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01.BikeShop
{
    /// <summary>
    /// ProductsManagement.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProductsManagement : Page
    {
        ProductsFactory factory = new ProductsFactory();

        public ProductsManagement()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataGrid.ItemsSource = factory.FindProducts(textBox.Text);
        }
    }
}
