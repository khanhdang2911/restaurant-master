﻿namespace winform_project
{
    partial class QuanLiHoaDon_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiHoaDon_form));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_xoaNhanVien = new System.Windows.Forms.Button();
            this.lbl_tenban = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_tongtien = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ngayban = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_tenban = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_tongtien = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_ngayban = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dtg_listHoaDon = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xoaNhanVien
            // 
            this.btn_xoaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoaNhanVien.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaNhanVien.Location = new System.Drawing.Point(20, 176);
            this.btn_xoaNhanVien.Name = "btn_xoaNhanVien";
            this.btn_xoaNhanVien.Size = new System.Drawing.Size(94, 37);
            this.btn_xoaNhanVien.TabIndex = 37;
            this.btn_xoaNhanVien.Text = "Xóa";
            this.btn_xoaNhanVien.UseVisualStyleBackColor = false;
            this.btn_xoaNhanVien.Click += new System.EventHandler(this.btn_xoaNhanVien_Click);
            // 
            // lbl_tenban
            // 
            this.lbl_tenban.AllowParentOverrides = false;
            this.lbl_tenban.AutoEllipsis = false;
            this.lbl_tenban.AutoSize = false;
            this.lbl_tenban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_tenban.CursorType = null;
            this.lbl_tenban.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenban.Location = new System.Drawing.Point(363, 25);
            this.lbl_tenban.Name = "lbl_tenban";
            this.lbl_tenban.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tenban.Size = new System.Drawing.Size(113, 36);
            this.lbl_tenban.TabIndex = 33;
            this.lbl_tenban.Text = "Tên bàn";
            this.lbl_tenban.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_tenban.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AllowParentOverrides = false;
            this.lbl_tongtien.AutoEllipsis = true;
            this.lbl_tongtien.AutoSize = false;
            this.lbl_tongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_tongtien.CursorType = null;
            this.lbl_tongtien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongtien.Location = new System.Drawing.Point(20, 103);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tongtien.Size = new System.Drawing.Size(94, 36);
            this.lbl_tongtien.TabIndex = 27;
            this.lbl_tongtien.Text = "Tổng tiền";
            this.lbl_tongtien.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_tongtien.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_ngayban
            // 
            this.lbl_ngayban.AllowParentOverrides = false;
            this.lbl_ngayban.AutoEllipsis = false;
            this.lbl_ngayban.AutoSize = false;
            this.lbl_ngayban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_ngayban.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ngayban.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_ngayban.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayban.Location = new System.Drawing.Point(20, 25);
            this.lbl_ngayban.Name = "lbl_ngayban";
            this.lbl_ngayban.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ngayban.Size = new System.Drawing.Size(94, 36);
            this.lbl_ngayban.TabIndex = 26;
            this.lbl_ngayban.Text = "Ngày bán";
            this.lbl_ngayban.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ngayban.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_tenban
            // 
            this.txt_tenban.AcceptsReturn = false;
            this.txt_tenban.AcceptsTab = false;
            this.txt_tenban.AnimationSpeed = 200;
            this.txt_tenban.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_tenban.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_tenban.BackColor = System.Drawing.Color.Transparent;
            this.txt_tenban.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_tenban.BackgroundImage")));
            this.txt_tenban.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_tenban.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_tenban.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_tenban.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_tenban.BorderRadius = 1;
            this.txt_tenban.BorderThickness = 1;
            this.txt_tenban.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_tenban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenban.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenban.DefaultText = "";
            this.txt_tenban.FillColor = System.Drawing.Color.White;
            this.txt_tenban.HideSelection = true;
            this.txt_tenban.IconLeft = null;
            this.txt_tenban.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenban.IconPadding = 10;
            this.txt_tenban.IconRight = null;
            this.txt_tenban.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenban.Lines = new string[0];
            this.txt_tenban.Location = new System.Drawing.Point(482, 25);
            this.txt_tenban.MaxLength = 32767;
            this.txt_tenban.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_tenban.Modified = false;
            this.txt_tenban.Multiline = false;
            this.txt_tenban.Name = "txt_tenban";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenban.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_tenban.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenban.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenban.OnIdleState = stateProperties16;
            this.txt_tenban.Padding = new System.Windows.Forms.Padding(3);
            this.txt_tenban.PasswordChar = '\0';
            this.txt_tenban.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_tenban.PlaceholderText = "";
            this.txt_tenban.ReadOnly = true;
            this.txt_tenban.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tenban.SelectedText = "";
            this.txt_tenban.SelectionLength = 0;
            this.txt_tenban.SelectionStart = 0;
            this.txt_tenban.ShortcutsEnabled = true;
            this.txt_tenban.Size = new System.Drawing.Size(244, 36);
            this.txt_tenban.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_tenban.TabIndex = 31;
            this.txt_tenban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tenban.TextMarginBottom = 0;
            this.txt_tenban.TextMarginLeft = 3;
            this.txt_tenban.TextMarginTop = 0;
            this.txt_tenban.TextPlaceholder = "";
            this.txt_tenban.UseSystemPasswordChar = false;
            this.txt_tenban.WordWrap = true;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.AcceptsReturn = false;
            this.txt_tongtien.AcceptsTab = false;
            this.txt_tongtien.AnimationSpeed = 200;
            this.txt_tongtien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_tongtien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_tongtien.BackColor = System.Drawing.Color.Transparent;
            this.txt_tongtien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_tongtien.BackgroundImage")));
            this.txt_tongtien.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_tongtien.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_tongtien.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_tongtien.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_tongtien.BorderRadius = 1;
            this.txt_tongtien.BorderThickness = 1;
            this.txt_tongtien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_tongtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tongtien.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.DefaultText = "";
            this.txt_tongtien.FillColor = System.Drawing.Color.White;
            this.txt_tongtien.HideSelection = true;
            this.txt_tongtien.IconLeft = null;
            this.txt_tongtien.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tongtien.IconPadding = 10;
            this.txt_tongtien.IconRight = null;
            this.txt_tongtien.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tongtien.Lines = new string[0];
            this.txt_tongtien.Location = new System.Drawing.Point(120, 103);
            this.txt_tongtien.MaxLength = 32767;
            this.txt_tongtien.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_tongtien.Modified = false;
            this.txt_tongtien.Multiline = false;
            this.txt_tongtien.Name = "txt_tongtien";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tongtien.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_tongtien.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tongtien.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tongtien.OnIdleState = stateProperties20;
            this.txt_tongtien.Padding = new System.Windows.Forms.Padding(3);
            this.txt_tongtien.PasswordChar = '\0';
            this.txt_tongtien.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_tongtien.PlaceholderText = "";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tongtien.SelectedText = "";
            this.txt_tongtien.SelectionLength = 0;
            this.txt_tongtien.SelectionStart = 0;
            this.txt_tongtien.ShortcutsEnabled = true;
            this.txt_tongtien.Size = new System.Drawing.Size(215, 36);
            this.txt_tongtien.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_tongtien.TabIndex = 29;
            this.txt_tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tongtien.TextMarginBottom = 0;
            this.txt_tongtien.TextMarginLeft = 3;
            this.txt_tongtien.TextMarginTop = 0;
            this.txt_tongtien.TextPlaceholder = "";
            this.txt_tongtien.UseSystemPasswordChar = false;
            this.txt_tongtien.WordWrap = true;
            // 
            // txt_ngayban
            // 
            this.txt_ngayban.AcceptsReturn = false;
            this.txt_ngayban.AcceptsTab = false;
            this.txt_ngayban.AnimationSpeed = 200;
            this.txt_ngayban.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_ngayban.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_ngayban.BackColor = System.Drawing.Color.Transparent;
            this.txt_ngayban.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_ngayban.BackgroundImage")));
            this.txt_ngayban.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_ngayban.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_ngayban.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_ngayban.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_ngayban.BorderRadius = 1;
            this.txt_ngayban.BorderThickness = 1;
            this.txt_ngayban.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ngayban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ngayban.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngayban.DefaultText = "";
            this.txt_ngayban.FillColor = System.Drawing.Color.White;
            this.txt_ngayban.HideSelection = true;
            this.txt_ngayban.IconLeft = null;
            this.txt_ngayban.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ngayban.IconPadding = 10;
            this.txt_ngayban.IconRight = null;
            this.txt_ngayban.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ngayban.Lines = new string[0];
            this.txt_ngayban.Location = new System.Drawing.Point(120, 25);
            this.txt_ngayban.MaxLength = 32767;
            this.txt_ngayban.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_ngayban.Modified = false;
            this.txt_ngayban.Multiline = false;
            this.txt_ngayban.Name = "txt_ngayban";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_ngayban.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_ngayban.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_ngayban.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_ngayban.OnIdleState = stateProperties24;
            this.txt_ngayban.Padding = new System.Windows.Forms.Padding(3);
            this.txt_ngayban.PasswordChar = '\0';
            this.txt_ngayban.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_ngayban.PlaceholderText = "";
            this.txt_ngayban.ReadOnly = true;
            this.txt_ngayban.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ngayban.SelectedText = "";
            this.txt_ngayban.SelectionLength = 0;
            this.txt_ngayban.SelectionStart = 0;
            this.txt_ngayban.ShortcutsEnabled = true;
            this.txt_ngayban.Size = new System.Drawing.Size(230, 36);
            this.txt_ngayban.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_ngayban.TabIndex = 28;
            this.txt_ngayban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ngayban.TextMarginBottom = 0;
            this.txt_ngayban.TextMarginLeft = 3;
            this.txt_ngayban.TextMarginTop = 0;
            this.txt_ngayban.TextPlaceholder = "";
            this.txt_ngayban.UseSystemPasswordChar = false;
            this.txt_ngayban.WordWrap = true;
            // 
            // dtg_listHoaDon
            // 
            this.dtg_listHoaDon.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dtg_listHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_listHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_listHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dtg_listHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_listHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_listHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_listHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_listHoaDon.ColumnHeadersHeight = 40;
            this.dtg_listHoaDon.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtg_listHoaDon.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_listHoaDon.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_listHoaDon.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtg_listHoaDon.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg_listHoaDon.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtg_listHoaDon.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtg_listHoaDon.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtg_listHoaDon.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtg_listHoaDon.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_listHoaDon.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtg_listHoaDon.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_listHoaDon.CurrentTheme.Name = null;
            this.dtg_listHoaDon.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_listHoaDon.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_listHoaDon.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_listHoaDon.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtg_listHoaDon.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_listHoaDon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_listHoaDon.EnableHeadersVisualStyles = false;
            this.dtg_listHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtg_listHoaDon.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtg_listHoaDon.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtg_listHoaDon.HeaderForeColor = System.Drawing.Color.White;
            this.dtg_listHoaDon.Location = new System.Drawing.Point(1, 252);
            this.dtg_listHoaDon.Name = "dtg_listHoaDon";
            this.dtg_listHoaDon.ReadOnly = true;
            this.dtg_listHoaDon.RowHeadersVisible = false;
            this.dtg_listHoaDon.RowTemplate.Height = 40;
            this.dtg_listHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_listHoaDon.Size = new System.Drawing.Size(765, 208);
            this.dtg_listHoaDon.TabIndex = 38;
            this.dtg_listHoaDon.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtg_listHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listHoaDon_CellContentClick);
            // 
            // QuanLiHoaDon_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 465);
            this.Controls.Add(this.dtg_listHoaDon);
            this.Controls.Add(this.btn_xoaNhanVien);
            this.Controls.Add(this.lbl_tenban);
            this.Controls.Add(this.txt_tenban);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.txt_ngayban);
            this.Controls.Add(this.lbl_tongtien);
            this.Controls.Add(this.lbl_ngayban);
            this.Name = "QuanLiHoaDon_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí hóa đơn";
            this.Load += new System.EventHandler(this.QuanLiHoaDon_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_xoaNhanVien;
        private Bunifu.UI.WinForms.BunifuLabel lbl_tenban;
        private Bunifu.UI.WinForms.BunifuTextBox txt_tenban;
        private Bunifu.UI.WinForms.BunifuTextBox txt_tongtien;
        private Bunifu.UI.WinForms.BunifuTextBox txt_ngayban;
        private Bunifu.UI.WinForms.BunifuLabel lbl_tongtien;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ngayban;
        private Bunifu.UI.WinForms.BunifuDataGridView dtg_listHoaDon;
    }
}