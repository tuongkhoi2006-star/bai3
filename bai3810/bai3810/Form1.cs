namespace bai3810
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // initialize defaults
            cmbUnit.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var code = txtCode.Text.Trim();
            var name = txtName.Text.Trim();
            var unit = cmbUnit.SelectedItem?.ToString() ?? string.Empty;
            var price = nudPrice.Value;

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Mã vật tư không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FindItemByCode(code) != null)
            {
                MessageBox.Show("Mã vật tư đã tồn tại trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lvi = new ListViewItem(code);
            lvi.SubItems.Add(name);
            lvi.SubItems.Add(unit);
            lvi.SubItems.Add(price.ToString("N2"));
            listViewItems.Items.Add(lvi);
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = listViewItems.SelectedItems[0];
            var newCode = txtCode.Text.Trim();
            if (string.IsNullOrEmpty(newCode))
            {
                MessageBox.Show("Mã vật tư không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If code changed, ensure no duplicate
            if (!string.Equals(selected.SubItems[0].Text, newCode, StringComparison.OrdinalIgnoreCase))
            {
                if (FindItemByCode(newCode) != null)
                {
                    MessageBox.Show("Mã vật tư mới đã tồn tại trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            selected.SubItems[0].Text = newCode;
            selected.SubItems[1].Text = txtName.Text.Trim();
            selected.SubItems[2].Text = cmbUnit.SelectedItem?.ToString() ?? string.Empty;
            selected.SubItems[3].Text = nudPrice.Value.ToString("N2");
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn xóa dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                listViewItems.Items.Remove(listViewItems.SelectedItems[0]);
                ClearInputs();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (listViewItems.Items.Count == 0) return;
            var result = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                listViewItems.Items.Clear();
                ClearInputs();
            }
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                return;
            }

            var it = listViewItems.SelectedItems[0];
            txtCode.Text = it.SubItems[0].Text;
            txtName.Text = it.SubItems[1].Text;
            var unit = it.SubItems[2].Text;
            if (!string.IsNullOrEmpty(unit) && cmbUnit.Items.Contains(unit))
                cmbUnit.SelectedItem = unit;
            else if (cmbUnit.Items.Count > 0)
                cmbUnit.SelectedIndex = 0;

            if (decimal.TryParse(it.SubItems[3].Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out var price))
                nudPrice.Value = price;
            else
                nudPrice.Value = 0;
        }

        private ListViewItem? FindItemByCode(string code)
        {
            foreach (ListViewItem it in listViewItems.Items)
            {
                if (string.Equals(it.SubItems[0].Text, code, StringComparison.OrdinalIgnoreCase))
                    return it;
            }
            return null;
        }

        private void ClearInputs()
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            if (cmbUnit.Items.Count > 0) cmbUnit.SelectedIndex = 0;
            nudPrice.Value = 0;
            listViewItems.SelectedItems.Clear();
            txtCode.Focus();
        }
    }
}
