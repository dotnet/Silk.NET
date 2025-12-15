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
    [NativeName("Name", "D3D12_ROOT_SIGNATURE_DESC2")]
    public unsafe partial struct RootSignatureDesc2
    {
        public RootSignatureDesc2
        (
            uint? numParameters = null,
            RootParameter1* pParameters = null,
            uint? numStaticSamplers = null,
            StaticSamplerDesc1* pStaticSamplers = null,
            RootSignatureFlags? flags = null
        ) : this()
        {
            if (numParameters is not null)
            {
                NumParameters = numParameters.Value;
            }

            if (pParameters is not null)
            {
                PParameters = pParameters;
            }

            if (numStaticSamplers is not null)
            {
                NumStaticSamplers = numStaticSamplers.Value;
            }

            if (pStaticSamplers is not null)
            {
                PStaticSamplers = pStaticSamplers;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumParameters")]
        public uint NumParameters;

        [NativeName("Type", "const D3D12_ROOT_PARAMETER1 *")]
        [NativeName("Type.Name", "const D3D12_ROOT_PARAMETER1 *")]
        [NativeName("Name", "pParameters")]
        public RootParameter1* PParameters;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumStaticSamplers")]
        public uint NumStaticSamplers;

        [NativeName("Type", "const D3D12_STATIC_SAMPLER_DESC1 *")]
        [NativeName("Type.Name", "const D3D12_STATIC_SAMPLER_DESC1 *")]
        [NativeName("Name", "pStaticSamplers")]
        public StaticSamplerDesc1* PStaticSamplers;

        [NativeName("Type", "D3D12_ROOT_SIGNATURE_FLAGS")]
        [NativeName("Type.Name", "D3D12_ROOT_SIGNATURE_FLAGS")]
        [NativeName("Name", "Flags")]
        public RootSignatureFlags Flags;
    }
}
