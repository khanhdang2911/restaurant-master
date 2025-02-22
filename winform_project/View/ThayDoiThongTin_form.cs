﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_project.Services;

namespace winform_project
{
    public partial class ThayDoiThongTin_form : Form
    {
        private readonly AppDbContext _context;
        private DoiMatKhau_form doiMatKhau_Form;
        private NguoiDung User { set; get; }
        public ThayDoiThongTin_form(NguoiDung _User)
        {
            User = _User;
            _context = DependencyContainer.Resolve<AppDbContext>();
            InitializeComponent();
        }
        public void LoadData()
        {
            txt_hoten.Text = User.HoTen;
            txt_phone.Text = User.Phone;
            txt_userName.Text = User.Username;
        }
        private void ThayDoiThongTin_form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

       

        private void btn_luuthongtin_Click(object sender, EventArgs e)
        {
            bool check = true;
            if(string.IsNullOrWhiteSpace(txt_hoten.Text))
            {
                check = false;
            }
            if(string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                check = false;
            }
            if(string.IsNullOrWhiteSpace(txt_userName.Text))
            {
                check = false;
            }
            if(check==false)
            {
                MessageBox.Show("Xin hãy nhập đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Check xem so dien thoai da co hay chua
                //Check sdt hop le hay khong
                bool checkSdt = _context.nguoiDungs.Any(c => c.Id != User.Id && c.Phone == txt_phone.Text);
                if (Validation.checkNumber(txt_phone.Text) == false)
                {
                    MessageBox.Show("Số điện thoại định dạng không hợp lệ, hãy nhập số khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else if(checkSdt==true)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại, hãy nhập số khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _context.Entry(User).State = System.Data.Entity.EntityState.Modified;
                    User.HoTen=txt_hoten.Text;
                    User.Phone = txt_phone.Text;
                    User.Username = txt_userName.Text;
                    _context.SaveChangesAsync();

                    MessageBox.Show("Sửa thành công.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void button_doimatkhau_Click(object sender, EventArgs e)
        {
            
            if(doiMatKhau_Form==null)
            {
                User = _context.nguoiDungs.Find(User.Id);
                doiMatKhau_Form = new DoiMatKhau_form(User);
                doiMatKhau_Form.FormBorderStyle = FormBorderStyle.Sizable;
                doiMatKhau_Form.FormClosed += ThayDoiThongTin_Form_FormClosed;
                doiMatKhau_Form.Show();
            }

        }
        private void ThayDoiThongTin_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            doiMatKhau_Form = null; 
        }
    }
}
