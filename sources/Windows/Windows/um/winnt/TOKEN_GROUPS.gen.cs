// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='TOKEN_GROUPS.xml' path='doc/member[@name="TOKEN_GROUPS"]/*'/>
public partial struct TOKEN_GROUPS
{
    /// <include file='TOKEN_GROUPS.xml' path='doc/member[@name="TOKEN_GROUPS.GroupCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint GroupCount;
    /// <include file='TOKEN_GROUPS.xml' path='doc/member[@name="TOKEN_GROUPS.Groups"]/*'/>
    [NativeTypeName("SID_AND_ATTRIBUTES[1]")]
    public _Groups_e__FixedBuffer Groups;
    /// <include file='_Groups_e__FixedBuffer.xml' path='doc/member[@name="_Groups_e__FixedBuffer"]/*'/>
    public partial struct _Groups_e__FixedBuffer
    {
        public SID_AND_ATTRIBUTES e0;
        [UnscopedRef]
        public ref SID_AND_ATTRIBUTES this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SID_AND_ATTRIBUTES> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}