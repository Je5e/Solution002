using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DataAccesFactory.Model;

namespace DataAccesFactory
{
    public partial class MainPage : ContentPage
    {
        
        protected override void OnAppearing() // ?
        {
            base.OnAppearing();
            UpdateCategories();
                
        }
        
        public MainPage()
        {
            InitializeComponent();

            //listViewCategories.ItemsSource = Categories;
            
        }

        private void BtnAddCategory_Clicked(object sender, EventArgs e)
        {
          
            var Category = new Category
            {
                CategoryName = categoryNameEntry.Text,
                Description = categoryDescriptionEntry.Text
            };
           var Result = App.Repository.InsertCategory(Category);
            if (Result > 0)
            {
                DisplayAlert
                    ("Mensaje", $"Category:{Category.CategoryID} added", "Ok");
            }

            UpdateCategories();
        }

        private void UpdateCategories()
        {
           
            listViewCategories.ItemsSource = App.Repository.
                GetCategories();
        }
    }
}
