// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum ACCESS_REASON_TYPE
{
    AccessReasonNone = 0x00000000,
    AccessReasonAllowedAce = 0x00010000,
    AccessReasonDeniedAce = 0x00020000,
    AccessReasonAllowedParentAce = 0x00030000,
    AccessReasonDeniedParentAce = 0x00040000,
    AccessReasonNotGrantedByCape = 0x00050000,
    AccessReasonNotGrantedByParentCape = 0x00060000,
    AccessReasonNotGrantedToAppContainer = 0x00070000,
    AccessReasonMissingPrivilege = 0x00100000,
    AccessReasonFromPrivilege = 0x00200000,
    AccessReasonIntegrityLevel = 0x00300000,
    AccessReasonOwnership = 0x00400000,
    AccessReasonNullDacl = 0x00500000,
    AccessReasonEmptyDacl = 0x00600000,
    AccessReasonNoSD = 0x00700000,
    AccessReasonNoGrant = 0x00800000,
    AccessReasonTrustLabel = 0x00900000,
    AccessReasonFilterAce = 0x00a00000,
}
