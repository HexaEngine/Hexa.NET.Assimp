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
	/// Describes a morphing animation of a given mesh. <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "aiMeshMorphAnim")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiMeshMorphAnim
	{
		/// <summary>
		/// Name of the mesh to be animated. An empty string is not allowed,<br/>
		/// animated meshes need to be named (not necessarily uniquely,<br/>
		/// the name can basically serve as wildcard to select a group<br/>
		/// of meshes with similar animation setup)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mName")]
		[NativeName(NativeNameType.Type, "aiString")]
		public AiString MName;

		/// <summary>
		/// Size of the #mKeys array. Must be 1, at least. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mNumKeys")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint MNumKeys;

		/// <summary>
		/// Key frames of the animation. May not be nullptr. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mKeys")]
		[NativeName(NativeNameType.Type, "aiMeshMorphKey *")]
		public unsafe AiMeshMorphKey* MKeys;


		public unsafe AiMeshMorphAnim(AiString mName = default, uint mNumKeys = default, AiMeshMorphKey* mKeys = default)
		{
			MName = mName;
			MNumKeys = mNumKeys;
			MKeys = mKeys;
		}


	}

}
