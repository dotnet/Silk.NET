// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POLICY_MODIFICATION_INFO.xml' path='doc/member[@name="POLICY_MODIFICATION_INFO"]/*' />
public partial struct POLICY_MODIFICATION_INFO
{
    /// <include file='POLICY_MODIFICATION_INFO.xml' path='doc/member[@name="POLICY_MODIFICATION_INFO.ModifiedId"]/*' />
    public LARGE_INTEGER ModifiedId;

    /// <include file='POLICY_MODIFICATION_INFO.xml' path='doc/member[@name="POLICY_MODIFICATION_INFO.DatabaseCreationTime"]/*' />
    public LARGE_INTEGER DatabaseCreationTime;
}
