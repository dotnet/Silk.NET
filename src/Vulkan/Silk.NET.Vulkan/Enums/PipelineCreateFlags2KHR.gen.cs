// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineCreateFlags2KHR")]
    public enum PipelineCreateFlags2KHR : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DisableOptimizationBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT")]
        PipelineCreate2DisableOptimizationBit = 1,
        [Obsolete("Deprecated in favour of \"AllowDerivativesBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT")]
        PipelineCreate2AllowDerivativesBit = 2,
        [Obsolete("Deprecated in favour of \"DerivativeBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DERIVATIVE_BIT")]
        PipelineCreate2DerivativeBit = 4,
        [Obsolete("Deprecated in favour of \"ViewIndexFromDeviceIndexBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
        PipelineCreate2ViewIndexFromDeviceIndexBit = 8,
        [Obsolete("Deprecated in favour of \"DispatchBaseBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT")]
        PipelineCreate2DispatchBaseBit = 16,
        [Obsolete("Deprecated in favour of \"FailOnPipelineCompileRequiredBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT")]
        PipelineCreate2FailOnPipelineCompileRequiredBit = 256,
        [Obsolete("Deprecated in favour of \"EarlyReturnOnFailureBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT")]
        PipelineCreate2EarlyReturnOnFailureBit = 512,
        [Obsolete("Deprecated in favour of \"NoProtectedAccessBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT")]
        PipelineCreate2NoProtectedAccessBit = 134217728,
        [Obsolete("Deprecated in favour of \"ProtectedAccessOnlyBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT")]
        PipelineCreate2ProtectedAccessOnlyBit = 1073741824,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT")]
        DisableOptimizationBit = 1,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT")]
        AllowDerivativesBit = 2,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DERIVATIVE_BIT")]
        DerivativeBit = 4,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT")]
        ViewIndexFromDeviceIndexBit = 8,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT")]
        DispatchBaseBit = 16,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT")]
        FailOnPipelineCompileRequiredBit = 256,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT")]
        EarlyReturnOnFailureBit = 512,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT")]
        NoProtectedAccessBit = 134217728,
        [NativeName("Name", "VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT")]
        ProtectedAccessOnlyBit = 1073741824,
    }
}
