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
    [NativeName("Name", "_D3DDEVINFO_RESOURCEMANAGER")]
    public unsafe partial struct DevinfoResourcemanager
    {
        
        [NativeName("Type", "D3DRESOURCESTATS[8]")]
        [NativeName("Type.Name", "D3DRESOURCESTATS[8]")]
        [NativeName("Name", "stats")]
        public StatsBuffer Stats;

        public struct StatsBuffer
        {
            public Resourcestats Element0;
            public Resourcestats Element1;
            public Resourcestats Element2;
            public Resourcestats Element3;
            public Resourcestats Element4;
            public Resourcestats Element5;
            public Resourcestats Element6;
            public Resourcestats Element7;
            public ref Resourcestats this[int index]
            {
                get
                {
                    if (index > 7 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Resourcestats* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<Resourcestats> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 8);
#endif
        }

    }
}
