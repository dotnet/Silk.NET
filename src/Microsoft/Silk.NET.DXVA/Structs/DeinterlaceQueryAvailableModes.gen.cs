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
    [NativeName("Name", "_DXVA_DeinterlaceQueryAvailableModes")]
    public unsafe partial struct DeinterlaceQueryAvailableModes
    {
        public DeinterlaceQueryAvailableModes
        (
            uint? size = null,
            uint? numGuids = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (numGuids is not null)
            {
                NumGuids = numGuids.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumGuids")]
        public uint NumGuids;
        
        [NativeName("Type", "GUID[32]")]
        [NativeName("Type.Name", "GUID[32]")]
        [NativeName("Name", "Guids")]
        public GuidsBuffer Guids;

        public struct GuidsBuffer
        {
            public Guid Element0;
            public Guid Element1;
            public Guid Element2;
            public Guid Element3;
            public Guid Element4;
            public Guid Element5;
            public Guid Element6;
            public Guid Element7;
            public Guid Element8;
            public Guid Element9;
            public Guid Element10;
            public Guid Element11;
            public Guid Element12;
            public Guid Element13;
            public Guid Element14;
            public Guid Element15;
            public Guid Element16;
            public Guid Element17;
            public Guid Element18;
            public Guid Element19;
            public Guid Element20;
            public Guid Element21;
            public Guid Element22;
            public Guid Element23;
            public Guid Element24;
            public Guid Element25;
            public Guid Element26;
            public Guid Element27;
            public Guid Element28;
            public Guid Element29;
            public Guid Element30;
            public Guid Element31;
            public ref Guid this[int index]
            {
                get
                {
                    if (index > 31 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Guid* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<Guid> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 32);
#endif
        }

    }
}
