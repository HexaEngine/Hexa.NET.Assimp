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
	/// Helper structure to describe a light source.<br/>
	/// Assimp supports multiple sorts of light sources, including<br/>
	/// directional, point and spot lights. All of them are defined with just<br/>
	/// a single structure and distinguished by their parameters.<br/>
	/// Note - some file formats (such as 3DS, ASE) export a "target point" -<br/>
	/// the point a spot light is looking at (it can even be animated). Assimp<br/>
	/// writes the target point as a sub-node of a spot-lights's main node,<br/>
	/// called "<spotName>.Target". However, this is just additional information<br/>
	/// then, the transformation tracks of the main node make the<br/>
	/// spot light already point in the right direction.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "aiLight")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AiLight
	{
		/// <summary>
		/// The name of the light source.<br/>
		/// There must be a node in the scene-graph with the same name.<br/>
		/// This node specifies the position of the light in the scene<br/>
		/// hierarchy and can be animated.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mName")]
		[NativeName(NativeNameType.Type, "aiString")]
		public AiString MName;

		/// <summary>
		/// The type of the light source.<br/>
		/// aiLightSource_UNDEFINED is not a valid value for this member.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mType")]
		[NativeName(NativeNameType.Type, "aiLightSourceType")]
		public AiLightSourceType MType;

		/// <summary>
		/// Position of the light source in space. Relative to the<br/>
		/// transformation of the node corresponding to the light.<br/>
		/// The position is undefined for directional lights.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mPosition")]
		[NativeName(NativeNameType.Type, "aiVector3D")]
		public Vector3 MPosition;

		/// <summary>
		/// Direction of the light source in space. Relative to the<br/>
		/// transformation of the node corresponding to the light.<br/>
		/// The direction is undefined for point lights. The vector<br/>
		/// may be normalized, but it needn't.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mDirection")]
		[NativeName(NativeNameType.Type, "aiVector3D")]
		public Vector3 MDirection;

		/// <summary>
		/// Up direction of the light source in space. Relative to the<br/>
		/// transformation of the node corresponding to the light.<br/>
		/// The direction is undefined for point lights. The vector<br/>
		/// may be normalized, but it needn't.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mUp")]
		[NativeName(NativeNameType.Type, "aiVector3D")]
		public Vector3 MUp;

		/// <summary>
		/// Constant light attenuation factor.<br/>
		/// The intensity of the light source at a given distance 'd' from<br/>
		/// the light's position is<br/>
		/// <br/>
		/// This member corresponds to the att0 variable in the equation.<br/>
		/// Naturally undefined for directional lights.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mAttenuationConstant")]
		[NativeName(NativeNameType.Type, "float")]
		public float MAttenuationConstant;

		/// <summary>
		/// Linear light attenuation factor.<br/>
		/// The intensity of the light source at a given distance 'd' from<br/>
		/// the light's position is<br/>
		/// <br/>
		/// This member corresponds to the att1 variable in the equation.<br/>
		/// Naturally undefined for directional lights.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mAttenuationLinear")]
		[NativeName(NativeNameType.Type, "float")]
		public float MAttenuationLinear;

		/// <summary>
		/// Quadratic light attenuation factor.<br/>
		/// The intensity of the light source at a given distance 'd' from<br/>
		/// the light's position is<br/>
		/// <br/>
		/// This member corresponds to the att2 variable in the equation.<br/>
		/// Naturally undefined for directional lights.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mAttenuationQuadratic")]
		[NativeName(NativeNameType.Type, "float")]
		public float MAttenuationQuadratic;

		/// <summary>
		/// Diffuse color of the light source<br/>
		/// The diffuse light color is multiplied with the diffuse<br/>
		/// material color to obtain the final color that contributes<br/>
		/// to the diffuse shading term.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mColorDiffuse")]
		[NativeName(NativeNameType.Type, "aiColor3D")]
		public AiColor3D MColorDiffuse;

		/// <summary>
		/// Specular color of the light source<br/>
		/// The specular light color is multiplied with the specular<br/>
		/// material color to obtain the final color that contributes<br/>
		/// to the specular shading term.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mColorSpecular")]
		[NativeName(NativeNameType.Type, "aiColor3D")]
		public AiColor3D MColorSpecular;

		/// <summary>
		/// Ambient color of the light source<br/>
		/// The ambient light color is multiplied with the ambient<br/>
		/// material color to obtain the final color that contributes<br/>
		/// to the ambient shading term. Most renderers will ignore<br/>
		/// this value it, is just a remaining of the fixed-function pipeline<br/>
		/// that is still supported by quite many file formats.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mColorAmbient")]
		[NativeName(NativeNameType.Type, "aiColor3D")]
		public AiColor3D MColorAmbient;

		/// <summary>
		/// Inner angle of a spot light's light cone.<br/>
		/// The spot light has maximum influence on objects inside this<br/>
		/// angle. The angle is given in radians. It is 2PI for point<br/>
		/// lights and undefined for directional lights.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mAngleInnerCone")]
		[NativeName(NativeNameType.Type, "float")]
		public float MAngleInnerCone;

		/// <summary>
		/// Outer angle of a spot light's light cone.<br/>
		/// The spot light does not affect objects outside this angle.<br/>
		/// The angle is given in radians. It is 2PI for point lights and<br/>
		/// undefined for directional lights. The outer angle must be<br/>
		/// greater than or equal to the inner angle.<br/>
		/// It is assumed that the application uses a smooth<br/>
		/// interpolation between the inner and the outer cone of the<br/>
		/// spot light.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mAngleOuterCone")]
		[NativeName(NativeNameType.Type, "float")]
		public float MAngleOuterCone;

		/// <summary>
		/// Size of area light source. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mSize")]
		[NativeName(NativeNameType.Type, "aiVector2D")]
		public Vector2 MSize;


		public unsafe AiLight(AiString mName = default, AiLightSourceType mType = default, Vector3 mPosition = default, Vector3 mDirection = default, Vector3 mUp = default, float mAttenuationConstant = default, float mAttenuationLinear = default, float mAttenuationQuadratic = default, AiColor3D mColorDiffuse = default, AiColor3D mColorSpecular = default, AiColor3D mColorAmbient = default, float mAngleInnerCone = default, float mAngleOuterCone = default, Vector2 mSize = default)
		{
			MName = mName;
			MType = mType;
			MPosition = mPosition;
			MDirection = mDirection;
			MUp = mUp;
			MAttenuationConstant = mAttenuationConstant;
			MAttenuationLinear = mAttenuationLinear;
			MAttenuationQuadratic = mAttenuationQuadratic;
			MColorDiffuse = mColorDiffuse;
			MColorSpecular = mColorSpecular;
			MColorAmbient = mColorAmbient;
			MAngleInnerCone = mAngleInnerCone;
			MAngleOuterCone = mAngleOuterCone;
			MSize = mSize;
		}


	}

}
