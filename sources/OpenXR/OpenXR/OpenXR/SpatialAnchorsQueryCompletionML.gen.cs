// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorsQueryCompletionML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorsQueryCompletionML
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public StructureType Type = StructureType.SpatialAnchorsQueryCompletionML;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public void* Next;

    [NativeName("futureResult")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public Result FutureResult;

    [NativeName("uuidCapacityInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public uint UuidCapacityInput;

    [NativeName("uuidCountOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public uint UuidCountOutput;

    [NativeName("uuids")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public Uuid* Uuids;

    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public SpatialAnchorsQueryCompletionML() { }
}
