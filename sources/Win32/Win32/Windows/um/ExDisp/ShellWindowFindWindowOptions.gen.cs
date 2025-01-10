// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ShellWindowFindWindowOptions
{
    SWFO_NEEDDISPATCH = 0x1,
    SWFO_INCLUDEPENDING = 0x2,
    SWFO_COOKIEPASSED = 0x4,
}
