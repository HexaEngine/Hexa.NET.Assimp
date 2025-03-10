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
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "aiVertexWeight")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiVertexWeight
	{
		/// <summary>
		/// Index of the vertex which is influenced by the bone.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mVertexId")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint MVertexId;

		/// <summary>
		/// The strength of the influence in the range (0...1).<br/>
		/// The influence from all bones at one vertex amounts to 1.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mWeight")]
		[NativeName(NativeNameType.Type, "ai_real")]
		public double MWeight;


		public unsafe AiVertexWeight(uint mVertexId = default, double mWeight = default)
		{
			MVertexId = mVertexId;
			MWeight = mWeight;
		}


	}

}
