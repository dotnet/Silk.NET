// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='ARRAYDESC.xml' path='doc/member[@name="ARRAYDESC"]/*' />
public partial struct ARRAYDESC
{
    /// <include file='ARRAYDESC.xml' path='doc/member[@name="ARRAYDESC.tdescElem"]/*' />
    public TYPEDESC tdescElem;

    /// <include file='ARRAYDESC.xml' path='doc/member[@name="ARRAYDESC.cDims"]/*' />
    public ushort cDims;

    /// <include file='ARRAYDESC.xml' path='doc/member[@name="ARRAYDESC.rgbounds"]/*' />
    [NativeTypeName("SAFEARRAYBOUND[1]")]
    public _rgbounds_e__FixedBuffer rgbounds;

    /// <include file='_rgbounds_e__FixedBuffer.xml' path='doc/member[@name="_rgbounds_e__FixedBuffer"]/*' />
    public partial struct _rgbounds_e__FixedBuffer
    {
        public SAFEARRAYBOUND e0;

        [UnscopedRef]
        public ref SAFEARRAYBOUND this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SAFEARRAYBOUND> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
