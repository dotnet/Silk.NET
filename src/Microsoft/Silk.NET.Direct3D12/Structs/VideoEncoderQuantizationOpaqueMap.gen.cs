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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_QUANTIZATION_OPAQUE_MAP")]
    public unsafe partial struct VideoEncoderQuantizationOpaqueMap
    {
        public VideoEncoderQuantizationOpaqueMap
        (
            ID3D12Resource* pOpaqueQuantizationMap = null
        ) : this()
        {
            if (pOpaqueQuantizationMap is not null)
            {
                POpaqueQuantizationMap = pOpaqueQuantizationMap;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pOpaqueQuantizationMap")]
        public ID3D12Resource* POpaqueQuantizationMap;
    }
}
