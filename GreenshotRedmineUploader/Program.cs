/*
 * Created by SharpDevelop.
 * User: Michael Kling - Ascendro S.R.L
 * Date: 19.12.2012
 * Time: 2:27 
 * 
 *  Copyright Michael Kling - Ascendro S.R.L
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
using System;
using System.Windows.Forms;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;

namespace GreenshotRedmineUploader
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		public static MainForm mainForm;
		public static RedmineSettings redmine;
		
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			redmine = new RedmineSettings();						
			mainForm = new MainForm();
			if (args.Length > 0)
			{
				mainForm.setFilesource(args[0]);
			}
            Application.Run(mainForm);
		}
		
	}
}
