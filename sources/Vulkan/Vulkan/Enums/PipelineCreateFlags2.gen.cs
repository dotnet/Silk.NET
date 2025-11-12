// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Transformed]
[Flags]
public enum PipelineCreateFlags2 : ulong
{
    None = 0,
    DisableOptimizationBit = unchecked((ulong)0x00000001UL),
    AllowDerivativesBit = unchecked((ulong)0x00000002UL),
    DerivativeBit = unchecked((ulong)0x00000004UL),
    ViewIndexFromDeviceIndexBit = unchecked((ulong)0x00000008UL),
    DispatchBaseBit = unchecked((ulong)0x00000010UL),
    FailOnPipelineCompileRequiredBit = unchecked((ulong)0x00000100UL),
    EarlyReturnOnFailureBit = unchecked((ulong)0x00000200UL),
    NoProtectedAccessBit = unchecked((ulong)0x08000000UL),
    ProtectedAccessOnlyBit = unchecked((ulong)0x40000000UL),
    RayTracingSkipBuiltInPrimitivesBitKHR = unchecked((ulong)0x00001000UL),
    RayTracingAllowSpheresAndLinearSweptSpheresBitNV = unchecked((ulong)0x200000000UL),
    EnableLegacyDitheringBitEXT = unchecked((ulong)0x400000000UL),
    DisableOptimizationBitKHR = unchecked((ulong)0x00000001UL),
    AllowDerivativesBitKHR = unchecked((ulong)0x00000002UL),
    DerivativeBitKHR = unchecked((ulong)0x00000004UL),
    ViewIndexFromDeviceIndexBitKHR = unchecked((ulong)0x00000008UL),
    DispatchBaseBitKHR = unchecked((ulong)0x00000010UL),
    DeferCompileBitNV = unchecked((ulong)0x00000020UL),
    CaptureStatisticsBitKHR = unchecked((ulong)0x00000040UL),
    CaptureInternalRepresentationsBitKHR = unchecked((ulong)0x00000080UL),
    FailOnPipelineCompileRequiredBitKHR = unchecked((ulong)0x00000100UL),
    EarlyReturnOnFailureBitKHR = unchecked((ulong)0x00000200UL),
    LinkTimeOptimizationBitEXT = unchecked((ulong)0x00000400UL),
    RetainLinkTimeOptimizationInfoBitEXT = unchecked((ulong)0x00800000UL),
    LibraryBitKHR = unchecked((ulong)0x00000800UL),
    RayTracingSkipTrianglesBitKHR = unchecked((ulong)0x00001000UL),
    RayTracingSkipAabbsBitKHR = unchecked((ulong)0x00002000UL),
    RayTracingNoNullAnyHitShadersBitKHR = unchecked((ulong)0x00004000UL),
    RayTracingNoNullClosestHitShadersBitKHR = unchecked((ulong)0x00008000UL),
    RayTracingNoNullMissShadersBitKHR = unchecked((ulong)0x00010000UL),
    RayTracingNoNullIntersectionShadersBitKHR = unchecked((ulong)0x00020000UL),
    RayTracingShaderGroupHandleCaptureReplayBitKHR = unchecked((ulong)0x00080000UL),
    IndirectBindableBitNV = unchecked((ulong)0x00040000UL),
    RayTracingAllowMotionBitNV = unchecked((ulong)0x00100000UL),
    RenderingFragmentShadingRateAttachmentBitKHR = unchecked((ulong)0x00200000UL),
    RenderingFragmentDensityMapAttachmentBitEXT = unchecked((ulong)0x00400000UL),
    RayTracingOpacityMicromapBitEXT = unchecked((ulong)0x01000000UL),
    ColorAttachmentFeedbackLoopBitEXT = unchecked((ulong)0x02000000UL),
    DepthStencilAttachmentFeedbackLoopBitEXT = unchecked((ulong)0x04000000UL),
    NoProtectedAccessBitEXT = unchecked((ulong)0x08000000UL),
    ProtectedAccessOnlyBitEXT = unchecked((ulong)0x40000000UL),
    RayTracingDisplacementMicromapBitNV = unchecked((ulong)0x10000000UL),
    DescriptorBufferBitEXT = unchecked((ulong)0x20000000UL),
    DisallowOpacityMicromapBitARM = unchecked((ulong)0x2000000000UL),
    CaptureDataBitKHR = unchecked((ulong)0x80000000UL),
    IndirectBindableBitEXT = unchecked((ulong)0x4000000000UL),
    PerLayerFragmentDensityBitValve = unchecked((ulong)0x10000000000UL),
    X64BitIndexingBitEXT = unchecked((ulong)0x80000000000UL),
}
