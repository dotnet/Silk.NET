// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define _INC_MMREG 158")]
    public const int _INC_MMREG = 158;
    [NativeTypeName("#define CRYSTAL_NET_SFM_CODEC 1")]
    public const int CRYSTAL_NET_SFM_CODEC = 1;
    [NativeTypeName("#define MPEGLAYER3_WFX_EXTRA_BYTES 12")]
    public const int MPEGLAYER3_WFX_EXTRA_BYTES = 12;
    [NativeTypeName("#define MPEGLAYER3_ID_UNKNOWN 0")]
    public const int MPEGLAYER3_ID_UNKNOWN = 0;
    [NativeTypeName("#define MPEGLAYER3_ID_MPEG 1")]
    public const int MPEGLAYER3_ID_MPEG = 1;
    [NativeTypeName("#define MPEGLAYER3_ID_CONSTANTFRAMESIZE 2")]
    public const int MPEGLAYER3_ID_CONSTANTFRAMESIZE = 2;
    [NativeTypeName("#define MPEGLAYER3_FLAG_PADDING_ISO 0x00000000")]
    public const int MPEGLAYER3_FLAG_PADDING_ISO = 0x00000000;
    [NativeTypeName("#define MPEGLAYER3_FLAG_PADDING_ON 0x00000001")]
    public const int MPEGLAYER3_FLAG_PADDING_ON = 0x00000001;
    [NativeTypeName("#define MPEGLAYER3_FLAG_PADDING_OFF 0x00000002")]
    public const int MPEGLAYER3_FLAG_PADDING_OFF = 0x00000002;
    [NativeTypeName("#define WMAUDIO_BITS_PER_SAMPLE 16")]
    public const int WMAUDIO_BITS_PER_SAMPLE = 16;
    [NativeTypeName("#define WMAUDIO_MAX_CHANNELS 2")]
    public const int WMAUDIO_MAX_CHANNELS = 2;
    [NativeTypeName("#define MSAUDIO1_BITS_PER_SAMPLE WMAUDIO_BITS_PER_SAMPLE")]
    public const int MSAUDIO1_BITS_PER_SAMPLE = 16;
    [NativeTypeName("#define MSAUDIO1_MAX_CHANNELS WMAUDIO_MAX_CHANNELS")]
    public const int MSAUDIO1_MAX_CHANNELS = 2;
    [NativeTypeName("#define WMAUDIO2_BITS_PER_SAMPLE WMAUDIO_BITS_PER_SAMPLE")]
    public const int WMAUDIO2_BITS_PER_SAMPLE = 16;
    [NativeTypeName("#define WMAUDIO2_MAX_CHANNELS WMAUDIO_MAX_CHANNELS")]
    public const int WMAUDIO2_MAX_CHANNELS = 2;
    [NativeTypeName("#define RIFFWAVE_inst mmioFOURCC('i','n','s','t')")]
    public const uint RIFFWAVE_inst = ((uint)((byte)('i')) | ((uint)((byte)('n')) << 8) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('t')) << 24));
    [NativeTypeName("#define RIFFCPPO mmioFOURCC('C','P','P','O')")]
    public const uint RIFFCPPO = ((uint)((byte)('C')) | ((uint)((byte)('P')) << 8) | ((uint)((byte)('P')) << 16) | ((uint)((byte)('O')) << 24));
    [NativeTypeName("#define BICOMP_IBMULTIMOTION mmioFOURCC('U', 'L', 'T', 'I')")]
    public const uint BICOMP_IBMULTIMOTION = ((uint)((byte)('U')) | ((uint)((byte)('L')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('I')) << 24));
    [NativeTypeName("#define BICOMP_IBMPHOTOMOTION mmioFOURCC('P', 'H', 'M', 'O')")]
    public const uint BICOMP_IBMPHOTOMOTION = ((uint)((byte)('P')) | ((uint)((byte)('H')) << 8) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('O')) << 24));
    [NativeTypeName("#define BICOMP_CREATIVEYUV mmioFOURCC('c', 'y', 'u', 'v')")]
    public const uint BICOMP_CREATIVEYUV = ((uint)((byte)('c')) | ((uint)((byte)('y')) << 8) | ((uint)((byte)('u')) << 16) | ((uint)((byte)('v')) << 24));
    [NativeTypeName("#define JPEG_DIB mmioFOURCC('J','P','E','G')")]
    public const uint JPEG_DIB = ((uint)((byte)('J')) | ((uint)((byte)('P')) << 8) | ((uint)((byte)('E')) << 16) | ((uint)((byte)('G')) << 24));
    [NativeTypeName("#define MJPG_DIB mmioFOURCC('M','J','P','G')")]
    public const uint MJPG_DIB = ((uint)((byte)('M')) | ((uint)((byte)('J')) << 8) | ((uint)((byte)('P')) << 16) | ((uint)((byte)('G')) << 24));
    [NativeTypeName("#define JPEG_PROCESS_BASELINE 0")]
    public const int JPEG_PROCESS_BASELINE = 0;
    [NativeTypeName("#define AVIIF_CONTROLFRAME 0x00000200L")]
    public const int AVIIF_CONTROLFRAME = 0x00000200;
    [NativeTypeName("#define JPEG_Y 1")]
    public const int JPEG_Y = 1;
    [NativeTypeName("#define JPEG_YCbCr 2")]
    public const int JPEG_YCbCr = 2;
    [NativeTypeName("#define JPEG_RGB 3")]
    public const int JPEG_RGB = 3;
    [NativeTypeName("#define ICTYPE_VIDEO mmioFOURCC('v', 'i', 'd', 'c')")]
    public const uint ICTYPE_VIDEO = ((uint)((byte)('v')) | ((uint)((byte)('i')) << 8) | ((uint)((byte)('d')) << 16) | ((uint)((byte)('c')) << 24));
    [NativeTypeName("#define ICTYPE_AUDIO mmioFOURCC('a', 'u', 'd', 'c')")]
    public const uint ICTYPE_AUDIO = ((uint)((byte)('a')) | ((uint)((byte)('u')) << 8) | ((uint)((byte)('d')) << 16) | ((uint)((byte)('c')) << 24));
    [NativeTypeName("#define FOURCC_RDSP mmioFOURCC('R', 'D', 'S', 'P')")]
    public const uint FOURCC_RDSP = ((uint)((byte)('R')) | ((uint)((byte)('D')) << 8) | ((uint)((byte)('S')) << 16) | ((uint)((byte)('P')) << 24));
}