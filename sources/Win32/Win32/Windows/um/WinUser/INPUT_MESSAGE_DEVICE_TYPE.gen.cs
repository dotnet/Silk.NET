// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum INPUT_MESSAGE_DEVICE_TYPE
{
    IMDT_UNAVAILABLE = 0x00000000,
    IMDT_KEYBOARD = 0x00000001,
    IMDT_MOUSE = 0x00000002,
    IMDT_TOUCH = 0x00000004,
    IMDT_PEN = 0x00000008,
    IMDT_TOUCHPAD = 0x00000010,
}
