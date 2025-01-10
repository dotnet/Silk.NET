// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum ContactQuerySearchFields : uint
{
    ContactQuerySearchFields_None = 0,
    ContactQuerySearchFields_Name = 0x1,
    ContactQuerySearchFields_Email = 0x2,
    ContactQuerySearchFields_Phone = 0x4,
    ContactQuerySearchFields_All = 0xffffffff,
}
