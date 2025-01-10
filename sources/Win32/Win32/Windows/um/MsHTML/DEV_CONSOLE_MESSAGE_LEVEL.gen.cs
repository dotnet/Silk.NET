// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DEV_CONSOLE_MESSAGE_LEVEL
{
    DCML_INFORMATIONAL = 0,
    DCML_WARNING = 0x1,
    DCML_ERROR = 0x2,
    DEV_CONSOLE_MESSAGE_LEVEL_Max = 2147483647,
}
