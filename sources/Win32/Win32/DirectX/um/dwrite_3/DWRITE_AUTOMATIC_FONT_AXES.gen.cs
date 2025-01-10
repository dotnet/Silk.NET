// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum DWRITE_AUTOMATIC_FONT_AXES
{
    DWRITE_AUTOMATIC_FONT_AXES_NONE = 0x0000,
    DWRITE_AUTOMATIC_FONT_AXES_OPTICAL_SIZE = 0x0001,
}
