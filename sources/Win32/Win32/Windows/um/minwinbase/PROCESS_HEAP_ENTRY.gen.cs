// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PROCESS_HEAP_ENTRY
{
    [NativeTypeName("PVOID")]
    public void* lpData;

    [NativeTypeName("DWORD")]
    public uint cbData;
    public byte cbOverhead;
    public byte iRegionIndex;

    [NativeTypeName("WORD")]
    public ushort wFlags;

    [NativeTypeName("__AnonymousRecord_minwinbase_L252_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._Block_e__Struct Block
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Block; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._Region_e__Struct Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Region; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minwinbase_L253_C9")]
        public _Block_e__Struct Block;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minwinbase_L257_C9")]
        public _Region_e__Struct Region;

        public partial struct _Block_e__Struct
        {
            public HANDLE hMem;

            [NativeTypeName("DWORD[3]")]
            public _dwReserved_e__FixedBuffer dwReserved;

            [InlineArray(3)]
            public partial struct _dwReserved_e__FixedBuffer
            {
                public uint e0;
            }
        }

        public unsafe partial struct _Region_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint dwCommittedSize;

            [NativeTypeName("DWORD")]
            public uint dwUnCommittedSize;

            [NativeTypeName("LPVOID")]
            public void* lpFirstBlock;

            [NativeTypeName("LPVOID")]
            public void* lpLastBlock;
        }
    }
}
