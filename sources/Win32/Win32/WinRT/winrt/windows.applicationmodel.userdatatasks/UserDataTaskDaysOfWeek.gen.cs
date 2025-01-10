// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum UserDataTaskDaysOfWeek : uint
{
    UserDataTaskDaysOfWeek_None = 0,
    UserDataTaskDaysOfWeek_Sunday = 0x1,
    UserDataTaskDaysOfWeek_Monday = 0x2,
    UserDataTaskDaysOfWeek_Tuesday = 0x4,
    UserDataTaskDaysOfWeek_Wednesday = 0x8,
    UserDataTaskDaysOfWeek_Thursday = 0x10,
    UserDataTaskDaysOfWeek_Friday = 0x20,
    UserDataTaskDaysOfWeek_Saturday = 0x40,
}
