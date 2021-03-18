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
    [NativeName("Name", "D3D12_RAYTRACING_SHADER_CONFIG")]
    public unsafe partial struct RaytracingShaderConfig
    {
        public RaytracingShaderConfig
        (
            uint? maxPayloadSizeInBytes = null,
            uint? maxAttributeSizeInBytes = null
        ) : this()
        {
            if (maxPayloadSizeInBytes is not null)
            {
                MaxPayloadSizeInBytes = maxPayloadSizeInBytes.Value;
            }

            if (maxAttributeSizeInBytes is not null)
            {
                MaxAttributeSizeInBytes = maxAttributeSizeInBytes.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxPayloadSizeInBytes")]
        public uint MaxPayloadSizeInBytes;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxAttributeSizeInBytes")]
        public uint MaxAttributeSizeInBytes;
    }
}
