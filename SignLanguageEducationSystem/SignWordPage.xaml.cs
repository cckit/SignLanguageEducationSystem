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
using Microsoft.Kinect;

namespace SignLanguageEducationSystem {
	/// <summary>
	/// Interaction logic for SignWordPage.xaml
	/// </summary>
	public partial class SignWordPage : UserControl {
		public SignWordPage(SystemStatusCollection systemStatusCollection) {
			InitializeComponent();
			this.DataContext = systemStatusCollection;

			systemStatusCollection.CurrentKinectSensor.ColorStream.Enable();
			systemStatusCollection.CurrentKinectSensor.ColorFrameReady += CurrentKinectSensor_ColorFrameReady;
		}

		private void CurrentKinectSensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e) {
			using (ColorImageFrame colorFrame = e.OpenColorImageFrame()) {
				if (colorFrame != null) {
					Byte[] pixels = new Byte[colorFrame.PixelDataLength];
					colorFrame.CopyPixelDataTo(pixels);
				}
			}
		}

		private void btnBack_Click(object sender, RoutedEventArgs e) {
			if (this.Parent != null) {
				UIElementCollection children = ((Panel)this.Parent).Children;
				if (children.Contains(this)) {
					children.Remove(this);
				}
			}
		}
	}
}
