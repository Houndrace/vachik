using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Shapes;


namespace n9_PieChart {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public readonly Canvas ChartBackground = new();
        public MainWindow() {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e) {
            PieChartGrid.Children.OfType<Canvas>().ToList().ForEach(p => PieChartGrid.Children.Remove(p));

            PieChartGrid.Children.Add(ChartBackground);

            PieChartGrid.UpdateLayout();

            CreateChart();
        }

        private void CreateChart() {
            Clear();

            Random random = new();

            for (int i = 0; i < random.Next(1, 25); i++) {
                AddValue(random.Next(1, 25));
            }
        }

        public void AddValue(double value) {
            List<StoredValues> listValues = CalculateSectorAngle(value);

            double sum = listValues.Select(p => p.Value).Sum();

            Clear();

            // Placement of sectors of calculated size to create Pie Chart
            for (int i = 0; i < listValues.Count; i++) {
                StoredValues sv = listValues[i];

                // Each Path element will store sector data for subsequent calculations
                Path p = CreateSector(sv.Degree, sv.Offset, sv.Value);
                _ = ChartBackground.Children.Add(p);


                // Numeric values of disk sectors
                Label label = new() {
                    Content = sv.Value + " (" + Math.Round(sv.Value / sum * 100, 2) + " %)",
                };

                // Color labels before numeric ones
                Rectangle r = new() {
                    Width = 16,
                    Height = 12,
                    Fill = p.Fill,
                    Stroke = Brushes.White,
                    StrokeThickness = 1
                };

                StackPanel sp = new() {
                    Orientation = Orientation.Horizontal
                };
                sp.Children.Add(r);
                sp.Children.Add(label);

                
                Canvas.SetLeft(sp, 10);
                Canvas.SetTop(sp, 20 * i);
                _ = ChartBackground.Children.Add(sp);
            }
        }

        public void Clear() {
            ChartBackground.Children.Clear();
        }

        /// <summary>
        /// Creating a disk sector with its own color
        /// </summary>
        /// <param name="degree">sector angle in degrees</param>
        /// <param name="offset">offset angle by the value of the angle of the previous sector</param>
        /// <param name="value">the absolute value of the graph point</param>
        /// <returns></returns>
        private Path CreateSector(double degree, double offset, double value) {
            Random random = new Random();

            Path path = new() {
                StrokeThickness = 5,
                Stroke = Brushes.White,
                Fill = new SolidColorBrush(Color.FromArgb(255, (byte)random.Next(50, 256), (byte)random.Next(50, 256), (byte)random.Next(50, 256))),

                Data = new PathGeometry() {
                    Figures = new PathFigureCollection(){
                        SectorGeometry(degree, offset)
                    }
                },

                //
                Tag = new StoredValues() {
                    Degree = degree,
                    Offset = offset,
                    Value = value
                }
            };

            return path;
        }

        /// <summary>
        /// Geometry of the sector
        /// </summary>
        /// <param name="degree">a sector angle</param>
        /// <param name="offset">offset by the angle of the previous sector</param>
        /// <returns></returns>
        private PathFigure SectorGeometry(double degree, double offset) {
            // The radius of the pie chart
            double _radius = 0;
            if (ChartBackground.ActualHeight < ChartBackground.ActualWidth) {
                _radius = ChartBackground.ActualHeight / 2 - 10;
            } else {
                _radius = ChartBackground.ActualWidth / 2 - 10;
            }

            bool isLarge = false;

            // If the angle is more than half of the disk, form a large arc
            if (degree > 180) isLarge = true;

            // Exclude the coincidence of the starting point with the ending point
            // otherwise the sector won't appear
            if (degree >= 360) degree = 359.999;

            // The center of the disk
            Point centerPoint = new(ChartBackground.ActualWidth / 2, ChartBackground.ActualHeight / 2);

            // The starting point of the disk sector is the lowest point of the disk
            Point startPoint = new(centerPoint.X, centerPoint.Y + _radius);
            
            // The end point of the arc. The point to be rotated.
            // It starts from the beginning of the disk, from the lowest point
            // Clockwise rotation
            Point endPoint = startPoint;

            // Rotate the starting point by the offset angle
            RotateTransform rotateStartPoint = new(offset) {
                CenterX = centerPoint.X,
                CenterY = centerPoint.Y
            };
            startPoint = rotateStartPoint.Transform(startPoint);

            // Rotate the end point by a given angle,
            // by an angle relative to the starting point of the figure
            RotateTransform rotateEndPoint = new(offset + degree) {
                CenterX = centerPoint.X,
                CenterY = centerPoint.Y
            };
            endPoint = rotateEndPoint.Transform(endPoint);

            // A figure representing a separate sector on the disk
            PathFigure sector = new() {
                StartPoint = startPoint,
                Segments = new PathSegmentCollection()
                {
                    new ArcSegment()
                    {
                        Point = endPoint,
                        Size = new(_radius, _radius),
                        SweepDirection = SweepDirection.Clockwise,
                        IsLargeArc = isLarge,
                        IsStroked = true
                    },

                    new PolyLineSegment()
                    {
                        // Start the line from the end point of the arc so 
                        // that the points line up in a logical, consistent curve
                        Points = new PointCollection() { endPoint, centerPoint, startPoint },
                        IsStroked = false
                    }
                }
            };

            return sector;
        }

        /// <summary>
        /// Calculation of angular values for each sector
        /// </summary>
        /// <param name="value">absolute value</param>
        /// <returns></returns>
        private List<StoredValues> CalculateSectorAngle(double value) {
            // Get the absolute values of the sectors of the current disk
            // to calculate the new angular sizes of the sectors
            // after adding another sector
            List<StoredValues> listValues = ChartBackground.Children.OfType<Path>().Select(p => (StoredValues)p.Tag).ToList();

            // Adding a new absolute value to the list
            StoredValues d = new();
            d.Value = value;
            listValues.Add(d);

            // Sort by ascending value
            listValues = listValues.OrderBy(p => p.Value).ToList();

            // The sum of all absolute values of sectors
            double sum = listValues.Select(p => p.Value).Sum();

            // Common denominator for calculating degrees of rotation
            // and angular offset for each value
            double denominator = sum / 360;

            for (int i = 0; i < listValues.Count; i++) {
                // The accuracy of the angle is reduced to hundredths
                // to exclude artifacts when drawing a sector
                double degree = Math.Round(listValues[i].Value / denominator, 2);
                listValues[i].Degree = degree;

                double offset = 0;
                if (i > 0) {
                    // The angular offset of the next sector is formed
                    // on the data of the previous one
                    offset = listValues[i - 1].Degree + listValues[i - 1].Offset;
                }

                listValues[i].Offset = offset;
            }

            return listValues;
        }

        /// <summary>
        /// The set of stored values in each Path element 
        /// </summary>
        internal class StoredValues{
            // Disk sector angle and angular offset from
            // the previous sector in degrees
            public double Degree;
            public double Offset;

            // Absolute value
            public double Value;
        }

        private void PieChartGrid_SizeChanged(object sender, SizeChangedEventArgs e) {
            Clear();
        }
    }
}