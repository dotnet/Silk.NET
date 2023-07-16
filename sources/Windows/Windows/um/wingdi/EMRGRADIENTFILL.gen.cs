// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='EMRGRADIENTFILL.xml' path='doc/member[@name="EMRGRADIENTFILL"]/*'/>
public partial struct EMRGRADIENTFILL
{
    /// <include file='EMRGRADIENTFILL.xml' path='doc/member[@name="EMRGRADIENTFILL.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRGRADIENTFILL.xml' path='doc/member[@name="EMRGRADIENTFILL.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='EMRGRADIENTFILL.xml' path='doc/member[@name="EMRGRADIENTFILL.nVer"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nVer;
    /// <include file='EMRGRADIENTFILL.xml' path='doc/member[@name="EMRGRADIENTFILL.nTri"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nTri;
    /// <include file='EMRGRADIENTFILL.xml' path='doc/member[@name="EMRGRADIENTFILL.ulMode"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulMode;
    /// <include file='EMRGRADIENTFILL.xml' path='doc/member[@name="EMRGRADIENTFILL.Ver"]/*'/>
    [NativeTypeName("TRIVERTEX[1]")]
    public _Ver_e__FixedBuffer Ver;
    /// <include file='_Ver_e__FixedBuffer.xml' path='doc/member[@name="_Ver_e__FixedBuffer"]/*'/>
    public partial struct _Ver_e__FixedBuffer
    {
        public TRIVERTEX e0;
        [UnscopedRef]
        public ref TRIVERTEX this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<TRIVERTEX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}