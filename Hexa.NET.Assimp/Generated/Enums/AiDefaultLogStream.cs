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
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "aiDefaultLogStream")]
	[Flags]
	public enum AiDefaultLogStream : int
	{
		/// <summary>
		/// Stream the log to a file <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiDefaultLogStream_FILE")]
		[NativeName(NativeNameType.Value, "1")]
		File = unchecked(1),

		/// <summary>
		/// Stream the log to std::cout <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiDefaultLogStream_STDOUT")]
		[NativeName(NativeNameType.Value, "2")]
		Stdout = unchecked(2),

		/// <summary>
		/// Stream the log to std::cerr <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiDefaultLogStream_STDERR")]
		[NativeName(NativeNameType.Value, "4")]
		Stderr = unchecked(4),

		/// <summary>
		/// MSVC only: Stream the log the the debugger<br/>
		/// (this relies on OutputDebugString from the Win32 SDK)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiDefaultLogStream_DEBUGGER")]
		[NativeName(NativeNameType.Value, "8")]
		Debugger = unchecked(8),

		/// <summary>
		/// <br/>
		/// Force 32-bit size enum<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "_AI_DLS_ENFORCE_ENUM_SIZE")]
		[NativeName(NativeNameType.Value, "2147483647")]
		DlsEnforceEnumSize = unchecked(2147483647),
	}
}
