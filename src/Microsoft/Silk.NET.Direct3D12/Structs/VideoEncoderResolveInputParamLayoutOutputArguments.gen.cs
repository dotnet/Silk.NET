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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RESOLVE_INPUT_PARAM_LAYOUT_OUTPUT_ARGUMENTS")]
    public unsafe partial struct VideoEncoderResolveInputParamLayoutOutputArguments
    {
        public VideoEncoderResolveInputParamLayoutOutputArguments
        (
            ID3D12Resource* pOpaqueLayoutBuffer = null
        ) : this()
        {
            if (pOpaqueLayoutBuffer is not null)
            {
                POpaqueLayoutBuffer = pOpaqueLayoutBuffer;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pOpaqueLayoutBuffer")]
        public ID3D12Resource* POpaqueLayoutBuffer;
    }
}
