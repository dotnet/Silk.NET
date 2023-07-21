// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='ADPCMWAVEFORMAT.xml' path='doc/member[@name="ADPCMWAVEFORMAT"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ADPCMWAVEFORMAT
{
    /// <include file='ADPCMWAVEFORMAT.xml' path='doc/member[@name="ADPCMWAVEFORMAT.wfx"]/*' />
    public WAVEFORMATEX wfx;

    /// <include file='ADPCMWAVEFORMAT.xml' path='doc/member[@name="ADPCMWAVEFORMAT.wSamplesPerBlock"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSamplesPerBlock;

    /// <include file='ADPCMWAVEFORMAT.xml' path='doc/member[@name="ADPCMWAVEFORMAT.wNumCoef"]/*' />
    [NativeTypeName("WORD")]
    public ushort wNumCoef;

    /// <include file='ADPCMWAVEFORMAT.xml' path='doc/member[@name="ADPCMWAVEFORMAT.aCoef"]/*' />
    [NativeTypeName("ADPCMCOEFSET[]")]
    public _aCoef_e__FixedBuffer aCoef;

    /// <include file='_aCoef_e__FixedBuffer.xml' path='doc/member[@name="_aCoef_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _aCoef_e__FixedBuffer
    {
        public ADPCMCOEFSET e0;

        [UnscopedRef]
        public ref ADPCMCOEFSET this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ADPCMCOEFSET> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
