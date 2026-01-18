// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUCreatePipelineAsyncStatus")]
    public enum CreatePipelineAsyncStatus : int
    {
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_Success")]
        Success = 0x1,
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_CallbackCancelled")]
        CallbackCancelled = 0x2,
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_ValidationError")]
        ValidationError = 0x3,
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_InternalError")]
        InternalError = 0x4,
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
