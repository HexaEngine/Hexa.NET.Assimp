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
	/// ----------------------------------------------------------------------------------<br/>
	/// Represents a ray<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "aiRay")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiRay
	{
		/// <summary>
		/// Position and direction of the ray<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pos")]
		[NativeName(NativeNameType.Type, "aiVector3D")]
		public Vector3 Pos;

		/// <summary>
		/// Position and direction of the ray<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "dir")]
		[NativeName(NativeNameType.Type, "aiVector3D")]
		public Vector3 Dir;


		public unsafe AiRay(Vector3 pos = default, Vector3 dir = default)
		{
			Pos = pos;
			Dir = dir;
		}


	}

}
