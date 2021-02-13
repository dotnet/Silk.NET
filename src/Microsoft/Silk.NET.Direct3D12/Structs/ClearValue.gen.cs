// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L2582_C5")]
        [NativeName("Name", "anonymous1")]
        public ClearValueUnion Anonymous;
#if NETSTANDARD2_1
        public ref DepthStencilValue DepthStencil
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.DepthStencil;
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
