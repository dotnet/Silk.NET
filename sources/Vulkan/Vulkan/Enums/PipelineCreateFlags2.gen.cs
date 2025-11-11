// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Transformed]
[Flags]
public enum PipelineCreateFlags2 : ulong
{
    None = 0,
    X2DisableOptimizationBit = unchecked((ulong)0x00000001UL),
    X2AllowDerivativesBit = unchecked((ulong)0x00000002UL),
    X2DerivativeBit = unchecked((ulong)0x00000004UL),
    X2ViewIndexFromDeviceIndexBit = unchecked((ulong)0x00000008UL),
    X2DispatchBaseBit = unchecked((ulong)0x00000010UL),
    X2FailOnPipelineCompileRequiredBit = unchecked((ulong)0x00000100UL),
    X2EarlyReturnOnFailureBit = unchecked((ulong)0x00000200UL),
    X2NoProtectedAccessBit = unchecked((ulong)0x08000000UL),
    X2ProtectedAccessOnlyBit = unchecked((ulong)0x40000000UL),
    X2RayTracingSkipBuiltInPrimitivesBitKHR = unchecked((ulong)0x00001000UL),
    X2RayTracingAllowSpheresAndLinearSweptSpheresBitNV = unchecked((ulong)0x200000000UL),
    X2EnableLegacyDitheringBitEXT = unchecked((ulong)0x400000000UL),
    X2DisableOptimizationBitKHR = unchecked((ulong)0x00000001UL),
    X2AllowDerivativesBitKHR = unchecked((ulong)0x00000002UL),
    X2DerivativeBitKHR = unchecked((ulong)0x00000004UL),
    X2ViewIndexFromDeviceIndexBitKHR = unchecked((ulong)0x00000008UL),
    X2DispatchBaseBitKHR = unchecked((ulong)0x00000010UL),
    X2DeferCompileBitNV = unchecked((ulong)0x00000020UL),
    X2CaptureStatisticsBitKHR = unchecked((ulong)0x00000040UL),
    X2CaptureInternalRepresentationsBitKHR = unchecked((ulong)0x00000080UL),
    X2FailOnPipelineCompileRequiredBitKHR = unchecked((ulong)0x00000100UL),
    X2EarlyReturnOnFailureBitKHR = unchecked((ulong)0x00000200UL),
    X2LinkTimeOptimizationBitEXT = unchecked((ulong)0x00000400UL),
    X2RetainLinkTimeOptimizationInfoBitEXT = unchecked((ulong)0x00800000UL),
    X2LibraryBitKHR = unchecked((ulong)0x00000800UL),
    X2RayTracingSkipTrianglesBitKHR = unchecked((ulong)0x00001000UL),
    X2RayTracingSkipAabbsBitKHR = unchecked((ulong)0x00002000UL),
    X2RayTracingNoNullAnyHitShadersBitKHR = unchecked((ulong)0x00004000UL),
    X2RayTracingNoNullClosestHitShadersBitKHR = unchecked((ulong)0x00008000UL),
    X2RayTracingNoNullMissShadersBitKHR = unchecked((ulong)0x00010000UL),
    X2RayTracingNoNullIntersectionShadersBitKHR = unchecked((ulong)0x00020000UL),
    X2RayTracingShaderGroupHandleCaptureReplayBitKHR = unchecked((ulong)0x00080000UL),
    X2IndirectBindableBitNV = unchecked((ulong)0x00040000UL),
    X2RayTracingAllowMotionBitNV = unchecked((ulong)0x00100000UL),
    X2RenderingFragmentShadingRateAttachmentBitKHR = unchecked((ulong)0x00200000UL),
    X2RenderingFragmentDensityMapAttachmentBitEXT = unchecked((ulong)0x00400000UL),
    X2RayTracingOpacityMicromapBitEXT = unchecked((ulong)0x01000000UL),
    X2ColorAttachmentFeedbackLoopBitEXT = unchecked((ulong)0x02000000UL),
    X2DepthStencilAttachmentFeedbackLoopBitEXT = unchecked((ulong)0x04000000UL),
    X2NoProtectedAccessBitEXT = unchecked((ulong)0x08000000UL),
    X2ProtectedAccessOnlyBitEXT = unchecked((ulong)0x40000000UL),
    X2RayTracingDisplacementMicromapBitNV = unchecked((ulong)0x10000000UL),
    X2DescriptorBufferBitEXT = unchecked((ulong)0x20000000UL),
    X2DisallowOpacityMicromapBitARM = unchecked((ulong)0x2000000000UL),
    X2CaptureDataBitKHR = unchecked((ulong)0x80000000UL),
    X2IndirectBindableBitEXT = unchecked((ulong)0x4000000000UL),
    X2PerLayerFragmentDensityBitValve = unchecked((ulong)0x10000000000UL),
    X2X64BitIndexingBitEXT = unchecked((ulong)0x80000000000UL),
}
