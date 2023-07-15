// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class ACM
{
    [NativeTypeName("#define ACM_MPEG_LAYER1 (0x0001)")]
    public const int ACM_MPEG_LAYER1 = (0x0001);
    [NativeTypeName("#define ACM_MPEG_LAYER2 (0x0002)")]
    public const int ACM_MPEG_LAYER2 = (0x0002);
    [NativeTypeName("#define ACM_MPEG_LAYER3 (0x0004)")]
    public const int ACM_MPEG_LAYER3 = (0x0004);
    [NativeTypeName("#define ACM_MPEG_STEREO (0x0001)")]
    public const int ACM_MPEG_STEREO = (0x0001);
    [NativeTypeName("#define ACM_MPEG_JOINTSTEREO (0x0002)")]
    public const int ACM_MPEG_JOINTSTEREO = (0x0002);
    [NativeTypeName("#define ACM_MPEG_DUALCHANNEL (0x0004)")]
    public const int ACM_MPEG_DUALCHANNEL = (0x0004);
    [NativeTypeName("#define ACM_MPEG_SINGLECHANNEL (0x0008)")]
    public const int ACM_MPEG_SINGLECHANNEL = (0x0008);
    [NativeTypeName("#define ACM_MPEG_PRIVATEBIT (0x0001)")]
    public const int ACM_MPEG_PRIVATEBIT = (0x0001);
    [NativeTypeName("#define ACM_MPEG_COPYRIGHT (0x0002)")]
    public const int ACM_MPEG_COPYRIGHT = (0x0002);
    [NativeTypeName("#define ACM_MPEG_ORIGINALHOME (0x0004)")]
    public const int ACM_MPEG_ORIGINALHOME = (0x0004);
    [NativeTypeName("#define ACM_MPEG_PROTECTIONBIT (0x0008)")]
    public const int ACM_MPEG_PROTECTIONBIT = (0x0008);
    [NativeTypeName("#define ACM_MPEG_ID_MPEG1 (0x0010)")]
    public const int ACM_MPEG_ID_MPEG1 = (0x0010);
}