// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum URLZONE
{
    URLZONE_INVALID = -1,
    URLZONE_PREDEFINED_MIN = 0,
    URLZONE_LOCAL_MACHINE = 0,
    URLZONE_INTRANET = (URLZONE_LOCAL_MACHINE + 1),
    URLZONE_TRUSTED = (URLZONE_INTRANET + 1),
    URLZONE_INTERNET = (URLZONE_TRUSTED + 1),
    URLZONE_UNTRUSTED = (URLZONE_INTERNET + 1),
    URLZONE_PREDEFINED_MAX = 999,
    URLZONE_USER_MIN = 1000,
    URLZONE_USER_MAX = 10000,
}
