// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_import_properties_arm")]
public enum ImportPropertiesARM : intptr_t
{
    [NativeName("CL_IMPORT_TYPE_ARM")]
    Type = unchecked((intptr_t)0x40B2),

    [NativeName("CL_IMPORT_TYPE_HOST_ARM")]
    TypeHost = unchecked((intptr_t)0x40B3),

    [NativeName("CL_IMPORT_TYPE_DMA_BUF_ARM")]
    TypeDmaBuf = unchecked((intptr_t)0x40B4),

    [NativeName("CL_IMPORT_TYPE_PROTECTED_ARM")]
    TypeProtected = unchecked((intptr_t)0x40B5),

    [NativeName("CL_IMPORT_TYPE_ANDROID_HARDWARE_BUFFER_ARM")]
    TypeAndroidHardwareBuffer = unchecked((intptr_t)0x41E2),

    [NativeName("CL_IMPORT_DMA_BUF_DATA_CONSISTENCY_WITH_HOST_ARM")]
    DmaBufDataConsistencyWithHost = unchecked((intptr_t)0x41E3),

    [NativeName("CL_IMPORT_ANDROID_HARDWARE_BUFFER_PLANE_INDEX_ARM")]
    AndroidHardwareBufferPlaneIndex = unchecked((intptr_t)0x41EF),

    [NativeName("CL_IMPORT_ANDROID_HARDWARE_BUFFER_LAYER_INDEX_ARM")]
    AndroidHardwareBufferLayerIndex = unchecked((intptr_t)0x41F0),
}
