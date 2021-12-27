using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmOtherOperations : Form
    {
        DoublyLinkedList ListCB;
        DoublyLinkedList ListCB1;
        DoublyLinkedList ListCB2;
        private string maChuyenBay;
        private string tenCoTruong;
        private string diemDau;
        private string diemCuoi;
        private DateTime thoiGianKH;
        public frmOtherOperations(DoublyLinkedList ListCB)
        {
            InitializeComponent();
            this.ListCB = ListCB;
            addDatatoDGV(dgv1, ListCB);
        }
        private void addDatatoDGV(DataGridView dgv, DoublyLinkedList list)
        {
            Node p = list.Head;
            while (p != null && p != list.Tail.Next)
            {
                dgv.Rows.Add(p.Data.maChuyenBay, p.Data.tenCoTruong, p.Data.TGKhoiHanh, p.Data.diemDau, p.Data.diemCuoi);
                p = p.Next;
            }
        }
        private void btnTach_Click(object sender, EventArgs e)
        {
            dgv2.Rows.Clear();
            dgv2.Refresh();
            dgv3.Rows.Clear();
            dgv3.Refresh();

            Flight b = new Flight();
            b.maChuyenBay = maChuyenBay;
            b.diemDau = diemDau;
            b.tenCoTruong = tenCoTruong;
            b.diemCuoi = diemCuoi;
            b.TGKhoiHanh = thoiGianKH;

            ListCB1 = ListCB;
            ListCB2 = ListCB1.tach(ListCB1, b);
            ListCB1 = ListCB;

            addDatatoDGV(dgv2, ListCB1);
            addDatatoDGV(dgv3, ListCB2);

            

            dgv6.Rows.Clear();
            dgv6.Refresh();

            
            ListCB1 = ListCB1.hop(ListCB1, ListCB2);
            addDatatoDGV(dgv1, ListCB1);
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv1.Rows[e.RowIndex];
                maChuyenBay = row.Cells[0].Value.ToString();
                tenCoTruong = row.Cells[1].Value.ToString();
                diemDau = row.Cells[3].Value.ToString();
                diemCuoi = row.Cells[4].Value.ToString();
                thoiGianKH = DateTime.Parse(row.Cells[2].Value.ToString());
            }
        }

        private void btnHop_Click(object sender, EventArgs e)
        {
            dgv6.Rows.Clear();
            dgv6.Refresh();

            ListCB2 = ListCB2.hop(ListCB2, ListCB1);
            addDatatoDGV(dgv6, ListCB2);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            addDatatoDGV(dgv1, ListCB);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dgv4.Rows.Clear();
            dgv4.Refresh();
            dgv5.Rows.Clear();
            dgv5.Refresh();
            addDatatoDGV(dgv4, ListCB1);
            addDatatoDGV(dgv5, ListCB2);
        }
    }
}
