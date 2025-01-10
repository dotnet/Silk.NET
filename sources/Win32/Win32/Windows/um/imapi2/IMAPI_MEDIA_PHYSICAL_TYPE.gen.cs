// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum IMAPI_MEDIA_PHYSICAL_TYPE
{
    IMAPI_MEDIA_TYPE_UNKNOWN = 0,
    IMAPI_MEDIA_TYPE_CDROM = 0x1,
    IMAPI_MEDIA_TYPE_CDR = 0x2,
    IMAPI_MEDIA_TYPE_CDRW = 0x3,
    IMAPI_MEDIA_TYPE_DVDROM = 0x4,
    IMAPI_MEDIA_TYPE_DVDRAM = 0x5,
    IMAPI_MEDIA_TYPE_DVDPLUSR = 0x6,
    IMAPI_MEDIA_TYPE_DVDPLUSRW = 0x7,
    IMAPI_MEDIA_TYPE_DVDPLUSR_DUALLAYER = 0x8,
    IMAPI_MEDIA_TYPE_DVDDASHR = 0x9,
    IMAPI_MEDIA_TYPE_DVDDASHRW = 0xa,
    IMAPI_MEDIA_TYPE_DVDDASHR_DUALLAYER = 0xb,
    IMAPI_MEDIA_TYPE_DISK = 0xc,
    IMAPI_MEDIA_TYPE_DVDPLUSRW_DUALLAYER = 0xd,
    IMAPI_MEDIA_TYPE_HDDVDROM = 0xe,
    IMAPI_MEDIA_TYPE_HDDVDR = 0xf,
    IMAPI_MEDIA_TYPE_HDDVDRAM = 0x10,
    IMAPI_MEDIA_TYPE_BDROM = 0x11,
    IMAPI_MEDIA_TYPE_BDR = 0x12,
    IMAPI_MEDIA_TYPE_BDRE = 0x13,
    IMAPI_MEDIA_TYPE_MAX = 0x13,
}
