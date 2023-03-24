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

// avoid warnings because of naming rule violation messages of button names....
#pragma warning disable IDE1006

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;

namespace DirCleaner {
	public partial class F_Main : Form {
		public F_Main() {
			InitializeComponent();
			System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
			ToolTip1.SetToolTip(this.btnConCatPDF, "Mehrere PDFs zusammenfügen");
			this.Text = "DirCleaner - Version: " + typeof(F_Main).Assembly.GetName().Version.ToString();
		}

		private void btnExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void btnDelAll_Click(object sender, EventArgs e) {
			if (cbxAskForDelete.Checked) {
				if (MessageBox.Show(null, "Wirklich alle gescannten Dokumente (*.pdf) löschen?","Löschbestätigung",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
					return;
				}
			}
			int plaene = DeleteFiles(CPaths.PlanPath);
			tbFilesDeleted.Text = plaene.ToString() + " Pläne und ";
			tbFilesDeleted.Text += DeleteFiles(CPaths.DokPath).ToString() + " Dokumente";
		}

		private void btnPlaene_Click(object sender, EventArgs e) {
			if (cbxAskForDelete.Checked) {
				if (MessageBox.Show(null, "Wirklich alle gescannten PLÄNE (*.pdf) löschen?", "Löschbestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
					return;
				}
			}
			tbFilesDeleted.Text = DeleteFiles(CPaths.PlanPath).ToString() + " Pläne";
		}

		private void btnDokumente_Click(object sender, EventArgs e) {
			if (cbxAskForDelete.Checked) {
				if (MessageBox.Show(null, "Wirklich alle gescannten DOKUMENTE (*.pdf) löschen?", "Löschbestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
					return;
				}
			}
			tbFilesDeleted.Text = DeleteFiles(CPaths.DokPath).ToString() + " Dokumente";
		}

		private int DeleteFiles(String pPath) {
			int ctr = 0;
			var txtFileList = Directory.GetFiles(pPath, "*.pdf*", SearchOption.TopDirectoryOnly);

			Cursor.Current = Cursors.WaitCursor;
         foreach (string currentFile in txtFileList) {
				this.Refresh();
            Application.DoEvents();
            try {
					if (File.Exists(@currentFile)) {
						File.Delete(@currentFile);
						ctr++;
					}
				}
            catch (Exception ex) {
               MessageBox.Show(ex.Message, "Exception beim Löschen der Dateien!");
            }
            this.Refresh();
            Application.DoEvents();
         }
         Cursor.Current = Cursors.Default;
         Application.DoEvents();
			return (ctr);
		}

		private void btnConCatPDF_Click(object sender, EventArgs e) {

			int FileCounter = 0; ;
			List<string> PathList = new List<string>();
			List<COneFile> FileList = new List<COneFile>();

			if (File.Exists(CPaths.DokPath + @"\Output.pdf")) {
				try {
					File.Delete(CPaths.DokPath + @"\Output.pdf");
				}
				catch (IOException iox) {
					MessageBox.Show(null, "Fehler bim Löschen der Output Datei\r\n" + iox.Message, "PDF Löschen fehlgeschlagen",MessageBoxButtons.OK, MessageBoxIcon.Error );
					return;
				}
			}
			// create list of paths
			PathList.Add(CPaths.DokPath);
			PathList.Add(CPaths.PlanPath);

			try {
				// create list of files for every path, one list only
				foreach (string currentPath in PathList) {
					Cursor.Current = Cursors.WaitCursor;
					var txtFileList = Directory.GetFiles(currentPath, "*.pdf*", SearchOption.TopDirectoryOnly);
					foreach (string currentFile in txtFileList) {
						this.Refresh();
						Application.DoEvents();
						FileCounter++;
						FileList.Add(new COneFile { FileID = FileCounter
														  , FileName = currentFile
														  });
						tbFilesDeleted.Text = "Adding file " + currentFile;
						this.Refresh();
						Application.DoEvents();
					}
					
					// build timestamps for sorting
					foreach (COneFile sFile in FileList) {
						tbFilesDeleted.Text = "Sorting " + @sFile.FileName;
						this.Refresh();
						Application.DoEvents();
						sFile.CreateTimestampAndSortIndex();
					}
				}

				// any file there? otherwise quit...
				if(FileList.Count > 0) {
					FileList.Sort();

					// concatenate all files
					PdfWriter pdfWriter = new PdfWriter(CPaths.DokPath + @"\Output.pdf");
					PdfDocument pdfDocument = new PdfDocument(pdfWriter);
					PdfMerger pdfMerger = new PdfMerger(pdfDocument);
					foreach (COneFile sFile in FileList) {
						PdfReader pdfSource = new PdfReader(sFile.FileName);
						pdfSource.SetUnethicalReading(true);
						PdfDocument pdfSingleDoc = new PdfDocument(pdfSource);
						pdfMerger.Merge(pdfSingleDoc, 1, pdfSingleDoc.GetNumberOfPages());
						pdfSingleDoc.Close();
						tbFilesDeleted.Text = "concat file " + @sFile.FileName;
						this.Refresh();
						Application.DoEvents();
					}
					pdfDocument.Close();
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "Exception beim Zusammenführen der PDF Dateien!");
				tbFilesDeleted.Text = "";
				return;
			}
			tbFilesDeleted.Text = "";
			this.Refresh();
			Application.DoEvents();
			Cursor.Current = Cursors.Default;
			// any file there? otherwise quit...
			if (FileList.Count > 0) {
				MessageBox.Show(null, "Alle PDFS sind in der Datei Output.pdf zusammengefasst, Auftrag beendet!", "PDF Dateien zusammengefasst", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else {
				MessageBox.Show(null, "Keine PDFS zum Zusammenfassen vorhanden, Auftrag beendet!", "Keine PDF Dateien zusammengefasst", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		class COneFile : IComparable<COneFile> {
			public int FileID { get; set; }
			public string FileName { get; set; }
			public string TimeStamp { get; set; }
			public long SortIndex { get; set; }

			public void CreateTimestampAndSortIndex() {
				string TempTimeStamp = FileName.Substring(FileName.LastIndexOf("\\") + 1);
				if (TempTimeStamp.StartsWith("Dokumenten-Scan_")) {
					//Example Dokumenten-Scan_200323_085254.pdf
					TempTimeStamp = "1" + TempTimeStamp.Substring("Dokumenten-Scan_DDMMYY_".Length, 6);
				}
				else {
					//Example: Plan_08-54-20__004.pdf
					TempTimeStamp = "1" + TempTimeStamp.Substring("Plan_".Length, 2) + TempTimeStamp.Substring("Plan_".Length + 3, 2) + TempTimeStamp.Substring("Plan_".Length + 6, 2);
				}
				TimeStamp = TempTimeStamp;
				SortIndex = Convert.ToInt32(TempTimeStamp);
			}
			public int CompareTo(COneFile obj) {
				if (obj.GetType() == typeof(COneFile)) {
					if (obj.SortIndex > SortIndex) return (-1);
					if (obj.SortIndex == SortIndex) return (0);
					return (1);
				}
				else {
					throw new Exception("Versuch, einen falschen Typen zu vwergleichen");
				}				
			}
		}
	}
}
