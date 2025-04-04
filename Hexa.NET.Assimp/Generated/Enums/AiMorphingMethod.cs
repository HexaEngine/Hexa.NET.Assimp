// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.Assimp
{
	/// <summary>
	/// ---------------------------------------------------------------------------<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "aiMorphingMethod")]
	[Flags]
	public enum AiMorphingMethod : int
	{
		/// <summary>
		/// Morphing method to be determined <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiMorphingMethod_UNKNOWN")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),

		/// <summary>
		/// Interpolation between morph targets <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiMorphingMethod_VERTEX_BLEND")]
		[NativeName(NativeNameType.Value, "1")]
		VertexBlend = unchecked(1),

		/// <summary>
		/// Normalized morphing between morph targets  <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiMorphingMethod_MORPH_NORMALIZED")]
		[NativeName(NativeNameType.Value, "2")]
		MorphNormalized = unchecked(2),

		/// <summary>
		/// Relative morphing between morph targets  <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiMorphingMethod_MORPH_RELATIVE")]
		[NativeName(NativeNameType.Value, "3")]
		MorphRelative = unchecked(3),

		[NativeName(NativeNameType.EnumItem, "_aiMorphingMethod_Force32Bit")]
		[NativeName(NativeNameType.Value, "2147483647")]
		Force32Bit = unchecked(2147483647),
	}
}
