// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DIRTYRECT_INFO.xml' path='doc/member[@name="DIRTYRECT_INFO"]/*'/>
public partial struct DIRTYRECT_INFO
{
    /// <include file='DIRTYRECT_INFO.xml' path='doc/member[@name="DIRTYRECT_INFO.FrameNumber"]/*'/>
    public uint FrameNumber;
    /// <include file='DIRTYRECT_INFO.xml' path='doc/member[@name="DIRTYRECT_INFO.NumDirtyRects"]/*'/>
    public uint NumDirtyRects;
    /// <include file='DIRTYRECT_INFO.xml' path='doc/member[@name="DIRTYRECT_INFO.DirtyRects"]/*'/>
    [NativeTypeName("RECT[1]")]
    public _DirtyRects_e__FixedBuffer DirtyRects;
    /// <include file='_DirtyRects_e__FixedBuffer.xml' path='doc/member[@name="_DirtyRects_e__FixedBuffer"]/*'/>
    public partial struct _DirtyRects_e__FixedBuffer
    {
        public RECT e0;
        [UnscopedRef]
        public ref RECT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<RECT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}