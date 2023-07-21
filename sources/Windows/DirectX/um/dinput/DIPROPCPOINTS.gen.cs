// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='DIPROPCPOINTS.xml' path='doc/member[@name="DIPROPCPOINTS"]/*' />
public partial struct DIPROPCPOINTS
{
    /// <include file='DIPROPCPOINTS.xml' path='doc/member[@name="DIPROPCPOINTS.diph"]/*' />
    public DIPROPHEADER diph;

    /// <include file='DIPROPCPOINTS.xml' path='doc/member[@name="DIPROPCPOINTS.dwCPointsNum"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCPointsNum;

    /// <include file='DIPROPCPOINTS.xml' path='doc/member[@name="DIPROPCPOINTS.cp"]/*' />
    [NativeTypeName("CPOINT[8]")]
    public _cp_e__FixedBuffer cp;

    /// <include file='_cp_e__FixedBuffer.xml' path='doc/member[@name="_cp_e__FixedBuffer"]/*' />
    public partial struct _cp_e__FixedBuffer
    {
        public CPOINT e0;
        public CPOINT e1;
        public CPOINT e2;
        public CPOINT e3;
        public CPOINT e4;
        public CPOINT e5;
        public CPOINT e6;
        public CPOINT e7;

        [UnscopedRef]
        public ref CPOINT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<CPOINT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }
}
