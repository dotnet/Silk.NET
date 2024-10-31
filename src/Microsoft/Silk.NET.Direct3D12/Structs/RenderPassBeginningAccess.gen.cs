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
    [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS")]
    public unsafe partial struct RenderPassBeginningAccess
    {
        public RenderPassBeginningAccess
        (
            RenderPassBeginningAccessType? type = null,
            RenderPassBeginningAccessUnion? anonymous = null,
            RenderPassBeginningAccessClearParameters? clear = null,
            RenderPassBeginningAccessPreserveLocalParameters? preserveLocal = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (clear is not null)
            {
                Clear = clear.Value;
            }

            if (preserveLocal is not null)
            {
                PreserveLocal = preserveLocal.Value;
            }
        }


        [NativeName("Type", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE")]
        [NativeName("Name", "Type")]
        public RenderPassBeginningAccessType Type;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L20676_C5")]
        [NativeName("Name", "anonymous1")]
        public RenderPassBeginningAccessUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RenderPassBeginningAccessClearParameters Clear
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Clear;
        }
#else
        public RenderPassBeginningAccessClearParameters Clear
        {
            get => Anonymous.Clear;
            set => Anonymous.Clear = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RenderPassBeginningAccessPreserveLocalParameters PreserveLocal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PreserveLocal;
        }
#else
        public RenderPassBeginningAccessPreserveLocalParameters PreserveLocal
        {
            get => Anonymous.PreserveLocal;
            set => Anonymous.PreserveLocal = value;
        }
#endif

    }
}
