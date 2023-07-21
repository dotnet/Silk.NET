// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='LM_OWF_PASSWORD.xml' path='doc/member[@name="LM_OWF_PASSWORD"]/*' />
public partial struct LM_OWF_PASSWORD
{
    /// <include file='LM_OWF_PASSWORD.xml' path='doc/member[@name="LM_OWF_PASSWORD.data"]/*' />
    [NativeTypeName("CYPHER_BLOCK[2]")]
    public _data_e__FixedBuffer data;

    /// <include file='_data_e__FixedBuffer.xml' path='doc/member[@name="_data_e__FixedBuffer"]/*' />
    public partial struct _data_e__FixedBuffer
    {
        public CYPHER_BLOCK e0;
        public CYPHER_BLOCK e1;

        [UnscopedRef]
        public ref CYPHER_BLOCK this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<CYPHER_BLOCK> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}
