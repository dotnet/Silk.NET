// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class IDF
{
    [NativeTypeName("#define IDF_NOBROWSE 0x00000001")]
    public const int IDF_NOBROWSE = 0x00000001;
    [NativeTypeName("#define IDF_NOSKIP 0x00000002")]
    public const int IDF_NOSKIP = 0x00000002;
    [NativeTypeName("#define IDF_NODETAILS 0x00000004")]
    public const int IDF_NODETAILS = 0x00000004;
    [NativeTypeName("#define IDF_NOCOMPRESSED 0x00000008")]
    public const int IDF_NOCOMPRESSED = 0x00000008;
    [NativeTypeName("#define IDF_CHECKFIRST 0x00000100")]
    public const int IDF_CHECKFIRST = 0x00000100;
    [NativeTypeName("#define IDF_NOBEEP 0x00000200")]
    public const int IDF_NOBEEP = 0x00000200;
    [NativeTypeName("#define IDF_NOFOREGROUND 0x00000400")]
    public const int IDF_NOFOREGROUND = 0x00000400;
    [NativeTypeName("#define IDF_WARNIFSKIP 0x00000800")]
    public const int IDF_WARNIFSKIP = 0x00000800;
    [NativeTypeName("#define IDF_NOREMOVABLEMEDIAPROMPT 0x00001000")]
    public const int IDF_NOREMOVABLEMEDIAPROMPT = 0x00001000;
    [NativeTypeName("#define IDF_USEDISKNAMEASPROMPT 0x00002000")]
    public const int IDF_USEDISKNAMEASPROMPT = 0x00002000;
    [NativeTypeName("#define IDF_OEMDISK 0x80000000")]
    public const uint IDF_OEMDISK = 0x80000000;
}