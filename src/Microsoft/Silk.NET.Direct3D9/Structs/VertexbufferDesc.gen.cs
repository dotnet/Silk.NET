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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DVERTEXBUFFER_DESC")]
    public unsafe partial struct VertexbufferDesc
    {
        public VertexbufferDesc
        (
            Format? format = null,
            Resourcetype? type = null,
            int? usage = null,
            Pool? pool = null,
            uint? size = null,
            int? fVF = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (pool is not null)
            {
                Pool = pool.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (fVF is not null)
            {
                FVF = fVF.Value;
            }
        }


        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "Format")]
        public Format Format;

        [NativeName("Type", "D3DRESOURCETYPE")]
        [NativeName("Type.Name", "D3DRESOURCETYPE")]
        [NativeName("Name", "Type")]
        public Resourcetype Type;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Usage")]
        public int Usage;

        [NativeName("Type", "D3DPOOL")]
        [NativeName("Type.Name", "D3DPOOL")]
        [NativeName("Name", "Pool")]
        public Pool Pool;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "FVF")]
        public int FVF;
    }
}
