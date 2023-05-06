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
    [NativeName("Name", "tagSAFEARRAY")]
    public unsafe partial struct SafeArray
    {
        public SafeArray
        (
            ushort? cDims = null,
            ushort? fFeatures = null,
            uint? cbElements = null,
            uint? cLocks = null,
            void* pvData = null
        ) : this()
        {
            if (cDims is not null)
            {
                CDims = cDims.Value;
            }

            if (fFeatures is not null)
            {
                FFeatures = fFeatures.Value;
            }

            if (cbElements is not null)
            {
                CbElements = cbElements.Value;
            }

            if (cLocks is not null)
            {
                CLocks = cLocks.Value;
            }

            if (pvData is not null)
            {
                PvData = pvData;
            }
        }


        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "cDims")]
        public ushort CDims;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "fFeatures")]
        public ushort FFeatures;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cbElements")]
        public uint CbElements;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cLocks")]
        public uint CLocks;

        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "pvData")]
        public void* PvData;
        
        [NativeName("Type", "SAFEARRAYBOUND[1]")]
        [NativeName("Type.Name", "SAFEARRAYBOUND[1]")]
        [NativeName("Name", "rgsabound")]
        public RgsaboundBuffer Rgsabound;

        public struct RgsaboundBuffer
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
