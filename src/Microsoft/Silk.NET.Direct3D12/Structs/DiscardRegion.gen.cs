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
    [NativeName("Name", "D3D12_DISCARD_REGION")]
    public unsafe partial struct DiscardRegion
    {
        public DiscardRegion
        (
            uint? numRects = null,
            Silk.NET.Maths.Box2D<int>* pRects = null,
            uint? firstSubresource = null,
            uint? numSubresources = null
        ) : this()
        {
            if (numRects is not null)
            {
                NumRects = numRects.Value;
            }

            if (pRects is not null)
            {
                PRects = pRects;
            }

            if (firstSubresource is not null)
            {
                FirstSubresource = firstSubresource.Value;
            }

            if (numSubresources is not null)
            {
                NumSubresources = numSubresources.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumRects")]
        public uint NumRects;

        [NativeName("Type", "const D3D12_RECT *")]
        [NativeName("Type.Name", "const D3D12_RECT *")]
        [NativeName("Name", "pRects")]
        public Silk.NET.Maths.Box2D<int>* PRects;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstSubresource")]
        public uint FirstSubresource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumSubresources")]
        public uint NumSubresources;
    }
}
