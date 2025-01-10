// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ContactPhoneKind
{
    ContactPhoneKind_Home = 0,
    ContactPhoneKind_Mobile = 1,
    ContactPhoneKind_Work = 2,
    ContactPhoneKind_Other = 3,
    ContactPhoneKind_Pager = 4,
    ContactPhoneKind_BusinessFax = 5,
    ContactPhoneKind_HomeFax = 6,
    ContactPhoneKind_Company = 7,
    ContactPhoneKind_Assistant = 8,
    ContactPhoneKind_Radio = 9,
}
