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
    [NativeName("Name", "D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS")]
    public unsafe partial struct DebugCommandListGpuBasedValidationSettings
    {
        public DebugCommandListGpuBasedValidationSettings
        (
            GpuBasedValidationShaderPatchMode? shaderPatchMode = null
        ) : this()
        {
            if (shaderPatchMode is not null)
            {
                ShaderPatchMode = shaderPatchMode.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE")]
        [NativeName("Type.Name", "D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE")]
        [NativeName("Name", "ShaderPatchMode")]
        public GpuBasedValidationShaderPatchMode ShaderPatchMode;
    }
}
