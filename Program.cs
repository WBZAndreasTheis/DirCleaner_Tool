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

using System;
using System.Windows.Forms;
using System.IO;

namespace DirCleaner {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			string msg = "";

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (!Directory.Exists(CPaths.DokPath)) msg = "Der Pfad " + CPaths.DokPath + " existiert nicht!\r\n";
			if (!Directory.Exists(CPaths.PlanPath)) msg += "Der Pfad " + CPaths.PlanPath + " existiert nicht!\r\n";
			if (msg.Length > 0) {
				msg += "\r\nApplikation wird beendet";
				MessageBox.Show(null, msg, "DirCleaner Error: Pfad(e) nicht vorhanden!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
			else {
				Application.Run(new F_Main());
			}

		}
	}
}
