// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ALLOC_CONSOLE_MODE
{
    ALLOC_CONSOLE_MODE_DEFAULT = 0,
    ALLOC_CONSOLE_MODE_NEW_WINDOW = 1,
    ALLOC_CONSOLE_MODE_NO_WINDOW = 2,
}
