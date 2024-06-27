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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagARRAYDESC")]
    public unsafe partial struct ArrayDesc
    {
        public ArrayDesc
        (
            TypeDesc? tdescElem = null,
            ushort? cDims = null
        ) : this()
        {
            if (tdescElem is not null)
            {
                TdescElem = tdescElem.Value;
            }

            if (cDims is not null)
            {
                CDims = cDims.Value;
            }
        }


        [NativeName("Type", "TYPEDESC")]
        [NativeName("Type.Name", "TYPEDESC")]
        [NativeName("Name", "tdescElem")]
        public TypeDesc TdescElem;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "cDims")]
        public ushort CDims;
        
        [NativeName("Type", "SAFEARRAYBOUND[1]")]
        [NativeName("Type.Name", "SAFEARRAYBOUND[1]")]
        [NativeName("Name", "rgbounds")]
        public RgboundsBuffer Rgbounds;

        public struct RgboundsBuffer
        {
            public SafeArrayBound Element0;
            public ref SafeArrayBound this[int index]
            {
                get
                {
                    if (index > 0 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (SafeArrayBound* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<SafeArrayBound> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 1);
#endif
        }

    }
}
