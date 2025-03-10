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
	/// ----------------------------------------------------------------------------------<br/>
	/// Standard return type for some library functions.<br/>
	/// Rarely used, and if, mostly in the C API.<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "aiReturn")]
	[Flags]
	public enum AiReturn : int
	{
		/// <summary>
		/// Indicates that a function was successful <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiReturn_SUCCESS")]
		[NativeName(NativeNameType.Value, "0")]
		Success = unchecked(0),

		/// <summary>
		/// Indicates that a function failed <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiReturn_FAILURE")]
		[NativeName(NativeNameType.Value, "-1")]
		Failure = unchecked(-1),

		/// <summary>
		/// Indicates that not enough memory was available<br/>
		/// to perform the requested operation<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiReturn_OUTOFMEMORY")]
		[NativeName(NativeNameType.Value, "-3")]
		Outofmemory = unchecked(-3),

		/// <summary>
		/// <br/>
		/// Force 32-bit size enum<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "_AI_ENFORCE_ENUM_SIZE")]
		[NativeName(NativeNameType.Value, "2147483647")]
		EnforceEnumSize = unchecked(2147483647),
	}
}
