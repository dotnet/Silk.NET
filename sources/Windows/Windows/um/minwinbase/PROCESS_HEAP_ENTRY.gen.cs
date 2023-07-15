// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY"]/*'/>
public unsafe partial struct PROCESS_HEAP_ENTRY
{
    /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.lpData"]/*'/>
    [NativeTypeName("PVOID")]
    public void* lpData;
    /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.cbData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbData;
    /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.cbOverhead"]/*'/>
    public byte cbOverhead;
    /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.iRegionIndex"]/*'/>
    public byte iRegionIndex;
    /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.wFlags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wFlags;
    /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_minwinbase_L249_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Block"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._Block_e__Struct Block
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Block;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Region"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._Region_e__Struct Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Region;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Block"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minwinbase_L250_C9")]
        public _Block_e__Struct Block;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Region"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minwinbase_L254_C9")]
        public _Region_e__Struct Region;
        /// <include file='_Block_e__Struct.xml' path='doc/member[@name="_Block_e__Struct"]/*'/>
        public unsafe partial struct _Block_e__Struct
        {
            /// <include file='_Block_e__Struct.xml' path='doc/member[@name="_Block_e__Struct.hMem"]/*'/>
            public HANDLE hMem;
            /// <include file='_Block_e__Struct.xml' path='doc/member[@name="_Block_e__Struct.dwReserved"]/*'/>
            [NativeTypeName("DWORD[3]")]
            public fixed uint dwReserved[3];
        }

        /// <include file='_Region_e__Struct.xml' path='doc/member[@name="_Region_e__Struct"]/*'/>
        public unsafe partial struct _Region_e__Struct
        {
            /// <include file='_Region_e__Struct.xml' path='doc/member[@name="_Region_e__Struct.dwCommittedSize"]/*'/>
            [NativeTypeName("DWORD")]
            public uint dwCommittedSize;
            /// <include file='_Region_e__Struct.xml' path='doc/member[@name="_Region_e__Struct.dwUnCommittedSize"]/*'/>
            [NativeTypeName("DWORD")]
            public uint dwUnCommittedSize;
            /// <include file='_Region_e__Struct.xml' path='doc/member[@name="_Region_e__Struct.lpFirstBlock"]/*'/>
            [NativeTypeName("LPVOID")]
            public void* lpFirstBlock;
            /// <include file='_Region_e__Struct.xml' path='doc/member[@name="_Region_e__Struct.lpLastBlock"]/*'/>
            [NativeTypeName("LPVOID")]
            public void* lpLastBlock;
        }
    }
}