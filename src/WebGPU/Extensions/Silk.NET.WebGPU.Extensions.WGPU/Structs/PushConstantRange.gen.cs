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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUPushConstantRange")]
    public unsafe partial struct PushConstantRange
    {
        public PushConstantRange
        (
            Silk.NET.WebGPU.ShaderStage? stages = null,
            uint? start = null,
            uint? end = null
        ) : this()
        {
            if (stages is not null)
            {
                Stages = stages.Value;
            }

            if (start is not null)
            {
                Start = start.Value;
            }

            if (end is not null)
            {
                End = end.Value;
            }
        }


        [NativeName("Type", "WGPUShaderStageFlags")]
        [NativeName("Type.Name", "WGPUShaderStageFlags")]
        [NativeName("Name", "stages")]
        public Silk.NET.WebGPU.ShaderStage Stages;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "start")]
        public uint Start;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "end")]
        public uint End;
    }
}
