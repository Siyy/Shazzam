﻿using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace Shazzam.Views {

	public partial class FileLoaderPlugin : UserControl {
		string _exePath;
		public FileLoaderPlugin() {
			InitializeComponent();
			_exePath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			FillList();
			FillSampleList();
		}
		public CodeTabView CodeTabView { get; set; }
		private void FillList() {
			if (Directory.Exists(Properties.Settings.Default.FolderFX))
			{
				fileListBox.ItemsSource = Directory.GetFiles(Properties.Settings.Default.FolderFX, "*.fx").Select(filename => System.IO.Path.GetFileName(filename));

			}

		}

		private void fileListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			if (fileListBox.SelectedItem == null)
			{
				return;
			}
			string path = System.IO.Path.Combine(Properties.Settings.Default.FolderFX, fileListBox.SelectedItem.ToString());

			ShazzamSwitchboard.CodeTabView.EnableControls(false);
			ShazzamSwitchboard.CodeTabView.FillEditControls(path, true);

		}

		private void Hyperlink_Click(object sender, RoutedEventArgs e) {
			var ofd = new System.Windows.Forms.FolderBrowserDialog();

			if (Properties.Settings.Default.FolderFX != string.Empty)
			{
				ofd.SelectedPath = Properties.Settings.Default.FolderFX;
			}
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Properties.Settings.Default.FolderFX = ofd.SelectedPath;
				FillList();
			}
		}
		private void FillSampleList() {


			string path = System.IO.Path.Combine(_exePath, "samples");
			if (Directory.Exists(path))
			{
				sampleListBox.ItemsSource = Directory.GetFiles(path, "*.fx").Select(filename => System.IO.Path.GetFileName(filename));

			}

		}

		private void sampleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			string samplesPath = System.IO.Path.Combine(_exePath, "samples");
			if (sampleListBox.SelectedItem == null)
			{
				return;
			}
			string path = System.IO.Path.Combine(samplesPath, sampleListBox.SelectedItem.ToString());

			ShazzamSwitchboard.CodeTabView.EnableControls(false);
			ShazzamSwitchboard.CodeTabView.FillEditControls(path, true);
		}
	}
}
