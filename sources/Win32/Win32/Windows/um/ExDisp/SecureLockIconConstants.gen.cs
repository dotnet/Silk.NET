// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SecureLockIconConstants
{
    secureLockIconUnsecure = 0,
    secureLockIconMixed = 0x1,
    secureLockIconSecureUnknownBits = 0x2,
    secureLockIconSecure40Bit = 0x3,
    secureLockIconSecure56Bit = 0x4,
    secureLockIconSecureFortezza = 0x5,
    secureLockIconSecure128Bit = 0x6,
}
