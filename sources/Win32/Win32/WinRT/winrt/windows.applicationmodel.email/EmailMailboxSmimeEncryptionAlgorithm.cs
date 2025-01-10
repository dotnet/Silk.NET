// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0149, CA1416
namespace Silk.NET.WinRT;

/// <include file='EmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeEncryptionAlgorithm"]/*' />
public enum EmailMailboxSmimeEncryptionAlgorithm
{
    /// <include file='EmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_Any"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_Any = 0,

    /// <include file='EmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_TripleDes"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_TripleDes = 1,

    /// <include file='EmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_Des"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_Des = 2,

    /// <include file='EmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_RC2128Bit"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_RC2128Bit = 3,

    /// <include file='EmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_RC264Bit"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_RC264Bit = 4,

    /// <include file='EmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="EmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_RC240Bit"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_RC240Bit = 5,
}
