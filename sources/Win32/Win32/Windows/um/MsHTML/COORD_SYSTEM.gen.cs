// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum COORD_SYSTEM
{
    COORD_SYSTEM_GLOBAL = 0,
    COORD_SYSTEM_PARENT = 1,
    COORD_SYSTEM_CONTAINER = 2,
    COORD_SYSTEM_CONTENT = 3,
    COORD_SYSTEM_FRAME = 4,
    COORD_SYSTEM_CLIENT = 5,
    COORD_SYSTEM_Max = 2147483647,
}
