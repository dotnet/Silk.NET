// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='PROVDATA_SIP.xml' path='doc/member[@name="PROVDATA_SIP"]/*' />
public unsafe partial struct PROVDATA_SIP
{
    /// <include file='PROVDATA_SIP.xml' path='doc/member[@name="PROVDATA_SIP.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='PROVDATA_SIP.xml' path='doc/member[@name="PROVDATA_SIP.gSubject"]/*' />
    public Guid gSubject;

    /// <include file='PROVDATA_SIP.xml' path='doc/member[@name="PROVDATA_SIP.pSip"]/*' />
    [NativeTypeName("struct SIP_DISPATCH_INFO_ *")]
    public SIP_DISPATCH_INFO* pSip;

    /// <include file='PROVDATA_SIP.xml' path='doc/member[@name="PROVDATA_SIP.pCATSip"]/*' />
    [NativeTypeName("struct SIP_DISPATCH_INFO_ *")]
    public SIP_DISPATCH_INFO* pCATSip;

    /// <include file='PROVDATA_SIP.xml' path='doc/member[@name="PROVDATA_SIP.psSipSubjectInfo"]/*' />
    [NativeTypeName("struct SIP_SUBJECTINFO_ *")]
    public SIP_SUBJECTINFO* psSipSubjectInfo;

    /// <include file='PROVDATA_SIP.xml' path='doc/member[@name="PROVDATA_SIP.psSipCATSubjectInfo"]/*' />
    [NativeTypeName("struct SIP_SUBJECTINFO_ *")]
    public SIP_SUBJECTINFO* psSipCATSubjectInfo;

    /// <include file='PROVDATA_SIP.xml' path='doc/member[@name="PROVDATA_SIP.psIndirectData"]/*' />
    [NativeTypeName("struct SIP_INDIRECT_DATA_ *")]
    public SIP_INDIRECT_DATA* psIndirectData;
}
