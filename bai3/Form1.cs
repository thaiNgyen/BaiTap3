using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // tạo 1 dòng
            ListViewItem lvi = new ListViewItem(txtSTT.Text);

            // thêm cột còn lại
            lvi.SubItems.Add(txtMa.Text);
            lvi.SubItems.Add(txtTen.Text);

            // đưa một dòng vào ListView
            lvSanPham.Items.Add(lvi);
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = lvSanPham.SelectedItems[0];
                string STT = lv1.SubItems[0].Text;
                string Ma = lv1.SubItems[1].Text;
                string Ten = lv1.SubItems[2].Text;

                // Display the information in a message box
                // MessageBox.Show($"Mã: {ma}\nTên: {ten}\nGiá: {gia}");

                // Update text boxes
                txtSTT.Text = STT;
                txtMa.Text = Ma;
                txtTen.Text = Ten;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Check if any items are selected
            if (lvSanPham.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = lvSanPham.SelectedItems[0];

                // Output the index of the selected item to the console
                Console.WriteLine($"Selected item index: {selectedItem.Index}");

                // Remove the selected item from the ListView
                lvSanPham.Items.RemoveAt(selectedItem.Index);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                if (lvSanPham.SelectedItems.Count > 0)
                {
                    // Get the selected item
                    var selectedItem = lvSanPham.SelectedItems[0];

                    // Set the sub-item text
                    selectedItem.SubItems[0].Text = txtSTT.Text;
                    selectedItem.SubItems[1].Text = txtMa.Text;
                    selectedItem.SubItems[2].Text = txtTen.Text;
                }
            
        }
    }
}
