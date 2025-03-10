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
	/// Describes a blob of exported scene data. Use #aiExportSceneToBlob() to create a blob containing an<br/>
	/// exported scene. The memory referred by this structure is owned by Assimp.<br/>
	/// to free its resources. Don't try to free the memory on your side - it will crash for most build configurations<br/>
	/// due to conflicting heaps.<br/>
	/// Blobs can be nested - each blob may reference another blob, which may in turn reference another blob and so on.<br/>
	/// This is used when exporters write more than one output file for a given #aiScene. See the remarks for<br/>
	/// #aiExportDataBlob::name for more information.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "aiExportDataBlob")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiExportDataBlob
	{
		/// <summary>
		/// Size of the data in bytes<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "size")]
		[NativeName(NativeNameType.Type, "size_t")]
		public nuint Size;

		/// <summary>
		/// The data.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "data")]
		[NativeName(NativeNameType.Type, "void *")]
		public unsafe void* Data;

		/// <summary>
		/// Name of the blob. An empty string always<br/>
		/// indicates the first (and primary) blob,<br/>
		/// which contains the actual file data.<br/>
		/// Any other blobs are auxiliary files produced<br/>
		/// by exporters (i.e. material files). Existence<br/>
		/// of such files depends on the file format. Most<br/>
		/// formats don't split assets across multiple files.<br/>
		/// If used, blob names usually contain the file<br/>
		/// extension that should be used when writing<br/>
		/// the data to disc.<br/>
		/// The blob names generated can be influenced by<br/>
		/// setting the #AI_CONFIG_EXPORT_BLOB_NAME export<br/>
		/// property to the name that is used for the master<br/>
		/// blob. All other names are typically derived from<br/>
		/// the base name, by the file format exporter.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "name")]
		[NativeName(NativeNameType.Type, "aiString")]
		public AiString Name;

		/// <summary>
		/// Pointer to the next blob in the chain or NULL if there is none. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "next")]
		[NativeName(NativeNameType.Type, "aiExportDataBlob *")]
		public unsafe AiExportDataBlob* Next;


		public unsafe AiExportDataBlob(nuint size = default, void* data = default, AiString name = default, AiExportDataBlob* next = default)
		{
			Size = size;
			Data = data;
			Name = name;
			Next = next;
		}


	}

}
