using Class2Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DTests
{
	public class SampleClass : IC2D
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Company { get; set; }

		public SampleClass() {
				Id = 1;
				FirstName = "Tom";
				LastName = "Swift";
				Company = "Swift Enterprises";
		}
	}
}
