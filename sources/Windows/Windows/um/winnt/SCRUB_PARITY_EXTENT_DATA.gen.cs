// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA"]/*'/>
public partial struct SCRUB_PARITY_EXTENT_DATA
{
    /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA.Size"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Size;
    /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA.Flags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Flags;
    /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA.NumberOfParityExtents"]/*'/>
    [NativeTypeName("WORD")]
    public ushort NumberOfParityExtents;
    /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA.MaximumNumberOfParityExtents"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MaximumNumberOfParityExtents;
    /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA.ParityExtents"]/*'/>
    [NativeTypeName("SCRUB_PARITY_EXTENT[1]")]
    public _ParityExtents_e__FixedBuffer ParityExtents;
    /// <include file='_ParityExtents_e__FixedBuffer.xml' path='doc/member[@name="_ParityExtents_e__FixedBuffer"]/*'/>
    public partial struct _ParityExtents_e__FixedBuffer
    {
        public SCRUB_PARITY_EXTENT e0;
        [UnscopedRef]
        public ref SCRUB_PARITY_EXTENT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCRUB_PARITY_EXTENT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}