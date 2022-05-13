// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [NativeName("Name", "cl_import_properties_arm")]
    public enum ImportProperties : ulong
    {
        [NativeName("Name", "CL_IMPORT_TYPE_ARM")]
        Type = 0x40B2,
        [NativeName("Name", "CL_IMPORT_TYPE_HOST_ARM")]
        TypeHost = 0x40B3,
        [NativeName("Name", "CL_IMPORT_TYPE_DMA_BUF_ARM")]
        TypeDmaBuf = 0x40B4,
        [NativeName("Name", "CL_IMPORT_TYPE_PROTECTED_ARM")]
        TypeProtected = 0x40B5,
        [NativeName("Name", "CL_IMPORT_TYPE_ANDROID_HARDWARE_BUFFER_ARM")]
        TypeAndroidHardwareBuffer = 0x41E2,
        [NativeName("Name", "CL_IMPORT_DMA_BUF_DATA_CONSISTENCY_WITH_HOST_ARM")]
        DmaBufDataConsistencyWithHost = 0x41E3,
        [NativeName("Name", "CL_IMPORT_ANDROID_HARDWARE_BUFFER_PLANE_INDEX_ARM")]
        AndroidHardwareBufferPlaneIndex = 0x41EF,
        [NativeName("Name", "CL_IMPORT_ANDROID_HARDWARE_BUFFER_LAYER_INDEX_ARM")]
        AndroidHardwareBufferLayerIndex = 0x41F0,
    }
}
