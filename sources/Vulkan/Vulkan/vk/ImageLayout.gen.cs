// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageLayout")]
public enum ImageLayout : uint
{
    [NativeName("VK_IMAGE_LAYOUT_UNDEFINED")]
    Undefined = 0,

    [NativeName("VK_IMAGE_LAYOUT_GENERAL")]
    General = 1,

    [NativeName("VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL")]
    ColorAttachmentOptimal = 2,

    [NativeName("VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL")]
    DepthStencilAttachmentOptimal = 3,

    [NativeName("VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL")]
    DepthStencilReadOnlyOptimal = 4,

    [NativeName("VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL")]
    ShaderReadOnlyOptimal = 5,

    [NativeName("VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL")]
    TransferSrcOptimal = 6,

    [NativeName("VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL")]
    TransferDstOptimal = 7,

    [NativeName("VK_IMAGE_LAYOUT_PREINITIALIZED")]
    Preinitialized = 8,

    [NativeName("VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL")]
    DepthReadOnlyStencilAttachmentOptimal = 1000117000,

    [NativeName("VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL")]
    DepthAttachmentStencilReadOnlyOptimal = 1000117001,

    [NativeName("VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL")]
    DepthAttachmentOptimal = 1000241000,

    [NativeName("VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL")]
    DepthReadOnlyOptimal = 1000241001,

    [NativeName("VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL")]
    StencilAttachmentOptimal = 1000241002,

    [NativeName("VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL")]
    StencilReadOnlyOptimal = 1000241003,

    [NativeName("VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL")]
    ReadOnlyOptimal = 1000314000,

    [NativeName("VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL")]
    AttachmentOptimal = 1000314001,

    [NativeName("VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ")]
    RenderingLocalRead = 1000232000,

    [NativeName("VK_IMAGE_LAYOUT_PRESENT_SRC_KHR")]
    PresentSrcKHR = 1000001002,

    [NativeName("VK_IMAGE_LAYOUT_VIDEO_DECODE_DST_KHR")]
    VideoDecodeDstKHR = 1000024000,

    [NativeName("VK_IMAGE_LAYOUT_VIDEO_DECODE_SRC_KHR")]
    VideoDecodeSrcKHR = 1000024001,

    [NativeName("VK_IMAGE_LAYOUT_VIDEO_DECODE_DPB_KHR")]
    VideoDecodeDpbKHR = 1000024002,

    [NativeName("VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR")]
    SharedPresentKHR = 1000111000,

    [NativeName("VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT")]
    FragmentDensityMapOptimalEXT = 1000218000,

    [NativeName("VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR")]
    FragmentShadingRateAttachmentOptimalKHR = 1000164003,

    [NativeName("VK_IMAGE_LAYOUT_VIDEO_ENCODE_DST_KHR")]
    VideoEncodeDstKHR = 1000299000,

    [NativeName("VK_IMAGE_LAYOUT_VIDEO_ENCODE_SRC_KHR")]
    VideoEncodeSrcKHR = 1000299001,

    [NativeName("VK_IMAGE_LAYOUT_VIDEO_ENCODE_DPB_KHR")]
    VideoEncodeDpbKHR = 1000299002,

    [NativeName("VK_IMAGE_LAYOUT_ATTACHMENT_FEEDBACK_LOOP_OPTIMAL_EXT")]
    AttachmentFeedbackLoopOptimalEXT = 1000339000,

    [NativeName("VK_IMAGE_LAYOUT_TENSOR_ALIASING_ARM")]
    TensorAliasingARM = 1000460000,

    [NativeName("VK_IMAGE_LAYOUT_VIDEO_ENCODE_QUANTIZATION_MAP_KHR")]
    VideoEncodeQuantizationMapKHR = 1000553000,

    [NativeName("VK_IMAGE_LAYOUT_ZERO_INITIALIZED_EXT")]
    ZeroInitializedEXT = 1000620000,

    [NativeName("VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL_KHR")]
    DepthReadOnlyStencilAttachmentOptimalKHR = DepthReadOnlyStencilAttachmentOptimal,

    [NativeName("VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL_KHR")]
    DepthAttachmentStencilReadOnlyOptimalKHR = DepthAttachmentStencilReadOnlyOptimal,

    [NativeName("VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV")]
    ShadingRateOptimalNV = FragmentShadingRateAttachmentOptimalKHR,

    [NativeName("VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ_KHR")]
    RenderingLocalReadKHR = RenderingLocalRead,

    [NativeName("VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL_KHR")]
    DepthAttachmentOptimalKHR = DepthAttachmentOptimal,

    [NativeName("VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL_KHR")]
    DepthReadOnlyOptimalKHR = DepthReadOnlyOptimal,

    [NativeName("VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL_KHR")]
    StencilAttachmentOptimalKHR = StencilAttachmentOptimal,

    [NativeName("VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL_KHR")]
    StencilReadOnlyOptimalKHR = StencilReadOnlyOptimal,

    [NativeName("VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL_KHR")]
    ReadOnlyOptimalKHR = ReadOnlyOptimal,

    [NativeName("VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL_KHR")]
    AttachmentOptimalKHR = AttachmentOptimal,
}
