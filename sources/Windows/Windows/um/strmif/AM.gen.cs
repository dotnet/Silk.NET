// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class AM
{
    [NativeTypeName("#define AM_GBF_PREVFRAMESKIPPED 1")]
    public const int AM_GBF_PREVFRAMESKIPPED = 1;
    [NativeTypeName("#define AM_GBF_NOTASYNCPOINT 2")]
    public const int AM_GBF_NOTASYNCPOINT = 2;
    [NativeTypeName("#define AM_GBF_NOWAIT 4")]
    public const int AM_GBF_NOWAIT = 4;
    [NativeTypeName("#define AM_GBF_NODDSURFACELOCK 8")]
    public const int AM_GBF_NODDSURFACELOCK = 8;
    [NativeTypeName("#define AM_GETDECODERCAP_QUERY_VMR_SUPPORT 0x00000001")]
    public const int AM_GETDECODERCAP_QUERY_VMR_SUPPORT = 0x00000001;
    [NativeTypeName("#define AM_QUERY_DECODER_VMR_SUPPORT 0x00000001")]
    public const int AM_QUERY_DECODER_VMR_SUPPORT = 0x00000001;
    [NativeTypeName("#define AM_QUERY_DECODER_DXVA_1_SUPPORT 0x00000002")]
    public const int AM_QUERY_DECODER_DXVA_1_SUPPORT = 0x00000002;
    [NativeTypeName("#define AM_QUERY_DECODER_DVD_SUPPORT 0x00000003")]
    public const int AM_QUERY_DECODER_DVD_SUPPORT = 0x00000003;
    [NativeTypeName("#define AM_QUERY_DECODER_ATSC_SD_SUPPORT 0x00000004")]
    public const int AM_QUERY_DECODER_ATSC_SD_SUPPORT = 0x00000004;
    [NativeTypeName("#define AM_QUERY_DECODER_ATSC_HD_SUPPORT 0x00000005")]
    public const int AM_QUERY_DECODER_ATSC_HD_SUPPORT = 0x00000005;
    [NativeTypeName("#define AM_GETDECODERCAP_QUERY_VMR9_SUPPORT 0x00000006")]
    public const int AM_GETDECODERCAP_QUERY_VMR9_SUPPORT = 0x00000006;
    [NativeTypeName("#define AM_GETDECODERCAP_QUERY_EVR_SUPPORT 0x00000007")]
    public const int AM_GETDECODERCAP_QUERY_EVR_SUPPORT = 0x00000007;
}