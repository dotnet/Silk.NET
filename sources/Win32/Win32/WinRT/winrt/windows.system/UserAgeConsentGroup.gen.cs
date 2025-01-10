// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum UserAgeConsentGroup
{
    UserAgeConsentGroup_Child = 0,
    UserAgeConsentGroup_Minor = 1,
    UserAgeConsentGroup_Adult = 2,
}
