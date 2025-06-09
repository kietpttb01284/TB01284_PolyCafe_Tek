using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Poly;
using System.Windows.Forms.DataVisualization.Charting;
using DTO_PolyCafe;

namespace TB01284_PolyCafe
{
    public partial class frmThongKe : Form
    {
        BUS_ThongKe busThongKe = new BUS_ThongKe();

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }
        private void VeBieuDo(List<DoanhThuNV> data)
        {
            chartDoanhThuNhanVien.Series.Clear();
            chartDoanhThuNhanVien.ChartAreas.Clear();
            chartDoanhThuNhanVien.Titles.Clear();

            ChartArea area = new ChartArea("DoanhThuNV");
            area.AxisX.Title = "Ngày tạo";
            area.AxisY.Title = "Tổng tiền (VNĐ)";
            chartDoanhThuNhanVien.ChartAreas.Add(area);

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.Orange;
            series.IsValueShownAsLabel = true;

            foreach (var nv in data)
            {
                string label = $"{nv.NgayTao} ({nv.HoTen})";
                decimal tongTien = 0;
                Decimal.TryParse(nv.TongTien.Replace(",", ""), out tongTien);

                series.Points.AddXY(label, tongTien);
            }

            chartDoanhThuNhanVien.Series.Add(series);

            if (data.Count > 0)
                chartDoanhThuNhanVien.Titles.Add($"Doanh thu nhân viên từ {data[0].NgayTao} đến {data[data.Count - 1].NgayTao}");
            else
                chartDoanhThuNhanVien.Titles.Add("Không có dữ liệu");
        }
    }
}
