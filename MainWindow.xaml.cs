/*Andrea Bonafini
*March 25,2019
*Creating a Tshirt through canvas and for loop
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace U2AndreaTShirt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int k = 0; k < 4; k++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Ellipse e = new Ellipse();
                    e.Height = 110;
                    e.Width = 75;

                    Ellipse e1 = new Ellipse();
                    e1.Height = 110;
                    e1.Width = 75;

                    Rectangle r = new Rectangle();
                    r.Width = 20000;
                    r.Height = 500;
                    r.Fill = Brushes.White;
                    
                    if (i % 2 == 0)
                    {
                        e.Fill = Brushes.Red;
                        e1.Fill = Brushes.Red;

                    }

                    canvas.Children.Add(e);
                    Canvas.SetTop(e, 25+200*k);
                    Canvas.SetLeft(e, (i * 110));

                    canvas.Children.Add(e1);
                    Canvas.SetTop(e1, k*200 +25);
                    Canvas.SetLeft(e1, (55 + i * 110));

                    canvas.Children.Add(r);
                    Canvas.SetTop(r, 105+200*k);
                    Canvas.SetLeft(r, 0);
                }

                for (int j = 0; j < 10; j++)
                {
                    Polygon p = new Polygon();
                    Point Point1 = new Point(0, 0);
                    Point Point2 = new Point(119, 0);
                    Point Point3 = new Point(62.5, 99);
                    PointCollection Collection = new PointCollection();
                    Collection.Add(Point1);
                    Collection.Add(Point2);
                    Collection.Add(Point3);
                    p.Points = Collection;

                    if (j % 2 == 0)
                    {
                        p.Stroke = Brushes.Red;
                        p.Fill = Brushes.Red;
                        p.StrokeThickness = 2;
                    }
                    canvas.Children.Add(p);
                    Canvas.SetTop(p, 105+(k*200));
                    Canvas.SetLeft(p, 5.5 * (j + 1) + 104.5 * (j));
                }
                if (k % 2 == 0)
                {

                }
            }
        }
    }
}
