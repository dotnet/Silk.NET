// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DEBUG_DEVICE_GPU_BASED_VALIDATION_SETTINGS")]
    public unsafe partial struct DebugDeviceGpuBasedValidationSettings
    {
        public DebugDeviceGpuBasedValidationSettings
        (
            uint? maxMessagesPerCommandList = null,
            GpuBasedValidationShaderPatchMode? defaultShaderPatchMode = null,
            GpuBasedValidationPipelineStateCreateFlags? pipelineStateCreateFlags = null
        ) : this()
        {
            if (maxMessagesPerCommandList is not null)
            {
                MaxMessagesPerCommandList = maxMessagesPerCommandList.Value;
            }

            if (defaultShaderPatchMode is not null)
            {
                DefaultShaderPatchMode = defaultShaderPatchMode.Value;
            }

            if (pipelineStateCreateFlags is not null)
            {
                PipelineStateCreateFlags = pipelineStateCreateFlags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxMessagesPerCommandList")]
        public uint MaxMessagesPerCommandList;

        [NativeName("Type", "D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE")]
        [NativeName("Type.Name", "D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE")]
        [NativeName("Name", "DefaultShaderPatchMode")]
        public GpuBasedValidationShaderPatchMode DefaultShaderPatchMode;

        [NativeName("Type", "D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS")]
        [NativeName("Type.Name", "D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS")]
        [NativeName("Name", "PipelineStateCreateFlags")]
        public GpuBasedValidationPipelineStateCreateFlags PipelineStateCreateFlags;
    }
}
