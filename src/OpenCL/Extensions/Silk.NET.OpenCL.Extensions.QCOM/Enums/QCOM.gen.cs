// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [NativeName("Name", "GLenum")]
    public enum QCOM : int
    {
        [NativeName("Name", "CL_MEM_ANDROID_NATIVE_BUFFER_HOST_PTR_QCOM")]
        MemAndroidNativeBufferHostPtrQCom = 0x40C6,
        [NativeName("Name", "CL_MEM_EXT_HOST_PTR_QCOM")]
        MemExtHostPtrQCom = 0x20000000,
        [NativeName("Name", "CL_DEVICE_EXT_MEM_PADDING_IN_BYTES_QCOM")]
        DeviceExtMemPaddingInBytesQCom = 0x40A0,
        [NativeName("Name", "CL_DEVICE_PAGE_SIZE_QCOM")]
        DevicePageSizeQCom = 0x40A1,
        [NativeName("Name", "CL_IMAGE_ROW_ALIGNMENT_QCOM")]
        ImageRowAlignmentQCom = 0x40A2,
        [NativeName("Name", "CL_IMAGE_SLICE_ALIGNMENT_QCOM")]
        ImageSliceAlignmentQCom = 0x40A3,
        [NativeName("Name", "CL_MEM_HOST_UNCACHED_QCOM")]
        MemHostUncachedQCom = 0x40A4,
        [NativeName("Name", "CL_MEM_HOST_WRITEBACK_QCOM")]
        MemHostWritebackQCom = 0x40A5,
        [NativeName("Name", "CL_MEM_HOST_WRITETHROUGH_QCOM")]
        MemHostWritethroughQCom = 0x40A6,
        [NativeName("Name", "CL_MEM_HOST_WRITE_COMBINING_QCOM")]
        MemHostWriteCombiningQCom = 0x40A7,
        [NativeName("Name", "CL_MEM_HOST_IOCOHERENT_QCOM")]
        MemHostIocoherentQCom = 0x40A9,
        [NativeName("Name", "CL_MEM_ION_HOST_PTR_QCOM")]
        MemIonHostPtrQCom = 0x40A8,
    }
}
