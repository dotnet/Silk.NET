// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='PAGESET.xml' path='doc/member[@name="PAGESET"]/*'/>
public partial struct PAGESET
{
    /// <include file='PAGESET.xml' path='doc/member[@name="PAGESET.cbStruct"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbStruct;
    /// <include file='PAGESET.xml' path='doc/member[@name="PAGESET.fOddPages"]/*'/>
    public BOOL fOddPages;
    /// <include file='PAGESET.xml' path='doc/member[@name="PAGESET.fEvenPages"]/*'/>
    public BOOL fEvenPages;
    /// <include file='PAGESET.xml' path='doc/member[@name="PAGESET.cPageRange"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cPageRange;
    /// <include file='PAGESET.xml' path='doc/member[@name="PAGESET.rgPages"]/*'/>
    [NativeTypeName("PAGERANGE[1]")]
    public _rgPages_e__FixedBuffer rgPages;
    /// <include file='_rgPages_e__FixedBuffer.xml' path='doc/member[@name="_rgPages_e__FixedBuffer"]/*'/>
    public partial struct _rgPages_e__FixedBuffer
    {
        public PAGERANGE e0;
        [UnscopedRef]
        public ref PAGERANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PAGERANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}