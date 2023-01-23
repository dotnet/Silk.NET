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
    [NativeName("Name", "D3D12_BLEND_DESC")]
    public unsafe partial struct BlendDesc
    {
        public BlendDesc
        (
            Silk.NET.Core.Bool32? alphaToCoverageEnable = null,
            Silk.NET.Core.Bool32? independentBlendEnable = null
        ) : this()
        {
            if (alphaToCoverageEnable is not null)
            {
                AlphaToCoverageEnable = alphaToCoverageEnable.Value;
            }

            if (independentBlendEnable is not null)
            {
                IndependentBlendEnable = independentBlendEnable.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AlphaToCoverageEnable")]
        public Silk.NET.Core.Bool32 AlphaToCoverageEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IndependentBlendEnable")]
        public Silk.NET.Core.Bool32 IndependentBlendEnable;
        
        [NativeName("Type", "D3D12_RENDER_TARGET_BLEND_DESC[8]")]
        [NativeName("Type.Name", "D3D12_RENDER_TARGET_BLEND_DESC[8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBuffer RenderTarget;

        public struct RenderTargetBuffer
        {
            public RenderTargetBlendDesc Element0;
            public RenderTargetBlendDesc Element1;
            public RenderTargetBlendDesc Element2;
            public RenderTargetBlendDesc Element3;
            public RenderTargetBlendDesc Element4;
            public RenderTargetBlendDesc Element5;
            public RenderTargetBlendDesc Element6;
            public RenderTargetBlendDesc Element7;
            public ref RenderTargetBlendDesc this[int index]
            {
                get
                {
                    if (index > 7 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (RenderTargetBlendDesc* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<RenderTargetBlendDesc> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 8);
#endif
        }

    }
}
