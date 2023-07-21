// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LSA_LAST_INTER_LOGON_INFO.xml' path='doc/member[@name="LSA_LAST_INTER_LOGON_INFO"]/*' />
public partial struct LSA_LAST_INTER_LOGON_INFO
{
    /// <include file='LSA_LAST_INTER_LOGON_INFO.xml' path='doc/member[@name="LSA_LAST_INTER_LOGON_INFO.LastSuccessfulLogon"]/*' />
    public LARGE_INTEGER LastSuccessfulLogon;

    /// <include file='LSA_LAST_INTER_LOGON_INFO.xml' path='doc/member[@name="LSA_LAST_INTER_LOGON_INFO.LastFailedLogon"]/*' />
    public LARGE_INTEGER LastFailedLogon;

    /// <include file='LSA_LAST_INTER_LOGON_INFO.xml' path='doc/member[@name="LSA_LAST_INTER_LOGON_INFO.FailedAttemptCountSinceLastSuccessfulLogon"]/*' />
    [NativeTypeName("ULONG")]
    public uint FailedAttemptCountSinceLastSuccessfulLogon;
}
