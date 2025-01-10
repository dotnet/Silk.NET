// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ALLOC_CONSOLE_RESULT
{
    ALLOC_CONSOLE_RESULT_NO_CONSOLE = 0,
    ALLOC_CONSOLE_RESULT_NEW_CONSOLE = 1,
    ALLOC_CONSOLE_RESULT_EXISTING_CONSOLE = 2,
}
