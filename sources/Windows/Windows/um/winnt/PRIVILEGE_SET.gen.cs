// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='PRIVILEGE_SET.xml' path='doc/member[@name="PRIVILEGE_SET"]/*'/>
public partial struct PRIVILEGE_SET
{
    /// <include file='PRIVILEGE_SET.xml' path='doc/member[@name="PRIVILEGE_SET.PrivilegeCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PrivilegeCount;
    /// <include file='PRIVILEGE_SET.xml' path='doc/member[@name="PRIVILEGE_SET.Control"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Control;
    /// <include file='PRIVILEGE_SET.xml' path='doc/member[@name="PRIVILEGE_SET.Privilege"]/*'/>
    [NativeTypeName("LUID_AND_ATTRIBUTES[1]")]
    public _Privilege_e__FixedBuffer Privilege;
    /// <include file='_Privilege_e__FixedBuffer.xml' path='doc/member[@name="_Privilege_e__FixedBuffer"]/*'/>
    public partial struct _Privilege_e__FixedBuffer
    {
        public LUID_AND_ATTRIBUTES e0;
        [UnscopedRef]
        public ref LUID_AND_ATTRIBUTES this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<LUID_AND_ATTRIBUTES> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}