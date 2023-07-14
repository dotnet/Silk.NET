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

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_resource_binding")]
    public unsafe partial struct MslResourceBinding
    {
        public MslResourceBinding
        (
            Silk.NET.SPIRV.ExecutionModel? stage = null,
            uint? descSet = null,
            uint? binding = null,
            uint? mslBuffer = null,
            uint? mslTexture = null,
            uint? mslSampler = null
        ) : this()
        {
            if (stage is not null)
            {
                Stage = stage.Value;
            }

            if (descSet is not null)
            {
                DescSet = descSet.Value;
            }

            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (mslBuffer is not null)
            {
                MslBuffer = mslBuffer.Value;
            }

            if (mslTexture is not null)
            {
                MslTexture = mslTexture.Value;
            }

            if (mslSampler is not null)
            {
                MslSampler = mslSampler.Value;
            }
        }


        [NativeName("Type", "SpvExecutionModel")]
        [NativeName("Type.Name", "SpvExecutionModel")]
        [NativeName("Name", "stage")]
        public Silk.NET.SPIRV.ExecutionModel Stage;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "desc_set")]
        public uint DescSet;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "binding")]
        public uint Binding;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "msl_buffer")]
        public uint MslBuffer;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "msl_texture")]
        public uint MslTexture;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "msl_sampler")]
        public uint MslSampler;
    }
}
