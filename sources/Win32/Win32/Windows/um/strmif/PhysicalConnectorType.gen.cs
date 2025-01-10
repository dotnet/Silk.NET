// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PhysicalConnectorType
{
    PhysConn_Video_Tuner = 1,
    PhysConn_Video_Composite = (PhysConn_Video_Tuner + 1),
    PhysConn_Video_SVideo = (PhysConn_Video_Composite + 1),
    PhysConn_Video_RGB = (PhysConn_Video_SVideo + 1),
    PhysConn_Video_YRYBY = (PhysConn_Video_RGB + 1),
    PhysConn_Video_SerialDigital = (PhysConn_Video_YRYBY + 1),
    PhysConn_Video_ParallelDigital = (PhysConn_Video_SerialDigital + 1),
    PhysConn_Video_SCSI = (PhysConn_Video_ParallelDigital + 1),
    PhysConn_Video_AUX = (PhysConn_Video_SCSI + 1),
    PhysConn_Video_1394 = (PhysConn_Video_AUX + 1),
    PhysConn_Video_USB = (PhysConn_Video_1394 + 1),
    PhysConn_Video_VideoDecoder = (PhysConn_Video_USB + 1),
    PhysConn_Video_VideoEncoder = (PhysConn_Video_VideoDecoder + 1),
    PhysConn_Video_SCART = (PhysConn_Video_VideoEncoder + 1),
    PhysConn_Video_Black = (PhysConn_Video_SCART + 1),
    PhysConn_Audio_Tuner = 0x1000,
    PhysConn_Audio_Line = (PhysConn_Audio_Tuner + 1),
    PhysConn_Audio_Mic = (PhysConn_Audio_Line + 1),
    PhysConn_Audio_AESDigital = (PhysConn_Audio_Mic + 1),
    PhysConn_Audio_SPDIFDigital = (PhysConn_Audio_AESDigital + 1),
    PhysConn_Audio_SCSI = (PhysConn_Audio_SPDIFDigital + 1),
    PhysConn_Audio_AUX = (PhysConn_Audio_SCSI + 1),
    PhysConn_Audio_1394 = (PhysConn_Audio_AUX + 1),
    PhysConn_Audio_USB = (PhysConn_Audio_1394 + 1),
    PhysConn_Audio_AudioDecoder = (PhysConn_Audio_USB + 1),
}
