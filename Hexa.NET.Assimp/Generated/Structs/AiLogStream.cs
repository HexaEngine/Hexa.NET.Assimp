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
	/// --------------------------------------------------------------------------------<br/>
	/// C-API: Represents a log stream. A log stream receives all log messages and<br/>
	/// streams them _somewhere_.<br/>
	/// <br/>
	/// --------------------------------------------------------------------------------<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "aiLogStream")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiLogStream
	{
		/// <summary>
		/// callback to be called <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "callback")]
		[NativeName(NativeNameType.Type, "aiLogStreamCallback")]
		public unsafe void* Callback;
		/// <summary>
		/// user data to be passed to the callback <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "user")]
		[NativeName(NativeNameType.Type, "char *")]
		public unsafe byte* User;


		public unsafe AiLogStream(AiLogStreamCallback callback = default, byte* user = default)
		{
			Callback = (delegate*<byte*, byte*, void>)Marshal.GetFunctionPointerForDelegate(callback);
			User = user;
		}


	}

}
