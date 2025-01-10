// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;

    [NativeTypeName("WORD")]
    public ushort wSamplesPerBlock;

    [NativeTypeName("WORD")]
    public ushort wNumCoef;

    [NativeTypeName("ADPCMCOEFSET[]")]
    public _aCoef_e__FixedBuffer aCoef;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _aCoef_e__FixedBuffer
    {
        public ADPCMCOEFSET e0;

        [UnscopedRef]
        public ref ADPCMCOEFSET this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ADPCMCOEFSET> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
