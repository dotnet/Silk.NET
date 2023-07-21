// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64"]/*' />
public partial struct NT_TIB64
{
    /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.ExceptionList"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong ExceptionList;

    /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.StackBase"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong StackBase;

    /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.StackLimit"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong StackLimit;

    /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.SubSystemTib"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong SubSystemTib;

    /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L12329_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.ArbitraryUserPointer"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong ArbitraryUserPointer;

    /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.Self"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Self;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FiberData"]/*' />
    [UnscopedRef]
    public ref ulong FiberData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FiberData;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Version"]/*' />
    [UnscopedRef]
    public ref uint Version
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Version;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FiberData"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD64")]
        public ulong FiberData;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Version"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Version;
    }
}
