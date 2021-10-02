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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVACompBufferInfo")]
    public unsafe partial struct CompBufferInfo
    {
        public CompBufferInfo
        (
            uint? numCompBuffers = null,
            uint? widthToCreate = null,
            uint? heightToCreate = null,
            uint? bytesToAllocate = null,
            uint? usage = null,
            Silk.NET.Direct3D9.Pool? pool = null,
            Silk.NET.Direct3D9.Format? format = null
        ) : this()
        {
            if (numCompBuffers is not null)
            {
                NumCompBuffers = numCompBuffers.Value;
            }

            if (widthToCreate is not null)
            {
                WidthToCreate = widthToCreate.Value;
            }

            if (heightToCreate is not null)
            {
                HeightToCreate = heightToCreate.Value;
            }

            if (bytesToAllocate is not null)
            {
                BytesToAllocate = bytesToAllocate.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (pool is not null)
            {
                Pool = pool.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumCompBuffers")]
        public uint NumCompBuffers;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "WidthToCreate")]
        public uint WidthToCreate;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "HeightToCreate")]
        public uint HeightToCreate;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "BytesToAllocate")]
        public uint BytesToAllocate;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Usage")]
        public uint Usage;

        [NativeName("Type", "D3DPOOL")]
        [NativeName("Type.Name", "D3DPOOL")]
        [NativeName("Name", "Pool")]
        public Silk.NET.Direct3D9.Pool Pool;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.Direct3D9.Format Format;
    }
}
