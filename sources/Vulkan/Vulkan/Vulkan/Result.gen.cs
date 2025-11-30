// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkResult")]
[SupportedApiProfile("vulkan")]
public enum Result
{
    [NativeName("VK_SUCCESS")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    Success = 0,

    [NativeName("VK_NOT_READY")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    NotReady = 1,

    [NativeName("VK_TIMEOUT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    Timeout = 2,

    [NativeName("VK_EVENT_SET")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    EventSet = 3,

    [NativeName("VK_EVENT_RESET")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    EventReset = 4,

    [NativeName("VK_INCOMPLETE")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    Incomplete = 5,

    [NativeName("VK_ERROR_OUT_OF_HOST_MEMORY")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorOutOfHostMemory = -1,

    [NativeName("VK_ERROR_OUT_OF_DEVICE_MEMORY")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorOutOfDeviceMemory = -2,

    [NativeName("VK_ERROR_INITIALIZATION_FAILED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorInitializationFailed = -3,

    [NativeName("VK_ERROR_DEVICE_LOST")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorDeviceLost = -4,

    [NativeName("VK_ERROR_MEMORY_MAP_FAILED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorMemoryMapFailed = -5,

    [NativeName("VK_ERROR_LAYER_NOT_PRESENT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorLayerNotPresent = -6,

    [NativeName("VK_ERROR_EXTENSION_NOT_PRESENT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorExtensionNotPresent = -7,

    [NativeName("VK_ERROR_FEATURE_NOT_PRESENT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorFeatureNotPresent = -8,

    [NativeName("VK_ERROR_INCOMPATIBLE_DRIVER")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorIncompatibleDriver = -9,

    [NativeName("VK_ERROR_TOO_MANY_OBJECTS")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorTooManyObjects = -10,

    [NativeName("VK_ERROR_FORMAT_NOT_SUPPORTED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorFormatNotSupported = -11,

    [NativeName("VK_ERROR_FRAGMENTED_POOL")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorFragmentedPool = -12,

    [NativeName("VK_ERROR_UNKNOWN")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorUnknown = -13,

    [NativeName("VK_ERROR_VALIDATION_FAILED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    ErrorValidationFailed = -1000011001,

    [NativeName("VK_ERROR_OUT_OF_POOL_MEMORY")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    ErrorOutOfPoolMemory = -1000069000,

    [NativeName("VK_ERROR_INVALID_EXTERNAL_HANDLE")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    ErrorInvalidExternalHandle = -1000072003,

    [NativeName("VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    ErrorInvalidOpaqueCaptureAddress = -1000257000,

    [NativeName("VK_ERROR_FRAGMENTATION")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    ErrorFragmentation = -1000161000,

    [NativeName("VK_PIPELINE_COMPILE_REQUIRED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    PipelineCompileRequired = 1000297000,

    [NativeName("VK_ERROR_NOT_PERMITTED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    ErrorNotPermitted = -1000174001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_SURFACE_LOST_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    ErrorSurfaceLostkhr = -1000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_NATIVE_WINDOW_IN_USE_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    ErrorNativeWindowInUsekhr = -1000000001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_SUBOPTIMAL_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    Suboptimalkhr = 1000001003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_OUT_OF_DATE_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    ErrorOutOfDatekhr = -1000001004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_INCOMPATIBLE_DISPLAY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_display_swapchain"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_swapchain"]
    )]
    ErrorIncompatibleDisplaykhr = -1000003001,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_ERROR_INVALID_SHADER_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_glsl_shader"])]
    ErrorInvalidShadernv = -1000012000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    ErrorImageUsageNotSupportedkhr = -1000023000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    ErrorVideoPictureLayoutNotSupportedkhr = -1000023001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    ErrorVideoProfileOperationNotSupportedkhr = -1000023002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    ErrorVideoProfileFormatNotSupportedkhr = -1000023003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    ErrorVideoProfileCodecNotSupportedkhr = -1000023004,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    ErrorVideoStdVersionNotSupportedkhr = -1000023005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_drm_format_modifier"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    ErrorInvalidDrmFormatModifierPlaneLayoutext = -1000158000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    ErrorFullScreenExclusiveModeLostext = -1000255000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_THREAD_IDLE_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_deferred_host_operations"])]
    ThreadIdlekhr = 1000268000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_THREAD_DONE_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_deferred_host_operations"])]
    ThreadDonekhr = 1000268001,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_OPERATION_DEFERRED_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_deferred_host_operations"])]
    OperationDeferredkhr = 1000268002,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_OPERATION_NOT_DEFERRED_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_deferred_host_operations"])]
    OperationNotDeferredkhr = 1000268003,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_INVALID_VIDEO_STD_PARAMETERS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    ErrorInvalidVideoStdParameterskhr = -1000299000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ERROR_COMPRESSION_EXHAUSTED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    ErrorCompressionExhaustedext = -1000338000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_INCOMPATIBLE_SHADER_BINARY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    IncompatibleShaderBinaryext = 1000482000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_BINARY_MISSING_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryMissingkhr = 1000483000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_NOT_ENOUGH_SPACE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    ErrorNotEnoughSpacekhr = -1000483000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ERROR_VALIDATION_FAILED_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ErrorValidationFailedext = ErrorValidationFailed,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_OUT_OF_POOL_MEMORY_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance1"])]
    ErrorOutOfPoolMemorykhr = ErrorOutOfPoolMemory,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory"],
        ImpliesSets = [
            "VK_KHR_external_memory+VK_KHR_external_memory_capabilities",
            "VK_KHR_external_memory+VK_VERSION_1_1",
        ]
    )]
    ErrorInvalidExternalHandlekhr = ErrorInvalidExternalHandle,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ERROR_FRAGMENTATION_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    ErrorFragmentationext = ErrorFragmentation,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ERROR_NOT_PERMITTED_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    ErrorNotPermittedext = ErrorNotPermitted,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_NOT_PERMITTED_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    ErrorNotPermittedkhr = ErrorNotPermitted,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ERROR_INVALID_DEVICE_ADDRESS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_buffer_device_address"],
        ImpliesSets = [
            "VK_EXT_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_EXT_buffer_device_address+VK_VERSION_1_1",
        ]
    )]
    ErrorInvalidDeviceAddressext = ErrorInvalidOpaqueCaptureAddress,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    ErrorInvalidOpaqueCaptureAddresskhr = ErrorInvalidOpaqueCaptureAddress,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_COMPILE_REQUIRED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_creation_cache_control"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        ]
    )]
    PipelineCompileRequiredext = PipelineCompileRequired,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_ERROR_PIPELINE_COMPILE_REQUIRED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_creation_cache_control"],
        ImpliesSets = [
            "VK_EXT_pipeline_creation_cache_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_pipeline_creation_cache_control+VK_VERSION_1_1",
        ]
    )]
    ErrorPipelineCompileRequiredext = PipelineCompileRequired,
}
