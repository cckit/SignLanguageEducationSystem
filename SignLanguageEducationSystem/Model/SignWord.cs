using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignLanguageEducationSystem {
	public class SignWord {
		public String Name {
			get;
			private set;
		}

		public SignWord(String name) {
			this.Name = name;
		}
	}
}
