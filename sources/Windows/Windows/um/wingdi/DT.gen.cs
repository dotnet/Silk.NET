// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class DT
{
    [NativeTypeName("#define DT_PLOTTER 0")]
    public const int DT_PLOTTER = 0;
    [NativeTypeName("#define DT_RASDISPLAY 1")]
    public const int DT_RASDISPLAY = 1;
    [NativeTypeName("#define DT_RASPRINTER 2")]
    public const int DT_RASPRINTER = 2;
    [NativeTypeName("#define DT_RASCAMERA 3")]
    public const int DT_RASCAMERA = 3;
    [NativeTypeName("#define DT_CHARSTREAM 4")]
    public const int DT_CHARSTREAM = 4;
    [NativeTypeName("#define DT_METAFILE 5")]
    public const int DT_METAFILE = 5;
    [NativeTypeName("#define DT_DISPFILE 6")]
    public const int DT_DISPFILE = 6;
}