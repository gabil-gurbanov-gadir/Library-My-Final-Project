﻿using Library_Final_Project.Data;
using Library_Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_Final_Project.Windows
{
    public delegate void Refresh();
    public partial class AddBookCategoryWindow : Window
    {
        public readonly LibraryContext _context;
        public event Refresh RefreshCmbBookCategories;
        public AddBookCategoryWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }

        private void BtnAddCategory_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                LblName.Foreground = new SolidColorBrush(Colors.Red);
                MessageBox.Show("Kateqoriya adı yazın");
                
                return;
            }
            else
            {
                LblName.Foreground = new SolidColorBrush(Colors.Black);
                BookCategory bookCategory = new BookCategory();
                bookCategory.Name = TxtName.Text;
                _context.BookCategories.Add(bookCategory);
                _context.SaveChanges();
                Reset();
                this.Close();
            }
        }

        private void Reset()
        {
            TxtName.Clear();
            RefreshCmbBookCategories?.Invoke();
        }
    }
}
