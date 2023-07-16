// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='ACTRL_OVERLAPPED.xml' path='doc/member[@name="ACTRL_OVERLAPPED"]/*'/>
public unsafe partial struct ACTRL_OVERLAPPED
{
    /// <include file='ACTRL_OVERLAPPED.xml' path='doc/member[@name="ACTRL_OVERLAPPED.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_accctrl_L658_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='ACTRL_OVERLAPPED.xml' path='doc/member[@name="ACTRL_OVERLAPPED.Reserved2"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Reserved2;
    /// <include file='ACTRL_OVERLAPPED.xml' path='doc/member[@name="ACTRL_OVERLAPPED.hEvent"]/*'/>
    public HANDLE hEvent;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Provider"]/*'/>
    [UnscopedRef]
    public ref void* Provider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Provider;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved1"]/*'/>
    [UnscopedRef]
    public ref uint Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Reserved1;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Provider"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PVOID")]
        public void* Provider;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved1"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint Reserved1;
    }
}