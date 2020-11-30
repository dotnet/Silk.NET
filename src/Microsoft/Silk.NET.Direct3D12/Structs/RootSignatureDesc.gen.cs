// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_ROOT_SIGNATURE_DESC")]
    public unsafe partial struct RootSignatureDesc
    {
        public RootSignatureDesc
        (
            uint? numParameters = null,
            RootParameter* pParameters = null,
            uint? numStaticSamplers = null,
            StaticSamplerDesc* pStaticSamplers = null,
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

        [NativeName("Type", "const D3D12_ROOT_PARAMETER *")]
        [NativeName("Type.Name", "const D3D12_ROOT_PARAMETER *")]
        [NativeName("Name", "pParameters")]
        public RootParameter* PParameters;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumStaticSamplers")]
        public uint NumStaticSamplers;

        [NativeName("Type", "const D3D12_STATIC_SAMPLER_DESC *")]
        [NativeName("Type.Name", "const D3D12_STATIC_SAMPLER_DESC *")]
        [NativeName("Name", "pStaticSamplers")]
        public StaticSamplerDesc* PStaticSamplers;

        [NativeName("Type", "D3D12_ROOT_SIGNATURE_FLAGS")]
        [NativeName("Type.Name", "D3D12_ROOT_SIGNATURE_FLAGS")]
        [NativeName("Name", "Flags")]
        public RootSignatureFlags Flags;
    }
}
