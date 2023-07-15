// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='EMRSETPALETTEENTRIES.xml' path='doc/member[@name="EMRSETPALETTEENTRIES"]/*'/>
public partial struct EMRSETPALETTEENTRIES
{
    /// <include file='EMRSETPALETTEENTRIES.xml' path='doc/member[@name="EMRSETPALETTEENTRIES.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRSETPALETTEENTRIES.xml' path='doc/member[@name="EMRSETPALETTEENTRIES.ihPal"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ihPal;
    /// <include file='EMRSETPALETTEENTRIES.xml' path='doc/member[@name="EMRSETPALETTEENTRIES.iStart"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iStart;
    /// <include file='EMRSETPALETTEENTRIES.xml' path='doc/member[@name="EMRSETPALETTEENTRIES.cEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cEntries;
    /// <include file='EMRSETPALETTEENTRIES.xml' path='doc/member[@name="EMRSETPALETTEENTRIES.aPalEntries"]/*'/>
    [NativeTypeName("PALETTEENTRY[1]")]
    public _aPalEntries_e__FixedBuffer aPalEntries;
    /// <include file='_aPalEntries_e__FixedBuffer.xml' path='doc/member[@name="_aPalEntries_e__FixedBuffer"]/*'/>
    public partial struct _aPalEntries_e__FixedBuffer
    {
        public PALETTEENTRY e0;
        [UnscopedRef]
        public ref PALETTEENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PALETTEENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}