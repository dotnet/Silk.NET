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

namespace Silk.NET.Core.Native
{
    public unsafe partial class D3DCommon
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION")]
        public const int D3DFL91ReqTexture1DUDimension = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION")]
        public const int D3DFL93ReqTexture1DUDimension = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION")]
        public const int D3DFL91ReqTexture2DUOrVDimension = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION")]
        public const int D3DFL93ReqTexture2DUOrVDimension = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION")]
        public const int D3DFL91ReqTexturecubeDimension = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION")]
        public const int D3DFL93ReqTexturecubeDimension = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION")]
        public const int D3DFL91ReqTexture3DUVOrWDimension = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_DEFAULT_MAX_ANISOTROPY")]
        public const int D3DFL91DefaultMaxAnisotropy = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT")]
        public const int D3DFL91IAPrimitiveMaxCount = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT")]
        public const int D3DFL92IAPrimitiveMaxCount = unchecked((int) 0xFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT")]
        public const int D3DFL91SimultaneousRenderTargetCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT")]
        public const int D3DFL93SimultaneousRenderTargetCount = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_MAX_TEXTURE_REPEAT")]
        public const int D3DFL91MaxTextureRepeat = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_2_MAX_TEXTURE_REPEAT")]
        public const int D3DFL92MaxTextureRepeat = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_3_MAX_TEXTURE_REPEAT")]
        public const int D3DFL93MaxTextureRepeat = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_DOUBLES")]
        public const int D3DShaderFeatureDoubles = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_COMPUTE_SHADERS_PLUS_RAW_AND_STRUCTURED_BUFFERS_VIA_SHADER_4_X")]
        public const int D3DShaderFeatureComputeShadersPlusRawAndStructuredBuffersViaShader4X = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_UAVS_AT_EVERY_STAGE")]
        public const int D3DShaderFeatureUavsATEveryStage = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_64_UAVS")]
        public const int D3DShaderFeature64Uavs = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_MINIMUM_PRECISION")]
        public const int D3DShaderFeatureMinimumPrecision = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_11_1_DOUBLE_EXTENSIONS")]
        public const int D3DShaderFeature111DoubleExtensions = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_11_1_SHADER_EXTENSIONS")]
        public const int D3DShaderFeature111ShaderExtensions = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_LEVEL_9_COMPARISON_FILTERING")]
        public const int D3DShaderFeatureLevel9ComparisonFiltering = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_TILED_RESOURCES")]
        public const int D3DShaderFeatureTiledResources = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_STENCIL_REF")]
        public const int D3DShaderFeatureStencilRef = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_INNER_COVERAGE")]
        public const int D3DShaderFeatureInnerCoverage = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_TYPED_UAV_LOAD_ADDITIONAL_FORMATS")]
        public const int D3DShaderFeatureTypedUavLoadAdditionalFormats = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_ROVS")]
        public const int D3DShaderFeatureRovs = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER")]
        public const int D3DShaderFeatureViewportAndRTArrayIndexFromAnyShaderFeedingRasterizer = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_WAVE_OPS")]
        public const int D3DShaderFeatureWaveOps = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_INT64_OPS")]
        public const int D3DShaderFeatureInt64Ops = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_VIEW_ID")]
        public const int D3DShaderFeatureViewID = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_BARYCENTRICS")]
        public const int D3DShaderFeatureBarycentrics = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_NATIVE_16BIT_OPS")]
        public const int D3DShaderFeatureNative16BitOps = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_SHADING_RATE")]
        public const int D3DShaderFeatureShadingRate = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_RAYTRACING_TIER_1_1")]
        public const int D3DShaderFeatureRaytracingTier11 = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_SAMPLER_FEEDBACK")]
        public const int D3DShaderFeatureSamplerFeedback = unchecked((int) 0x200000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_ATOMIC_INT64_ON_TYPED_RESOURCE")]
        public const int D3DShaderFeatureAtomicInt64OnTypedResource = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_ATOMIC_INT64_ON_GROUP_SHARED")]
        public const int D3DShaderFeatureAtomicInt64OnGroupShared = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_DERIVATIVES_IN_MESH_AND_AMPLIFICATION_SHADERS")]
        public const int D3DShaderFeatureDerivativesInMeshAndAmplificationShaders = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_RESOURCE_DESCRIPTOR_HEAP_INDEXING")]
        public const int D3DShaderFeatureResourceDescriptorHeapIndexing = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_SAMPLER_DESCRIPTOR_HEAP_INDEXING")]
        public const int D3DShaderFeatureSamplerDescriptorHeapIndexing = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_WAVE_MMA")]
        public const int D3DShaderFeatureWaveMma = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_ATOMIC_INT64_ON_DESCRIPTOR_HEAP_RESOURCE")]
        public const int D3DShaderFeatureAtomicInt64OnDescriptorHeapResource = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_ADVANCED_TEXTURE_OPS")]
        public const int D3DShaderFeatureAdvancedTextureOps = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_WRITEABLE_MSAA_TEXTURES")]
        public const int D3DShaderFeatureWriteableMsaaTextures = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D_SHADER_FEATURE_SAMPLE_CMP_GRADIENT_OR_BIAS")]
        public const uint D3DShaderFeatureSampleCmpGradientOrBias = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "D3D_SHADER_FEATURE_EXTENDED_COMMAND_INFO")]
        public const ulong D3DShaderFeatureExtendedCommandInfo = unchecked((ulong) 0x100000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_COMPONENT_MASK_X")]
        public const int D3DComponentMaskX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_COMPONENT_MASK_Y")]
        public const int D3DComponentMaskY = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_COMPONENT_MASK_Z")]
        public const int D3DComponentMaskZ = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_COMPONENT_MASK_W")]
        public const int D3DComponentMaskW = unchecked((int) 0x8);

    }
}

