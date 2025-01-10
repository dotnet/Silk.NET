// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct QCMINFO_IDMAP
{
    public uint nMaxIds;

    [NativeTypeName("QCMINFO_IDMAP_PLACEMENT[1]")]
    public _pIdList_e__FixedBuffer pIdList;

    public partial struct _pIdList_e__FixedBuffer
    {
        public QCMINFO_IDMAP_PLACEMENT e0;

        [UnscopedRef]
        public ref QCMINFO_IDMAP_PLACEMENT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<QCMINFO_IDMAP_PLACEMENT> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
