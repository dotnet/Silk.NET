// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='QCMINFO_IDMAP.xml' path='doc/member[@name="QCMINFO_IDMAP"]/*' />
public partial struct QCMINFO_IDMAP
{
    /// <include file='QCMINFO_IDMAP.xml' path='doc/member[@name="QCMINFO_IDMAP.nMaxIds"]/*' />
    public uint nMaxIds;

    /// <include file='QCMINFO_IDMAP.xml' path='doc/member[@name="QCMINFO_IDMAP.pIdList"]/*' />
    [NativeTypeName("QCMINFO_IDMAP_PLACEMENT[1]")]
    public _pIdList_e__FixedBuffer pIdList;

    /// <include file='_pIdList_e__FixedBuffer.xml' path='doc/member[@name="_pIdList_e__FixedBuffer"]/*' />
    public partial struct _pIdList_e__FixedBuffer
    {
        public QCMINFO_IDMAP_PLACEMENT e0;

        [UnscopedRef]
        public ref QCMINFO_IDMAP_PLACEMENT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<QCMINFO_IDMAP_PLACEMENT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
