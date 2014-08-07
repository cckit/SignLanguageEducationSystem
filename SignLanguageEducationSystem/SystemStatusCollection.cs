using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;

namespace SignLanguageEducationSystem {

	public class SystemStatusCollection : AutoNotifyPropertyChanged {

		private bool _isKinectAllSet;
		public bool IsKinectAllSet {
			get { return _isKinectAllSet; }
			set { SetProperty(ref _isKinectAllSet, value, true); }
		}

		private String _currentSignWordName = "";
		public String CurrentSignWordName {
			get { return _currentSignWordName; }
			set { SetProperty(ref _currentSignWordName, value, true); }
		}

		private KinectSensor _currentKinectSensor;
		public KinectSensor CurrentKinectSensor {
			get { return _currentKinectSensor; }
			set { SetProperty(ref _currentKinectSensor, value, true); }
		}
	}
}
