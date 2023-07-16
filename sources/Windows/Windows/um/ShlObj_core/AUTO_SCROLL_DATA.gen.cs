// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='AUTO_SCROLL_DATA.xml' path='doc/member[@name="AUTO_SCROLL_DATA"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct AUTO_SCROLL_DATA
{
    /// <include file='AUTO_SCROLL_DATA.xml' path='doc/member[@name="AUTO_SCROLL_DATA.iNextSample"]/*'/>
    public int iNextSample;
    /// <include file='AUTO_SCROLL_DATA.xml' path='doc/member[@name="AUTO_SCROLL_DATA.dwLastScroll"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLastScroll;
    /// <include file='AUTO_SCROLL_DATA.xml' path='doc/member[@name="AUTO_SCROLL_DATA.bFull"]/*'/>
    public BOOL bFull;
    /// <include file='AUTO_SCROLL_DATA.xml' path='doc/member[@name="AUTO_SCROLL_DATA.pts"]/*'/>
    [NativeTypeName("POINT[3]")]
    public _pts_e__FixedBuffer pts;
    /// <include file='AUTO_SCROLL_DATA.xml' path='doc/member[@name="AUTO_SCROLL_DATA.dwTimes"]/*'/>
    [NativeTypeName("DWORD[3]")]
    public fixed uint dwTimes[3];
    /// <include file='_pts_e__FixedBuffer.xml' path='doc/member[@name="_pts_e__FixedBuffer"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _pts_e__FixedBuffer
    {
        public POINT e0;
        public POINT e1;
        public POINT e2;
        [UnscopedRef]
        public ref POINT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<POINT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
    }
}