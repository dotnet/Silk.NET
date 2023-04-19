// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvCapability_")]
    public enum Capability : int
    {
        [NativeName("Name", "SpvCapabilityMatrix")]
        Matrix = 0x0,
        [NativeName("Name", "SpvCapabilityShader")]
        Shader = 0x1,
        [NativeName("Name", "SpvCapabilityGeometry")]
        Geometry = 0x2,
        [NativeName("Name", "SpvCapabilityTessellation")]
        Tessellation = 0x3,
        [NativeName("Name", "SpvCapabilityAddresses")]
        Addresses = 0x4,
        [NativeName("Name", "SpvCapabilityLinkage")]
        Linkage = 0x5,
        [NativeName("Name", "SpvCapabilityKernel")]
        Kernel = 0x6,
        [NativeName("Name", "SpvCapabilityVector16")]
        Vector16 = 0x7,
        [NativeName("Name", "SpvCapabilityFloat16Buffer")]
        Float16Buffer = 0x8,
        [NativeName("Name", "SpvCapabilityFloat16")]
        Float16 = 0x9,
        [NativeName("Name", "SpvCapabilityFloat64")]
        Float64 = 0xA,
        [NativeName("Name", "SpvCapabilityInt64")]
        Int64 = 0xB,
        [NativeName("Name", "SpvCapabilityInt64Atomics")]
        Int64Atomics = 0xC,
        [NativeName("Name", "SpvCapabilityImageBasic")]
        ImageBasic = 0xD,
        [NativeName("Name", "SpvCapabilityImageReadWrite")]
        ImageReadWrite = 0xE,
        [NativeName("Name", "SpvCapabilityImageMipmap")]
        ImageMipmap = 0xF,
        [NativeName("Name", "SpvCapabilityPipes")]
        Pipes = 0x11,
        [NativeName("Name", "SpvCapabilityGroups")]
        Groups = 0x12,
        [NativeName("Name", "SpvCapabilityDeviceEnqueue")]
        DeviceEnqueue = 0x13,
        [NativeName("Name", "SpvCapabilityLiteralSampler")]
        LiteralSampler = 0x14,
        [NativeName("Name", "SpvCapabilityAtomicStorage")]
        AtomicStorage = 0x15,
        [NativeName("Name", "SpvCapabilityInt16")]
        Int16 = 0x16,
        [NativeName("Name", "SpvCapabilityTessellationPointSize")]
        TessellationPointSize = 0x17,
        [NativeName("Name", "SpvCapabilityGeometryPointSize")]
        GeometryPointSize = 0x18,
        [NativeName("Name", "SpvCapabilityImageGatherExtended")]
        ImageGatherExtended = 0x19,
        [NativeName("Name", "SpvCapabilityStorageImageMultisample")]
        StorageImageMultisample = 0x1B,
        [NativeName("Name", "SpvCapabilityUniformBufferArrayDynamicIndexing")]
        UniformBufferArrayDynamicIndexing = 0x1C,
        [NativeName("Name", "SpvCapabilitySampledImageArrayDynamicIndexing")]
        SampledImageArrayDynamicIndexing = 0x1D,
        [NativeName("Name", "SpvCapabilityStorageBufferArrayDynamicIndexing")]
        StorageBufferArrayDynamicIndexing = 0x1E,
        [NativeName("Name", "SpvCapabilityStorageImageArrayDynamicIndexing")]
        StorageImageArrayDynamicIndexing = 0x1F,
        [NativeName("Name", "SpvCapabilityClipDistance")]
        ClipDistance = 0x20,
        [NativeName("Name", "SpvCapabilityCullDistance")]
        CullDistance = 0x21,
        [NativeName("Name", "SpvCapabilityImageCubeArray")]
        ImageCubeArray = 0x22,
        [NativeName("Name", "SpvCapabilitySampleRateShading")]
        SampleRateShading = 0x23,
        [NativeName("Name", "SpvCapabilityImageRect")]
        ImageRect = 0x24,
        [NativeName("Name", "SpvCapabilitySampledRect")]
        SampledRect = 0x25,
        [NativeName("Name", "SpvCapabilityGenericPointer")]
        GenericPointer = 0x26,
        [NativeName("Name", "SpvCapabilityInt8")]
        Int8 = 0x27,
        [NativeName("Name", "SpvCapabilityInputAttachment")]
        InputAttachment = 0x28,
        [NativeName("Name", "SpvCapabilitySparseResidency")]
        SparseResidency = 0x29,
        [NativeName("Name", "SpvCapabilityMinLod")]
        MinLod = 0x2A,
        [NativeName("Name", "SpvCapabilitySampled1D")]
        Sampled1D = 0x2B,
        [NativeName("Name", "SpvCapabilityImage1D")]
        Image1D = 0x2C,
        [NativeName("Name", "SpvCapabilitySampledCubeArray")]
        SampledCubeArray = 0x2D,
        [NativeName("Name", "SpvCapabilitySampledBuffer")]
        SampledBuffer = 0x2E,
        [NativeName("Name", "SpvCapabilityImageBuffer")]
        ImageBuffer = 0x2F,
        [NativeName("Name", "SpvCapabilityImageMSArray")]
        ImageMSArray = 0x30,
        [NativeName("Name", "SpvCapabilityStorageImageExtendedFormats")]
        StorageImageExtendedFormats = 0x31,
        [NativeName("Name", "SpvCapabilityImageQuery")]
        ImageQuery = 0x32,
        [NativeName("Name", "SpvCapabilityDerivativeControl")]
        DerivativeControl = 0x33,
        [NativeName("Name", "SpvCapabilityInterpolationFunction")]
        InterpolationFunction = 0x34,
        [NativeName("Name", "SpvCapabilityTransformFeedback")]
        TransformFeedback = 0x35,
        [NativeName("Name", "SpvCapabilityGeometryStreams")]
        GeometryStreams = 0x36,
        [NativeName("Name", "SpvCapabilityStorageImageReadWithoutFormat")]
        StorageImageReadWithoutFormat = 0x37,
        [NativeName("Name", "SpvCapabilityStorageImageWriteWithoutFormat")]
        StorageImageWriteWithoutFormat = 0x38,
        [NativeName("Name", "SpvCapabilityMultiViewport")]
        MultiViewport = 0x39,
        [NativeName("Name", "SpvCapabilitySubgroupDispatch")]
        SubgroupDispatch = 0x3A,
        [NativeName("Name", "SpvCapabilityNamedBarrier")]
        NamedBarrier = 0x3B,
        [NativeName("Name", "SpvCapabilityPipeStorage")]
        PipeStorage = 0x3C,
        [NativeName("Name", "SpvCapabilityGroupNonUniform")]
        GroupNonUniform = 0x3D,
        [NativeName("Name", "SpvCapabilityGroupNonUniformVote")]
        GroupNonUniformVote = 0x3E,
        [NativeName("Name", "SpvCapabilityGroupNonUniformArithmetic")]
        GroupNonUniformArithmetic = 0x3F,
        [NativeName("Name", "SpvCapabilityGroupNonUniformBallot")]
        GroupNonUniformBallot = 0x40,
        [NativeName("Name", "SpvCapabilityGroupNonUniformShuffle")]
        GroupNonUniformShuffle = 0x41,
        [NativeName("Name", "SpvCapabilityGroupNonUniformShuffleRelative")]
        GroupNonUniformShuffleRelative = 0x42,
        [NativeName("Name", "SpvCapabilityGroupNonUniformClustered")]
        GroupNonUniformClustered = 0x43,
        [NativeName("Name", "SpvCapabilityGroupNonUniformQuad")]
        GroupNonUniformQuad = 0x44,
        [NativeName("Name", "SpvCapabilityShaderLayer")]
        ShaderLayer = 0x45,
        [NativeName("Name", "SpvCapabilityShaderViewportIndex")]
        ShaderViewportIndex = 0x46,
        [NativeName("Name", "SpvCapabilityUniformDecoration")]
        UniformDecoration = 0x47,
        [NativeName("Name", "SpvCapabilityCoreBuiltinsARM")]
        CoreBuiltinsArm = 0x1045,
        [NativeName("Name", "SpvCapabilityTileImageColorReadAccessEXT")]
        TileImageColorReadAccessExt = 0x1046,
        [NativeName("Name", "SpvCapabilityTileImageDepthReadAccessEXT")]
        TileImageDepthReadAccessExt = 0x1047,
        [NativeName("Name", "SpvCapabilityTileImageStencilReadAccessEXT")]
        TileImageStencilReadAccessExt = 0x1048,
        [NativeName("Name", "SpvCapabilityFragmentShadingRateKHR")]
        FragmentShadingRateKhr = 0x1146,
        [NativeName("Name", "SpvCapabilitySubgroupBallotKHR")]
        SubgroupBallotKhr = 0x1147,
        [NativeName("Name", "SpvCapabilityDrawParameters")]
        DrawParameters = 0x114B,
        [NativeName("Name", "SpvCapabilityWorkgroupMemoryExplicitLayoutKHR")]
        WorkgroupMemoryExplicitLayoutKhr = 0x114C,
        [NativeName("Name", "SpvCapabilityWorkgroupMemoryExplicitLayout8BitAccessKHR")]
        WorkgroupMemoryExplicitLayout8BitAccessKhr = 0x114D,
        [NativeName("Name", "SpvCapabilityWorkgroupMemoryExplicitLayout16BitAccessKHR")]
        WorkgroupMemoryExplicitLayout16BitAccessKhr = 0x114E,
        [NativeName("Name", "SpvCapabilitySubgroupVoteKHR")]
        SubgroupVoteKhr = 0x114F,
        [NativeName("Name", "SpvCapabilityStorageBuffer16BitAccess")]
        StorageBuffer16BitAccess = 0x1151,
        [NativeName("Name", "SpvCapabilityStorageUniformBufferBlock16")]
        StorageUniformBufferBlock16 = 0x1151,
        [NativeName("Name", "SpvCapabilityStorageUniform16")]
        StorageUniform16 = 0x1152,
        [NativeName("Name", "SpvCapabilityUniformAndStorageBuffer16BitAccess")]
        UniformAndStorageBuffer16BitAccess = 0x1152,
        [NativeName("Name", "SpvCapabilityStoragePushConstant16")]
        StoragePushConstant16 = 0x1153,
        [NativeName("Name", "SpvCapabilityStorageInputOutput16")]
        StorageInputOutput16 = 0x1154,
        [NativeName("Name", "SpvCapabilityDeviceGroup")]
        DeviceGroup = 0x1155,
        [NativeName("Name", "SpvCapabilityMultiView")]
        MultiView = 0x1157,
        [NativeName("Name", "SpvCapabilityVariablePointersStorageBuffer")]
        VariablePointersStorageBuffer = 0x1159,
        [NativeName("Name", "SpvCapabilityVariablePointers")]
        VariablePointers = 0x115A,
        [NativeName("Name", "SpvCapabilityAtomicStorageOps")]
        AtomicStorageOps = 0x115D,
        [NativeName("Name", "SpvCapabilitySampleMaskPostDepthCoverage")]
        SampleMaskPostDepthCoverage = 0x115F,
        [NativeName("Name", "SpvCapabilityStorageBuffer8BitAccess")]
        StorageBuffer8BitAccess = 0x1160,
        [NativeName("Name", "SpvCapabilityUniformAndStorageBuffer8BitAccess")]
        UniformAndStorageBuffer8BitAccess = 0x1161,
        [NativeName("Name", "SpvCapabilityStoragePushConstant8")]
        StoragePushConstant8 = 0x1162,
        [NativeName("Name", "SpvCapabilityDenormPreserve")]
        DenormPreserve = 0x1170,
        [NativeName("Name", "SpvCapabilityDenormFlushToZero")]
        DenormFlushToZero = 0x1171,
        [NativeName("Name", "SpvCapabilitySignedZeroInfNanPreserve")]
        SignedZeroInfNanPreserve = 0x1172,
        [NativeName("Name", "SpvCapabilityRoundingModeRTE")]
        RoundingModeRte = 0x1173,
        [NativeName("Name", "SpvCapabilityRoundingModeRTZ")]
        RoundingModeRtz = 0x1174,
        [NativeName("Name", "SpvCapabilityRayQueryProvisionalKHR")]
        RayQueryProvisionalKhr = 0x1177,
        [NativeName("Name", "SpvCapabilityRayQueryKHR")]
        RayQueryKhr = 0x1178,
        [NativeName("Name", "SpvCapabilityRayTraversalPrimitiveCullingKHR")]
        RayTraversalPrimitiveCullingKhr = 0x117E,
        [NativeName("Name", "SpvCapabilityRayTracingKHR")]
        RayTracingKhr = 0x117F,
        [NativeName("Name", "SpvCapabilityTextureSampleWeightedQCOM")]
        TextureSampleWeightedQCom = 0x1184,
        [NativeName("Name", "SpvCapabilityTextureBoxFilterQCOM")]
        TextureBoxFilterQCom = 0x1185,
        [NativeName("Name", "SpvCapabilityTextureBlockMatchQCOM")]
        TextureBlockMatchQCom = 0x1186,
        [NativeName("Name", "SpvCapabilityFloat16ImageAMD")]
        Float16imageAmd = 0x1390,
        [NativeName("Name", "SpvCapabilityImageGatherBiasLodAMD")]
        ImageGatherBiasLodAmd = 0x1391,
        [NativeName("Name", "SpvCapabilityFragmentMaskAMD")]
        FragmentMaskAmd = 0x1392,
        [NativeName("Name", "SpvCapabilityStencilExportEXT")]
        StencilExportExt = 0x1395,
        [NativeName("Name", "SpvCapabilityImageReadWriteLodAMD")]
        ImageReadWriteLodAmd = 0x1397,
        [NativeName("Name", "SpvCapabilityInt64ImageEXT")]
        Int64imageExt = 0x1398,
        [NativeName("Name", "SpvCapabilityShaderClockKHR")]
        ShaderClockKhr = 0x13BF,
        [NativeName("Name", "SpvCapabilitySampleMaskOverrideCoverageNV")]
        SampleMaskOverrideCoverageNV = 0x1481,
        [NativeName("Name", "SpvCapabilityGeometryShaderPassthroughNV")]
        GeometryShaderPassthroughNV = 0x1483,
        [NativeName("Name", "SpvCapabilityShaderViewportIndexLayerEXT")]
        ShaderViewportIndexLayerExt = 0x1486,
        [NativeName("Name", "SpvCapabilityShaderViewportIndexLayerNV")]
        ShaderViewportIndexLayerNV = 0x1486,
        [NativeName("Name", "SpvCapabilityShaderViewportMaskNV")]
        ShaderViewportMaskNV = 0x1487,
        [NativeName("Name", "SpvCapabilityShaderStereoViewNV")]
        ShaderStereoViewNV = 0x148B,
        [NativeName("Name", "SpvCapabilityPerViewAttributesNV")]
        PerViewAttributesNV = 0x148C,
        [NativeName("Name", "SpvCapabilityFragmentFullyCoveredEXT")]
        FragmentFullyCoveredExt = 0x1491,
        [NativeName("Name", "SpvCapabilityMeshShadingNV")]
        MeshShadingNV = 0x1492,
        [NativeName("Name", "SpvCapabilityImageFootprintNV")]
        ImageFootprintNV = 0x14A2,
        [NativeName("Name", "SpvCapabilityMeshShadingEXT")]
        MeshShadingExt = 0x14A3,
        [NativeName("Name", "SpvCapabilityFragmentBarycentricKHR")]
        FragmentBarycentricKhr = 0x14A4,
        [NativeName("Name", "SpvCapabilityFragmentBarycentricNV")]
        FragmentBarycentricNV = 0x14A4,
        [NativeName("Name", "SpvCapabilityComputeDerivativeGroupQuadsNV")]
        ComputeDerivativeGroupQuadsNV = 0x14A8,
        [NativeName("Name", "SpvCapabilityFragmentDensityEXT")]
        FragmentDensityExt = 0x14AB,
        [NativeName("Name", "SpvCapabilityShadingRateNV")]
        ShadingRateNV = 0x14AB,
        [NativeName("Name", "SpvCapabilityGroupNonUniformPartitionedNV")]
        GroupNonUniformPartitionedNV = 0x14B1,
        [NativeName("Name", "SpvCapabilityShaderNonUniform")]
        ShaderNonUniform = 0x14B5,
        [NativeName("Name", "SpvCapabilityShaderNonUniformEXT")]
        ShaderNonUniformExt = 0x14B5,
        [NativeName("Name", "SpvCapabilityRuntimeDescriptorArray")]
        RuntimeDescriptorArray = 0x14B6,
        [NativeName("Name", "SpvCapabilityRuntimeDescriptorArrayEXT")]
        RuntimeDescriptorArrayExt = 0x14B6,
        [NativeName("Name", "SpvCapabilityInputAttachmentArrayDynamicIndexing")]
        InputAttachmentArrayDynamicIndexing = 0x14B7,
        [NativeName("Name", "SpvCapabilityInputAttachmentArrayDynamicIndexingEXT")]
        InputAttachmentArrayDynamicIndexingExt = 0x14B7,
        [NativeName("Name", "SpvCapabilityUniformTexelBufferArrayDynamicIndexing")]
        UniformTexelBufferArrayDynamicIndexing = 0x14B8,
        [NativeName("Name", "SpvCapabilityUniformTexelBufferArrayDynamicIndexingEXT")]
        UniformTexelBufferArrayDynamicIndexingExt = 0x14B8,
        [NativeName("Name", "SpvCapabilityStorageTexelBufferArrayDynamicIndexing")]
        StorageTexelBufferArrayDynamicIndexing = 0x14B9,
        [NativeName("Name", "SpvCapabilityStorageTexelBufferArrayDynamicIndexingEXT")]
        StorageTexelBufferArrayDynamicIndexingExt = 0x14B9,
        [NativeName("Name", "SpvCapabilityUniformBufferArrayNonUniformIndexing")]
        UniformBufferArrayNonUniformIndexing = 0x14BA,
        [NativeName("Name", "SpvCapabilityUniformBufferArrayNonUniformIndexingEXT")]
        UniformBufferArrayNonUniformIndexingExt = 0x14BA,
        [NativeName("Name", "SpvCapabilitySampledImageArrayNonUniformIndexing")]
        SampledImageArrayNonUniformIndexing = 0x14BB,
        [NativeName("Name", "SpvCapabilitySampledImageArrayNonUniformIndexingEXT")]
        SampledImageArrayNonUniformIndexingExt = 0x14BB,
        [NativeName("Name", "SpvCapabilityStorageBufferArrayNonUniformIndexing")]
        StorageBufferArrayNonUniformIndexing = 0x14BC,
        [NativeName("Name", "SpvCapabilityStorageBufferArrayNonUniformIndexingEXT")]
        StorageBufferArrayNonUniformIndexingExt = 0x14BC,
        [NativeName("Name", "SpvCapabilityStorageImageArrayNonUniformIndexing")]
        StorageImageArrayNonUniformIndexing = 0x14BD,
        [NativeName("Name", "SpvCapabilityStorageImageArrayNonUniformIndexingEXT")]
        StorageImageArrayNonUniformIndexingExt = 0x14BD,
        [NativeName("Name", "SpvCapabilityInputAttachmentArrayNonUniformIndexing")]
        InputAttachmentArrayNonUniformIndexing = 0x14BE,
        [NativeName("Name", "SpvCapabilityInputAttachmentArrayNonUniformIndexingEXT")]
        InputAttachmentArrayNonUniformIndexingExt = 0x14BE,
        [NativeName("Name", "SpvCapabilityUniformTexelBufferArrayNonUniformIndexing")]
        UniformTexelBufferArrayNonUniformIndexing = 0x14BF,
        [NativeName("Name", "SpvCapabilityUniformTexelBufferArrayNonUniformIndexingEXT")]
        UniformTexelBufferArrayNonUniformIndexingExt = 0x14BF,
        [NativeName("Name", "SpvCapabilityStorageTexelBufferArrayNonUniformIndexing")]
        StorageTexelBufferArrayNonUniformIndexing = 0x14C0,
        [NativeName("Name", "SpvCapabilityStorageTexelBufferArrayNonUniformIndexingEXT")]
        StorageTexelBufferArrayNonUniformIndexingExt = 0x14C0,
        [NativeName("Name", "SpvCapabilityRayTracingNV")]
        RayTracingNV = 0x14DC,
        [NativeName("Name", "SpvCapabilityRayTracingMotionBlurNV")]
        RayTracingMotionBlurNV = 0x14DD,
        [NativeName("Name", "SpvCapabilityVulkanMemoryModel")]
        VulkanMemoryModel = 0x14E1,
        [NativeName("Name", "SpvCapabilityVulkanMemoryModelKHR")]
        VulkanMemoryModelKhr = 0x14E1,
        [NativeName("Name", "SpvCapabilityVulkanMemoryModelDeviceScope")]
        VulkanMemoryModelDeviceScope = 0x14E2,
        [NativeName("Name", "SpvCapabilityVulkanMemoryModelDeviceScopeKHR")]
        VulkanMemoryModelDeviceScopeKhr = 0x14E2,
        [NativeName("Name", "SpvCapabilityPhysicalStorageBufferAddresses")]
        PhysicalStorageBufferAddresses = 0x14E3,
        [NativeName("Name", "SpvCapabilityPhysicalStorageBufferAddressesEXT")]
        PhysicalStorageBufferAddressesExt = 0x14E3,
        [NativeName("Name", "SpvCapabilityComputeDerivativeGroupLinearNV")]
        ComputeDerivativeGroupLinearNV = 0x14E6,
        [NativeName("Name", "SpvCapabilityRayTracingProvisionalKHR")]
        RayTracingProvisionalKhr = 0x14E9,
        [NativeName("Name", "SpvCapabilityCooperativeMatrixNV")]
        CooperativeMatrixNV = 0x14ED,
        [NativeName("Name", "SpvCapabilityFragmentShaderSampleInterlockEXT")]
        FragmentShaderSampleInterlockExt = 0x14F3,
        [NativeName("Name", "SpvCapabilityFragmentShaderShadingRateInterlockEXT")]
        FragmentShaderShadingRateInterlockExt = 0x14FC,
        [NativeName("Name", "SpvCapabilityShaderSMBuiltinsNV")]
        ShaderSMBuiltinsNV = 0x14FD,
        [NativeName("Name", "SpvCapabilityFragmentShaderPixelInterlockEXT")]
        FragmentShaderPixelInterlockExt = 0x1502,
        [NativeName("Name", "SpvCapabilityDemoteToHelperInvocation")]
        DemoteToHelperInvocation = 0x1503,
        [NativeName("Name", "SpvCapabilityDemoteToHelperInvocationEXT")]
        DemoteToHelperInvocationExt = 0x1503,
        [NativeName("Name", "SpvCapabilityRayTracingOpacityMicromapEXT")]
        RayTracingOpacityMicromapExt = 0x1505,
        [NativeName("Name", "SpvCapabilityShaderInvocationReorderNV")]
        ShaderInvocationReorderNV = 0x1507,
        [NativeName("Name", "SpvCapabilityBindlessTextureNV")]
        BindlessTextureNV = 0x150E,
        [NativeName("Name", "SpvCapabilitySubgroupShuffleINTEL")]
        SubgroupShuffleIntel = 0x15C0,
        [NativeName("Name", "SpvCapabilitySubgroupBufferBlockIOINTEL")]
        SubgroupBufferBlockIointel = 0x15C1,
        [NativeName("Name", "SpvCapabilitySubgroupImageBlockIOINTEL")]
        SubgroupImageBlockIointel = 0x15C2,
        [NativeName("Name", "SpvCapabilitySubgroupImageMediaBlockIOINTEL")]
        SubgroupImageMediaBlockIointel = 0x15CB,
        [NativeName("Name", "SpvCapabilityRoundToInfinityINTEL")]
        RoundToInfinityIntel = 0x15CE,
        [NativeName("Name", "SpvCapabilityFloatingPointModeINTEL")]
        FloatingPointModeIntel = 0x15CF,
        [NativeName("Name", "SpvCapabilityIntegerFunctions2INTEL")]
        IntegerFunctions2intel = 0x15D0,
        [NativeName("Name", "SpvCapabilityFunctionPointersINTEL")]
        FunctionPointersIntel = 0x15E3,
        [NativeName("Name", "SpvCapabilityIndirectReferencesINTEL")]
        IndirectReferencesIntel = 0x15E4,
        [NativeName("Name", "SpvCapabilityAsmINTEL")]
        AsmIntel = 0x15E6,
        [NativeName("Name", "SpvCapabilityAtomicFloat32MinMaxEXT")]
        AtomicFloat32MinMaxExt = 0x15EC,
        [NativeName("Name", "SpvCapabilityAtomicFloat64MinMaxEXT")]
        AtomicFloat64MinMaxExt = 0x15ED,
        [NativeName("Name", "SpvCapabilityAtomicFloat16MinMaxEXT")]
        AtomicFloat16MinMaxExt = 0x15F0,
        [NativeName("Name", "SpvCapabilityVectorComputeINTEL")]
        VectorComputeIntel = 0x15F1,
        [NativeName("Name", "SpvCapabilityVectorAnyINTEL")]
        VectorAnyIntel = 0x15F3,
        [NativeName("Name", "SpvCapabilityExpectAssumeKHR")]
        ExpectAssumeKhr = 0x15FD,
        [NativeName("Name", "SpvCapabilitySubgroupAvcMotionEstimationINTEL")]
        SubgroupAvcMotionEstimationIntel = 0x1640,
        [NativeName("Name", "SpvCapabilitySubgroupAvcMotionEstimationIntraINTEL")]
        SubgroupAvcMotionEstimationIntraIntel = 0x1641,
        [NativeName("Name", "SpvCapabilitySubgroupAvcMotionEstimationChromaINTEL")]
        SubgroupAvcMotionEstimationChromaIntel = 0x1642,
        [NativeName("Name", "SpvCapabilityVariableLengthArrayINTEL")]
        VariableLengthArrayIntel = 0x16B9,
        [NativeName("Name", "SpvCapabilityFunctionFloatControlINTEL")]
        FunctionFloatControlIntel = 0x16BD,
        [NativeName("Name", "SpvCapabilityFPGAMemoryAttributesINTEL")]
        FpgaMemoryAttributesIntel = 0x16C0,
        [NativeName("Name", "SpvCapabilityFPFastMathModeINTEL")]
        FPFastMathModeIntel = 0x16CD,
        [NativeName("Name", "SpvCapabilityArbitraryPrecisionIntegersINTEL")]
        ArbitraryPrecisionIntegersIntel = 0x16D4,
        [NativeName("Name", "SpvCapabilityArbitraryPrecisionFloatingPointINTEL")]
        ArbitraryPrecisionFloatingPointIntel = 0x16D5,
        [NativeName("Name", "SpvCapabilityUnstructuredLoopControlsINTEL")]
        UnstructuredLoopControlsIntel = 0x16FE,
        [NativeName("Name", "SpvCapabilityFPGALoopControlsINTEL")]
        FpgaLoopControlsIntel = 0x1700,
        [NativeName("Name", "SpvCapabilityKernelAttributesINTEL")]
        KernelAttributesIntel = 0x1704,
        [NativeName("Name", "SpvCapabilityFPGAKernelAttributesINTEL")]
        FpgaKernelAttributesIntel = 0x1709,
        [NativeName("Name", "SpvCapabilityFPGAMemoryAccessesINTEL")]
        FpgaMemoryAccessesIntel = 0x170A,
        [NativeName("Name", "SpvCapabilityFPGAClusterAttributesINTEL")]
        FpgaClusterAttributesIntel = 0x1710,
        [NativeName("Name", "SpvCapabilityLoopFuseINTEL")]
        LoopFuseIntel = 0x1712,
        [NativeName("Name", "SpvCapabilityFPGADSPControlINTEL")]
        FpgadspControlIntel = 0x1714,
        [NativeName("Name", "SpvCapabilityMemoryAccessAliasingINTEL")]
        MemoryAccessAliasingIntel = 0x1716,
        [NativeName("Name", "SpvCapabilityFPGAInvocationPipeliningAttributesINTEL")]
        FpgaInvocationPipeliningAttributesIntel = 0x171C,
        [NativeName("Name", "SpvCapabilityFPGABufferLocationINTEL")]
        FpgaBufferLocationIntel = 0x1720,
        [NativeName("Name", "SpvCapabilityArbitraryPrecisionFixedPointINTEL")]
        ArbitraryPrecisionFixedPointIntel = 0x1722,
        [NativeName("Name", "SpvCapabilityUSMStorageClassesINTEL")]
        UsmStorageClassesIntel = 0x172F,
        [NativeName("Name", "SpvCapabilityRuntimeAlignedAttributeINTEL")]
        RuntimeAlignedAttributeIntel = 0x1733,
        [NativeName("Name", "SpvCapabilityIOPipesINTEL")]
        IOPipesIntel = 0x1737,
        [NativeName("Name", "SpvCapabilityBlockingPipesINTEL")]
        BlockingPipesIntel = 0x1739,
        [NativeName("Name", "SpvCapabilityFPGARegINTEL")]
        FpgaRegIntel = 0x173C,
        [NativeName("Name", "SpvCapabilityDotProductInputAll")]
        DotProductInputAll = 0x1780,
        [NativeName("Name", "SpvCapabilityDotProductInputAllKHR")]
        DotProductInputAllKhr = 0x1780,
        [NativeName("Name", "SpvCapabilityDotProductInput4x8Bit")]
        DotProductInput4x8Bit = 0x1781,
        [NativeName("Name", "SpvCapabilityDotProductInput4x8BitKHR")]
        DotProductInput4x8BitKhr = 0x1781,
        [NativeName("Name", "SpvCapabilityDotProductInput4x8BitPacked")]
        DotProductInput4x8BitPacked = 0x1782,
        [NativeName("Name", "SpvCapabilityDotProductInput4x8BitPackedKHR")]
        DotProductInput4x8BitPackedKhr = 0x1782,
        [NativeName("Name", "SpvCapabilityDotProduct")]
        DotProduct = 0x1783,
        [NativeName("Name", "SpvCapabilityDotProductKHR")]
        DotProductKhr = 0x1783,
        [NativeName("Name", "SpvCapabilityRayCullMaskKHR")]
        RayCullMaskKhr = 0x1784,
        [NativeName("Name", "SpvCapabilityBitInstructions")]
        BitInstructions = 0x1789,
        [NativeName("Name", "SpvCapabilityGroupNonUniformRotateKHR")]
        GroupNonUniformRotateKhr = 0x178A,
        [NativeName("Name", "SpvCapabilityAtomicFloat32AddEXT")]
        AtomicFloat32AddExt = 0x1791,
        [NativeName("Name", "SpvCapabilityAtomicFloat64AddEXT")]
        AtomicFloat64AddExt = 0x1792,
        [NativeName("Name", "SpvCapabilityLongConstantCompositeINTEL")]
        LongConstantCompositeIntel = 0x17C9,
        [NativeName("Name", "SpvCapabilityOptNoneINTEL")]
        OptNoneIntel = 0x17CE,
        [NativeName("Name", "SpvCapabilityAtomicFloat16AddEXT")]
        AtomicFloat16AddExt = 0x17CF,
        [NativeName("Name", "SpvCapabilityDebugInfoModuleINTEL")]
        DebugInfoModuleIntel = 0x17E2,
        [NativeName("Name", "SpvCapabilityBFloat16ConversionINTEL")]
        BFloat16ConversionIntel = 0x17E3,
        [NativeName("Name", "SpvCapabilitySplitBarrierINTEL")]
        SplitBarrierIntel = 0x17FD,
        [NativeName("Name", "SpvCapabilityFPGAKernelAttributesv2INTEL")]
        FpgaKernelAttributesv2intel = 0x1811,
        [NativeName("Name", "SpvCapabilityFPGALatencyControlINTEL")]
        FpgaLatencyControlIntel = 0x181B,
        [NativeName("Name", "SpvCapabilityFPGAArgumentInterfacesINTEL")]
        FpgaArgumentInterfacesIntel = 0x181E,
        [NativeName("Name", "SpvCapabilityGroupUniformArithmeticKHR")]
        GroupUniformArithmeticKhr = 0x1900,
        [NativeName("Name", "SpvCapabilityMax")]
        Max = 0x7FFFFFFF,
    }
}
