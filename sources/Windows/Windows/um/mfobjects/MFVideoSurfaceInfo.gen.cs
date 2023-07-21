// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MFVideoSurfaceInfo.xml' path='doc/member[@name="MFVideoSurfaceInfo"]/*' />
public partial struct MFVideoSurfaceInfo
{
    /// <include file='MFVideoSurfaceInfo.xml' path='doc/member[@name="MFVideoSurfaceInfo.Format"]/*' />
    [NativeTypeName("DWORD")]
    public uint Format;

    /// <include file='MFVideoSurfaceInfo.xml' path='doc/member[@name="MFVideoSurfaceInfo.PaletteEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint PaletteEntries;

    /// <include file='MFVideoSurfaceInfo.xml' path='doc/member[@name="MFVideoSurfaceInfo.Palette"]/*' />
    [NativeTypeName("MFPaletteEntry[1]")]
    public _Palette_e__FixedBuffer Palette;

    /// <include file='_Palette_e__FixedBuffer.xml' path='doc/member[@name="_Palette_e__FixedBuffer"]/*' />
    public partial struct _Palette_e__FixedBuffer
    {
        public MFPaletteEntry e0;

        [UnscopedRef]
        public ref MFPaletteEntry this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MFPaletteEntry> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
