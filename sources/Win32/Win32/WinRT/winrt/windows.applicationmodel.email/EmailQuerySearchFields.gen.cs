// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum EmailQuerySearchFields : uint
{
    EmailQuerySearchFields_None = 0,
    EmailQuerySearchFields_Subject = 0x1,
    EmailQuerySearchFields_Sender = 0x2,
    EmailQuerySearchFields_Preview = 0x4,
    EmailQuerySearchFields_Recipients = 0x8,
    EmailQuerySearchFields_All = 0xffffffff,
}
