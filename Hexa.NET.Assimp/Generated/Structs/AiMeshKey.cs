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
	/// Binds a anim-mesh to a specific point in time. <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "aiMeshKey")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiMeshKey
	{
		/// <summary>
		/// The time of this key <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mTime")]
		[NativeName(NativeNameType.Type, "double")]
		public double MTime;

		/// <summary>
		/// Index into the aiMesh::mAnimMeshes array of the<br/>
		/// mesh corresponding to the #aiMeshAnim hosting this<br/>
		/// key frame. The referenced anim mesh is evaluated<br/>
		/// according to the rules defined in the docs for #aiAnimMesh.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mValue")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint MValue;


		public unsafe AiMeshKey(double mTime = default, uint mValue = default)
		{
			MTime = mTime;
			MValue = mValue;
		}


	}

}
