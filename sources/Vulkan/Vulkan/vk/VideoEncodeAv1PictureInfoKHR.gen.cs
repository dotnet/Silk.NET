// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeAV1PictureInfoKHR")]
public unsafe partial struct VideoEncodeAv1PictureInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeAv1PictureInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("predictionMode")]
    public VideoEncodeAv1PredictionModeKHR PredictionMode;

    [NativeName("rateControlGroup")]
    public VideoEncodeAv1RateControlGroupKHR RateControlGroup;

    [NativeName("constantQIndex")]
    public uint ConstantQIndex;

    [NativeName("pStdPictureInfo")]
    public StdVideoEncodeAv1PictureInfo* PStdPictureInfo;

    [NativeName("referenceNameSlotIndices")]
    public VideoEncodeAv1PictureInfoKHRReferenceNameSlotIndices ReferenceNameSlotIndices;

    [NativeName("primaryReferenceCdfOnly")]
    public MaybeBool<uint> PrimaryReferenceCdfOnly;

    [NativeName("generateObuExtensionHeader")]
    public MaybeBool<uint> GenerateObuExtensionHeader;

    public VideoEncodeAv1PictureInfoKHR() { }
}
