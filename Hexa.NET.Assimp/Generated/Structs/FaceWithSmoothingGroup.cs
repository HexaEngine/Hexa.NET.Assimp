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
	/// Helper structure representing a face with smoothing groups assigned <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FaceWithSmoothingGroup")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FaceWithSmoothingGroup
	{
		/// <summary>
		/// Indices. .3ds is using uint16. However, after<br/>
		/// an unique vertex set has been generated,<br/>
		/// individual index values might exceed 2^16<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mIndices")]
		[NativeName(NativeNameType.Type, "uint32_t[3]")]
		public uint MIndices_0;
		public uint MIndices_1;
		public uint MIndices_2;

		/// <summary>
		/// specifies to which smoothing group the face belongs to<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "iSmoothGroup")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint ISmoothGroup;


		public unsafe FaceWithSmoothingGroup(uint* mIndices = default, uint iSmoothGroup = default)
		{
			if (mIndices != default(uint*))
			{
				MIndices_0 = mIndices[0];
				MIndices_1 = mIndices[1];
				MIndices_2 = mIndices[2];
			}
			ISmoothGroup = iSmoothGroup;
		}

		public unsafe FaceWithSmoothingGroup(Span<uint> mIndices = default, uint iSmoothGroup = default)
		{
			if (mIndices != default(Span<uint>))
			{
				MIndices_0 = mIndices[0];
				MIndices_1 = mIndices[1];
				MIndices_2 = mIndices[2];
			}
			ISmoothGroup = iSmoothGroup;
		}


	}

}
