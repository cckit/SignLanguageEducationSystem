using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect.Toolkit.Controls;

namespace SignLanguageEducationSystem {
	/// <summary>
	/// Interaction logic for SignBrowserPage.xaml
	/// </summary>
	public partial class SignBrowserPage : UserControl {
		public SignBrowserPage(SystemStatusCollection systemStatusCollection) {
			InitializeComponent();
			this.DataContext = systemStatusCollection;
		}

		private void btnBack_Click(object sender, RoutedEventArgs e) {
			if (this.Parent != null) {
				UIElementCollection children = ((Panel)this.Parent).Children;
				if (children.Contains(this)) {
					children.Remove(this);
				}
			}
		}

		private KinectTileButton createKinectButton(SignWord signWord) {
			KinectTileButton button = new KinectTileButton();
			button.DataContext = signWord;
			button.Click += btnSignWord_Click;
			button.Label = signWord.Name;
			return button;
		}

		private void btnSignWord_Click(object sender, RoutedEventArgs e) {
			KinectTileButton button = (KinectTileButton)sender;
		}
	}
}
