// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [Obsolete("The \"ungrouped\" enums (CLEnum, KHR, etc...) are deprecated in favour of the \"grouped\" enums (ErrorCodes, DeviceType, etc...). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ")]
    [NativeName("Name", "CLenum")]
    public enum QCOM : int
    {
        [NativeName("Name", "CL_MEM_ION_HOST_PTR_QCOM")]
        IonHostPtr = 0x40A8,
        [NativeName("Name", "CL_MEM_ION_HOST_PTR_QCOM")]
        MemIonHostPtrQCom = 0x40A8,
        [NativeName("Name", "CL_MEM_ANDROID_NATIVE_BUFFER_HOST_PTR_QCOM")]
        AndroidNativeBufferHostPtr = 0x40C6,
        [NativeName("Name", "CL_MEM_ANDROID_NATIVE_BUFFER_HOST_PTR_QCOM")]
        MemAndroidNativeBufferHostPtrQCom = 0x40C6,
        [NativeName("Name", "CL_MEM_HOST_UNCACHED_QCOM")]
        Uncached = 0x40A4,
        [NativeName("Name", "CL_MEM_HOST_UNCACHED_QCOM")]
        MemHostUncachedQCom = 0x40A4,
        [NativeName("Name", "CL_MEM_HOST_WRITEBACK_QCOM")]
        Writeback = 0x40A5,
        [NativeName("Name", "CL_MEM_HOST_WRITEBACK_QCOM")]
        MemHostWritebackQCom = 0x40A5,
        [NativeName("Name", "CL_MEM_HOST_WRITETHROUGH_QCOM")]
        Writethrough = 0x40A6,
        [NativeName("Name", "CL_MEM_HOST_WRITETHROUGH_QCOM")]
        MemHostWritethroughQCom = 0x40A6,
        [NativeName("Name", "CL_MEM_HOST_WRITE_COMBINING_QCOM")]
        WriteCombining = 0x40A7,
        [NativeName("Name", "CL_MEM_HOST_WRITE_COMBINING_QCOM")]
        MemHostWriteCombiningQCom = 0x40A7,
        [NativeName("Name", "CL_MEM_HOST_IOCOHERENT_QCOM")]
        Iocoherent = 0x40A9,
        [NativeName("Name", "CL_MEM_HOST_IOCOHERENT_QCOM")]
        MemHostIocoherentQCom = 0x40A9,
        [NativeName("Name", "CL_IMAGE_ROW_ALIGNMENT_QCOM")]
        RowAlignment = 0x40A2,
        [NativeName("Name", "CL_IMAGE_ROW_ALIGNMENT_QCOM")]
        ImageRowAlignmentQCom = 0x40A2,
        [NativeName("Name", "CL_IMAGE_SLICE_ALIGNMENT_QCOM")]
        SliceAlignment = 0x40A3,
        [NativeName("Name", "CL_IMAGE_SLICE_ALIGNMENT_QCOM")]
        ImageSliceAlignmentQCom = 0x40A3,
        [NativeName("Name", "CL_PERF_HINT_HIGH_QCOM")]
        High = 0x40C3,
        [NativeName("Name", "CL_PERF_HINT_HIGH_QCOM")]
        PerfHintHighQCom = 0x40C3,
        [NativeName("Name", "CL_PERF_HINT_NORMAL_QCOM")]
        Normal = 0x40C4,
        [NativeName("Name", "CL_PERF_HINT_NORMAL_QCOM")]
        PerfHintNormalQCom = 0x40C4,
        [NativeName("Name", "CL_PERF_HINT_LOW_QCOM")]
        Low = 0x40C5,
        [NativeName("Name", "CL_PERF_HINT_LOW_QCOM")]
        PerfHintLowQCom = 0x40C5,
        [NativeName("Name", "CL_CONTEXT_PERF_HINT_QCOM")]
        PerfHintQCom = 0x40C2,
        [NativeName("Name", "CL_CONTEXT_PERF_HINT_QCOM")]
        ContextPerfHintQCom = 0x40C2,
        [NativeName("Name", "CL_DEVICE_EXT_MEM_PADDING_IN_BYTES_QCOM")]
        ExtMemPaddingInBytesQCom = 0x40A0,
        [NativeName("Name", "CL_DEVICE_EXT_MEM_PADDING_IN_BYTES_QCOM")]
        DeviceExtMemPaddingInBytesQCom = 0x40A0,
        [NativeName("Name", "CL_DEVICE_PAGE_SIZE_QCOM")]
        PageSizeQCom = 0x40A1,
        [NativeName("Name", "CL_DEVICE_PAGE_SIZE_QCOM")]
        DevicePageSizeQCom = 0x40A1,
        [NativeName("Name", "CL_MEM_EXT_HOST_PTR_QCOM")]
        ExtHostPtrQCom = 0x20000000,
        [NativeName("Name", "CL_MEM_EXT_HOST_PTR_QCOM")]
        MemExtHostPtrQCom = 0x20000000,
    }
}
