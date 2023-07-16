// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='CMC_STATUS_INFO.xml' path='doc/member[@name="CMC_STATUS_INFO"]/*'/>
public unsafe partial struct CMC_STATUS_INFO
{
    /// <include file='CMC_STATUS_INFO.xml' path='doc/member[@name="CMC_STATUS_INFO.dwStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStatus;
    /// <include file='CMC_STATUS_INFO.xml' path='doc/member[@name="CMC_STATUS_INFO.cBodyList"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cBodyList;
    /// <include file='CMC_STATUS_INFO.xml' path='doc/member[@name="CMC_STATUS_INFO.rgdwBodyList"]/*'/>
    [NativeTypeName("DWORD *")]
    public uint* rgdwBodyList;
    /// <include file='CMC_STATUS_INFO.xml' path='doc/member[@name="CMC_STATUS_INFO.pwszStatusString"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszStatusString;
    /// <include file='CMC_STATUS_INFO.xml' path='doc/member[@name="CMC_STATUS_INFO.dwOtherInfoChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOtherInfoChoice;
    /// <include file='CMC_STATUS_INFO.xml' path='doc/member[@name="CMC_STATUS_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L5304_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwFailInfo"]/*'/>
    [UnscopedRef]
    public ref uint dwFailInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwFailInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pPendInfo"]/*'/>
    [UnscopedRef]
    public ref CMC_PEND_INFO* pPendInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pPendInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwFailInfo"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFailInfo;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pPendInfo"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCMC_PEND_INFO")]
        public CMC_PEND_INFO* pPendInfo;
    }
}