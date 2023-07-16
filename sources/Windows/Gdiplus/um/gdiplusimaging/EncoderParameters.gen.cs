// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus;
/// <include file='EncoderParameters.xml' path='doc/member[@name="EncoderParameters"]/*'/>
public partial struct EncoderParameters
{
    /// <include file='EncoderParameters.xml' path='doc/member[@name="EncoderParameters.Count"]/*'/>
    public uint Count;
    /// <include file='EncoderParameters.xml' path='doc/member[@name="EncoderParameters.Parameter"]/*'/>
    [NativeTypeName("EncoderParameter[1]")]
    public _Parameter_e__FixedBuffer Parameter;
    /// <include file='_Parameter_e__FixedBuffer.xml' path='doc/member[@name="_Parameter_e__FixedBuffer"]/*'/>
    public partial struct _Parameter_e__FixedBuffer
    {
        public EncoderParameter e0;
        [UnscopedRef]
        public ref EncoderParameter this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<EncoderParameter> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}