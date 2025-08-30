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
    [NativeName("Name", "D3D12_TEXTURE_COPY_LOCATION")]
    public unsafe partial struct TextureCopyLocation
    {
        public TextureCopyLocation
        (
            ID3D12Resource* pResource = null,
            TextureCopyType? type = null,
            TextureCopyLocationUnion? anonymous = null,
            PlacedSubresourceFootprint? placedFootprint = null,
            uint? subresourceIndex = null
        ) : this()
        {
            if (pResource is not null)
            {
                PResource = pResource;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (placedFootprint is not null)
            {
                PlacedFootprint = placedFootprint.Value;
            }

            if (subresourceIndex is not null)
            {
                SubresourceIndex = subresourceIndex.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pResource")]
        public ID3D12Resource* PResource;

        [NativeName("Type", "D3D12_TEXTURE_COPY_TYPE")]
        [NativeName("Type.Name", "D3D12_TEXTURE_COPY_TYPE")]
        [NativeName("Name", "Type")]
        public TextureCopyType Type;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L3249_C5")]
        [NativeName("Name", "anonymous1")]
        public TextureCopyLocationUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref PlacedSubresourceFootprint PlacedFootprint
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PlacedFootprint;
        }
#else
        public PlacedSubresourceFootprint PlacedFootprint
        {
            get => Anonymous.PlacedFootprint;
            set => Anonymous.PlacedFootprint = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint SubresourceIndex
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].SubresourceIndex;
        }
#else
        public uint SubresourceIndex
        {
            get => Anonymous.SubresourceIndex;
            set => Anonymous.SubresourceIndex = value;
        }
#endif

    }
}
