// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='DIACTIONA.xml' path='doc/member[@name="DIACTIONA"]/*'/>
public unsafe partial struct DIACTIONA
{
    /// <include file='DIACTIONA.xml' path='doc/member[@name="DIACTIONA.uAppData"]/*'/>
    [NativeTypeName("UINT_PTR")]
    public nuint uAppData;
    /// <include file='DIACTIONA.xml' path='doc/member[@name="DIACTIONA.dwSemantic"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSemantic;
    /// <include file='DIACTIONA.xml' path='doc/member[@name="DIACTIONA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DIACTIONA.xml' path='doc/member[@name="DIACTIONA.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_dinput_L660_C17")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='DIACTIONA.xml' path='doc/member[@name="DIACTIONA.guidInstance"]/*'/>
    public Guid guidInstance;
    /// <include file='DIACTIONA.xml' path='doc/member[@name="DIACTIONA.dwObjID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwObjID;
    /// <include file='DIACTIONA.xml' path='doc/member[@name="DIACTIONA.dwHow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHow;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lptszActionName"]/*'/>
    [UnscopedRef]
    public ref sbyte* lptszActionName
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
        [NativeTypeName("LPCSTR")]
        public sbyte* lptszActionName;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uResIdString"]/*'/>
        [FieldOffset(0)]
        public uint uResIdString;
    }
}