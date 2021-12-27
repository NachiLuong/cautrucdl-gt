using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmLinkedList : Form
    {

        // TẠO DANH SÁCH
        DoublyLinkedList ListCB = new DoublyLinkedList();
        public static List<Flight> dsChuyenBay = new List<Flight>();
        private string maChuyenBay;
        private string tenCoTruong;
        private string diemDau;
        private string diemCuoi;
        private DateTime thoiGianKH;
        public frmLinkedList()
        {
            InitializeComponent();
            rbHead.Checked = true;
            taoDSChuyenBay();
            addList(ListCB);
            addDatatoDGV();
        }
        private void addDatatoDGV()
        {
            Node p = ListCB.Head;
            while (p != null)
            {
                dataGridView1.Rows.Add(p.Data.maChuyenBay, p.Data.tenCoTruong, p.Data.TGKhoiHanh, p.Data.diemDau, p.Data.diemCuoi);
                p = p.Next;
            }
        }

        private void taoDSChuyenBay()
        {
            dsChuyenBay.Add(new Flight("CB001", new DateTime(2021, 04, 03, 07, 30, 00), "Huỳnh Lý Đông Phương", "SB Tân Sơn Nhất, TP.HCM ", "SB Nội Bài, Hà Nội", 1100000));
            dsChuyenBay.Add(new Flight("CB002", new DateTime(2021, 05, 02, 09, 00, 00), "Nguyễn Nam Liên", "SB Nội Bài, Hà Nội", "SB Đà Nẵng, Đà Nẵng", 900000));
            dsChuyenBay.Add(new Flight("CB003", new DateTime(2021, 05, 14, 14, 00, 00), "Trần Hữu Phương", "SB Tân Sơn Nhất, TP.HCM", "SB Jo F Kennedy , New York, Mỹ", 15000000));
            dsChuyenBay.Add(new Flight("CB004", new DateTime(2021, 06, 02, 04, 12, 00), "Nguyễn Tất Đạt", "SB Nội Bài, Hà Nội", "SB Hartsfield-Jackson Atlanta, Georgia, Mỹ", 15500000));
            dsChuyenBay.Add(new Flight("CB005", new DateTime(2021, 06, 02, 12, 20, 00), "Phùng Văn Bá", "SB Đà Nẵng, Đà Nẵng", "SB Phú Quốc, Kiên Giang", 800000));
            dsChuyenBay.Add(new Flight("CB006", new DateTime(2021, 06, 02, 23, 30, 00), "Phan Văn Kiệt", "SB Phú Bài, Thừa Thiên Huế", "SB Tân Sơn Nhất, TP.HCM", 700000));
            dsChuyenBay.Add(new Flight("CB007", new DateTime(2021, 07, 15, 03, 00, 00), "Đặng Cảnh Trâm", "SB Nội Bài, Hà Nội", "SB Kursk, Kursk, Nga", 13000000));
            dsChuyenBay.Add(new Flight("CB008", new DateTime(2021, 08, 15, 16, 30, 00), "Châu Minh Toàn", "SB Tân Sơn Nhất, TP.HCM", "SB Gimhae, Busan, Hàn Quốc", 4000000));
            dsChuyenBay.Add(new Flight("CB009", new DateTime(2021, 08, 17, 16, 00, 00), "Nguyễn Huỳnh Thắng", "SB Côn Đảo, Bà Rịa-Vũng Tàu", "SB Nội Bài, Hà Nội", 1100000));
            dsChuyenBay.Add(new Flight("CB010", new DateTime(2021, 09, 12, 06, 30, 00), "Phan Nhật Hào", "SB Tân Sơn Nhất, TP.HCM", "SB Quốc tế Thủ đô Bắc Kinh, Bắc Kinh, Trung Quốc", 6600000));
            dsChuyenBay.Add(new Flight("CB011", new DateTime(2021, 09, 19, 10, 30, 00), "Bùi Duy Nghĩa", "SB Nội Bài, Hà Nội", "SB Quốc tế Giang Bắc Trùng Khánh, Trùng Khánh, Trung Quốc", 3900000));
            dsChuyenBay.Add(new Flight("CB012", new DateTime(2021, 09, 25, 14, 30, 00), "Lê Đoan Phùng", "SB Tân Sơn Nhất, TP.HCM", "SB Kloten,Bang Kloten, Thụy Sỹ", 9600000));
            dsChuyenBay.Add(new Flight("CB013", new DateTime(2021, 10, 15, 12, 30, 00), "Trần Nguyên Đại", "SB Nội Bài, Hà Nội", "SB Quốc tế BangKok, Bangkok, Thái Lan", 3000000));
            dsChuyenBay.Add(new Flight("CB014", new DateTime(2021, 10, 15, 18, 20, 00), "Vũ Văn Nguyên", "SB Nội Bài, Hà Nội", "SB Quốc tế Paris Charles de Gaulle, Paris, Pháp", 13500000));
            dsChuyenBay.Add(new Flight("CB015", new DateTime(2021, 02, 20, 20, 30, 00), "Đào Quang Chính", "SB Tân Sơn Nhất, TP.HCM", "SB London Heathrow, Luân Đôn, Anh Quốc", 8900000));
            dsChuyenBay.Add(new Flight("CB016", new DateTime(2021, 11, 22, 09, 00, 00), "Phan Duy Liêm", "SB Nội Bài, Hà Nội", "SB Đà Nẵng, Đà Nẵng", 560000));
            dsChuyenBay.Add(new Flight("CB017", new DateTime(2021, 11, 29, 17, 30, 00), "Tô Hải Nam", "SB Phú Quốc, Kiên Giang", "SB Đà Nẵng, Đà Nẵng", 1300000));
            dsChuyenBay.Add(new Flight("CB018", new DateTime(2021, 12, 04, 21, 00, 00), "Nguyễn Trần Minh", "SB Vinh, Nghệ An", "SB Tân Sơn Nhất, TP.HCM", 1200000));
            dsChuyenBay.Add(new Flight("CB019", new DateTime(2021, 12, 09, 07, 30, 00), "Đặng Hào Kiệt", "SB Phú Bài, Thừa Thiên Huế", "SB Tân Sơn Nhất, TP.HCM", 1250000));
            dsChuyenBay.Add(new Flight("CB020", new DateTime(2022, 01, 28, 10, 30, 00), "Phan Hữu Phong", "SB Tuy Hòa, Phú Yên", "SB Nội Bài, Hà Nội", 550000));
        }

        private void addList(DoublyLinkedList ListCB)
        {
            //thêm vô đầu list
            for (int i = 5; i >= 0; i--)
            {
                ListCB.addHead(dsChuyenBay[i]);
            }

            //thêm vào cuối list
            for (int i = 6; i < 16; i++)
            {
                ListCB.addTail(dsChuyenBay[i]);
            }
            Node a1 = new Node(dsChuyenBay[16]);
            Node a2 = new Node(dsChuyenBay[18]);

            ListCB.addTail(a1);//them kieu node
            ListCB.addTail(a2);
            ListCB.addAfter(dsChuyenBay[17], dsChuyenBay[16]);
          
        }
       
      
        public static void search(DoublyLinkedList ListCB)
        {
            Console.WriteLine("\n---TÌM KIẾM\n");

            // Tìm kiếm CB004
            Console.WriteLine("    - TÌM KIẾM CHUYẾN BAY CB004\n");
            Node srch = ListCB.searchNode(dsChuyenBay[3]);
            if (srch == null)
                Console.WriteLine("\tKhông thấy Node cần tìm trong danh sách");
            else
                Console.WriteLine("\tChuyến bay {0} có trong danh sách", srch.Data.maChuyenBay);

            // Tìm những chuyến bay xuát phát từ sân bay nội bài
            DoublyLinkedList list = ListCB.searchdDau("SB Nội Bài, Hà Nội");
            Console.WriteLine("\n    - NHỮNG CHUYẾN BAY XUẤT PHÁT TỪ SÂN BAY NỘI BÀI");
            list.print();
        }
        private void hoatDong(DoublyLinkedList ListCB)
        {

            // TÁCH DANH SÁCH
            DoublyLinkedList ListCB2 = new DoublyLinkedList();
            ListCB2 = ListCB.tach(ListCB, dsChuyenBay[10]);
            Console.WriteLine("    - DANH SÁCH SAU KHI TÁCH TỪ CB011\n");
            Console.WriteLine("\tList1");
            ListCB.print();
            Console.WriteLine("\tList2");
            ListCB2.print();

            // HỢP NHẤT DANH SÁCH
            Console.WriteLine("    - DANH SÁCH SAU KHI HỢP NHẤT\n");
            ListCB = ListCB.hop(ListCB, ListCB2);
            ListCB.print();

            // XÓA TẤT CẢ CÁC CHUYẾN BAY CÓ NGÀY KHỞI HÀNH TRƯỚC 28/9/2021
            Console.WriteLine("    - DANH SÁCH SAU KHI XÓA TẤT CẢ CÁC CHUYẾN BAY TRƯỚC NGÀY 28/9/2021");
            ListCB.removeCB();
            ListCB.printTG();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbHead.Checked) //thêm đầu
            {
                Flight a = new Flight();
                a.maChuyenBay = txbFlightCode.Text;
                a.diemDau = txbDeparture.Text;
                a.diemCuoi = txbDestination.Text;
                a.tenCoTruong = txbCaptainName.Text;
                a.TGKhoiHanh = dtDepartureDay.Value;
                ListCB.addHead(a);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                addDatatoDGV();
            }
            if (rbNext.Checked) // thêm sau
            {
                Flight a = new Flight();
                a.maChuyenBay = txbFlightCode.Text;
                a.diemDau = txbDeparture.Text;
                a.diemCuoi = txbDestination.Text;
                a.tenCoTruong = txbCaptainName.Text;
                a.TGKhoiHanh = dtDepartureDay.Value;

                Flight b = new Flight();
                b.maChuyenBay = maChuyenBay;
                b.diemDau = diemDau;
                b.tenCoTruong = tenCoTruong;
                b.diemCuoi = diemCuoi;
                b.TGKhoiHanh = thoiGianKH;
                b.giaVeMacDinh = 0;
               
               
                ListCB.addAfter(a, b);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                addDatatoDGV();
            }
            if (rbTail.Checked) // thêm cuối
            {
                Flight a = new Flight();
                a.maChuyenBay = txbFlightCode.Text;
                a.diemDau = txbDeparture.Text;
                a.diemCuoi = txbDestination.Text;
                a.tenCoTruong = txbCaptainName.Text;
                a.TGKhoiHanh = dtDepartureDay.Value;
                ListCB.addTail(a);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                addDatatoDGV();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (rbHead.Checked) //xóa đầu
            {
                ListCB.removeHead();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                addDatatoDGV();
            }
            if (rbNext.Checked) // xóa sau
            {
                Flight a = new Flight();
                a.maChuyenBay = txbFlightCode.Text;
                a.diemDau = txbDeparture.Text;
                a.diemCuoi = txbDestination.Text;
                a.tenCoTruong = txbCaptainName.Text;
                a.TGKhoiHanh = dtDepartureDay.Value;

                Flight b = new Flight();
                b.maChuyenBay = maChuyenBay;
                b.diemDau = diemDau;
                b.tenCoTruong = tenCoTruong;
                b.diemCuoi = diemCuoi;
                b.TGKhoiHanh = thoiGianKH;
                b.giaVeMacDinh = 0;


                ListCB.removeAfter(b);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                addDatatoDGV();
            }
            if (rbTail.Checked) // xóa cuối
            {
                ListCB.removeTail();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                addDatatoDGV();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Flight a = new Flight();
            a.maChuyenBay = txbFlightCode.Text;
            a.diemDau = txbDeparture.Text;
            a.diemCuoi = txbDestination.Text;
            a.tenCoTruong = txbCaptainName.Text;
            a.TGKhoiHanh = dtDepartureDay.Value;

            Flight b = new Flight();
            b.maChuyenBay = maChuyenBay;
            b.diemDau = diemDau;
            b.tenCoTruong = tenCoTruong;
            b.diemCuoi = diemCuoi;
            b.TGKhoiHanh = thoiGianKH;

            ListCB.editNode(b, a);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            addDatatoDGV();
        }

        private void btnEnforcement_Click(object sender, EventArgs e)
        {

        }

        private void btnOperationOther_Click(object sender, EventArgs e)
        {

            frmOtherOperations f = new frmOtherOperations(ListCB);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLinkedList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //data binding, chiếu từ bảng (datagridview) sang cái ô bên cạch
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txbFlightCode.Text = row.Cells[0].Value.ToString();
                txbCaptainName.Text = row.Cells[1].Value.ToString();
                dtDepartureDay.Text = row.Cells[2].Value.ToString();
                txbDeparture.Text = row.Cells[3].Value.ToString();
                txbDestination.Text = row.Cells[4].Value.ToString();

                maChuyenBay = row.Cells[0].Value.ToString();
                tenCoTruong = row.Cells[1].Value.ToString();
                diemDau = row.Cells[3].Value.ToString();
                diemCuoi = row.Cells[4].Value.ToString();
                thoiGianKH = DateTime.Parse(row.Cells[2].Value.ToString());
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSort.Text == "Mã chuyến bay")
            {
                ListCB.selectionSort(ListCB);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                addDatatoDGV();
            }
            if (cbSort.Text == "Tên cơ trưởng")
            {
                ListCB.quickSort(ListCB);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                addDatatoDGV();
            }
            if (cbSort.Text == "Thời gian khởi hành")
            {

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                addDatatoDGV();
            }
            if (cbSort.Text == "Giá vé")
            {

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                addDatatoDGV();
            }
            
        }
    }
}
