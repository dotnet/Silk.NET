// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MESSAGE_RESOURCE_DATA.xml' path='doc/member[@name="MESSAGE_RESOURCE_DATA"]/*'/>
public partial struct MESSAGE_RESOURCE_DATA
{
    /// <include file='MESSAGE_RESOURCE_DATA.xml' path='doc/member[@name="MESSAGE_RESOURCE_DATA.NumberOfBlocks"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfBlocks;
    /// <include file='MESSAGE_RESOURCE_DATA.xml' path='doc/member[@name="MESSAGE_RESOURCE_DATA.Blocks"]/*'/>
    [NativeTypeName("MESSAGE_RESOURCE_BLOCK[1]")]
    public _Blocks_e__FixedBuffer Blocks;
    /// <include file='_Blocks_e__FixedBuffer.xml' path='doc/member[@name="_Blocks_e__FixedBuffer"]/*'/>
    public partial struct _Blocks_e__FixedBuffer
    {
        public MESSAGE_RESOURCE_BLOCK e0;
        [UnscopedRef]
        public ref MESSAGE_RESOURCE_BLOCK this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MESSAGE_RESOURCE_BLOCK> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}