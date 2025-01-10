// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0149, CA1416
namespace Silk.NET.WinRT;

/// <include file='EmailMailboxSmimeSigningAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeSigningAlgorithm"]/*' />
public enum EmailMailboxSmimeSigningAlgorithm
{
    /// <include file='EmailMailboxSmimeSigningAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeSigningAlgorithm.EmailMailboxSmimeSigningAlgorithm_Any"]/*' />
    EmailMailboxSmimeSigningAlgorithm_Any = 0,

    /// <include file='EmailMailboxSmimeSigningAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeSigningAlgorithm.EmailMailboxSmimeSigningAlgorithm_Sha1"]/*' />
    EmailMailboxSmimeSigningAlgorithm_Sha1 = 1,

    /// <include file='EmailMailboxSmimeSigningAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeSigningAlgorithm.EmailMailboxSmimeSigningAlgorithm_MD5"]/*' />
    EmailMailboxSmimeSigningAlgorithm_MD5 = 2,
}
