// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Transformed]
[Flags]
public enum PipelineCreateFlags2 : long
{
    None = 0x0,
    DisableOptimizationBit = 0x1,
    AllowDerivativesBit = 0x2,
    DerivativeBit = 0x4,
    ViewIndexFromDeviceIndexBit = 0x8,
    DispatchBaseBit = 0x10,
    FailOnPipelineCompileRequiredBit = 0x100,
    EarlyReturnOnFailureBit = 0x200,
    NoProtectedAccessBit = 0x8000000,
    ProtectedAccessOnlyBit = 0x40000000,
    RayTracingSkipBuiltInPrimitivesBitKHR = 0x1000,
    RayTracingAllowSpheresAndLinearSweptSpheresBitNV = 0x200000000,
    EnableLegacyDitheringBitEXT = 0x400000000,
    DisableOptimizationBitKHR = 0x1,
    AllowDerivativesBitKHR = 0x2,
    DerivativeBitKHR = 0x4,
    ViewIndexFromDeviceIndexBitKHR = 0x8,
    DispatchBaseBitKHR = 0x10,
    DeferCompileBitNV = 0x20,
    CaptureStatisticsBitKHR = 0x40,
    CaptureInternalRepresentationsBitKHR = 0x80,
    FailOnPipelineCompileRequiredBitKHR = 0x100,
    EarlyReturnOnFailureBitKHR = 0x200,
    LinkTimeOptimizationBitEXT = 0x400,
    RetainLinkTimeOptimizationInfoBitEXT = 0x800000,
    LibraryBitKHR = 0x800,
    RayTracingSkipTrianglesBitKHR = 0x1000,
    RayTracingSkipAabbsBitKHR = 0x2000,
    RayTracingNoNullAnyHitShadersBitKHR = 0x4000,
    RayTracingNoNullClosestHitShadersBitKHR = 0x8000,
    RayTracingNoNullMissShadersBitKHR = 0x10000,
    RayTracingNoNullIntersectionShadersBitKHR = 0x20000,
    RayTracingShaderGroupHandleCaptureReplayBitKHR = 0x80000,
    IndirectBindableBitNV = 0x40000,
    RayTracingAllowMotionBitNV = 0x100000,
    RenderingFragmentShadingRateAttachmentBitKHR = 0x200000,
    RenderingFragmentDensityMapAttachmentBitEXT = 0x400000,
    RayTracingOpacityMicromapBitEXT = 0x1000000,
    ColorAttachmentFeedbackLoopBitEXT = 0x2000000,
    DepthStencilAttachmentFeedbackLoopBitEXT = 0x4000000,
    NoProtectedAccessBitEXT = 0x8000000,
    ProtectedAccessOnlyBitEXT = 0x40000000,
    RayTracingDisplacementMicromapBitNV = 0x10000000,
    DescriptorBufferBitEXT = 0x20000000,
    DisallowOpacityMicromapBitARM = 0x2000000000,
    CaptureDataBitKHR = 0x80000000,
    IndirectBindableBitEXT = 0x4000000000,
    PerLayerFragmentDensityBitValve = 0x10000000000,
    X64BitIndexingBitEXT = 0x80000000000,
}
