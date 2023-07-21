// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='JOBOBJECT_SECURITY_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_SECURITY_LIMIT_INFORMATION"]/*' />
public unsafe partial struct JOBOBJECT_SECURITY_LIMIT_INFORMATION
{
    /// <include file='JOBOBJECT_SECURITY_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_SECURITY_LIMIT_INFORMATION.SecurityLimitFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint SecurityLimitFlags;

    /// <include file='JOBOBJECT_SECURITY_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_SECURITY_LIMIT_INFORMATION.JobToken"]/*' />
    public HANDLE JobToken;

    /// <include file='JOBOBJECT_SECURITY_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_SECURITY_LIMIT_INFORMATION.SidsToDisable"]/*' />
    [NativeTypeName("PTOKEN_GROUPS")]
    public TOKEN_GROUPS* SidsToDisable;

    /// <include file='JOBOBJECT_SECURITY_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_SECURITY_LIMIT_INFORMATION.PrivilegesToDelete"]/*' />
    [NativeTypeName("PTOKEN_PRIVILEGES")]
    public TOKEN_PRIVILEGES* PrivilegesToDelete;

    /// <include file='JOBOBJECT_SECURITY_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_SECURITY_LIMIT_INFORMATION.RestrictedSids"]/*' />
    [NativeTypeName("PTOKEN_GROUPS")]
    public TOKEN_GROUPS* RestrictedSids;
}
