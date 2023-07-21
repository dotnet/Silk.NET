// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE"]/*' />
public enum SID_NAME_USE
{
    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeUser"]/*' />
    SidTypeUser = 1,

    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeGroup"]/*' />
    SidTypeGroup,

    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeDomain"]/*' />
    SidTypeDomain,

    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeAlias"]/*' />
    SidTypeAlias,

    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeWellKnownGroup"]/*' />
    SidTypeWellKnownGroup,

    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeDeletedAccount"]/*' />
    SidTypeDeletedAccount,

    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeInvalid"]/*' />
    SidTypeInvalid,

    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeUnknown"]/*' />
    SidTypeUnknown,

    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeComputer"]/*' />
    SidTypeComputer,

    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeLabel"]/*' />
    SidTypeLabel,

    /// <include file='SID_NAME_USE.xml' path='doc/member[@name="SID_NAME_USE.SidTypeLogonSession"]/*' />
    SidTypeLogonSession,
}
