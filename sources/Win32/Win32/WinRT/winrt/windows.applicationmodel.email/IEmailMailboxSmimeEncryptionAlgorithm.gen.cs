// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum IEmailMailboxSmimeEncryptionAlgorithm
{
    EmailMailboxSmimeEncryptionAlgorithm_Any = 0,
    EmailMailboxSmimeEncryptionAlgorithm_TripleDes = 1,
    EmailMailboxSmimeEncryptionAlgorithm_Des = 2,
    EmailMailboxSmimeEncryptionAlgorithm_RC2128Bit = 3,
    EmailMailboxSmimeEncryptionAlgorithm_RC264Bit = 4,
    EmailMailboxSmimeEncryptionAlgorithm_RC240Bit = 5,
}
