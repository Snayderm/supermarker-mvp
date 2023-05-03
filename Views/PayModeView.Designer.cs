namespace Supermarker_mvp.Views
{
	partial class PayModeView
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
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			TabControl = new TabControl();
			tabPagePayModeList = new TabPage();
			BtnClose = new Button();
			BtnDelete = new Button();
			BtnEdit = new Button();
			BtnNew = new Button();
			DgPayMode = new DataGridView();
			BtnSearch = new Button();
			TxtSearch = new TextBox();
			Label = new Label();
			tabPagePayModeDetail = new TabPage();
			label4 = new Label();
			label3 = new Label();
			TxtPayModeObservation = new TextBox();
			TxtPayModeName = new TextBox();
			TxtPayModeId = new TextBox();
			label2 = new Label();
			BtnSave = new Button();
			BtnCancel = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			TabControl.SuspendLayout();
			tabPagePayModeList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
			tabPagePayModeDetail.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 100);
			panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.buy;
			pictureBox1.Location = new Point(3, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(147, 94);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Stencil", 30F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(156, 28);
			label1.Name = "label1";
			label1.Size = new Size(209, 47);
			label1.TabIndex = 0;
			label1.Text = "Pay Mode";
			// 
			// TabControl
			// 
			TabControl.Controls.Add(tabPagePayModeList);
			TabControl.Controls.Add(tabPagePayModeDetail);
			TabControl.Dock = DockStyle.Fill;
			TabControl.Location = new Point(0, 100);
			TabControl.Name = "TabControl";
			TabControl.SelectedIndex = 0;
			TabControl.Size = new Size(800, 350);
			TabControl.TabIndex = 1;
			// 
			// tabPagePayModeList
			// 
			tabPagePayModeList.Controls.Add(BtnClose);
			tabPagePayModeList.Controls.Add(BtnDelete);
			tabPagePayModeList.Controls.Add(BtnEdit);
			tabPagePayModeList.Controls.Add(BtnNew);
			tabPagePayModeList.Controls.Add(DgPayMode);
			tabPagePayModeList.Controls.Add(BtnSearch);
			tabPagePayModeList.Controls.Add(TxtSearch);
			tabPagePayModeList.Controls.Add(Label);
			tabPagePayModeList.Location = new Point(4, 24);
			tabPagePayModeList.Name = "tabPagePayModeList";
			tabPagePayModeList.Padding = new Padding(3);
			tabPagePayModeList.Size = new Size(792, 322);
			tabPagePayModeList.TabIndex = 0;
			tabPagePayModeList.Text = "Pay Mode List";
			tabPagePayModeList.UseVisualStyleBackColor = true;
			// 
			// BtnClose
			// 
			BtnClose.Image = Properties.Resources.cerrar;
			BtnClose.Location = new Point(687, 212);
			BtnClose.Name = "BtnClose";
			BtnClose.Size = new Size(89, 58);
			BtnClose.TabIndex = 7;
			BtnClose.UseVisualStyleBackColor = true;
			// 
			// BtnDelete
			// 
			BtnDelete.Image = Properties.Resources.delete;
			BtnDelete.Location = new Point(587, 212);
			BtnDelete.Name = "BtnDelete";
			BtnDelete.Size = new Size(89, 58);
			BtnDelete.TabIndex = 6;
			BtnDelete.UseVisualStyleBackColor = true;
			// 
			// BtnEdit
			// 
			BtnEdit.Image = Properties.Resources.edit;
			BtnEdit.Location = new Point(687, 111);
			BtnEdit.Name = "BtnEdit";
			BtnEdit.Size = new Size(89, 58);
			BtnEdit.TabIndex = 5;
			BtnEdit.UseVisualStyleBackColor = true;
			// 
			// BtnNew
			// 
			BtnNew.Image = Properties.Resources.new1;
			BtnNew.Location = new Point(587, 111);
			BtnNew.Name = "BtnNew";
			BtnNew.Size = new Size(89, 58);
			BtnNew.TabIndex = 4;
			BtnNew.UseVisualStyleBackColor = true;
			// 
			// DgPayMode
			// 
			DgPayMode.AllowUserToAddRows = false;
			DgPayMode.AllowUserToDeleteRows = false;
			DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DgPayMode.Location = new Point(20, 80);
			DgPayMode.Name = "DgPayMode";
			DgPayMode.ReadOnly = true;
			DgPayMode.RowTemplate.Height = 25;
			DgPayMode.Size = new Size(548, 234);
			DgPayMode.TabIndex = 3;
			// 
			// BtnSearch
			// 
			BtnSearch.Image = Properties.Resources.search_small;
			BtnSearch.Location = new Point(587, 18);
			BtnSearch.Name = "BtnSearch";
			BtnSearch.Size = new Size(51, 44);
			BtnSearch.TabIndex = 2;
			BtnSearch.UseVisualStyleBackColor = true;
			// 
			// TxtSearch
			// 
			TxtSearch.Location = new Point(20, 30);
			TxtSearch.Multiline = true;
			TxtSearch.Name = "TxtSearch";
			TxtSearch.PlaceholderText = "Data to search";
			TxtSearch.Size = new Size(548, 29);
			TxtSearch.TabIndex = 1;
			// 
			// Label
			// 
			Label.AutoSize = true;
			Label.Location = new Point(20, 12);
			Label.Name = "Label";
			Label.Size = new Size(94, 15);
			Label.TabIndex = 0;
			Label.Text = "Seach Pay Mode";
			// 
			// tabPagePayModeDetail
			// 
			tabPagePayModeDetail.Controls.Add(BtnCancel);
			tabPagePayModeDetail.Controls.Add(BtnSave);
			tabPagePayModeDetail.Controls.Add(label4);
			tabPagePayModeDetail.Controls.Add(label3);
			tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
			tabPagePayModeDetail.Controls.Add(TxtPayModeName);
			tabPagePayModeDetail.Controls.Add(TxtPayModeId);
			tabPagePayModeDetail.Controls.Add(label2);
			tabPagePayModeDetail.Location = new Point(4, 24);
			tabPagePayModeDetail.Name = "tabPagePayModeDetail";
			tabPagePayModeDetail.Padding = new Padding(3);
			tabPagePayModeDetail.Size = new Size(792, 322);
			tabPagePayModeDetail.TabIndex = 1;
			tabPagePayModeDetail.Text = "Pay Mode Detail";
			tabPagePayModeDetail.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(26, 141);
			label4.Name = "label4";
			label4.Size = new Size(75, 15);
			label4.TabIndex = 5;
			label4.Text = "Pay Mode Id";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(26, 80);
			label3.Name = "label3";
			label3.Size = new Size(75, 15);
			label3.TabIndex = 4;
			label3.Text = "Pay Mode Id";
			// 
			// TxtPayModeObservation
			// 
			TxtPayModeObservation.Location = new Point(26, 168);
			TxtPayModeObservation.Multiline = true;
			TxtPayModeObservation.Name = "TxtPayModeObservation";
			TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
			TxtPayModeObservation.Size = new Size(309, 69);
			TxtPayModeObservation.TabIndex = 3;
			// 
			// TxtPayModeName
			// 
			TxtPayModeName.Location = new Point(26, 98);
			TxtPayModeName.Name = "TxtPayModeName";
			TxtPayModeName.PlaceholderText = "Pay Mode Name";
			TxtPayModeName.Size = new Size(309, 23);
			TxtPayModeName.TabIndex = 2;
			// 
			// TxtPayModeId
			// 
			TxtPayModeId.Location = new Point(26, 38);
			TxtPayModeId.Name = "TxtPayModeId";
			TxtPayModeId.Size = new Size(100, 23);
			TxtPayModeId.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(26, 20);
			label2.Name = "label2";
			label2.Size = new Size(75, 15);
			label2.TabIndex = 0;
			label2.Text = "Pay Mode Id";
			// 
			// BtnSave
			// 
			BtnSave.Image = Properties.Resources.save;
			BtnSave.Location = new Point(26, 254);
			BtnSave.Name = "BtnSave";
			BtnSave.Size = new Size(75, 42);
			BtnSave.TabIndex = 6;
			BtnSave.UseVisualStyleBackColor = true;
			// 
			// BtnCancel
			// 
			BtnCancel.Image = Properties.Resources.cancel;
			BtnCancel.Location = new Point(134, 254);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(75, 42);
			BtnCancel.TabIndex = 7;
			BtnCancel.UseVisualStyleBackColor = true;
			// 
			// PayModeView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(TabControl);
			Controls.Add(panel1);
			Name = "PayModeView";
			Text = "Pay Mode Management";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			TabControl.ResumeLayout(false);
			tabPagePayModeList.ResumeLayout(false);
			tabPagePayModeList.PerformLayout();
			((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
			tabPagePayModeDetail.ResumeLayout(false);
			tabPagePayModeDetail.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label1;
		private TabControl TabControl;
		private TabPage tabPagePayModeList;
		private Button BtnClose;
		private Button BtnDelete;
		private Button BtnEdit;
		private Button BtnNew;
		private DataGridView DgPayMode;
		private Button BtnSearch;
		private TextBox TxtSearch;
		private Label Label;
		private TabPage tabPagePayModeDetail;
		private Label label4;
		private Label label3;
		private TextBox TxtPayModeObservation;
		private TextBox TxtPayModeName;
		private TextBox TxtPayModeId;
		private Label label2;
		private Button BtnCancel;
		private Button BtnSave;
	}
}