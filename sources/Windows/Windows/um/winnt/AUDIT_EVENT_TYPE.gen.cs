// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AUDIT_EVENT_TYPE.xml' path='doc/member[@name="AUDIT_EVENT_TYPE"]/*' />
public enum AUDIT_EVENT_TYPE
{
    /// <include file='AUDIT_EVENT_TYPE.xml' path='doc/member[@name="AUDIT_EVENT_TYPE.AuditEventObjectAccess"]/*' />
    AuditEventObjectAccess,

    /// <include file='AUDIT_EVENT_TYPE.xml' path='doc/member[@name="AUDIT_EVENT_TYPE.AuditEventDirectoryServiceAccess"]/*' />
    AuditEventDirectoryServiceAccess,
}
