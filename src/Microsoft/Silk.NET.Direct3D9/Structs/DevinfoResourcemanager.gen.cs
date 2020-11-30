// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
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
        
        [NativeName("Type", "D3DRESOURCESTATS [8]")]
        [NativeName("Type.Name", "D3DRESOURCESTATS [8]")]
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

#if NETSTANDARD2_1
            public Span<Resourcestats> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 8);
#endif
        }

    }
}
