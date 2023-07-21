// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SIP_DISPATCH_INFO.xml' path='doc/member[@name="SIP_DISPATCH_INFO"]/*' />
public unsafe partial struct SIP_DISPATCH_INFO
{
    /// <include file='SIP_DISPATCH_INFO.xml' path='doc/member[@name="SIP_DISPATCH_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIP_DISPATCH_INFO.xml' path='doc/member[@name="SIP_DISPATCH_INFO.hSIP"]/*' />
    public HANDLE hSIP;

    /// <include file='SIP_DISPATCH_INFO.xml' path='doc/member[@name="SIP_DISPATCH_INFO.pfGet"]/*' />
    [NativeTypeName("pCryptSIPGetSignedDataMsg")]
    public delegate* unmanaged<SIP_SUBJECTINFO*, uint*, uint, uint*, byte*, BOOL> pfGet;

    /// <include file='SIP_DISPATCH_INFO.xml' path='doc/member[@name="SIP_DISPATCH_INFO.pfPut"]/*' />
    [NativeTypeName("pCryptSIPPutSignedDataMsg")]
    public delegate* unmanaged<SIP_SUBJECTINFO*, uint, uint*, uint, byte*, BOOL> pfPut;

    /// <include file='SIP_DISPATCH_INFO.xml' path='doc/member[@name="SIP_DISPATCH_INFO.pfCreate"]/*' />
    [NativeTypeName("pCryptSIPCreateIndirectData")]
    public delegate* unmanaged<SIP_SUBJECTINFO*, uint*, SIP_INDIRECT_DATA*, BOOL> pfCreate;

    /// <include file='SIP_DISPATCH_INFO.xml' path='doc/member[@name="SIP_DISPATCH_INFO.pfVerify"]/*' />
    [NativeTypeName("pCryptSIPVerifyIndirectData")]
    public delegate* unmanaged<SIP_SUBJECTINFO*, SIP_INDIRECT_DATA*, BOOL> pfVerify;

    /// <include file='SIP_DISPATCH_INFO.xml' path='doc/member[@name="SIP_DISPATCH_INFO.pfRemove"]/*' />
    [NativeTypeName("pCryptSIPRemoveSignedDataMsg")]
    public delegate* unmanaged<SIP_SUBJECTINFO*, uint, BOOL> pfRemove;
}
