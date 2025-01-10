// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum LanguageLayoutDirection
{
    LanguageLayoutDirection_Ltr = 0,
    LanguageLayoutDirection_Rtl = 1,
    LanguageLayoutDirection_TtbLtr = 2,
    LanguageLayoutDirection_TtbRtl = 3,
}
