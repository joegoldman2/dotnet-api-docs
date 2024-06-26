﻿using System;
using System.Globalization;

namespace Snippets {
	class Launcher {
		static void Main(string[] args)
		{
			Temperature t1 = Temperature.Parse("20'F", NumberStyles.Integer, null);
			Console.WriteLine( t1.ToString("F", null) );

			string str1 = t1.ToString("G", null);
			Console.WriteLine( str1 );

			Temperature t2 = Temperature.Parse(str1, NumberStyles.Integer, null);
			Console.WriteLine( t2.ToString("F", null) );

			Console.WriteLine( t1.CompareTo(t2) );

			Temperature t3 = Temperature.Parse("30'F", NumberStyles.Integer, null);
			Console.WriteLine( t3.ToString("F", null) );

			Console.WriteLine( t1.CompareTo(t3) );

			Console.ReadLine();
		}
	}
	//<snippet1>
	/// <summary>
	/// Temperature class stores the value as UInt16
	/// and delegates most of the functionality
	/// to the UInt16 implementation.
	/// </summary>
	public class Temperature : IComparable, IFormattable {
		/// <summary>
		/// IComparable.CompareTo implementation.
		/// </summary>
		public int CompareTo(object obj) {
			if(obj is Temperature) {
				Temperature temp = (Temperature) obj;

				return m_value.CompareTo(temp.m_value);
			}
			
			throw new ArgumentException("object is not a Temperature");	
		}

		/// <summary>
		/// IFormattable.ToString implementation.
		/// </summary>
		public string ToString(string format, IFormatProvider provider) {
			if( format != null && format.Equals("F") ) {
				return String.Format("{0}'F", this.Value.ToString());
			}

			return m_value.ToString(format, provider);
		}

		/// <summary>
		/// Parses the temperature from a string in form
		/// [ws][sign]digits['F|'C][ws]
		/// </summary>
		public static Temperature Parse(string s, NumberStyles styles, IFormatProvider provider) {
			Temperature temp = new Temperature();

			if( s.TrimEnd(null).EndsWith("'F") ) {
				temp.Value = UInt16.Parse( s.Remove(s.LastIndexOf('\''), 2), styles, provider);
			}
			else {
				temp.Value = UInt16.Parse(s, styles, provider);
			}

			return temp;
		}

		// The value holder
		protected ushort m_value;

		public ushort Value {
			get {
				return m_value;
			}
			set {
				m_value = value;
			}
		}
	}
	//</snippet1>
}

namespace Snippets2 {
	//<snippet2>
	public class Temperature {
		public static ushort MinValue {
			get {
				return UInt16.MinValue;
			}
		}

		public static ushort MaxValue {
			get {
				return UInt16.MaxValue;
			}
		}

		// The value holder
		protected ushort m_value;

		public ushort Value {
			get {
				return m_value;
			}
			set {
				m_value = value;
			}
		}
	}
	//</snippet2>
}

namespace Snippets3 {
	//<snippet3>
	public class Temperature : IComparable {
		/// <summary>
		/// IComparable.CompareTo implementation.
		/// </summary>
		public int CompareTo(object obj) {
			if(obj is Temperature) {
				Temperature temp = (Temperature) obj;

				return m_value.CompareTo(temp.m_value);
			}
			
			throw new ArgumentException("object is not a Temperature");	
		}

		// The value holder
		protected ushort m_value;

		public ushort Value {
			get {
				return m_value;
			}
			set {
				m_value = value;
			}
		}
	}
	//</snippet3>
}

namespace Snippets4 {
	//<snippet4>
	public class Temperature : IFormattable {
		/// <summary>
		/// IFormattable.ToString implementation.
		/// </summary>
		public string ToString(string format, IFormatProvider provider) {
			if( format != null && format.Equals("F") ) {
				return String.Format("{0}'F", this.Value.ToString());
			}

			return m_value.ToString(format, provider);
		}

		// The value holder
		protected ushort m_value;

		public ushort Value {
			get {
				return m_value;
			}
			set {
				m_value = value;
			}
		}
	}
	//</snippet4>
}
namespace Snippets5 {
	//<snippet5>
	public class Temperature {
		/// <summary>
		/// Parses the temperature from a string in form
		/// [ws][sign]digits['F|'C][ws]
		/// </summary>
		public static Temperature Parse(string s) {
			Temperature temp = new Temperature();

			if( s.TrimEnd(null).EndsWith("'F") ) {
				temp.Value = UInt16.Parse( s.Remove(s.LastIndexOf('\''), 2) );
			}
			else {
				temp.Value = UInt16.Parse(s);
			}

			return temp;
		}

		// The value holder
		protected ushort m_value;

		public ushort Value {
			get {
				return m_value;
			}
			set {
				m_value = value;
			}
		}
	}
	//</snippet5>
}
namespace Snippets6 {
	//<snippet6>
	public class Temperature {
		/// <summary>
		/// Parses the temperature from a string in form
		/// [ws][sign]digits['F|'C][ws]
		/// </summary>
		public static Temperature Parse(string s, IFormatProvider provider) {
			Temperature temp = new Temperature();

			if( s.TrimEnd(null).EndsWith("'F") ) {
				temp.Value = UInt16.Parse( s.Remove(s.LastIndexOf('\''), 2), provider);
			}
			else {
				temp.Value = UInt16.Parse(s, provider);
			}

			return temp;
		}

		// The value holder
		protected ushort m_value;

		public ushort Value {
			get {
				return m_value;
			}
			set {
				m_value = value;
			}
		}
	}
	//</snippet6>
}
namespace Snippets7 {
	//<snippet7>
	public class Temperature {
		/// <summary>
		/// Parses the temperature from a string in form
		/// [ws][sign]digits['F|'C][ws]
		/// </summary>
		public static Temperature Parse(string s, NumberStyles styles) {
			Temperature temp = new Temperature();

			if( s.TrimEnd(null).EndsWith("'F") ) {
				temp.Value = UInt16.Parse( s.Remove(s.LastIndexOf('\''), 2), styles);
			}
			else {
				temp.Value = UInt16.Parse(s, styles);
			}

			return temp;
		}

		// The value holder
		protected ushort m_value;

		public ushort Value {
			get {
				return m_value;
			}
			set {
				m_value = value;
			}
		}
	}
	//</snippet7>
}
namespace Snippets8 {
	//<snippet8>
	public class Temperature {
		/// <summary>
		/// Parses the temperature from a string in form
		/// [ws][sign]digits['F|'C][ws]
		/// </summary>
		public static Temperature Parse(string s, NumberStyles styles, IFormatProvider provider) {
			Temperature temp = new Temperature();

			if( s.TrimEnd(null).EndsWith("'F") ) {
				temp.Value = UInt16.Parse( s.Remove(s.LastIndexOf('\''), 2), styles, provider);
			}
			else {
				temp.Value = UInt16.Parse(s, styles, provider);
			}

			return temp;
		}

		// The value holder
		protected ushort m_value;

		public ushort Value {
			get {
				return m_value;
			}
			set {
				m_value = value;
			}
		}
	}
	//</snippet8>
}
