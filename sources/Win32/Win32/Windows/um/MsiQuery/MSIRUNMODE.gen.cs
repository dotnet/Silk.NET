// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MSIRUNMODE
{
    MSIRUNMODE_ADMIN = 0,
    MSIRUNMODE_ADVERTISE = 1,
    MSIRUNMODE_MAINTENANCE = 2,
    MSIRUNMODE_ROLLBACKENABLED = 3,
    MSIRUNMODE_LOGENABLED = 4,
    MSIRUNMODE_OPERATIONS = 5,
    MSIRUNMODE_REBOOTATEND = 6,
    MSIRUNMODE_REBOOTNOW = 7,
    MSIRUNMODE_CABINET = 8,
    MSIRUNMODE_SOURCESHORTNAMES = 9,
    MSIRUNMODE_TARGETSHORTNAMES = 10,
    MSIRUNMODE_RESERVED11 = 11,
    MSIRUNMODE_WINDOWS9X = 12,
    MSIRUNMODE_ZAWENABLED = 13,
    MSIRUNMODE_RESERVED14 = 14,
    MSIRUNMODE_RESERVED15 = 15,
    MSIRUNMODE_SCHEDULED = 16,
    MSIRUNMODE_ROLLBACK = 17,
    MSIRUNMODE_COMMIT = 18,
}
