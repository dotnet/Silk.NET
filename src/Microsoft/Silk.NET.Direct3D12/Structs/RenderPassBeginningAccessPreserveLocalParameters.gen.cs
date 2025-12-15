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
    [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_PRESERVE_LOCAL_PARAMETERS")]
    public unsafe partial struct RenderPassBeginningAccessPreserveLocalParameters
    {
        public RenderPassBeginningAccessPreserveLocalParameters
        (
            uint? additionalWidth = null,
            uint? additionalHeight = null
        ) : this()
        {
            if (additionalWidth is not null)
            {
                AdditionalWidth = additionalWidth.Value;
            }

            if (additionalHeight is not null)
            {
                AdditionalHeight = additionalHeight.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AdditionalWidth")]
        public uint AdditionalWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AdditionalHeight")]
        public uint AdditionalHeight;
    }
}
