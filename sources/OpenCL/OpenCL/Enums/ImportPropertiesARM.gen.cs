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
public enum ImportPropertiesARM : long
{
    [NativeName("CL_IMPORT_TYPE_ARM")]
    Type = 16562,

    [NativeName("CL_IMPORT_TYPE_HOST_ARM")]
    TypeHost = 16563,

    [NativeName("CL_IMPORT_TYPE_DMA_BUF_ARM")]
    TypeDmaBuf = 16564,

    [NativeName("CL_IMPORT_TYPE_PROTECTED_ARM")]
    TypeProtected = 16565,

    [NativeName("CL_IMPORT_TYPE_ANDROID_HARDWARE_BUFFER_ARM")]
    TypeAndroidHardwareBuffer = 16866,

    [NativeName("CL_IMPORT_DMA_BUF_DATA_CONSISTENCY_WITH_HOST_ARM")]
    DmaBufDataConsistencyWithHost = 16867,

    [NativeName("CL_IMPORT_ANDROID_HARDWARE_BUFFER_PLANE_INDEX_ARM")]
    AndroidHardwareBufferPlaneIndex = 16879,

    [NativeName("CL_IMPORT_ANDROID_HARDWARE_BUFFER_LAYER_INDEX_ARM")]
    AndroidHardwareBufferLayerIndex = 16880,
}
