// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='REASSIGN_BLOCKS_EX.xml' path='doc/member[@name="REASSIGN_BLOCKS_EX"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct REASSIGN_BLOCKS_EX
{
    /// <include file='REASSIGN_BLOCKS_EX.xml' path='doc/member[@name="REASSIGN_BLOCKS_EX.Reserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved;
    /// <include file='REASSIGN_BLOCKS_EX.xml' path='doc/member[@name="REASSIGN_BLOCKS_EX.Count"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Count;
    /// <include file='REASSIGN_BLOCKS_EX.xml' path='doc/member[@name="REASSIGN_BLOCKS_EX.BlockNumber"]/*'/>
    [NativeTypeName("LARGE_INTEGER[1]")]
    public _BlockNumber_e__FixedBuffer BlockNumber;
    /// <include file='_BlockNumber_e__FixedBuffer.xml' path='doc/member[@name="_BlockNumber_e__FixedBuffer"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _BlockNumber_e__FixedBuffer
    {
        public LARGE_INTEGER e0;
        [UnscopedRef]
        public ref LARGE_INTEGER this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<LARGE_INTEGER> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}