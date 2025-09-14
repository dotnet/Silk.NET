// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_ENQUEUE_REQUEST_FLAGS")]
    public enum EnqueueRequestFlags : uint
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DSTORAGE_ENQUEUE_REQUEST_FLAG_NONE")]
        EnqueueRequestFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"FenceWaitBeforeGpuWork\"")]
        [NativeName("Name", "DSTORAGE_ENQUEUE_REQUEST_FLAG_FENCE_WAIT_BEFORE_GPU_WORK")]
        EnqueueRequestFlagFenceWaitBeforeGpuWork = 0x1,
        [Obsolete("Deprecated in favour of \"FenceWaitBeforeSourceAccess\"")]
        [NativeName("Name", "DSTORAGE_ENQUEUE_REQUEST_FLAG_FENCE_WAIT_BEFORE_SOURCE_ACCESS")]
        EnqueueRequestFlagFenceWaitBeforeSourceAccess = 0x2,
        [NativeName("Name", "DSTORAGE_ENQUEUE_REQUEST_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "DSTORAGE_ENQUEUE_REQUEST_FLAG_FENCE_WAIT_BEFORE_GPU_WORK")]
        FenceWaitBeforeGpuWork = 0x1,
        [NativeName("Name", "DSTORAGE_ENQUEUE_REQUEST_FLAG_FENCE_WAIT_BEFORE_SOURCE_ACCESS")]
        FenceWaitBeforeSourceAccess = 0x2,
    }
}
