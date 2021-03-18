// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Assimp
{
    public partial class Assimp
    {
        /// <summary>A hint to assimp to favour speed against import quality.</summary>
        public const string PropertyFavourSpeed = "FAVOUR_SPEED";

        /// <summary>Enables time measurements.</summary>
        public const string PropertyGlobMeasureTime = "GLOB_MEASURE_TIME";

        /// <summary>Configures whether the AC loader evaluates subdivision surfaces ( indicated by the presence of the 'subdiv' attribute in the file).</summary>
        public const string PropertyImportAcEvalSubdivision = "IMPORT_AC_EVAL_SUBDIVISION";

        /// <summary>Configures the AC loader to collect all surfaces which have the "Backface cull" flag set in separate meshes.</summary>
        public const string PropertyImportAcSeparateBfcull = "IMPORT_AC_SEPARATE_BFCULL";

        /// <summary>Configures the ASE loader to always reconstruct normal vectors basing on the smoothing groups loaded from the file.</summary>
        public const string PropertyImportAseReconstructNormals = "IMPORT_ASE_RECONSTRUCT_NORMALS";

        /// <summary>Set the vertex animation keyframe to be imported.</summary>
        public const string PropertyImportGlobalKeyframe = "IMPORT_GLOBAL_KEYFRAME";

        /// <summary>Specifies whether the IFC loader will use its own, custom triangulation algorithm to triangulate wall and floor meshes.</summary>
        public const string PropertyImportIfcCustomTriangulation = "IMPORT_IFC_CUSTOM_TRIANGULATION";

        /// <summary>Specifies whether the IFC loader skips over shape representations of type 'Curve2D'.</summary>
        public const string PropertyImportIfcSkipCurveRepresentations = "IMPORT_IFC_SKIP_CURVE_REPRESENTATIONS";

        /// <summary>Specifies whether the IFC loader skips over IfcSpace elements.</summary>
        public const string PropertyImportIfcSkipSpaceRepresentations = "IMPORT_IFC_SKIP_SPACE_REPRESENTATIONS";

        /// <summary>Defines the output frame rate of the IRR loader.</summary>
        public const string PropertyImportIrrAnimFps = "IMPORT_IRR_ANIM_FPS";

        /// <summary>Configures the LWO loader to load just one layer from the model.</summary>
        public const string PropertyImportLwoOneLayerOnly = "IMPORT_LWO_ONE_LAYER_ONLY";

        public const string PropertyImportLwsAnimEnd = "IMPORT_LWS_ANIM_END";

        /// <summary>Defines the begin of the time range for which the LWS loader evaluates animations and computes aiNodeAnim's.</summary>
        public const string PropertyImportLwsAnimStart = "IMPORT_LWS_ANIM_START";

        public const string PropertyImportMd2Keyframe = "IMPORT_MD2_KEYFRAME";

        /// <summary>Configures the M3D loader to detect and process multi-part Quake player models.</summary>
        public const string PropertyImportMd3HandleMultipart = "IMPORT_MD3_HANDLE_MULTIPART";

        public const string PropertyImportMd3Keyframe = "IMPORT_MD3_KEYFRAME";

        /// <summary>Specify the Quake 3 shader file to be used for a particular MD3 file.</summary>
        public const string PropertyImportMd3ShaderSrc = "IMPORT_MD3_SHADER_SRC";

        /// <summary>Tells the MD3 loader which skin files to load.</summary>
        public const string PropertyImportMd3SkinName = "IMPORT_MD3_SKIN_NAME";

        /// <summary>Configures the MD5 loader to not load the MD5ANIM file for a MD5MESH file automatically.</summary>
        public const string PropertyImportMd5NoAnimAutoload = "IMPORT_MD5_NO_ANIM_AUTOLOAD";

        public const string PropertyImportMdcKeyframe = "IMPORT_MDC_KEYFRAME";

        /// <summary>Sets the colormap (= palette) to be used to decode embedded textures in MDL (Quake or 3DGS) files.</summary>
        public const string PropertyImportMdlColormap = "IMPORT_MDL_COLORMAP";

        public const string PropertyImportMdlKeyframe = "IMPORT_MDL_KEYFRAME";

        /// <summary>Ogre Importer will try to load this Materialfile.</summary>
        public const string PropertyImportOgreMaterialFile = "IMPORT_OGRE_MATERIAL_FILE";

        /// <summary>Ogre Importer detect the texture usage from its filename.</summary>
        public const string PropertyImportOgreTexturetypeFromFilename = "IMPORT_OGRE_TEXTURETYPE_FROM_FILENAME";

        public const string PropertyImportSmdKeyframe = "IMPORT_SMD_KEYFRAME";

        /// <summary>Configures the terragen import plugin to compute uv's for terrains, if not given.</summary>
        public const string PropertyImportTerMakeUvs = "IMPORT_TER_MAKE_UVS";

        /// <summary>Configures the UNREAL 3D loader to separate faces with different surface flags </summary>
        public const string PropertyImportUnrealHandleFlags = "UNREAL_HANDLE_FLAGS";

        public const string PropertyImportUnrealKeyframe = "IMPORT_UNREAL_KEYFRAME";

        /// <summary>Specifies the maximum angle that may be between two vertex tangents that their tangents and bi-tangents are smoothed.</summary>
        public const string PropertyPpCtMaxSmoothingAngle = "PP_CT_MAX_SMOOTHING_ANGLE";

        /// <summary>Source UV channel for tangent space computation.</summary>
        public const string PropertyPpCtTextureChannelIndex = "PP_CT_TEXTURE_CHANNEL_INDEX";

        /// <summary>Require all bones qualify for deboning before removing any.</summary>
        public const string PropertyPpDbAllOrNone = "PP_DB_ALL_OR_NONE";

        /// <summary>Lower the deboning threshold in order to remove more bones.</summary>
        public const string PropertyPpDbThreshold = "PP_DB_THRESHOLD";

        /// <summary>Configures the aiProcess_FindDegenerates step to remove degenerated primitives from the import - immediately.</summary>
        public const string PropertyPpFdRemove = "PP_FD_REMOVE";

        /// <summary>Input parameter to the aiProcess_FindInvalidData step: Specifies the floating-point accuracy for animation values.</summary>
        public const string PropertyPpFidAnimAccuracy = "PP_FID_ANIM_ACCURACY";

        /// <summary>Specifies the maximum angle that may be between two face normals at the same vertex position that their are smoothed together.</summary>
        public const string PropertyPpGsnMaxSmoothingAngle = "PP_GSN_MAX_SMOOTHING_ANGLE";

        /// <summary>Set the size of the post-transform vertex cache to optimize the vertices for.</summary>
        public const string PropertyPpIclPtcacheSize = "PP_ICL_PTCACHE_SIZE";

        /// <summary>Set the maximum number of bones affecting a single vertex.</summary>
        public const string PropertyPpLbwMaxWeights = "PP_LBW_MAX_WEIGHTS";

        /// <summary>Configures the aiProcess_OptimizeGraph step to preserve nodes matching a name in a given list.</summary>
        public const string PropertyPpOgExcludeList = "PP_OG_EXCLUDE_LIST";

        /// <summary>Configures the #aiProcess_PretransformVertices step to keep the scene hierarchy.</summary>
        public const string PropertyPpPtvKeepHierarchy = "PP_PTV_KEEP_HIERARCHY";

        /// <summary>Configures the #aiProcess_PretransformVertices step to normalize all vertex components into the [-1,1] range.</summary>
        public const string PropertyPpPtvNormalize = "PP_PTV_NORMALIZE";

        /// <summary>Configures the aiProcess_RemoveRedundantMaterials step to keep materials matching a name in a given list.</summary>
        public const string PropertyPpRrmExcludeList = "PP_RRM_EXCLUDE_LIST";

        /// <summary>Input parameter to the aiProcess_RemoveComponent step: Specifies the parts of the data structure to be removed.</summary>
        public const string PropertyPpRvcFlags = "PP_RVC_FLAGS";

        /// <summary>Maximum bone count per mesh for the SplitbyBoneCount step.</summary>
        public const string PropertyPpSbbcMaxBones = "PP_SBBC_MAX_BONES";

        /// <summary>Input parameter to the aiProcess_SortByPType step: Specifies which primitive types are removed by the step.</summary>
        public const string PropertyPpSbpRemove = "PP_SBP_REMOVE";

        /// <summary>Set the maximum number of triangles in a mesh.</summary>
        public const string PropertyPpSlmTriangleLimit = "PP_SLM_TRIANGLE_LIMIT";

        /// <summary>Set the maximum number of vertices in a mesh.</summary>
        public const string PropertyPpSlmVertexLimit = "PP_SLM_VERTEX_LIMIT";

        /// <summary>Input parameter to the aiProcess_TransformUVCoords step: Specifies which UV transformations are evaluated. </summary>
        public const string PropertyPpTuvEvaluate = "PP_TUV_EVALUATE";
    }
}
