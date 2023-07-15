// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='NCCALCSIZE_PARAMS.xml' path='doc/member[@name="NCCALCSIZE_PARAMS"]/*'/>
public unsafe partial struct NCCALCSIZE_PARAMS
{
    /// <include file='NCCALCSIZE_PARAMS.xml' path='doc/member[@name="NCCALCSIZE_PARAMS.rgrc"]/*'/>
    [NativeTypeName("RECT[3]")]
    public _rgrc_e__FixedBuffer rgrc;
    /// <include file='NCCALCSIZE_PARAMS.xml' path='doc/member[@name="NCCALCSIZE_PARAMS.lppos"]/*'/>
    [NativeTypeName("PWINDOWPOS")]
    public WINDOWPOS* lppos;
    /// <include file='_rgrc_e__FixedBuffer.xml' path='doc/member[@name="_rgrc_e__FixedBuffer"]/*'/>
    public partial struct _rgrc_e__FixedBuffer
    {
        public RECT e0;
        public RECT e1;
        public RECT e2;
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
        public Span<RECT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
    }
}