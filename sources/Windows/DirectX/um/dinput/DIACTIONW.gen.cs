// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='DIACTIONW.xml' path='doc/member[@name="DIACTIONW"]/*'/>
public unsafe partial struct DIACTIONW
{
    /// <include file='DIACTIONW.xml' path='doc/member[@name="DIACTIONW.uAppData"]/*'/>
    [NativeTypeName("UINT_PTR")]
    public nuint uAppData;
    /// <include file='DIACTIONW.xml' path='doc/member[@name="DIACTIONW.dwSemantic"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSemantic;
    /// <include file='DIACTIONW.xml' path='doc/member[@name="DIACTIONW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DIACTIONW.xml' path='doc/member[@name="DIACTIONW.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_dinput_L672_C17")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='DIACTIONW.xml' path='doc/member[@name="DIACTIONW.guidInstance"]/*'/>
    public Guid guidInstance;
    /// <include file='DIACTIONW.xml' path='doc/member[@name="DIACTIONW.dwObjID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwObjID;
    /// <include file='DIACTIONW.xml' path='doc/member[@name="DIACTIONW.dwHow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHow;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lptszActionName"]/*'/>
    [UnscopedRef]
    public ref ushort* lptszActionName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.lptszActionName;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uResIdString"]/*'/>
    [UnscopedRef]
    public ref uint uResIdString
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.uResIdString;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lptszActionName"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* lptszActionName;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uResIdString"]/*'/>
        [FieldOffset(0)]
        public uint uResIdString;
    }
}