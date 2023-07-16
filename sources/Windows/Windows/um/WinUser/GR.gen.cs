// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class GR
{
    [NativeTypeName("#define GR_GDIOBJECTS 0")]
    public const int GR_GDIOBJECTS = 0;
    [NativeTypeName("#define GR_USEROBJECTS 1")]
    public const int GR_USEROBJECTS = 1;
    [NativeTypeName("#define GR_GDIOBJECTS_PEAK 2")]
    public const int GR_GDIOBJECTS_PEAK = 2;
    [NativeTypeName("#define GR_USEROBJECTS_PEAK 4")]
    public const int GR_USEROBJECTS_PEAK = 4;
}