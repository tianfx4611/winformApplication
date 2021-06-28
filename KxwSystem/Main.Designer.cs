
namespace KxwSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSuitcaseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPlanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIsoCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResidualQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCompleteCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCreationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderNoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuitcaseNotext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PlanNotext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtOrderId,
            this.txtOrderNo,
            this.txtTypeCode,
            this.txtSuitcaseNo,
            this.txtPlanNo,
            this.txtIsoCode,
            this.txtTotalCount,
            this.txtBookCount,
            this.txtResidualQuantity,
            this.txtCompleteCount,
            this.txtCreationTime});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1429, 476);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtOrderId
            // 
            this.txtOrderId.DataPropertyName = "OrderId";
            this.txtOrderId.HeaderText = "订单编号";
            this.txtOrderId.MinimumWidth = 6;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Width = 125;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.DataPropertyName = "OrderNo";
            this.txtOrderNo.HeaderText = "订单号";
            this.txtOrderNo.MinimumWidth = 6;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Width = 125;
            // 
            // txtTypeCode
            // 
            this.txtTypeCode.DataPropertyName = "TypeCode";
            this.txtTypeCode.HeaderText = "箱型";
            this.txtTypeCode.MinimumWidth = 6;
            this.txtTypeCode.Name = "txtTypeCode";
            this.txtTypeCode.Width = 125;
            // 
            // txtSuitcaseNo
            // 
            this.txtSuitcaseNo.DataPropertyName = "SuitcaseNo";
            this.txtSuitcaseNo.HeaderText = "提单号";
            this.txtSuitcaseNo.MinimumWidth = 6;
            this.txtSuitcaseNo.Name = "txtSuitcaseNo";
            this.txtSuitcaseNo.Width = 125;
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.DataPropertyName = "PlanNo";
            this.txtPlanNo.HeaderText = "预约号";
            this.txtPlanNo.MinimumWidth = 6;
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Width = 125;
            // 
            // txtIsoCode
            // 
            this.txtIsoCode.DataPropertyName = "IsoCode";
            this.txtIsoCode.HeaderText = "ISO编码";
            this.txtIsoCode.MinimumWidth = 6;
            this.txtIsoCode.Name = "txtIsoCode";
            this.txtIsoCode.Width = 125;
            // 
            // txtTotalCount
            // 
            this.txtTotalCount.DataPropertyName = "TotalCount";
            this.txtTotalCount.HeaderText = "发布数量";
            this.txtTotalCount.MinimumWidth = 6;
            this.txtTotalCount.Name = "txtTotalCount";
            this.txtTotalCount.Width = 125;
            // 
            // txtBookCount
            // 
            this.txtBookCount.DataPropertyName = "BookCount";
            this.txtBookCount.HeaderText = "已预约数量";
            this.txtBookCount.MinimumWidth = 6;
            this.txtBookCount.Name = "txtBookCount";
            this.txtBookCount.Width = 125;
            // 
            // txtResidualQuantity
            // 
            this.txtResidualQuantity.DataPropertyName = "ResidualQuantity";
            this.txtResidualQuantity.HeaderText = "剩余数量";
            this.txtResidualQuantity.MinimumWidth = 6;
            this.txtResidualQuantity.Name = "txtResidualQuantity";
            this.txtResidualQuantity.Width = 125;
            // 
            // txtCompleteCount
            // 
            this.txtCompleteCount.DataPropertyName = "CompleteCount";
            this.txtCompleteCount.HeaderText = "完成数量";
            this.txtCompleteCount.MinimumWidth = 6;
            this.txtCompleteCount.Name = "txtCompleteCount";
            this.txtCompleteCount.Width = 125;
            // 
            // txtCreationTime
            // 
            this.txtCreationTime.DataPropertyName = "CreationTime";
            this.txtCreationTime.HeaderText = "发布时间";
            this.txtCreationTime.MinimumWidth = 6;
            this.txtCreationTime.Name = "txtCreationTime";
            this.txtCreationTime.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(943, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderNoText
            // 
            this.OrderNoText.Location = new System.Drawing.Point(108, 23);
            this.OrderNoText.Name = "OrderNoText";
            this.OrderNoText.Size = new System.Drawing.Size(136, 25);
            this.OrderNoText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "订单号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "提单号：";
            // 
            // SuitcaseNotext
            // 
            this.SuitcaseNotext.Location = new System.Drawing.Point(398, 23);
            this.SuitcaseNotext.Name = "SuitcaseNotext";
            this.SuitcaseNotext.Size = new System.Drawing.Size(136, 25);
            this.SuitcaseNotext.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "预约号：";
            // 
            // PlanNotext
            // 
            this.PlanNotext.Location = new System.Drawing.Point(699, 23);
            this.PlanNotext.Name = "PlanNotext";
            this.PlanNotext.Size = new System.Drawing.Size(136, 25);
            this.PlanNotext.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 583);
            this.Controls.Add(this.PlanNotext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SuitcaseNotext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderNoText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "飞单统计";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSuitcaseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPlanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIsoCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtResidualQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCompleteCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCreationTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OrderNoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SuitcaseNotext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PlanNotext;
    }
}