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
	[NativeName(NativeNameType.StructOrClass, "aiMaterial")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiMaterial
	{
		/// <summary>
		/// List of all material properties loaded. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mProperties")]
		[NativeName(NativeNameType.Type, "aiMaterialProperty * *")]
		public unsafe AiMaterialProperty** MProperties;

		/// <summary>
		/// Number of properties in the data base <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mNumProperties")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint MNumProperties;

		/// <summary>
		/// Storage allocated <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mNumAllocated")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint MNumAllocated;


		public unsafe AiMaterial(AiMaterialProperty** mProperties = default, uint mNumProperties = default, uint mNumAllocated = default)
		{
			MProperties = mProperties;
			MNumProperties = mNumProperties;
			MNumAllocated = mNumAllocated;
		}


	}

}
