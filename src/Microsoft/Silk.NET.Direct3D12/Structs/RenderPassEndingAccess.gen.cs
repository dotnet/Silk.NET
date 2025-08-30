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
    [NativeName("Name", "D3D12_RENDER_PASS_ENDING_ACCESS")]
    public unsafe partial struct RenderPassEndingAccess
    {
        public RenderPassEndingAccess
        (
            RenderPassEndingAccessType? type = null,
            RenderPassEndingAccessUnion? anonymous = null,
            RenderPassEndingAccessResolveParameters? resolve = null,
            RenderPassEndingAccessPreserveLocalParameters? preserveLocal = null
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

            if (resolve is not null)
            {
                Resolve = resolve.Value;
            }

            if (preserveLocal is not null)
            {
                PreserveLocal = preserveLocal.Value;
            }
        }


        [NativeName("Type", "D3D12_RENDER_PASS_ENDING_ACCESS_TYPE")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_ENDING_ACCESS_TYPE")]
        [NativeName("Name", "Type")]
        public RenderPassEndingAccessType Type;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L20724_C5")]
        [NativeName("Name", "anonymous1")]
        public RenderPassEndingAccessUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RenderPassEndingAccessResolveParameters Resolve
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Resolve;
        }
#else
        public RenderPassEndingAccessResolveParameters Resolve
        {
            get => Anonymous.Resolve;
            set => Anonymous.Resolve = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RenderPassEndingAccessPreserveLocalParameters PreserveLocal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PreserveLocal;
        }
#else
        public RenderPassEndingAccessPreserveLocalParameters PreserveLocal
        {
            get => Anonymous.PreserveLocal;
            set => Anonymous.PreserveLocal = value;
        }
#endif

    }
}
