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
    [NativeName("Name", "_PROCESS_HEAP_ENTRY")]
    public unsafe partial struct ProcessHeapEntry
    {
        public ProcessHeapEntry
        (
            void* lpData = null,
            uint? cbData = null,
            byte? cbOverhead = null,
            byte? iRegionIndex = null,
            ushort? wFlags = null,
            ProcessHeapEntryUnion? anonymous = null,
            ProcessHeapEntryUnionBlock? block = null,
            ProcessHeapEntryUnionRegion? region = null
        ) : this()
        {
            if (lpData is not null)
            {
                LpData = lpData;
            }

            if (cbData is not null)
            {
                CbData = cbData.Value;
            }

            if (cbOverhead is not null)
            {
                CbOverhead = cbOverhead.Value;
            }

            if (iRegionIndex is not null)
            {
                IRegionIndex = iRegionIndex.Value;
            }

            if (wFlags is not null)
            {
                WFlags = wFlags.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (block is not null)
            {
                Block = block.Value;
            }

            if (region is not null)
            {
                Region = region.Value;
            }
        }


        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "lpData")]
        public void* LpData;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "cbData")]
        public uint CbData;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "cbOverhead")]
        public byte CbOverhead;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "iRegionIndex")]
        public byte IRegionIndex;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wFlags")]
        public ushort WFlags;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_minwinbase_L252_C5")]
        [NativeName("Name", "anonymous1")]
        public ProcessHeapEntryUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ProcessHeapEntryUnionBlock Block
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Block;
        }
#else
        public ProcessHeapEntryUnionBlock Block
        {
            get => Anonymous.Block;
            set => Anonymous.Block = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ProcessHeapEntryUnionRegion Region
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Region;
        }
#else
        public ProcessHeapEntryUnionRegion Region
        {
            get => Anonymous.Region;
            set => Anonymous.Region = value;
        }
#endif

    }
}
