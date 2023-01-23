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
    [NativeName("Name", "D3D12_RT_FORMAT_ARRAY")]
    public unsafe partial struct RTFormatArray
    {
        public RTFormatArray
        (
            uint? numRenderTargets = null
        ) : this()
        {
            if (numRenderTargets is not null)
            {
                NumRenderTargets = numRenderTargets.Value;
            }
        }

        
        [NativeName("Type", "DXGI_FORMAT[8]")]
        [NativeName("Type.Name", "DXGI_FORMAT[8]")]
        [NativeName("Name", "RTFormats")]
        public RTFormatsBuffer RTFormats;

        public struct RTFormatsBuffer
        {
            public Silk.NET.DXGI.Format Element0;
            public Silk.NET.DXGI.Format Element1;
            public Silk.NET.DXGI.Format Element2;
            public Silk.NET.DXGI.Format Element3;
            public Silk.NET.DXGI.Format Element4;
            public Silk.NET.DXGI.Format Element5;
            public Silk.NET.DXGI.Format Element6;
            public Silk.NET.DXGI.Format Element7;
            public ref Silk.NET.DXGI.Format this[int index]
            {
                get
                {
                    if (index > 7 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Silk.NET.DXGI.Format* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<Silk.NET.DXGI.Format> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 8);
#endif
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumRenderTargets")]
        public uint NumRenderTargets;
    }
}
