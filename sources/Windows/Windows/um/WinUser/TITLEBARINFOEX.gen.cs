// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='TITLEBARINFOEX.xml' path='doc/member[@name="TITLEBARINFOEX"]/*' />
public unsafe partial struct TITLEBARINFOEX
{
    /// <include file='TITLEBARINFOEX.xml' path='doc/member[@name="TITLEBARINFOEX.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='TITLEBARINFOEX.xml' path='doc/member[@name="TITLEBARINFOEX.rcTitleBar"]/*' />
    public RECT rcTitleBar;

    /// <include file='TITLEBARINFOEX.xml' path='doc/member[@name="TITLEBARINFOEX.rgstate"]/*' />
    [NativeTypeName("DWORD[6]")]
    public fixed uint rgstate[6];

    /// <include file='TITLEBARINFOEX.xml' path='doc/member[@name="TITLEBARINFOEX.rgrect"]/*' />
    [NativeTypeName("RECT[6]")]
    public _rgrect_e__FixedBuffer rgrect;

    /// <include file='_rgrect_e__FixedBuffer.xml' path='doc/member[@name="_rgrect_e__FixedBuffer"]/*' />
    public partial struct _rgrect_e__FixedBuffer
    {
        public RECT e0;
        public RECT e1;
        public RECT e2;
        public RECT e3;
        public RECT e4;
        public RECT e5;

        [UnscopedRef]
        public ref RECT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<RECT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 6);
    }
}
