// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum INPUT_MESSAGE_ORIGIN_ID
{
    IMO_UNAVAILABLE = 0x00000000,
    IMO_HARDWARE = 0x00000001,
    IMO_INJECTED = 0x00000002,
    IMO_SYSTEM = 0x00000004,
}
