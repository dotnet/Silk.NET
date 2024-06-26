// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    public unsafe partial class Assimp : NativeAPI
    {
        [NativeName("Type", "const size_t")]
        [NativeName("Name", "MAXLEN")]
        public const nuint Maxlen = unchecked((nuint) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_FALSE")]
        public const int False = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_TRUE")]
        public const int True = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "AI_DEFAULT_MATERIAL_NAME")]
        public const string DefaultMaterialName = unchecked((string) "DefaultMaterial");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_NAME")]
        public const string MatkeyName = unchecked((string) "?mat.name");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_TWOSIDED")]
        public const string MatkeyTwosided = unchecked((string) "$mat.twosided");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADING_MODEL")]
        public const string MatkeyShadingModel = unchecked((string) "$mat.shadingm");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_ENABLE_WIREFRAME")]
        public const string MatkeyEnableWireframe = unchecked((string) "$mat.wireframe");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_BLEND_FUNC")]
        public const string MatkeyBlendFunc = unchecked((string) "$mat.blend");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_OPACITY")]
        public const string MatkeyOpacity = unchecked((string) "$mat.opacity");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_TRANSPARENCYFACTOR")]
        public const string MatkeyTransparencyfactor = unchecked((string) "$mat.transparencyfactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_BUMPSCALING")]
        public const string MatkeyBumpscaling = unchecked((string) "$mat.bumpscaling");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHININESS")]
        public const string MatkeyShininess = unchecked((string) "$mat.shininess");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_REFLECTIVITY")]
        public const string MatkeyReflectivity = unchecked((string) "$mat.reflectivity");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHININESS_STRENGTH")]
        public const string MatkeyShininessStrength = unchecked((string) "$mat.shinpercent");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_REFRACTI")]
        public const string MatkeyRefracti = unchecked((string) "$mat.refracti");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_DIFFUSE")]
        public const string MatkeyColorDiffuse = unchecked((string) "$clr.diffuse");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_AMBIENT")]
        public const string MatkeyColorAmbient = unchecked((string) "$clr.ambient");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_SPECULAR")]
        public const string MatkeyColorSpecular = unchecked((string) "$clr.specular");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_EMISSIVE")]
        public const string MatkeyColorEmissive = unchecked((string) "$clr.emissive");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_TRANSPARENT")]
        public const string MatkeyColorTransparent = unchecked((string) "$clr.transparent");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_REFLECTIVE")]
        public const string MatkeyColorReflective = unchecked((string) "$clr.reflective");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_GLOBAL_BACKGROUND_IMAGE")]
        public const string MatkeyGlobalBackgroundImage = unchecked((string) "?bg.global");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_GLOBAL_SHADERLANG")]
        public const string MatkeyGlobalShaderlang = unchecked((string) "?sh.lang");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_VERTEX")]
        public const string MatkeyShaderVertex = unchecked((string) "?sh.vs");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_FRAGMENT")]
        public const string MatkeyShaderFragment = unchecked((string) "?sh.fs");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_GEO")]
        public const string MatkeyShaderGeo = unchecked((string) "?sh.gs");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_TESSELATION")]
        public const string MatkeyShaderTesselation = unchecked((string) "?sh.ts");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_PRIMITIVE")]
        public const string MatkeyShaderPrimitive = unchecked((string) "?sh.ps");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_COMPUTE")]
        public const string MatkeyShaderCompute = unchecked((string) "?sh.cs");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_USE_COLOR_MAP")]
        public const string MatkeyUseColorMap = unchecked((string) "$mat.useColorMap");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_BASE_COLOR")]
        public const string MatkeyBaseColor = unchecked((string) "$clr.base");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_USE_METALLIC_MAP")]
        public const string MatkeyUseMetallicMap = unchecked((string) "$mat.useMetallicMap");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_METALLIC_FACTOR")]
        public const string MatkeyMetallicFactor = unchecked((string) "$mat.metallicFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_USE_ROUGHNESS_MAP")]
        public const string MatkeyUseRoughnessMap = unchecked((string) "$mat.useRoughnessMap");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_ROUGHNESS_FACTOR")]
        public const string MatkeyRoughnessFactor = unchecked((string) "$mat.roughnessFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_ANISOTROPY_FACTOR")]
        public const string MatkeyAnisotropyFactor = unchecked((string) "$mat.anisotropyFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SPECULAR_FACTOR")]
        public const string MatkeySpecularFactor = unchecked((string) "$mat.specularFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_GLOSSINESS_FACTOR")]
        public const string MatkeyGlossinessFactor = unchecked((string) "$mat.glossinessFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHEEN_COLOR_FACTOR")]
        public const string MatkeySheenColorFactor = unchecked((string) "$clr.sheen.factor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHEEN_ROUGHNESS_FACTOR")]
        public const string MatkeySheenRoughnessFactor = unchecked((string) "$mat.sheen.roughnessFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_CLEARCOAT_FACTOR")]
        public const string MatkeyClearcoatFactor = unchecked((string) "$mat.clearcoat.factor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_CLEARCOAT_ROUGHNESS_FACTOR")]
        public const string MatkeyClearcoatRoughnessFactor = unchecked((string) "$mat.clearcoat.roughnessFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_TRANSMISSION_FACTOR")]
        public const string MatkeyTransmissionFactor = unchecked((string) "$mat.transmission.factor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_VOLUME_THICKNESS_FACTOR")]
        public const string MatkeyVolumeThicknessFactor = unchecked((string) "$mat.volume.thicknessFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_VOLUME_ATTENUATION_DISTANCE")]
        public const string MatkeyVolumeAttenuationDistance = unchecked((string) "$mat.volume.attenuationDistance");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_VOLUME_ATTENUATION_COLOR")]
        public const string MatkeyVolumeAttenuationColor = unchecked((string) "$mat.volume.attenuationColor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_USE_EMISSIVE_MAP")]
        public const string MatkeyUseEmissiveMap = unchecked((string) "$mat.useEmissiveMap");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_EMISSIVE_INTENSITY")]
        public const string MatkeyEmissiveIntensity = unchecked((string) "$mat.emissiveIntensity");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_USE_AO_MAP")]
        public const string MatkeyUseAOMap = unchecked((string) "$mat.useAOMap");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_TEXTURE_BASE")]
        public const string MatkeyTextureBase = unchecked((string) "$tex.file");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_UVWSRC_BASE")]
        public const string MatkeyUvwsrcBase = unchecked((string) "$tex.uvwsrc");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_TEXOP_BASE")]
        public const string MatkeyTexopBase = unchecked((string) "$tex.op");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_MAPPING_BASE")]
        public const string MatkeyMappingBase = unchecked((string) "$tex.mapping");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_TEXBLEND_BASE")]
        public const string MatkeyTexblendBase = unchecked((string) "$tex.blend");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_MAPPINGMODE_U_BASE")]
        public const string MatkeyMappingmodeUBase = unchecked((string) "$tex.mapmodeu");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_MAPPINGMODE_V_BASE")]
        public const string MatkeyMappingmodeVBase = unchecked((string) "$tex.mapmodev");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_TEXMAP_AXIS_BASE")]
        public const string MatkeyTexmapAxisBase = unchecked((string) "$tex.mapaxis");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_UVTRANSFORM_BASE")]
        public const string MatkeyUvtransformBase = unchecked((string) "$tex.uvtrafo");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_TEXFLAGS_BASE")]
        public const string MatkeyTexflagsBase = unchecked((string) "$tex.flags");
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_SHARED")]
        public const int AssimpCflagsShared = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_STLPORT")]
        public const int AssimpCflagsStlport = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_DEBUG")]
        public const int AssimpCflagsDebug = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_NOBOOST")]
        public const int AssimpCflagsNoboost = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_SINGLETHREADED")]
        public const int AssimpCflagsSinglethreaded = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_DOUBLE_SUPPORT")]
        public const int AssimpCflagsDoubleSupport = unchecked((int) 0x20);
        [NativeName("Type", "")]
        [NativeName("Name", "AI_EMBEDDED_TEXNAME_PREFIX")]
        public const string EmbeddedTexnamePrefix = unchecked((string) "*");
        [NativeName("Type", "int")]
        [NativeName("Name", "HINTMAXTEXTURELEN")]
        public const int Hintmaxtexturelen = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_FACE_INDICES")]
        public const int MaxFaceIndices = unchecked((int) 0x7FFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_BONE_WEIGHTS")]
        public const int MaxBoneWeights = unchecked((int) 0x7FFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_VERTICES")]
        public const int MaxVertices = unchecked((int) 0x7FFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_FACES")]
        public const int MaxFaces = unchecked((int) 0x7FFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_NUMBER_OF_COLOR_SETS")]
        public const int MaxNumberOfColorSets = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_NUMBER_OF_TEXTURECOORDS")]
        public const int MaxNumberOfTexturecoords = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_INCOMPLETE")]
        public const int SceneFlagsIncomplete = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_VALIDATED")]
        public const int SceneFlagsValidated = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_VALIDATION_WARNING")]
        public const int SceneFlagsValidationWarning = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_NON_VERBOSE_FORMAT")]
        public const int SceneFlagsNonVerboseFormat = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_TERRAIN")]
        public const int SceneFlagsTerrain = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_ALLOW_SHARED")]
        public const int SceneFlagsAllowShared = unchecked((int) 0x20);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 19 in cexport.h")]
        [NativeApi(EntryPoint = "aiGetExportFormatCount")]
        public partial nuint GetExportFormatCount();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 100, Column 47 in cexport.h")]
        [NativeApi(EntryPoint = "aiGetExportFormatDescription")]
        public unsafe partial ExportFormatDesc* GetExportFormatDescription(nuint pIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 17 in cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportFormatDescription")]
        public unsafe partial void ReleaseExportFormatDescription([Flow(Silk.NET.Core.Native.FlowDirection.In)] ExportFormatDesc* desc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 17 in cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportFormatDescription")]
        public partial void ReleaseExportFormatDescription([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ExportFormatDesc desc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 17 in cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene")]
        public unsafe partial void CopyScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pIn, Scene** pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 17 in cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene")]
        public unsafe partial void CopyScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pIn, ref Scene* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 17 in cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene")]
        public unsafe partial void CopyScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pIn, Scene** pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 17 in cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene")]
        public unsafe partial void CopyScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pIn, ref Scene* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 17 in cexport.h")]
        [NativeApi(EntryPoint = "aiFreeScene")]
        public unsafe partial void FreeScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pIn);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 17 in cexport.h")]
        [NativeApi(EntryPoint = "aiFreeScene")]
        public partial void FreeScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pIn);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public unsafe partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene")]
        public partial Return ExportScene([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public unsafe partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public partial Return ExportSceneEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 17 in cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportBlob")]
        public unsafe partial void ReleaseExportBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] ExportDataBlob* pData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 17 in cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportBlob")]
        public partial void ReleaseExportBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ExportDataBlob pData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 43 in importerdesc.h")]
        [NativeApi(EntryPoint = "aiGetImporterDesc")]
        public unsafe partial ImporterDesc* GetImporterDesc([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 43 in importerdesc.h")]
        [NativeApi(EntryPoint = "aiGetImporterDesc")]
        public unsafe partial ImporterDesc* GetImporterDesc([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 43 in importerdesc.h")]
        [NativeApi(EntryPoint = "aiGetImporterDesc")]
        public unsafe partial ImporterDesc* GetImporterDesc([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFile")]
        public unsafe partial Scene* ImportFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFile")]
        public unsafe partial Scene* ImportFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFile, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFile")]
        public unsafe partial Scene* ImportFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public unsafe partial Scene* ImportFileEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public unsafe partial Scene* ImportFileEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags, ref FileIO pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public unsafe partial Scene* ImportFileEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public unsafe partial Scene* ImportFileEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFile, uint pFlags, ref FileIO pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public unsafe partial Scene* ImportFileEx([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public unsafe partial Scene* ImportFileEx([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, ref FileIO pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags, FileIO* pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags, FileIO* pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags, ref FileIO pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags, ref FileIO pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFile, uint pFlags, FileIO* pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFile, uint pFlags, FileIO* pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFile, uint pFlags, ref FileIO pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFile, uint pFlags, ref FileIO pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, ref FileIO pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public unsafe partial Scene* ImportFileExWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, ref FileIO pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public unsafe partial Scene* ImportFileFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public unsafe partial Scene* ImportFileFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public unsafe partial Scene* ImportFileFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public unsafe partial Scene* ImportFileFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public unsafe partial Scene* ImportFileFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public unsafe partial Scene* ImportFileFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public unsafe partial Scene* ImportFileFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public unsafe partial Scene* ImportFileFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public unsafe partial Scene* ImportFileFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 256, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiApplyPostProcessing")]
        public unsafe partial Scene* ApplyPostProcessing([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 256, Column 36 in cimport.h")]
        [NativeApi(EntryPoint = "aiApplyPostProcessing")]
        public unsafe partial Scene* ApplyPostProcessing([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 280, Column 33 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream")]
        public unsafe partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* file);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 280, Column 33 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream")]
        public partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte file);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 280, Column 33 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream")]
        public partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 294, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiAttachLogStream")]
        public unsafe partial void AttachLogStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] LogStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 294, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiAttachLogStream")]
        public partial void AttachLogStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LogStream stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiEnableVerboseLogging")]
        public partial void EnableVerboseLogging(int d);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 28 in cimport.h")]
        [NativeApi(EntryPoint = "aiDetachLogStream")]
        public unsafe partial Return DetachLogStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] LogStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 28 in cimport.h")]
        [NativeApi(EntryPoint = "aiDetachLogStream")]
        public partial Return DetachLogStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LogStream stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 326, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDetachAllLogStreams")]
        public partial void DetachAllLogStreams();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiReleaseImport")]
        public unsafe partial void ReleaseImport([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiReleaseImport")]
        public partial void ReleaseImport([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pScene);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 344, Column 24 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetErrorString")]
        public unsafe partial byte* GetErrorString();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 344, Column 24 in cimport.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "aiGetErrorString")]
        public partial string GetErrorStringS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 19 in cimport.h")]
        [NativeApi(EntryPoint = "aiIsExtensionSupported")]
        public unsafe partial int IsExtensionSupported([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szExtension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 19 in cimport.h")]
        [NativeApi(EntryPoint = "aiIsExtensionSupported")]
        public partial int IsExtensionSupported([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szExtension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 19 in cimport.h")]
        [NativeApi(EntryPoint = "aiIsExtensionSupported")]
        public partial int IsExtensionSupported([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szExtension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 364, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetExtensionList")]
        public unsafe partial void GetExtensionList(AssimpString* szOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 364, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetExtensionList")]
        public partial void GetExtensionList(ref AssimpString szOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 372, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements")]
        public unsafe partial void GetMemoryRequirements([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pIn, MemoryInfo* @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 372, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements")]
        public unsafe partial void GetMemoryRequirements([Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pIn, ref MemoryInfo @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 372, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements")]
        public unsafe partial void GetMemoryRequirements([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pIn, MemoryInfo* @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 372, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements")]
        public partial void GetMemoryRequirements([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Scene pIn, ref MemoryInfo @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 382, Column 38 in cimport.h")]
        [NativeApi(EntryPoint = "aiCreatePropertyStore")]
        public unsafe partial PropertyStore* CreatePropertyStore();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 388, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiReleasePropertyStore")]
        public unsafe partial void ReleasePropertyStore(PropertyStore* p);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 388, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiReleasePropertyStore")]
        public partial void ReleasePropertyStore(ref PropertyStore p);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public unsafe partial void SetImportPropertyInteger(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public unsafe partial void SetImportPropertyInteger(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public unsafe partial void SetImportPropertyInteger(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public unsafe partial void SetImportPropertyInteger(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public partial void SetImportPropertyInteger(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public partial void SetImportPropertyInteger(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public unsafe partial void SetImportPropertyFloat(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public unsafe partial void SetImportPropertyFloat(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public unsafe partial void SetImportPropertyFloat(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public unsafe partial void SetImportPropertyFloat(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public partial void SetImportPropertyFloat(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public partial void SetImportPropertyFloat(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public partial void SetImportPropertyString(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public partial void SetImportPropertyString(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public partial void SetImportPropertyMatrix(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public partial void SetImportPropertyMatrix(ref PropertyStore store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix")]
        public unsafe partial void CreateQuaternionFromMatrix(AssimpQuaternion* quat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix")]
        public unsafe partial void CreateQuaternionFromMatrix(AssimpQuaternion* quat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix")]
        public unsafe partial void CreateQuaternionFromMatrix(ref AssimpQuaternion quat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix")]
        public partial void CreateQuaternionFromMatrix(ref AssimpQuaternion quat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public unsafe partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public partial void DecomposeMatrix([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 488, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix4")]
        public unsafe partial void TransposeMatrix4(System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 488, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix4")]
        public partial void TransposeMatrix4(ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix3")]
        public unsafe partial void TransposeMatrix3(Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix3")]
        public partial void TransposeMatrix3(ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3")]
        public unsafe partial void TransformVecByMatrix3(System.Numerics.Vector3* vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3")]
        public unsafe partial void TransformVecByMatrix3(System.Numerics.Vector3* vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3")]
        public unsafe partial void TransformVecByMatrix3(ref System.Numerics.Vector3 vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3")]
        public partial void TransformVecByMatrix3(ref System.Numerics.Vector3 vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4")]
        public unsafe partial void TransformVecByMatrix4(System.Numerics.Vector3* vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4")]
        public unsafe partial void TransformVecByMatrix4(System.Numerics.Vector3* vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4")]
        public unsafe partial void TransformVecByMatrix4(ref System.Numerics.Vector3 vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4")]
        public partial void TransformVecByMatrix4(ref System.Numerics.Vector3 vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4")]
        public unsafe partial void MultiplyMatrix4(System.Numerics.Matrix4x4* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4")]
        public unsafe partial void MultiplyMatrix4(System.Numerics.Matrix4x4* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4")]
        public unsafe partial void MultiplyMatrix4(ref System.Numerics.Matrix4x4 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4")]
        public partial void MultiplyMatrix4(ref System.Numerics.Matrix4x4 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3")]
        public unsafe partial void MultiplyMatrix3(Silk.NET.Maths.Matrix3X3<float>* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3")]
        public unsafe partial void MultiplyMatrix3(Silk.NET.Maths.Matrix3X3<float>* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3")]
        public unsafe partial void MultiplyMatrix3(ref Silk.NET.Maths.Matrix3X3<float> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3")]
        public partial void MultiplyMatrix3(ref Silk.NET.Maths.Matrix3X3<float> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 538, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix3")]
        public unsafe partial void IdentityMatrix3(Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 538, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix3")]
        public partial void IdentityMatrix3(ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 545, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix4")]
        public unsafe partial void IdentityMatrix4(System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 545, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix4")]
        public partial void IdentityMatrix4(ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 552, Column 19 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetImportFormatCount")]
        public partial nuint GetImportFormatCount();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 561, Column 43 in cimport.h")]
        [NativeApi(EntryPoint = "aiGetImportFormatDescription")]
        public unsafe partial ImporterDesc* GetImportFormatDescription(nuint pIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqual")]
        public unsafe partial int Vector2AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqual")]
        public unsafe partial int Vector2AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqual")]
        public unsafe partial int Vector2AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqual")]
        public partial int Vector2AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqualEpsilon")]
        public unsafe partial int Vector2AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqualEpsilon")]
        public unsafe partial int Vector2AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqualEpsilon")]
        public unsafe partial int Vector2AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqualEpsilon")]
        public partial int Vector2AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Add")]
        public unsafe partial void Vector2Add(System.Numerics.Vector2* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Add")]
        public unsafe partial void Vector2Add(System.Numerics.Vector2* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Add")]
        public unsafe partial void Vector2Add(ref System.Numerics.Vector2 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Add")]
        public partial void Vector2Add(ref System.Numerics.Vector2 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Subtract")]
        public unsafe partial void Vector2Subtract(System.Numerics.Vector2* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Subtract")]
        public unsafe partial void Vector2Subtract(System.Numerics.Vector2* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Subtract")]
        public unsafe partial void Vector2Subtract(ref System.Numerics.Vector2 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Subtract")]
        public partial void Vector2Subtract(ref System.Numerics.Vector2 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Scale")]
        public unsafe partial void Vector2Scale(System.Numerics.Vector2* dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Scale")]
        public partial void Vector2Scale(ref System.Numerics.Vector2 dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SymMul")]
        public unsafe partial void Vector2SymMul(System.Numerics.Vector2* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SymMul")]
        public unsafe partial void Vector2SymMul(System.Numerics.Vector2* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SymMul")]
        public unsafe partial void Vector2SymMul(ref System.Numerics.Vector2 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SymMul")]
        public partial void Vector2SymMul(ref System.Numerics.Vector2 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 629, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByScalar")]
        public unsafe partial void Vector2DivideByScalar(System.Numerics.Vector2* dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 629, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByScalar")]
        public partial void Vector2DivideByScalar(ref System.Numerics.Vector2 dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByVector")]
        public unsafe partial void Vector2DivideByVector(System.Numerics.Vector2* dst, System.Numerics.Vector2* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByVector")]
        public unsafe partial void Vector2DivideByVector(System.Numerics.Vector2* dst, ref System.Numerics.Vector2 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByVector")]
        public unsafe partial void Vector2DivideByVector(ref System.Numerics.Vector2 dst, System.Numerics.Vector2* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByVector")]
        public partial void Vector2DivideByVector(ref System.Numerics.Vector2 dst, ref System.Numerics.Vector2 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Length")]
        public unsafe partial float Vector2Length([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Length")]
        public partial float Vector2Length([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SquareLength")]
        public unsafe partial float Vector2SquareLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SquareLength")]
        public partial float Vector2SquareLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 661, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Negate")]
        public unsafe partial void Vector2Negate(System.Numerics.Vector2* dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 661, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Negate")]
        public partial void Vector2Negate(ref System.Numerics.Vector2 dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 670, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DotProduct")]
        public unsafe partial float Vector2DotProduct([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 670, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DotProduct")]
        public unsafe partial float Vector2DotProduct([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 670, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DotProduct")]
        public unsafe partial float Vector2DotProduct([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 670, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DotProduct")]
        public partial float Vector2DotProduct([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 678, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Normalize")]
        public unsafe partial void Vector2Normalize(System.Numerics.Vector2* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 678, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Normalize")]
        public partial void Vector2Normalize(ref System.Numerics.Vector2 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 688, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqual")]
        public unsafe partial int Vector3AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 688, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqual")]
        public unsafe partial int Vector3AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 688, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqual")]
        public unsafe partial int Vector3AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 688, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqual")]
        public partial int Vector3AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqualEpsilon")]
        public unsafe partial int Vector3AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqualEpsilon")]
        public unsafe partial int Vector3AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqualEpsilon")]
        public unsafe partial int Vector3AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqualEpsilon")]
        public partial int Vector3AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3LessThan")]
        public unsafe partial int Vector3LessThan([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3LessThan")]
        public unsafe partial int Vector3LessThan([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3LessThan")]
        public unsafe partial int Vector3LessThan([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3LessThan")]
        public partial int Vector3LessThan([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Add")]
        public unsafe partial void Vector3Add(System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Add")]
        public unsafe partial void Vector3Add(System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Add")]
        public unsafe partial void Vector3Add(ref System.Numerics.Vector3 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Add")]
        public partial void Vector3Add(ref System.Numerics.Vector3 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Subtract")]
        public unsafe partial void Vector3Subtract(System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Subtract")]
        public unsafe partial void Vector3Subtract(System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Subtract")]
        public unsafe partial void Vector3Subtract(ref System.Numerics.Vector3 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Subtract")]
        public partial void Vector3Subtract(ref System.Numerics.Vector3 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 740, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Scale")]
        public unsafe partial void Vector3Scale(System.Numerics.Vector3* dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 740, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Scale")]
        public partial void Vector3Scale(ref System.Numerics.Vector3 dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 750, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SymMul")]
        public unsafe partial void Vector3SymMul(System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 750, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SymMul")]
        public unsafe partial void Vector3SymMul(System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 750, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SymMul")]
        public unsafe partial void Vector3SymMul(ref System.Numerics.Vector3 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 750, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SymMul")]
        public partial void Vector3SymMul(ref System.Numerics.Vector3 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 759, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByScalar")]
        public unsafe partial void Vector3DivideByScalar(System.Numerics.Vector3* dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 759, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByScalar")]
        public partial void Vector3DivideByScalar(ref System.Numerics.Vector3 dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByVector")]
        public unsafe partial void Vector3DivideByVector(System.Numerics.Vector3* dst, System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByVector")]
        public unsafe partial void Vector3DivideByVector(System.Numerics.Vector3* dst, ref System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByVector")]
        public unsafe partial void Vector3DivideByVector(ref System.Numerics.Vector3 dst, System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByVector")]
        public partial void Vector3DivideByVector(ref System.Numerics.Vector3 dst, ref System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Length")]
        public unsafe partial float Vector3Length([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Length")]
        public partial float Vector3Length([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SquareLength")]
        public unsafe partial float Vector3SquareLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SquareLength")]
        public partial float Vector3SquareLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Negate")]
        public unsafe partial void Vector3Negate(System.Numerics.Vector3* dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Negate")]
        public partial void Vector3Negate(ref System.Numerics.Vector3 dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DotProduct")]
        public unsafe partial float Vector3DotProduct([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DotProduct")]
        public unsafe partial float Vector3DotProduct([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DotProduct")]
        public unsafe partial float Vector3DotProduct([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DotProduct")]
        public partial float Vector3DotProduct([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct")]
        public unsafe partial void Vector3CrossProduct(System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct")]
        public unsafe partial void Vector3CrossProduct(System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct")]
        public unsafe partial void Vector3CrossProduct(System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct")]
        public unsafe partial void Vector3CrossProduct(System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct")]
        public unsafe partial void Vector3CrossProduct(ref System.Numerics.Vector3 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct")]
        public unsafe partial void Vector3CrossProduct(ref System.Numerics.Vector3 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct")]
        public unsafe partial void Vector3CrossProduct(ref System.Numerics.Vector3 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct")]
        public partial void Vector3CrossProduct(ref System.Numerics.Vector3 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Normalize")]
        public unsafe partial void Vector3Normalize(System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Normalize")]
        public partial void Vector3Normalize(ref System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 827, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3NormalizeSafe")]
        public unsafe partial void Vector3NormalizeSafe(System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 827, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3NormalizeSafe")]
        public partial void Vector3NormalizeSafe(ref System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3RotateByQuaternion")]
        public unsafe partial void Vector3RotateByQuaternion(System.Numerics.Vector3* v, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3RotateByQuaternion")]
        public unsafe partial void Vector3RotateByQuaternion(System.Numerics.Vector3* v, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3RotateByQuaternion")]
        public unsafe partial void Vector3RotateByQuaternion(ref System.Numerics.Vector3 v, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiVector3RotateByQuaternion")]
        public partial void Vector3RotateByQuaternion(ref System.Numerics.Vector3 v, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromMatrix4")]
        public unsafe partial void Matrix3FromMatrix4(Silk.NET.Maths.Matrix3X3<float>* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromMatrix4")]
        public unsafe partial void Matrix3FromMatrix4(Silk.NET.Maths.Matrix3X3<float>* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromMatrix4")]
        public unsafe partial void Matrix3FromMatrix4(ref Silk.NET.Maths.Matrix3X3<float> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromMatrix4")]
        public partial void Matrix3FromMatrix4(ref Silk.NET.Maths.Matrix3X3<float> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromQuaternion")]
        public unsafe partial void Matrix3FromQuaternion(Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromQuaternion")]
        public unsafe partial void Matrix3FromQuaternion(Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromQuaternion")]
        public unsafe partial void Matrix3FromQuaternion(ref Silk.NET.Maths.Matrix3X3<float> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromQuaternion")]
        public partial void Matrix3FromQuaternion(ref Silk.NET.Maths.Matrix3X3<float> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqual")]
        public unsafe partial int Matrix3AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqual")]
        public unsafe partial int Matrix3AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqual")]
        public unsafe partial int Matrix3AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqual")]
        public partial int Matrix3AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqualEpsilon")]
        public unsafe partial int Matrix3AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqualEpsilon")]
        public unsafe partial int Matrix3AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqualEpsilon")]
        public unsafe partial int Matrix3AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqualEpsilon")]
        public partial int Matrix3AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 885, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Inverse")]
        public unsafe partial void Matrix3Inverse(Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 885, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Inverse")]
        public partial void Matrix3Inverse(ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 892, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Determinant")]
        public unsafe partial float Matrix3Determinant([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 892, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Determinant")]
        public partial float Matrix3Determinant([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 900, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3RotationZ")]
        public unsafe partial void Matrix3RotationZ(Silk.NET.Maths.Matrix3X3<float>* mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 900, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3RotationZ")]
        public partial void Matrix3RotationZ(ref Silk.NET.Maths.Matrix3X3<float> mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromRotationAroundAxis")]
        public unsafe partial void Matrix3FromRotationAroundAxis(Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromRotationAroundAxis")]
        public unsafe partial void Matrix3FromRotationAroundAxis(Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromRotationAroundAxis")]
        public unsafe partial void Matrix3FromRotationAroundAxis(ref Silk.NET.Maths.Matrix3X3<float> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromRotationAroundAxis")]
        public partial void Matrix3FromRotationAroundAxis(ref Silk.NET.Maths.Matrix3X3<float> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Translation")]
        public unsafe partial void Matrix3Translation(Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Translation")]
        public unsafe partial void Matrix3Translation(Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Translation")]
        public unsafe partial void Matrix3Translation(ref Silk.NET.Maths.Matrix3X3<float> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Translation")]
        public partial void Matrix3Translation(ref Silk.NET.Maths.Matrix3X3<float> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector2 translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo")]
        public unsafe partial void Matrix3FromTo(Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo")]
        public unsafe partial void Matrix3FromTo(Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo")]
        public unsafe partial void Matrix3FromTo(Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo")]
        public unsafe partial void Matrix3FromTo(Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo")]
        public unsafe partial void Matrix3FromTo(ref Silk.NET.Maths.Matrix3X3<float> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo")]
        public unsafe partial void Matrix3FromTo(ref Silk.NET.Maths.Matrix3X3<float> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo")]
        public unsafe partial void Matrix3FromTo(ref Silk.NET.Maths.Matrix3X3<float> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo")]
        public partial void Matrix3FromTo(ref Silk.NET.Maths.Matrix3X3<float> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromMatrix3")]
        public unsafe partial void Matrix4FromMatrix3(System.Numerics.Matrix4x4* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromMatrix3")]
        public unsafe partial void Matrix4FromMatrix3(System.Numerics.Matrix4x4* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromMatrix3")]
        public unsafe partial void Matrix4FromMatrix3(ref System.Numerics.Matrix4x4 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromMatrix3")]
        public partial void Matrix4FromMatrix3(ref System.Numerics.Matrix4x4 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition")]
        public partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Add")]
        public unsafe partial void Matrix4Add(System.Numerics.Matrix4x4* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Add")]
        public unsafe partial void Matrix4Add(System.Numerics.Matrix4x4* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Add")]
        public unsafe partial void Matrix4Add(ref System.Numerics.Matrix4x4 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Add")]
        public partial void Matrix4Add(ref System.Numerics.Matrix4x4 dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqual")]
        public unsafe partial int Matrix4AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqual")]
        public unsafe partial int Matrix4AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqual")]
        public unsafe partial int Matrix4AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqual")]
        public partial int Matrix4AreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqualEpsilon")]
        public unsafe partial int Matrix4AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqualEpsilon")]
        public unsafe partial int Matrix4AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqualEpsilon")]
        public unsafe partial int Matrix4AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqualEpsilon")]
        public partial int Matrix4AreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 994, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Inverse")]
        public unsafe partial void Matrix4Inverse(System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 994, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Inverse")]
        public partial void Matrix4Inverse(ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1002, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Determinant")]
        public unsafe partial float Matrix4Determinant([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1002, Column 18 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Determinant")]
        public partial float Matrix4Determinant([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4IsIdentity")]
        public unsafe partial int Matrix4IsIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4IsIdentity")]
        public partial int Matrix4IsIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition")]
        public partial void Matrix4DecomposeIntoScalingEulerAnglesPosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition")]
        public partial void Matrix4DecomposeIntoScalingAxisAnglePosition([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling")]
        public unsafe partial void Matrix4DecomposeNoScaling([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling")]
        public unsafe partial void Matrix4DecomposeNoScaling([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling")]
        public unsafe partial void Matrix4DecomposeNoScaling([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling")]
        public unsafe partial void Matrix4DecomposeNoScaling([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling")]
        public unsafe partial void Matrix4DecomposeNoScaling([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling")]
        public unsafe partial void Matrix4DecomposeNoScaling([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling")]
        public unsafe partial void Matrix4DecomposeNoScaling([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling")]
        public partial void Matrix4DecomposeNoScaling([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 mat, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1067, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromEulerAngles")]
        public unsafe partial void Matrix4FromEulerAngles(System.Numerics.Matrix4x4* mat, float x, float y, float z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1067, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromEulerAngles")]
        public partial void Matrix4FromEulerAngles(ref System.Numerics.Matrix4x4 mat, float x, float y, float z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationX")]
        public unsafe partial void Matrix4RotationX(System.Numerics.Matrix4x4* mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationX")]
        public partial void Matrix4RotationX(ref System.Numerics.Matrix4x4 mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1085, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationY")]
        public unsafe partial void Matrix4RotationY(System.Numerics.Matrix4x4* mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1085, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationY")]
        public partial void Matrix4RotationY(ref System.Numerics.Matrix4x4 mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1094, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationZ")]
        public unsafe partial void Matrix4RotationZ(System.Numerics.Matrix4x4* mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1094, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationZ")]
        public partial void Matrix4RotationZ(ref System.Numerics.Matrix4x4 mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromRotationAroundAxis")]
        public unsafe partial void Matrix4FromRotationAroundAxis(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromRotationAroundAxis")]
        public unsafe partial void Matrix4FromRotationAroundAxis(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromRotationAroundAxis")]
        public unsafe partial void Matrix4FromRotationAroundAxis(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromRotationAroundAxis")]
        public partial void Matrix4FromRotationAroundAxis(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1114, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Translation")]
        public unsafe partial void Matrix4Translation(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1114, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Translation")]
        public unsafe partial void Matrix4Translation(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1114, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Translation")]
        public unsafe partial void Matrix4Translation(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1114, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Translation")]
        public partial void Matrix4Translation(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Scaling")]
        public unsafe partial void Matrix4Scaling(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Scaling")]
        public unsafe partial void Matrix4Scaling(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 scaling);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Scaling")]
        public unsafe partial void Matrix4Scaling(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Scaling")]
        public partial void Matrix4Scaling(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 scaling);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo")]
        public unsafe partial void Matrix4FromTo(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo")]
        public unsafe partial void Matrix4FromTo(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo")]
        public unsafe partial void Matrix4FromTo(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo")]
        public unsafe partial void Matrix4FromTo(System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo")]
        public unsafe partial void Matrix4FromTo(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo")]
        public unsafe partial void Matrix4FromTo(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo")]
        public unsafe partial void Matrix4FromTo(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo")]
        public partial void Matrix4FromTo(ref System.Numerics.Matrix4x4 mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1145, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromEulerAngles")]
        public unsafe partial void QuaternionFromEulerAngles(AssimpQuaternion* q, float x, float y, float z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1145, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromEulerAngles")]
        public partial void QuaternionFromEulerAngles(ref AssimpQuaternion q, float x, float y, float z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromAxisAngle")]
        public unsafe partial void QuaternionFromAxisAngle(AssimpQuaternion* q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromAxisAngle")]
        public unsafe partial void QuaternionFromAxisAngle(AssimpQuaternion* q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromAxisAngle")]
        public unsafe partial void QuaternionFromAxisAngle(ref AssimpQuaternion q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromAxisAngle")]
        public partial void QuaternionFromAxisAngle(ref AssimpQuaternion q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromNormalizedQuaternion")]
        public unsafe partial void QuaternionFromNormalizedQuaternion(AssimpQuaternion* q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* normalized);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromNormalizedQuaternion")]
        public unsafe partial void QuaternionFromNormalizedQuaternion(AssimpQuaternion* q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 normalized);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromNormalizedQuaternion")]
        public unsafe partial void QuaternionFromNormalizedQuaternion(ref AssimpQuaternion q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* normalized);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromNormalizedQuaternion")]
        public partial void QuaternionFromNormalizedQuaternion(ref AssimpQuaternion q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Vector3 normalized);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqual")]
        public unsafe partial int QuaternionAreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqual")]
        public unsafe partial int QuaternionAreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqual")]
        public unsafe partial int QuaternionAreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqual")]
        public partial int QuaternionAreEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqualEpsilon")]
        public unsafe partial int QuaternionAreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqualEpsilon")]
        public unsafe partial int QuaternionAreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqualEpsilon")]
        public unsafe partial int QuaternionAreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 16 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqualEpsilon")]
        public partial int QuaternionAreEqualEpsilon([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1198, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionNormalize")]
        public unsafe partial void QuaternionNormalize(AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1198, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionNormalize")]
        public partial void QuaternionNormalize(ref AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1206, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionConjugate")]
        public unsafe partial void QuaternionConjugate(AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1206, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionConjugate")]
        public partial void QuaternionConjugate(ref AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionMultiply")]
        public unsafe partial void QuaternionMultiply(AssimpQuaternion* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionMultiply")]
        public unsafe partial void QuaternionMultiply(AssimpQuaternion* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionMultiply")]
        public unsafe partial void QuaternionMultiply(ref AssimpQuaternion dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionMultiply")]
        public partial void QuaternionMultiply(ref AssimpQuaternion dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate")]
        public unsafe partial void QuaternionInterpolate(AssimpQuaternion* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate")]
        public unsafe partial void QuaternionInterpolate(AssimpQuaternion* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate")]
        public unsafe partial void QuaternionInterpolate(AssimpQuaternion* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate")]
        public unsafe partial void QuaternionInterpolate(AssimpQuaternion* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate")]
        public unsafe partial void QuaternionInterpolate(ref AssimpQuaternion dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate")]
        public unsafe partial void QuaternionInterpolate(ref AssimpQuaternion dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate")]
        public unsafe partial void QuaternionInterpolate(ref AssimpQuaternion dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate")]
        public partial void QuaternionInterpolate(ref AssimpQuaternion dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AssimpQuaternion end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 338, Column 24 in material.h")]
        [NativeApi(EntryPoint = "aiTextureTypeToString")]
        public unsafe partial byte* TextureTypeToString(TextureType @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 338, Column 24 in material.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "aiTextureTypeToString")]
        public partial string TextureTypeToStringS(TextureType @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public unsafe partial Return GetMaterialProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public unsafe partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public partial Return GetMaterialFloatArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public unsafe partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public partial Return GetMaterialIntegerArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public unsafe partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public unsafe partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public unsafe partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public unsafe partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public unsafe partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public unsafe partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public unsafe partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public unsafe partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public unsafe partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public unsafe partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public partial Return GetMaterialColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public unsafe partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public unsafe partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public unsafe partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public unsafe partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public unsafe partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public unsafe partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public unsafe partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public unsafe partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public unsafe partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public unsafe partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public partial Return GetMaterialUVTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public unsafe partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public unsafe partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public unsafe partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public unsafe partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public unsafe partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public unsafe partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public unsafe partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public unsafe partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public unsafe partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public unsafe partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public partial Return GetMaterialString([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1610, Column 25 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTextureCount")]
        public unsafe partial uint GetMaterialTextureCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, TextureType type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1610, Column 25 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTextureCount")]
        public partial uint GetMaterialTextureCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material pMat, TextureType type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public unsafe partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public partial Return GetMaterialTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 25 in version.h")]
        [NativeApi(EntryPoint = "aiGetLegalString")]
        public unsafe partial byte* GetLegalString();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 25 in version.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "aiGetLegalString")]
        public partial string GetLegalStringS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 68, Column 25 in version.h")]
        [NativeApi(EntryPoint = "aiGetVersionPatch")]
        public partial uint GetVersionPatch();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 75, Column 25 in version.h")]
        [NativeApi(EntryPoint = "aiGetVersionMinor")]
        public partial uint GetVersionMinor();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 82, Column 25 in version.h")]
        [NativeApi(EntryPoint = "aiGetVersionMajor")]
        public partial uint GetVersionMajor();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 25 in version.h")]
        [NativeApi(EntryPoint = "aiGetVersionRevision")]
        public partial uint GetVersionRevision();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 24 in version.h")]
        [NativeApi(EntryPoint = "aiGetBranchName")]
        public unsafe partial byte* GetBranchName();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 24 in version.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "aiGetBranchName")]
        public partial string GetBranchNameS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 115, Column 25 in version.h")]
        [NativeApi(EntryPoint = "aiGetCompileFlags")]
        public partial uint GetCompileFlags();


        public Assimp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

