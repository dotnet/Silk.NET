// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='CERT_LOGOTYPE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_INFO"]/*' />
public unsafe partial struct CERT_LOGOTYPE_INFO
{
    /// <include file='CERT_LOGOTYPE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_INFO.dwLogotypeInfoChoice"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLogotypeInfoChoice;

    /// <include file='CERT_LOGOTYPE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_wincrypt_L5523_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pLogotypeDirectInfo"]/*' />
    [UnscopedRef]
    public ref CERT_LOGOTYPE_DATA* pLogotypeDirectInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pLogotypeDirectInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pLogotypeIndirectInfo"]/*' />
    [UnscopedRef]
    public ref CERT_LOGOTYPE_REFERENCE* pLogotypeIndirectInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pLogotypeIndirectInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pLogotypeDirectInfo"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PCERT_LOGOTYPE_DATA")]
        public CERT_LOGOTYPE_DATA* pLogotypeDirectInfo;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pLogotypeIndirectInfo"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PCERT_LOGOTYPE_REFERENCE")]
        public CERT_LOGOTYPE_REFERENCE* pLogotypeIndirectInfo;
    }
}
