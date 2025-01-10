// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum EmailQueryKind
{
    EmailQueryKind_All = 0,
    EmailQueryKind_Important = 1,
    EmailQueryKind_Flagged = 2,
    EmailQueryKind_Unread = 3,
    EmailQueryKind_Read = 4,
    EmailQueryKind_Unseen = 5,
}
