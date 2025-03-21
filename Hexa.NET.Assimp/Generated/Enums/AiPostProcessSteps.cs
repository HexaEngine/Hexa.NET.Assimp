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
	/// -----------------------------------------------------------------------------------<br/>
	/// <br/>
	/// <br/>
	/// <br/>
	/// <br/>
	/// -----------------------------------------------------------------------------------<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "aiPostProcessSteps")]
	[Flags]
	public enum AiPostProcessSteps : int
	{
		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Calculates the tangents and bitangents for the imported meshes.<br/>
		/// Does nothing if a mesh does not have normals. You might want this post<br/>
		/// processing step to be executed if you plan to use tangent space calculations<br/>
		/// such as normal mapping  applied to the meshes. There's an importer property,<br/>
		/// <br/>
		/// #AI_CONFIG_PP_CT_MAX_SMOOTHING_ANGLE<br/>
		/// , which allows you to specify<br/>
		/// a maximum smoothing angle for the algorithm. However, usually you'll<br/>
		/// want to leave it at the default value.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_CalcTangentSpace")]
		[NativeName(NativeNameType.Value, "1")]
		CalcTangentSpace = unchecked(1),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Identifies and joins identical vertex data sets within all<br/>
		/// imported meshes.<br/>
		/// After this step is run, each mesh contains unique vertices,<br/>
		/// so a vertex may be used by multiple faces. You usually want<br/>
		/// to use this post processing step. If your application deals with<br/>
		/// indexed geometry, this step is compulsory or you'll just waste rendering<br/>
		/// time. <br/>
		/// If this flag is not specified<br/>
		/// , no vertices are referenced by<br/>
		/// more than one face and <br/>
		/// no index buffer is required<br/>
		/// for rendering.<br/>
		/// Unless the importer (like ply) had to split vertices. Then you need one regardless.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_JoinIdenticalVertices")]
		[NativeName(NativeNameType.Value, "2")]
		JoinIdenticalVertices = unchecked(2),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Converts all the imported data to a left-handed coordinate space.<br/>
		/// By default the data is returned in a right-handed coordinate space (which<br/>
		/// OpenGL prefers). In this space, +X points to the right,<br/>
		/// +Z points towards the viewer, and +Y points upwards. In the DirectX<br/>
		/// coordinate space +X points to the right, +Y points upwards, and +Z points<br/>
		/// away from the viewer.<br/>
		/// You'll probably want to consider this flag if you use Direct3D for<br/>
		/// rendering. The #aiProcess_ConvertToLeftHanded flag supersedes this<br/>
		/// setting and bundles all conversions typically required for D3D-based<br/>
		/// applications.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_MakeLeftHanded")]
		[NativeName(NativeNameType.Value, "4")]
		MakeLeftHanded = unchecked(4),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Triangulates all faces of all meshes.<br/>
		/// By default the imported mesh data might contain faces with more than 3<br/>
		/// indices. For rendering you'll usually want all faces to be triangles.<br/>
		/// This post processing step splits up faces with more than 3 indices into<br/>
		/// triangles. Line and point primitives are *not* modified! If you want<br/>
		/// 'triangles only' with no other kinds of primitives, try the following<br/>
		/// solution:<br/>
		/// <br/>
		/// <br/>
		/// Specify both #aiProcess_Triangulate and #aiProcess_SortByPType <br/>
		/// <br/>
		/// Ignore all point and line meshes when you process assimp's output<br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_Triangulate")]
		[NativeName(NativeNameType.Value, "8")]
		Triangulate = unchecked(8),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Removes some parts of the data structure (animations, materials,<br/>
		/// light sources, cameras, textures, vertex components).<br/>
		/// The  components to be removed are specified in a separate<br/>
		/// importer property, <br/>
		/// #AI_CONFIG_PP_RVC_FLAGS<br/>
		/// . This is quite useful<br/>
		/// if you don't need all parts of the output structure. Vertex colors<br/>
		/// are rarely used today for example... Calling this step to remove unneeded<br/>
		/// data from the pipeline as early as possible results in increased<br/>
		/// performance and a more optimized output data structure.<br/>
		/// This step is also useful if you want to force Assimp to recompute<br/>
		/// normals or tangents. The corresponding steps don't recompute them if<br/>
		/// they're already there (loaded from the source asset). By using this<br/>
		/// step you can make sure they are NOT there.<br/>
		/// This flag is a poor one, mainly because its purpose is usually<br/>
		/// misunderstood. Consider the following case: a 3D model has been exported<br/>
		/// from a CAD app, and it has per-face vertex colors. Vertex positions can't be<br/>
		/// shared, thus the #aiProcess_JoinIdenticalVertices step fails to<br/>
		/// optimize the data because of these nasty little vertex colors.<br/>
		/// Most apps don't even process them, so it's all for nothing. By using<br/>
		/// this step, unneeded components are excluded as early as possible<br/>
		/// thus opening more room for internal optimizations.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_RemoveComponent")]
		[NativeName(NativeNameType.Value, "16")]
		RemoveComponent = unchecked(16),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Generates normals for all faces of all meshes.<br/>
		/// This is ignored if normals are already there at the time this flag<br/>
		/// is evaluated. Model importers try to load them from the source file, so<br/>
		/// they're usually already there. Face normals are shared between all points<br/>
		/// of a single face, so a single point can have multiple normals, which<br/>
		/// forces the library to duplicate vertices in some cases.<br/>
		/// #aiProcess_JoinIdenticalVertices is *senseless* then.<br/>
		/// This flag may not be specified together with #aiProcess_GenSmoothNormals.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_GenNormals")]
		[NativeName(NativeNameType.Value, "32")]
		GenNormals = unchecked(32),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Generates smooth normals for all vertices in the mesh.<br/>
		/// This is ignored if normals are already there at the time this flag<br/>
		/// is evaluated. Model importers try to load them from the source file, so<br/>
		/// they're usually already there.<br/>
		/// This flag may not be specified together with<br/>
		/// #aiProcess_GenNormals. There's a importer property,<br/>
		/// <br/>
		/// #AI_CONFIG_PP_GSN_MAX_SMOOTHING_ANGLE<br/>
		/// which allows you to specify<br/>
		/// an angle maximum for the normal smoothing algorithm. Normals exceeding<br/>
		/// this limit are not smoothed, resulting in a 'hard' seam between two faces.<br/>
		/// Using a decent angle here (e.g. 80 degrees) results in very good visual<br/>
		/// appearance.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_GenSmoothNormals")]
		[NativeName(NativeNameType.Value, "64")]
		GenSmoothNormals = unchecked(64),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Splits large meshes into smaller sub-meshes.<br/>
		/// This is quite useful for real-time rendering, where the number of triangles<br/>
		/// which can be maximally processed in a single draw-call is limited<br/>
		/// by the video driver/hardware. The maximum vertex buffer is usually limited<br/>
		/// too. Both requirements can be met with this step: you may specify both a<br/>
		/// triangle and vertex limit for a single mesh.<br/>
		/// The split limits can (and should!) be set through the<br/>
		/// <br/>
		/// #AI_CONFIG_PP_SLM_VERTEX_LIMIT<br/>
		/// and <br/>
		/// #AI_CONFIG_PP_SLM_TRIANGLE_LIMIT<br/>
		/// importer properties. The default values are <br/>
		/// #AI_SLM_DEFAULT_MAX_VERTICES<br/>
		/// and<br/>
		/// <br/>
		/// #AI_SLM_DEFAULT_MAX_TRIANGLES<br/>
		/// .<br/>
		/// Note that splitting is generally a time-consuming task, but only if there's<br/>
		/// something to split. The use of this step is recommended for most users.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_SplitLargeMeshes")]
		[NativeName(NativeNameType.Value, "128")]
		SplitLargeMeshes = unchecked(128),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Removes the node graph and pre-transforms all vertices with<br/>
		/// the local transformation matrices of their nodes.<br/>
		/// If the resulting scene can be reduced to a single mesh, with a single<br/>
		/// material, no lights, and no cameras, then the output scene will contain<br/>
		/// only a root node (with no children) that references the single mesh.<br/>
		/// Otherwise, the output scene will be reduced to a root node with a single<br/>
		/// level of child nodes, each one referencing one mesh, and each mesh<br/>
		/// referencing one material.<br/>
		/// In either case, for rendering, you can<br/>
		/// simply render all meshes in order - you don't need to pay<br/>
		/// attention to local transformations and the node hierarchy.<br/>
		/// Animations are removed during this step.<br/>
		/// This step is intended for applications without a scenegraph.<br/>
		/// The step CAN cause some problems: if e.g. a mesh of the asset<br/>
		/// contains normals and another, using the same material index, does not,<br/>
		/// they will be brought together, but the first meshes's part of<br/>
		/// the normal list is zeroed. However, these artifacts are rare.<br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_PreTransformVertices")]
		[NativeName(NativeNameType.Value, "256")]
		PreTransformVertices = unchecked(256),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Limits the number of bones simultaneously affecting a single vertex<br/>
		/// to a maximum value.<br/>
		/// If any vertex is affected by more than the maximum number of bones, the least<br/>
		/// important vertex weights are removed and the remaining vertex weights are<br/>
		/// renormalized so that the weights still sum up to 1.<br/>
		/// The default bone weight limit is 4 (defined as <br/>
		/// #AI_LMW_MAX_WEIGHTS<br/>
		/// in<br/>
		/// config.h), but you can use the <br/>
		/// #AI_CONFIG_PP_LBW_MAX_WEIGHTS<br/>
		/// importer<br/>
		/// property to supply your own limit to the post processing step.<br/>
		/// If you intend to perform the skinning in hardware, this post processing<br/>
		/// step might be of interest to you.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_LimitBoneWeights")]
		[NativeName(NativeNameType.Value, "512")]
		LimitBoneWeights = unchecked(512),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Validates the imported scene data structure.<br/>
		/// This makes sure that all indices are valid, all animations and<br/>
		/// bones are linked correctly, all material references are correct .. etc.<br/>
		/// It is recommended that you capture Assimp's log output if you use this flag,<br/>
		/// so you can easily find out what's wrong if a file fails the<br/>
		/// validation. The validator is quite strict and will find *all*<br/>
		/// inconsistencies in the data structure... It is recommended that plugin<br/>
		/// developers use it to debug their loaders. There are two types of<br/>
		/// validation failures:<br/>
		/// <br/>
		/// <br/>
		/// Error: There's something wrong with the imported data. Further<br/>
		/// postprocessing is not possible and the data is not usable at all.<br/>
		/// The import fails. #Importer::GetErrorString() or #aiGetErrorString()<br/>
		/// carry the error message around.<br/>
		/// <br/>
		/// Warning: There are some minor issues (e.g. 1000000 animation<br/>
		/// keyframes with the same time), but further postprocessing and use<br/>
		/// of the data structure is still safe. Warning details are written<br/>
		/// to the log file, <br/>
		/// #AI_SCENE_FLAGS_VALIDATION_WARNING<br/>
		/// is set<br/>
		/// in #aiScene::mFlags<br/>
		/// <br/>
		/// This post-processing step is not time-consuming. Its use is not<br/>
		/// compulsory, but recommended.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_ValidateDataStructure")]
		[NativeName(NativeNameType.Value, "1024")]
		ValidateDataStructure = unchecked(1024),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Reorders triangles for better vertex cache locality.<br/>
		/// The step tries to improve the ACMR (average post-transform vertex cache<br/>
		/// miss ratio) for all meshes. The implementation runs in O(n) and is<br/>
		/// roughly based on the 'tipsify' algorithm (see <br/>
		/// this<br/>
		/// paper<br/>
		/// ).<br/>
		/// If you intend to render huge models in hardware, this step might<br/>
		/// be of interest to you. The <br/>
		/// #AI_CONFIG_PP_ICL_PTCACHE_SIZE<br/>
		/// importer property can be used to fine-tune the cache optimization.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_ImproveCacheLocality")]
		[NativeName(NativeNameType.Value, "2048")]
		ImproveCacheLocality = unchecked(2048),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Searches for redundant/unreferenced materials and removes them.<br/>
		/// This is especially useful in combination with the<br/>
		/// #aiProcess_PreTransformVertices and #aiProcess_OptimizeMeshes flags.<br/>
		/// Both join small meshes with equal characteristics, but they can't do<br/>
		/// their work if two meshes have different materials. Because several<br/>
		/// material settings are lost during Assimp's import filters,<br/>
		/// (and because many exporters don't check for redundant materials), huge<br/>
		/// models often have materials which are are defined several times with<br/>
		/// exactly the same settings.<br/>
		/// Several material settings not contributing to the final appearance of<br/>
		/// a surface are ignored in all comparisons (e.g. the material name).<br/>
		/// So, if you're passing additional information through the<br/>
		/// content pipeline (probably using *magic* material names), don't<br/>
		/// specify this flag. Alternatively take a look at the<br/>
		/// <br/>
		/// #AI_CONFIG_PP_RRM_EXCLUDE_LIST<br/>
		/// importer property.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_RemoveRedundantMaterials")]
		[NativeName(NativeNameType.Value, "4096")]
		RemoveRedundantMaterials = unchecked(4096),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step tries to determine which meshes have normal vectors<br/>
		/// that are facing inwards and inverts them.<br/>
		/// The algorithm is simple but effective:<br/>
		/// the bounding box of all vertices + their normals is compared against<br/>
		/// the volume of the bounding box of all vertices without their normals.<br/>
		/// This works well for most objects, problems might occur with planar<br/>
		/// surfaces. However, the step tries to filter such cases.<br/>
		/// The step inverts all in-facing normals. Generally it is recommended<br/>
		/// to enable this step, although the result is not always correct.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_FixInfacingNormals")]
		[NativeName(NativeNameType.Value, "8192")]
		FixInfacingNormals = unchecked(8192),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// This step generically populates aiBone->mArmature and aiBone->mNode generically<br/>
		/// The point of these is it saves you later having to calculate these elements<br/>
		/// This is useful when handling rest information or skin information<br/>
		/// If you have multiple armatures on your models we strongly recommend enabling this<br/>
		/// Instead of writing your own multi-root, multi-armature lookups we have done the<br/>
		/// hard work for you :)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_PopulateArmatureData")]
		[NativeName(NativeNameType.Value, "16384")]
		PopulateArmatureData = unchecked(16384),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step splits meshes with more than one primitive type in<br/>
		/// homogeneous sub-meshes.<br/>
		/// The step is executed after the triangulation step. After the step<br/>
		/// returns, just one bit is set in aiMesh::mPrimitiveTypes. This is<br/>
		/// especially useful for real-time rendering where point and line<br/>
		/// primitives are often ignored or rendered separately.<br/>
		/// You can use the <br/>
		/// #AI_CONFIG_PP_SBP_REMOVE<br/>
		/// importer property to<br/>
		/// specify which primitive types you need. This can be used to easily<br/>
		/// exclude lines and points, which are rarely used, from the import.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_SortByPType")]
		[NativeName(NativeNameType.Value, "32768")]
		SortByPType = unchecked(32768),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step searches all meshes for degenerate primitives and<br/>
		/// converts them to proper lines or points.<br/>
		/// A face is 'degenerate' if one or more of its points are identical.<br/>
		/// To have the degenerate stuff not only detected and collapsed but<br/>
		/// removed, try one of the following procedures:<br/>
		/// <br/>
		/// 1.<br/>
		/// (if you support lines and points for rendering but don't<br/>
		/// want the degenerates)<br/>
		/// <br/>
		/// <br/>
		/// Specify the #aiProcess_FindDegenerates flag.<br/>
		/// <br/>
		/// <br/>
		/// Set the <br/>
		/// #AI_CONFIG_PP_FD_REMOVE<br/>
		/// importer property to<br/>
		/// 1. This will cause the step to remove degenerate triangles from the<br/>
		/// import as soon as they're detected. They won't pass any further<br/>
		/// pipeline steps.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// 2.<br/>
		/// (if you don't support lines and points at all)<br/>
		/// <br/>
		/// <br/>
		/// Specify the #aiProcess_FindDegenerates flag.<br/>
		/// <br/>
		/// <br/>
		/// Specify the #aiProcess_SortByPType flag. This moves line and<br/>
		/// point primitives to separate meshes.<br/>
		/// <br/>
		/// <br/>
		/// Set the <br/>
		/// #AI_CONFIG_PP_SBP_REMOVE<br/>
		/// importer property to<br/>
		/// <br/>
		/// to cause SortByPType to reject point<br/>
		/// and line meshes from the scene.<br/>
		/// <br/>
		/// <br/>
		/// This step also removes very small triangles with a surface area smaller<br/>
		/// than 10^-6. If you rely on having these small triangles, or notice holes<br/>
		/// in your model, set the property <br/>
		/// #AI_CONFIG_PP_FD_CHECKAREA<br/>
		/// to<br/>
		/// false.<br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_FindDegenerates")]
		[NativeName(NativeNameType.Value, "65536")]
		FindDegenerates = unchecked(65536),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step searches all meshes for invalid data, such as zeroed<br/>
		/// normal vectors or invalid UV coords and removes/fixes them. This is<br/>
		/// intended to get rid of some common exporter errors.<br/>
		/// This is especially useful for normals. If they are invalid, and<br/>
		/// the step recognizes this, they will be removed and can later<br/>
		/// be recomputed, i.e. by the #aiProcess_GenSmoothNormals flag.<br/>
		/// The step will also remove meshes that are infinitely small and reduce<br/>
		/// animation tracks consisting of hundreds if redundant keys to a single<br/>
		/// key. The <br/>
		/// AI_CONFIG_PP_FID_ANIM_ACCURACY<br/>
		/// config property decides<br/>
		/// the accuracy of the check for duplicate animation tracks.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_FindInvalidData")]
		[NativeName(NativeNameType.Value, "131072")]
		FindInvalidData = unchecked(131072),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step converts non-UV mappings (such as spherical or<br/>
		/// cylindrical mapping) to proper texture coordinate channels.<br/>
		/// Most applications will support UV mapping only, so you will<br/>
		/// probably want to specify this step in every case. Note that Assimp is not<br/>
		/// always able to match the original mapping implementation of the<br/>
		/// 3D app which produced a model perfectly. It's always better to let the<br/>
		/// modelling app compute the UV channels - 3ds max, Maya, Blender,<br/>
		/// LightWave, and Modo do this for example.<br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_GenUVCoords")]
		[NativeName(NativeNameType.Value, "262144")]
		GenUvCoords = unchecked(262144),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step applies per-texture UV transformations and bakes<br/>
		/// them into stand-alone vtexture coordinate channels.<br/>
		/// UV transformations are specified per-texture - see the<br/>
		/// <br/>
		/// #AI_MATKEY_UVTRANSFORM<br/>
		/// material key for more information.<br/>
		/// This step processes all textures with<br/>
		/// transformed input UV coordinates and generates a new (pre-transformed) UV channel<br/>
		/// which replaces the old channel. Most applications won't support UV<br/>
		/// transformations, so you will probably want to specify this step.<br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_TransformUVCoords")]
		[NativeName(NativeNameType.Value, "524288")]
		TransformUvCoords = unchecked(524288),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step searches for duplicate meshes and replaces them<br/>
		/// with references to the first mesh.<br/>
		/// This step takes a while, so don't use it if speed is a concern.<br/>
		/// Its main purpose is to workaround the fact that many export<br/>
		/// file formats don't support instanced meshes, so exporters need to<br/>
		/// duplicate meshes. This step removes the duplicates again. Please<br/>
		/// note that Assimp does not currently support per-node material<br/>
		/// assignment to meshes, which means that identical meshes with<br/>
		/// different materials are currently *not* joined, although this is<br/>
		/// planned for future versions.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_FindInstances")]
		[NativeName(NativeNameType.Value, "1048576")]
		FindInstances = unchecked(1048576),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// A post-processing step to reduce the number of meshes.<br/>
		/// This will, in fact, reduce the number of draw calls.<br/>
		/// This is a very effective optimization and is recommended to be used<br/>
		/// together with #aiProcess_OptimizeGraph, if possible. The flag is fully<br/>
		/// compatible with both #aiProcess_SplitLargeMeshes and #aiProcess_SortByPType.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_OptimizeMeshes")]
		[NativeName(NativeNameType.Value, "2097152")]
		OptimizeMeshes = unchecked(2097152),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// A post-processing step to optimize the scene hierarchy.<br/>
		/// Nodes without animations, bones, lights or cameras assigned are<br/>
		/// collapsed and joined.<br/>
		/// Node names can be lost during this step. If you use special 'tag nodes'<br/>
		/// to pass additional information through your content pipeline, use the<br/>
		/// <br/>
		/// #AI_CONFIG_PP_OG_EXCLUDE_LIST<br/>
		/// importer property to specify a<br/>
		/// list of node names you want to be kept. Nodes matching one of the names<br/>
		/// in this list won't be touched or modified.<br/>
		/// Use this flag with caution. Most simple files will be collapsed to a<br/>
		/// single node, so complex hierarchies are usually completely lost. This is not<br/>
		/// useful for editor environments, but probably a very effective<br/>
		/// optimization if you just want to get the model data, convert it to your<br/>
		/// own format, and render it as fast as possible.<br/>
		/// This flag is designed to be used with #aiProcess_OptimizeMeshes for best<br/>
		/// results.<br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_OptimizeGraph")]
		[NativeName(NativeNameType.Value, "4194304")]
		OptimizeGraph = unchecked(4194304),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step flips all UV coordinates along the y-axis and adjusts<br/>
		/// material settings and bitangents accordingly.<br/>
		/// <br/>
		/// Output UV coordinate system:<br/>
		/// <br/>
		/// You'll probably want to consider this flag if you use Direct3D for<br/>
		/// rendering. The #aiProcess_ConvertToLeftHanded flag supersedes this<br/>
		/// setting and bundles all conversions typically required for D3D-based<br/>
		/// applications.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_FlipUVs")]
		[NativeName(NativeNameType.Value, "8388608")]
		FlipUVs = unchecked(8388608),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step adjusts the output face winding order to be CW.<br/>
		/// The default face winding order is counter clockwise (CCW).<br/>
		/// <br/>
		/// Output face order:<br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_FlipWindingOrder")]
		[NativeName(NativeNameType.Value, "16777216")]
		FlipWindingOrder = unchecked(16777216),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step splits meshes with many bones into sub-meshes so that each<br/>
		/// sub-mesh has fewer or as many bones as a given limit.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_SplitByBoneCount")]
		[NativeName(NativeNameType.Value, "33554432")]
		SplitByBoneCount = unchecked(33554432),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step removes bones losslessly or according to some threshold.<br/>
		/// In some cases (i.e. formats that require it) exporters are forced to<br/>
		/// assign dummy bone weights to otherwise static meshes assigned to<br/>
		/// animated meshes. Full, weight-based skinning is expensive while<br/>
		/// animating nodes is extremely cheap, so this step is offered to clean up<br/>
		/// the data in that regard.<br/>
		/// Use <br/>
		/// #AI_CONFIG_PP_DB_THRESHOLD<br/>
		/// to control this.<br/>
		/// Use <br/>
		/// #AI_CONFIG_PP_DB_ALL_OR_NONE<br/>
		/// if you want bones removed if and<br/>
		/// only if all bones within the scene qualify for removal.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_Debone")]
		[NativeName(NativeNameType.Value, "67108864")]
		Debone = unchecked(67108864),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// This step will perform a global scale of the model.<br/>
		/// Some importers are providing a mechanism to define a scaling unit for the<br/>
		/// model. This post processing step can be used to do so. You need to get the<br/>
		/// global scaling from your importer settings like in FBX. Use the flag<br/>
		/// AI_CONFIG_GLOBAL_SCALE_FACTOR_KEY from the global property table to configure this.<br/>
		/// Use <br/>
		/// #AI_CONFIG_GLOBAL_SCALE_FACTOR_KEY<br/>
		/// to setup the global scaling factor.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_GlobalScale")]
		[NativeName(NativeNameType.Value, "134217728")]
		GlobalScale = unchecked(134217728),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// A postprocessing step to embed of textures.<br/>
		/// This will remove external data dependencies for textures.<br/>
		/// If a texture's file does not exist at the specified path<br/>
		/// (due, for instance, to an absolute path generated on another system),<br/>
		/// it will check if a file with the same name exists at the root folder<br/>
		/// of the imported model. And if so, it uses that.<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_EmbedTextures")]
		[NativeName(NativeNameType.Value, "268435456")]
		EmbedTextures = unchecked(268435456),

		/// <summary>
		/// aiProcess_GenEntityMeshes = 0x100000,<br/>
		/// aiProcess_OptimizeAnimations = 0x200000<br/>
		/// aiProcess_FixTexturePaths = 0x200000<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_ForceGenNormals")]
		[NativeName(NativeNameType.Value, "536870912")]
		ForceGenNormals = unchecked(536870912),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// Drops normals for all faces of all meshes.<br/>
		/// This is ignored if no normals are present.<br/>
		/// Face normals are shared between all points of a single face,<br/>
		/// so a single point can have multiple normals, which<br/>
		/// forces the library to duplicate vertices in some cases.<br/>
		/// #aiProcess_JoinIdenticalVertices is *senseless* then.<br/>
		/// This process gives sense back to aiProcess_JoinIdenticalVertices<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_DropNormals")]
		[NativeName(NativeNameType.Value, "1073741824")]
		DropNormals = unchecked(1073741824),

		/// <summary>
		/// -------------------------------------------------------------------------<br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "aiProcess_GenBoundingBoxes")]
		[NativeName(NativeNameType.Value, "0x80000000")]
		GenBoundingBoxes = unchecked((int)0x80000000),
	}
}
