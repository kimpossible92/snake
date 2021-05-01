// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2014 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// Changes to this file will be reverted when you update Steamworks.NET

namespace Steamworks {
	public struct ScreenshotHandle : System.IEquatable<ScreenshotHandle>, System.IComparable<ScreenshotHandle> {
		public static readonly ScreenshotHandle Invalid = new ScreenshotHandle(0);
		public uint m_ScreenshotHandle;

		public ScreenshotHandle(uint value) {
			m_ScreenshotHandle = value;
		}

		public override string ToString() {
			return m_ScreenshotHandle.ToString();
		}

		public override bool Equals(object other) {
			return other is ScreenshotHandle && this == (ScreenshotHandle)other;
		}

		public override int GetHashCode() {
			return m_ScreenshotHandle.GetHashCode();
		}

		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y) {
			return x.m_ScreenshotHandle == y.m_ScreenshotHandle;
		}

		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y) {
			return !(x == y);
		}

		public static explicit operator ScreenshotHandle(uint value) {
			return new ScreenshotHandle(value);
		}

		public static explicit operator uint(ScreenshotHandle that) {
			return that.m_ScreenshotHandle;
		}

		public bool Equals(ScreenshotHandle other) {
			return m_ScreenshotHandle == other.m_ScreenshotHandle;
		}

		public int CompareTo(ScreenshotHandle other) {
			return m_ScreenshotHandle.CompareTo(other.m_ScreenshotHandle);
		}
	}
}
