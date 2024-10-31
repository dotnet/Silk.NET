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
    [NativeName("Name", "D3D12_CLEAR_VALUE")]
    public unsafe partial struct ClearValue
    {
        public ClearValue
        (
            Silk.NET.DXGI.Format? format = null,
            ClearValueUnion? anonymous = null,
            DepthStencilValue? depthStencil = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (depthStencil is not null)
            {
                DepthStencil = depthStencil.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L3037_C5")]
        [NativeName("Name", "anonymous1")]
        public ClearValueUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref DepthStencilValue DepthStencil
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].DepthStencil;
        }
#else
        public DepthStencilValue DepthStencil
        {
            get => Anonymous.DepthStencil;
            set => Anonymous.DepthStencil = value;
        }
#endif

    }
}
