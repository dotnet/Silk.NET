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
    [NativeName("Name", "D3D12_RESOURCE_UAV_BARRIER")]
    public unsafe partial struct ResourceUavBarrier
    {
        public ResourceUavBarrier
        (
            ID3D12Resource* pResource = null
        ) : this()
        {
            if (pResource is not null)
            {
                PResource = pResource;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pResource")]
        public ID3D12Resource* PResource;
    }
}
