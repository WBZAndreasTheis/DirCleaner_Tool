/*
    This file is part of the DirCleaner project.
    Copyright (c) 2023-2099 WBZ, Reinach, Switzerland
    Authors: Andreas Theis
    This program is offered under the AGPL license.
    AGPL licensing:
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details
	 (https://www.gnu.org/licenses/agpl-3.0.html).
    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

namespace DirCleaner {
	partial class F_Main {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
			this.btnDelAll = new System.Windows.Forms.Button();
			this.btnPlaene = new System.Windows.Forms.Button();
			this.btnDokumente = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.cbxAskForDelete = new System.Windows.Forms.CheckBox();
			this.lblFileDeleted = new System.Windows.Forms.Label();
			this.tbFilesDeleted = new System.Windows.Forms.TextBox();
			this.btnConCatPDF = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnDelAll
			// 
			this.btnDelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelAll.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDelAll.Location = new System.Drawing.Point(12, 6);
			this.btnDelAll.Name = "btnDelAll";
			this.btnDelAll.Size = new System.Drawing.Size(303, 54);
			this.btnDelAll.TabIndex = 0;
			this.btnDelAll.Text = "Alle PDF löschen";
			this.btnDelAll.UseVisualStyleBackColor = false;
			this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
			// 
			// btnPlaene
			// 
			this.btnPlaene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnPlaene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlaene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlaene.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPlaene.Location = new System.Drawing.Point(736, 7);
			this.btnPlaene.Name = "btnPlaene";
			this.btnPlaene.Size = new System.Drawing.Size(89, 54);
			this.btnPlaene.TabIndex = 1;
			this.btnPlaene.Text = "Pläne löschen";
			this.btnPlaene.UseVisualStyleBackColor = false;
			this.btnPlaene.Click += new System.EventHandler(this.btnPlaene_Click);
			// 
			// btnDokumente
			// 
			this.btnDokumente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
			this.btnDokumente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDokumente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDokumente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDokumente.Location = new System.Drawing.Point(641, 7);
			this.btnDokumente.Name = "btnDokumente";
			this.btnDokumente.Size = new System.Drawing.Size(89, 54);
			this.btnDokumente.TabIndex = 2;
			this.btnDokumente.Text = "Dokumente löschen";
			this.btnDokumente.UseVisualStyleBackColor = false;
			this.btnDokumente.Click += new System.EventHandler(this.btnDokumente_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnExit.Location = new System.Drawing.Point(736, 68);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(89, 28);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Beenden";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// cbxAskForDelete
			// 
			this.cbxAskForDelete.AutoSize = true;
			this.cbxAskForDelete.Location = new System.Drawing.Point(642, 75);
			this.cbxAskForDelete.Name = "cbxAskForDelete";
			this.cbxAskForDelete.Size = new System.Drawing.Size(88, 17);
			this.cbxAskForDelete.TabIndex = 4;
			this.cbxAskForDelete.Text = "Rückfragen?";
			this.cbxAskForDelete.UseVisualStyleBackColor = true;
			// 
			// lblFileDeleted
			// 
			this.lblFileDeleted.AutoSize = true;
			this.lblFileDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFileDeleted.Location = new System.Drawing.Point(12, 71);
			this.lblFileDeleted.Name = "lblFileDeleted";
			this.lblFileDeleted.Size = new System.Drawing.Size(122, 18);
			this.lblFileDeleted.TabIndex = 5;
			this.lblFileDeleted.Text = "Dateien gelöscht:";
			// 
			// tbFilesDeleted
			// 
			this.tbFilesDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFilesDeleted.Location = new System.Drawing.Point(140, 68);
			this.tbFilesDeleted.Name = "tbFilesDeleted";
			this.tbFilesDeleted.ReadOnly = true;
			this.tbFilesDeleted.Size = new System.Drawing.Size(459, 21);
			this.tbFilesDeleted.TabIndex = 6;
			// 
			// btnConCatPDF
			// 
			this.btnConCatPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnConCatPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConCatPDF.BackgroundImage")));
			this.btnConCatPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnConCatPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConCatPDF.Location = new System.Drawing.Point(391, 6);
			this.btnConCatPDF.Name = "btnConCatPDF";
			this.btnConCatPDF.Size = new System.Drawing.Size(130, 47);
			this.btnConCatPDF.TabIndex = 7;
			this.btnConCatPDF.UseVisualStyleBackColor = false;
			this.btnConCatPDF.Click += new System.EventHandler(this.btnConCatPDF_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(830, 103);
			this.Controls.Add(this.btnConCatPDF);
			this.Controls.Add(this.tbFilesDeleted);
			this.Controls.Add(this.lblFileDeleted);
			this.Controls.Add(this.cbxAskForDelete);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnDokumente);
			this.Controls.Add(this.btnPlaene);
			this.Controls.Add(this.btnDelAll);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TBA - Clean ScanDirs";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDelAll;
		private System.Windows.Forms.Button btnPlaene;
		private System.Windows.Forms.Button btnDokumente;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.CheckBox cbxAskForDelete;
		private System.Windows.Forms.Label lblFileDeleted;
		private System.Windows.Forms.TextBox tbFilesDeleted;
		private System.Windows.Forms.Button btnConCatPDF;
	}
}

