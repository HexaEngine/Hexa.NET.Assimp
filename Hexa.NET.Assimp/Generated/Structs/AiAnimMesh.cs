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
	/// <br/>
	/// You may think of an #aiAnimMesh as a `patch` for the host mesh, which<br/>
	/// replaces only certain vertex data streams at a particular time.<br/>
	/// Each mesh stores n attached attached meshes (#aiMesh::mAnimMeshes).<br/>
	/// The actual relationship between the time line and anim meshes is<br/>
	/// established by #aiMeshAnim, which references singular mesh attachments<br/>
	/// by their ID and binds them to a time offset.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "aiAnimMesh")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiAnimMesh
	{
		/// <summary>
		/// Anim Mesh name <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mName")]
		[NativeName(NativeNameType.Type, "aiString")]
		public AiString MName;

		/// <summary>
		/// Replacement for aiMesh::mVertices. If this array is non-nullptr,<br/>
		/// it *must* contain mNumVertices entries. The corresponding<br/>
		/// array in the host mesh must be non-nullptr as well - animation<br/>
		/// meshes may neither add or nor remove vertex components (if<br/>
		/// a replacement array is nullptr and the corresponding source<br/>
		/// array is not, the source data is taken instead)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mVertices")]
		[NativeName(NativeNameType.Type, "aiVector3D *")]
		public unsafe Vector3* MVertices;

		/// <summary>
		/// Replacement for aiMesh::mNormals.  <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mNormals")]
		[NativeName(NativeNameType.Type, "aiVector3D *")]
		public unsafe Vector3* MNormals;

		/// <summary>
		/// Replacement for aiMesh::mTangents. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mTangents")]
		[NativeName(NativeNameType.Type, "aiVector3D *")]
		public unsafe Vector3* MTangents;

		/// <summary>
		/// Replacement for aiMesh::mBitangents. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mBitangents")]
		[NativeName(NativeNameType.Type, "aiVector3D *")]
		public unsafe Vector3* MBitangents;

		/// <summary>
		/// Replacement for aiMesh::mColors <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mColors")]
		[NativeName(NativeNameType.Type, "aiColor4D *[8]")]
		public unsafe Vector4* MColors_0;
		public unsafe Vector4* MColors_1;
		public unsafe Vector4* MColors_2;
		public unsafe Vector4* MColors_3;
		public unsafe Vector4* MColors_4;
		public unsafe Vector4* MColors_5;
		public unsafe Vector4* MColors_6;
		public unsafe Vector4* MColors_7;

		/// <summary>
		/// Replacement for aiMesh::mTextureCoords <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mTextureCoords")]
		[NativeName(NativeNameType.Type, "aiVector3D *[8]")]
		public unsafe Vector3* MTextureCoords_0;
		public unsafe Vector3* MTextureCoords_1;
		public unsafe Vector3* MTextureCoords_2;
		public unsafe Vector3* MTextureCoords_3;
		public unsafe Vector3* MTextureCoords_4;
		public unsafe Vector3* MTextureCoords_5;
		public unsafe Vector3* MTextureCoords_6;
		public unsafe Vector3* MTextureCoords_7;

		/// <summary>
		/// The number of vertices in the aiAnimMesh, and thus the length of all<br/>
		/// the member arrays.<br/>
		/// This has always the same value as the mNumVertices property in the<br/>
		/// corresponding aiMesh. It is duplicated here merely to make the length<br/>
		/// of the member arrays accessible even if the aiMesh is not known, e.g.<br/>
		/// from language bindings.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mNumVertices")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint MNumVertices;

		/// <summary>
		/// Weight of the AnimMesh.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mWeight")]
		[NativeName(NativeNameType.Type, "float")]
		public float MWeight;


		public unsafe AiAnimMesh(AiString mName = default, Vector3* mVertices = default, Vector3* mNormals = default, Vector3* mTangents = default, Vector3* mBitangents = default, Vector4** mColors = default, Vector3** mTextureCoords = default, uint mNumVertices = default, float mWeight = default)
		{
			MName = mName;
			MVertices = mVertices;
			MNormals = mNormals;
			MTangents = mTangents;
			MBitangents = mBitangents;
			if (mColors != default(Vector4**))
			{
				MColors_0 = mColors[0];
				MColors_1 = mColors[1];
				MColors_2 = mColors[2];
				MColors_3 = mColors[3];
				MColors_4 = mColors[4];
				MColors_5 = mColors[5];
				MColors_6 = mColors[6];
				MColors_7 = mColors[7];
			}
			if (mTextureCoords != default(Vector3**))
			{
				MTextureCoords_0 = mTextureCoords[0];
				MTextureCoords_1 = mTextureCoords[1];
				MTextureCoords_2 = mTextureCoords[2];
				MTextureCoords_3 = mTextureCoords[3];
				MTextureCoords_4 = mTextureCoords[4];
				MTextureCoords_5 = mTextureCoords[5];
				MTextureCoords_6 = mTextureCoords[6];
				MTextureCoords_7 = mTextureCoords[7];
			}
			MNumVertices = mNumVertices;
			MWeight = mWeight;
		}

		public unsafe AiAnimMesh(AiString mName = default, Vector3* mVertices = default, Vector3* mNormals = default, Vector3* mTangents = default, Vector3* mBitangents = default, Span<Pointer<Vector4>> mColors = default, Span<Pointer<Vector3>> mTextureCoords = default, uint mNumVertices = default, float mWeight = default)
		{
			MName = mName;
			MVertices = mVertices;
			MNormals = mNormals;
			MTangents = mTangents;
			MBitangents = mBitangents;
			if (mColors != default(Span<Pointer<Vector4>>))
			{
				MColors_0 = mColors[0];
				MColors_1 = mColors[1];
				MColors_2 = mColors[2];
				MColors_3 = mColors[3];
				MColors_4 = mColors[4];
				MColors_5 = mColors[5];
				MColors_6 = mColors[6];
				MColors_7 = mColors[7];
			}
			if (mTextureCoords != default(Span<Pointer<Vector3>>))
			{
				MTextureCoords_0 = mTextureCoords[0];
				MTextureCoords_1 = mTextureCoords[1];
				MTextureCoords_2 = mTextureCoords[2];
				MTextureCoords_3 = mTextureCoords[3];
				MTextureCoords_4 = mTextureCoords[4];
				MTextureCoords_5 = mTextureCoords[5];
				MTextureCoords_6 = mTextureCoords[6];
				MTextureCoords_7 = mTextureCoords[7];
			}
			MNumVertices = mNumVertices;
			MWeight = mWeight;
		}


		/// <summary>
		/// Replacement for aiMesh::mColors <br/>
		/// </summary>
		public unsafe Span<Pointer<Vector4>> MColors
		
		{
			get
			{
				fixed (Vector4** p = &this.MColors_0)
				{
					return new Span<Pointer<Vector4>>(p, 8);
				}
			}
		}
		/// <summary>
		/// Replacement for aiMesh::mTextureCoords <br/>
		/// </summary>
		public unsafe Span<Pointer<Vector3>> MTextureCoords
		
		{
			get
			{
				fixed (Vector3** p = &this.MTextureCoords_0)
				{
					return new Span<Pointer<Vector3>>(p, 8);
				}
			}
		}
	}

}
