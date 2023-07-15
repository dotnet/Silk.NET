// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("#define iPALETTE_COLORS 256")]
    public const int iPALETTE_COLORS = 256;
    [NativeTypeName("#define iEGA_COLORS 16")]
    public const int iEGA_COLORS = 16;
    [NativeTypeName("#define iMASK_COLORS 3")]
    public const int iMASK_COLORS = 3;
    [NativeTypeName("#define iTRUECOLOR 16")]
    public const int iTRUECOLOR = 16;
    [NativeTypeName("#define iRED 0")]
    public const int iRED = 0;
    [NativeTypeName("#define iGREEN 1")]
    public const int iGREEN = 1;
    [NativeTypeName("#define iBLUE 2")]
    public const int iBLUE = 2;
    [NativeTypeName("#define iPALETTE 8")]
    public const int iPALETTE = 8;
    [NativeTypeName("#define iMAXBITS 8")]
    public const int iMAXBITS = 8;
    [NativeTypeName("#define SIZE_EGA_PALETTE (iEGA_COLORS * sizeof(RGBQUAD))")]
    public const uint SIZE_EGA_PALETTE = (16 * 4);
    [NativeTypeName("#define SIZE_PALETTE (iPALETTE_COLORS * sizeof(RGBQUAD))")]
    public const uint SIZE_PALETTE = (256 * 4);
    [NativeTypeName("#define SIZE_MASKS (iMASK_COLORS * sizeof(DWORD))")]
    public const uint SIZE_MASKS = (3 * 4);
}