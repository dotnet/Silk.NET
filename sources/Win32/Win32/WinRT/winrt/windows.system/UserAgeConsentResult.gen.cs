// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum UserAgeConsentResult
{
    UserAgeConsentResult_NotEnforced = 0,
    UserAgeConsentResult_Included = 1,
    UserAgeConsentResult_NotIncluded = 2,
    UserAgeConsentResult_Unknown = 3,
    UserAgeConsentResult_Ambiguous = 4,
}
