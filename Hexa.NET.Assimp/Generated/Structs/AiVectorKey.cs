// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.Assimp
{
	/// <summary>
	/// ---------------------------------------------------------------------------<br/>
	/// A time-value pair specifying a certain 3D vector for the given time. <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "aiVectorKey")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiVectorKey
	{
		/// <summary>
		/// The time of this key <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mTime")]
		[NativeName(NativeNameType.Type, "double")]
		public double MTime;

		/// <summary>
		/// The value of this key <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mValue")]
		[NativeName(NativeNameType.Type, "aiVector3D")]
		public Vector3 MValue;

		/// <summary>
		/// The interpolation setting of this key <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mInterpolation")]
		[NativeName(NativeNameType.Type, "aiAnimInterpolation")]
		public AiAnimInterpolation MInterpolation;


		public unsafe AiVectorKey(double mTime = default, Vector3 mValue = default, AiAnimInterpolation mInterpolation = default)
		{
			MTime = mTime;
			MValue = mValue;
			MInterpolation = mInterpolation;
		}


	}

}
