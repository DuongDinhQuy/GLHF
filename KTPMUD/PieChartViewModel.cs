using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;

namespace KTPMUD
{
    public class PieChartViewModel
    {
        public IEnumerable<ISeries> Series1 { get; set; }
        public IEnumerable<ISeries> Series2 { get; set; }
        public string[] Labels1 { get; set; }
        public string[] Labels2 { get; set; }
        public PieChartViewModel()
        {
            // Gọi hàm để lấy dữ liệu từ cơ sở dữ liệu
            var data1 = GetDataFromDatabase1();
            var data2 = GetDataFromDatabase2();


            // Tạo Series cho biểu đồ tròn
            var seriesList1 = new List<ISeries>();
            var seriesList2 = new List<ISeries>();


            // Labels tương ứng với từng danh mục
            Labels1 = new string[] { "Ăn uống", "Học tập", "Mua sắm", "Vui chơi", "Di chuyển", "Cho vay" };
            Labels2 = new string[] { "Thu nhập", "Phụ cấp", "Tiền thưởng", "Thu nợ" };

            for (int i = 0; i < data1.Length; i++)
            {
                var series1 = new PieSeries<double> { Values = new List<double> { data1[i] }, Name = Labels1[i] };
                seriesList1.Add(series1);
            }
            for (int j = 0; j < data2.Length; j++)
            {
                var series2 = new PieSeries<double> { Values = new List<double> { data2[j] }, Name = Labels2[j] };
                seriesList2.Add(series2);
            }

            Series1 = seriesList1;
            Series2 = seriesList2;
        }

        private double[] GetDataFromDatabase1()
        {
            Random random1 = new Random();
            double[] data1 = new double[6];

            // Giả định có 4 danh mục
            for (int i = 0; i < 6; i++)
            {
                // Giả định giá trị là số nguyên từ 1 đến 100
                data1[i] = random1.Next(1, 100);
            }

            return data1;
        }
        private double[] GetDataFromDatabase2()
        {
            Random random2 = new Random();
            double[] data2 = new double[4];

            // Giả định có 4 danh mục
            for (int j = 0; j < 4; j++)
            {
                // Giả định giá trị là số nguyên từ 1 đến 100
                data2[j] = random2.Next(5, 200);
            }

            return data2;
        }
    }
}