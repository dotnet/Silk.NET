// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum POINTER_INPUT_TYPE
{
    PT_POINTER = 1,
    PT_TOUCH = 2,
    PT_PEN = 3,
    PT_MOUSE = 4,
    PT_TOUCHPAD = 5,
}
