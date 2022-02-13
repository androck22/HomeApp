using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            Grid grid = new Grid
            {
                //ColumnSpacing = 20,
                //RowSpacing = 20,

                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            MergeColums(grid);

            Content = grid;
        }

        /// <summary>
        ///  Заполнение лейаута
        /// </summary>
        public void PopulateGrid(Grid grid)
        {
            // Добавление элементов по определенным позициям
            grid.Children.Add(new BoxView { Color = Color.FromRgb(250, 253, 255) }, 0 /* Позиция слева */, 0 /* Позиция сверху */);

            // Сохраняем элемент перед добавлением, чтобы потом модифицировать
            var mergedRow = new BoxView { Color = Color.FromRgb(196, 232, 255) };
            // Добавляем в Grid
            grid.Children.Add(mergedRow, 0, 1);
            // Устанавливаем свойство ColumnSpan, чтобы расширить элемент на 3 позиции
            Grid.SetColumnSpan(mergedRow, 3);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(133, 207, 255) }, 0, 2);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(87, 189, 255) }, 1, 0);
            // grid.Children.Add(new BoxView { Color = Color.FromRgb(43, 172, 255) }, 1, 1);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(23, 164, 255) }, 1, 2);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 121, 199) }, 2, 0);
            // grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 76, 199) }, 2, 1);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 76, 199) }, 2, 2);
        }

        public void MergeColums(Grid grid)
        {
            var leftMergedColumn  = new BoxView { Color = Color.FromRgb(133, 207, 255) };
            grid.Children.Add(leftMergedColumn , 0, 0);
            Grid.SetRowSpan(leftMergedColumn , 3);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(87, 189, 255) }, 1, 0);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(43, 172, 255) }, 1, 1);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(23, 164, 255) }, 1, 2);

            var rightMergedColumn  = new BoxView { Color = Color.FromRgb(133, 207, 255) };
            grid.Children.Add(rightMergedColumn , 2, 0);
            Grid.SetRowSpan(rightMergedColumn , 3);
        }
    }
}