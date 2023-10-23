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
    [NativeName("Name", "spvc_hlsl_resource_binding")]
    public unsafe partial struct HlslResourceBinding
    {
        public HlslResourceBinding
        (
            Silk.NET.SPIRV.ExecutionModel? stage = null,
            uint? descSet = null,
            uint? binding = null,
            HlslResourceBindingMapping? cbv = null,
            HlslResourceBindingMapping? uav = null,
            HlslResourceBindingMapping? srv = null,
            HlslResourceBindingMapping? sampler = null
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

            if (cbv is not null)
            {
                Cbv = cbv.Value;
            }

            if (uav is not null)
            {
                Uav = uav.Value;
            }

            if (srv is not null)
            {
                Srv = srv.Value;
            }

            if (sampler is not null)
            {
                Sampler = sampler.Value;
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

        [NativeName("Type", "spvc_hlsl_resource_binding_mapping")]
        [NativeName("Type.Name", "spvc_hlsl_resource_binding_mapping")]
        [NativeName("Name", "cbv")]
        public HlslResourceBindingMapping Cbv;

        [NativeName("Type", "spvc_hlsl_resource_binding_mapping")]
        [NativeName("Type.Name", "spvc_hlsl_resource_binding_mapping")]
        [NativeName("Name", "uav")]
        public HlslResourceBindingMapping Uav;

        [NativeName("Type", "spvc_hlsl_resource_binding_mapping")]
        [NativeName("Type.Name", "spvc_hlsl_resource_binding_mapping")]
        [NativeName("Name", "srv")]
        public HlslResourceBindingMapping Srv;

        [NativeName("Type", "spvc_hlsl_resource_binding_mapping")]
        [NativeName("Type.Name", "spvc_hlsl_resource_binding_mapping")]
        [NativeName("Name", "sampler")]
        public HlslResourceBindingMapping Sampler;
    }
}
