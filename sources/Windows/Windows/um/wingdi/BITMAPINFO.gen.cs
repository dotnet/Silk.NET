// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='BITMAPINFO.xml' path='doc/member[@name="BITMAPINFO"]/*'/>
public partial struct BITMAPINFO
{
    /// <include file='BITMAPINFO.xml' path='doc/member[@name="BITMAPINFO.bmiHeader"]/*'/>
    public BITMAPINFOHEADER bmiHeader;
    /// <include file='BITMAPINFO.xml' path='doc/member[@name="BITMAPINFO.bmiColors"]/*'/>
    [NativeTypeName("RGBQUAD[1]")]
    public _bmiColors_e__FixedBuffer bmiColors;
    /// <include file='_bmiColors_e__FixedBuffer.xml' path='doc/member[@name="_bmiColors_e__FixedBuffer"]/*'/>
    public partial struct _bmiColors_e__FixedBuffer
    {
        public RGBQUAD e0;
        [UnscopedRef]
        public ref RGBQUAD this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<RGBQUAD> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}