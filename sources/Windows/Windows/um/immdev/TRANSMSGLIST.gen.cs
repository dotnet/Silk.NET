// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='TRANSMSGLIST.xml' path='doc/member[@name="TRANSMSGLIST"]/*'/>
public partial struct TRANSMSGLIST
{
    /// <include file='TRANSMSGLIST.xml' path='doc/member[@name="TRANSMSGLIST.uMsgCount"]/*'/>
    public uint uMsgCount;
    /// <include file='TRANSMSGLIST.xml' path='doc/member[@name="TRANSMSGLIST.TransMsg"]/*'/>
    [NativeTypeName("TRANSMSG[1]")]
    public _TransMsg_e__FixedBuffer TransMsg;
    /// <include file='_TransMsg_e__FixedBuffer.xml' path='doc/member[@name="_TransMsg_e__FixedBuffer"]/*'/>
    public partial struct _TransMsg_e__FixedBuffer
    {
        public TRANSMSG e0;
        [UnscopedRef]
        public ref TRANSMSG this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<TRANSMSG> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}