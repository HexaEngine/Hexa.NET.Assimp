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
	/// <br/>
	/// Actually, it's a data structure to wrap a set of fXXXX (e.g fopen)<br/>
	/// replacement functions.<br/>
	/// The default implementation of the functions utilizes the fXXX functions from<br/>
	/// the CRT. However, you can supply a custom implementation to Assimp by<br/>
	/// delivering a custom aiFileIO. Use this to enable reading from other sources,<br/>
	/// such as ZIP archives or memory locations. <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "aiFile")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiFile
	{
		/// <summary>
		/// Callback to read from a file <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ReadProc")]
		[NativeName(NativeNameType.Type, "unsigned long long (*)() *")]
		public unsafe void* ReadProc;

		/// <summary>
		/// Callback to write to a file <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "WriteProc")]
		[NativeName(NativeNameType.Type, "unsigned long long (*)() *")]
		public unsafe void* WriteProc;

		/// <summary>
		/// Callback to retrieve the current position of<br/>
		/// the file cursor (ftell())<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "TellProc")]
		[NativeName(NativeNameType.Type, "unsigned long long (*)() *")]
		public unsafe void* TellProc;

		/// <summary>
		/// Callback to retrieve the size of the file,<br/>
		/// in bytes<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "FileSizeProc")]
		[NativeName(NativeNameType.Type, "unsigned long long (*)() *")]
		public unsafe void* FileSizeProc;

		/// <summary>
		/// Callback to set the current position<br/>
		/// of the file cursor (fseek())<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SeekProc")]
		[NativeName(NativeNameType.Type, "aiReturn (*)() *")]
		public unsafe void* SeekProc;

		/// <summary>
		/// Callback to flush the file contents<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "FlushProc")]
		[NativeName(NativeNameType.Type, "void (*)() *")]
		public unsafe void* FlushProc;

		/// <summary>
		/// User-defined, opaque data<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "UserData")]
		[NativeName(NativeNameType.Type, "char *")]
		public unsafe byte* UserData;


		public unsafe AiFile(delegate*<ulong> readProc = default, delegate*<ulong> writeProc = default, delegate*<ulong> tellProc = default, delegate*<ulong> fileSizeProc = default, delegate*<AiReturn> seekProc = default, delegate*<void> flushProc = default, byte* userData = default)
		{
			ReadProc = (delegate*<ulong>*)readProc;
			WriteProc = (delegate*<ulong>*)writeProc;
			TellProc = (delegate*<ulong>*)tellProc;
			FileSizeProc = (delegate*<ulong>*)fileSizeProc;
			SeekProc = (delegate*<AiReturn>*)seekProc;
			FlushProc = (delegate*<void>*)flushProc;
			UserData = userData;
		}


	}

}
