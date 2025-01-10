// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum ContactQueryDesiredFields : uint
{
    ContactQueryDesiredFields_None = 0,
    ContactQueryDesiredFields_PhoneNumber = 0x1,
    ContactQueryDesiredFields_EmailAddress = 0x2,
    ContactQueryDesiredFields_PostalAddress = 0x4,
}
