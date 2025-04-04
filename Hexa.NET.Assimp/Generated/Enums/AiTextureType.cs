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
	/// ---------------------------------------------------------------------------<br/>
	/// <br/>
	/// This is a very difficult topic. Different 3D packages support different<br/>
	/// kinds of textures. For very common texture types, such as bumpmaps, the<br/>
	/// rendering results depend on implementation details in the rendering<br/>
	/// pipelines of these applications. Assimp loads all texture references from<br/>
	/// the model file and tries to determine which of the predefined texture<br/>
	/// types below is the best choice to match the original use of the texture<br/>
	/// as closely as possible.<br/>
	/// In content pipelines you'll usually define how textures have to be handled,<br/>
	/// and the artists working on models have to conform to this specification,<br/>
	/// regardless which 3D tool they're using.<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "aiTextureType")]
	[Flags]
	public enum AiTextureType : int
	{
		/// <summary>
		/// Dummy value.<br/>
		/// No texture, but the value to be used as 'texture semantic'<br/>
		/// (#aiMaterialProperty::mSemantic) for all material properties<br/>
		/// *not* related to textures.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		/// The texture is combined with the result of the diffuse<br/>
		/// lighting equation.<br/>
		/// OR<br/>
		/// PBR Specular/Glossiness<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_DIFFUSE")]
		[NativeName(NativeNameType.Value, "1")]
		Diffuse = unchecked(1),

		/// <summary>
		/// The texture is combined with the result of the specular<br/>
		/// lighting equation.<br/>
		/// OR<br/>
		/// PBR Specular/Glossiness<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_SPECULAR")]
		[NativeName(NativeNameType.Value, "2")]
		Specular = unchecked(2),

		/// <summary>
		/// The texture is combined with the result of the ambient<br/>
		/// lighting equation.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_AMBIENT")]
		[NativeName(NativeNameType.Value, "3")]
		Ambient = unchecked(3),

		/// <summary>
		/// The texture is added to the result of the lighting<br/>
		/// calculation. It isn't influenced by incoming light.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_EMISSIVE")]
		[NativeName(NativeNameType.Value, "4")]
		Emissive = unchecked(4),

		/// <summary>
		/// The texture is a height map.<br/>
		/// By convention, higher gray-scale values stand for<br/>
		/// higher elevations from the base height.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_HEIGHT")]
		[NativeName(NativeNameType.Value, "5")]
		Height = unchecked(5),

		/// <summary>
		/// The texture is a (tangent space) normal-map.<br/>
		/// Again, there are several conventions for tangent-space<br/>
		/// normal maps. Assimp does (intentionally) not<br/>
		/// distinguish here.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_NORMALS")]
		[NativeName(NativeNameType.Value, "6")]
		Normals = unchecked(6),

		/// <summary>
		/// The texture defines the glossiness of the material.<br/>
		/// The glossiness is in fact the exponent of the specular<br/>
		/// (phong) lighting equation. Usually there is a conversion<br/>
		/// function defined to map the linear color values in the<br/>
		/// texture to a suitable exponent. Have fun.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_SHININESS")]
		[NativeName(NativeNameType.Value, "7")]
		Shininess = unchecked(7),

		/// <summary>
		/// The texture defines per-pixel opacity.<br/>
		/// Usually 'white' means opaque and 'black' means<br/>
		/// 'transparency'. Or quite the opposite. Have fun.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_OPACITY")]
		[NativeName(NativeNameType.Value, "8")]
		Opacity = unchecked(8),

		/// <summary>
		/// Displacement texture<br/>
		/// The exact purpose and format is application-dependent.<br/>
		/// Higher color values stand for higher vertex displacements.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_DISPLACEMENT")]
		[NativeName(NativeNameType.Value, "9")]
		Displacement = unchecked(9),

		/// <summary>
		/// Lightmap texture (aka Ambient Occlusion)<br/>
		/// Both 'Lightmaps' and dedicated 'ambient occlusion maps' are<br/>
		/// covered by this material property. The texture contains a<br/>
		/// scaling value for the final color value of a pixel. Its<br/>
		/// intensity is not affected by incoming light.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_LIGHTMAP")]
		[NativeName(NativeNameType.Value, "10")]
		Lightmap = unchecked(10),

		/// <summary>
		/// Reflection texture<br/>
		/// Contains the color of a perfect mirror reflection.<br/>
		/// Rarely used, almost never for real-time applications.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_REFLECTION")]
		[NativeName(NativeNameType.Value, "11")]
		Reflection = unchecked(11),

		/// <summary>
		/// PBR Materials<br/>
		/// PBR definitions from maya and other modelling packages now use this standard.<br/>
		/// This was originally introduced around 2012.<br/>
		/// Support for this is in game engines like Godot, Unreal or Unity3D.<br/>
		/// Modelling packages which use this are very common now.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_BASE_COLOR")]
		[NativeName(NativeNameType.Value, "12")]
		BaseColor = unchecked(12),

		/// <summary>
		/// PBR Materials<br/>
		/// PBR definitions from maya and other modelling packages now use this standard.<br/>
		/// This was originally introduced around 2012.<br/>
		/// Support for this is in game engines like Godot, Unreal or Unity3D.<br/>
		/// Modelling packages which use this are very common now.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_NORMAL_CAMERA")]
		[NativeName(NativeNameType.Value, "13")]
		NormalCamera = unchecked(13),

		/// <summary>
		/// PBR Materials<br/>
		/// PBR definitions from maya and other modelling packages now use this standard.<br/>
		/// This was originally introduced around 2012.<br/>
		/// Support for this is in game engines like Godot, Unreal or Unity3D.<br/>
		/// Modelling packages which use this are very common now.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_EMISSION_COLOR")]
		[NativeName(NativeNameType.Value, "14")]
		EmissionColor = unchecked(14),

		/// <summary>
		/// PBR Materials<br/>
		/// PBR definitions from maya and other modelling packages now use this standard.<br/>
		/// This was originally introduced around 2012.<br/>
		/// Support for this is in game engines like Godot, Unreal or Unity3D.<br/>
		/// Modelling packages which use this are very common now.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_METALNESS")]
		[NativeName(NativeNameType.Value, "15")]
		Metalness = unchecked(15),

		/// <summary>
		/// PBR Materials<br/>
		/// PBR definitions from maya and other modelling packages now use this standard.<br/>
		/// This was originally introduced around 2012.<br/>
		/// Support for this is in game engines like Godot, Unreal or Unity3D.<br/>
		/// Modelling packages which use this are very common now.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_DIFFUSE_ROUGHNESS")]
		[NativeName(NativeNameType.Value, "16")]
		DiffuseRoughness = unchecked(16),

		/// <summary>
		/// PBR Materials<br/>
		/// PBR definitions from maya and other modelling packages now use this standard.<br/>
		/// This was originally introduced around 2012.<br/>
		/// Support for this is in game engines like Godot, Unreal or Unity3D.<br/>
		/// Modelling packages which use this are very common now.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_AMBIENT_OCCLUSION")]
		[NativeName(NativeNameType.Value, "17")]
		AmbientOcclusion = unchecked(17),

		/// <summary>
		/// Unknown texture<br/>
		/// A texture reference that does not match any of the definitions<br/>
		/// above is considered to be 'unknown'. It is still imported,<br/>
		/// but is excluded from any further post-processing.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_UNKNOWN")]
		[NativeName(NativeNameType.Value, "18")]
		Unknown = unchecked(18),

		/// <summary>
		/// Sheen<br/>
		/// Generally used to simulate textiles that are covered in a layer of microfibers<br/>
		/// eg velvet<br/>
		/// https://github.com/KhronosGroup/glTF/tree/master/extensions/2.0/Khronos/KHR_materials_sheen<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_SHEEN")]
		[NativeName(NativeNameType.Value, "19")]
		Sheen = unchecked(19),

		/// <summary>
		/// Clearcoat<br/>
		/// Simulates a layer of 'polish' or 'lacquer' layered on top of a PBR substrate<br/>
		/// https://autodesk.github.io/standard-surface/#closures/coating<br/>
		/// https://github.com/KhronosGroup/glTF/tree/master/extensions/2.0/Khronos/KHR_materials_clearcoat<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_CLEARCOAT")]
		[NativeName(NativeNameType.Value, "20")]
		Clearcoat = unchecked(20),

		/// <summary>
		/// Transmission<br/>
		/// Simulates transmission through the surface<br/>
		/// May include further information such as wall thickness<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_TRANSMISSION")]
		[NativeName(NativeNameType.Value, "21")]
		Transmission = unchecked(21),

		/// <summary>
		/// Maya material declarations<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_MAYA_BASE")]
		[NativeName(NativeNameType.Value, "22")]
		MayaBase = unchecked(22),

		/// <summary>
		/// Maya material declarations<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_MAYA_SPECULAR")]
		[NativeName(NativeNameType.Value, "23")]
		MayaSpecular = unchecked(23),

		/// <summary>
		/// Maya material declarations<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_MAYA_SPECULAR_COLOR")]
		[NativeName(NativeNameType.Value, "24")]
		MayaSpecularColor = unchecked(24),

		/// <summary>
		/// Maya material declarations<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_MAYA_SPECULAR_ROUGHNESS")]
		[NativeName(NativeNameType.Value, "25")]
		MayaSpecularRoughness = unchecked(25),

		/// <summary>
		/// Anisotropy<br/>
		/// Simulates a surface with directional properties<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_ANISOTROPY")]
		[NativeName(NativeNameType.Value, "26")]
		Anisotropy = unchecked(26),

		/// <summary>
		/// gltf material declarations<br/>
		/// Refs: https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#metallic-roughness-material<br/>
		/// "textures for metalness and roughness properties are packed together in a single<br/>
		/// texture called metallicRoughnessTexture. Its green channel contains roughness<br/>
		/// values and its blue channel contains metalness values..."<br/>
		/// https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#_material_pbrmetallicroughness_metallicroughnesstexture<br/>
		/// "The metalness values are sampled from the B channel. The roughness values are<br/>
		/// sampled from the G channel..."<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiTextureType_GLTF_METALLIC_ROUGHNESS")]
		[NativeName(NativeNameType.Value, "27")]
		GltfMetallicRoughness = unchecked(27),

		[NativeName(NativeNameType.EnumItem, "_aiTextureType_Force32Bit")]
		[NativeName(NativeNameType.Value, "2147483647")]
		Force32Bit = unchecked(2147483647),
	}
}
