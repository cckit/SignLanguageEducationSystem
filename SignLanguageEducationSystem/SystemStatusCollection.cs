using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignLanguageEducationSystem {

	public class SystemStatusCollection : AutoNotifyPropertyChanged {

		private bool _isKinectAllSet;
		public bool IsKinectAllSet {
			get { return _isKinectAllSet; }
			set { SetProperty(ref _isKinectAllSet, value, true); }
		}
	}
}
