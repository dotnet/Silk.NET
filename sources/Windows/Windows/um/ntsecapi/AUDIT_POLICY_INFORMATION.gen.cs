// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='AUDIT_POLICY_INFORMATION.xml' path='doc/member[@name="AUDIT_POLICY_INFORMATION"]/*' />
public partial struct AUDIT_POLICY_INFORMATION
{
    /// <include file='AUDIT_POLICY_INFORMATION.xml' path='doc/member[@name="AUDIT_POLICY_INFORMATION.AuditSubCategoryGuid"]/*' />
    public Guid AuditSubCategoryGuid;

    /// <include file='AUDIT_POLICY_INFORMATION.xml' path='doc/member[@name="AUDIT_POLICY_INFORMATION.AuditingInformation"]/*' />
    [NativeTypeName("ULONG")]
    public uint AuditingInformation;

    /// <include file='AUDIT_POLICY_INFORMATION.xml' path='doc/member[@name="AUDIT_POLICY_INFORMATION.AuditCategoryGuid"]/*' />
    public Guid AuditCategoryGuid;
}
