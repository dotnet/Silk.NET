// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PSFEATURE_CUSTPAPER
{
    [NativeTypeName("LONG")]
    public int lOrientation;

    [NativeTypeName("LONG")]
    public int lWidth;

    [NativeTypeName("LONG")]
    public int lHeight;

    [NativeTypeName("LONG")]
    public int lWidthOffset;

    [NativeTypeName("LONG")]
    public int lHeightOffset;
}
