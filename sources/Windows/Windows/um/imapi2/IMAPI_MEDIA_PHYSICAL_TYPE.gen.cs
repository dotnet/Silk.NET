// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE"]/*' />
public enum IMAPI_MEDIA_PHYSICAL_TYPE
{
    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_UNKNOWN"]/*' />
    IMAPI_MEDIA_TYPE_UNKNOWN = 0,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_CDROM"]/*' />
    IMAPI_MEDIA_TYPE_CDROM = 0x1,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_CDR"]/*' />
    IMAPI_MEDIA_TYPE_CDR = 0x2,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_CDRW"]/*' />
    IMAPI_MEDIA_TYPE_CDRW = 0x3,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDROM"]/*' />
    IMAPI_MEDIA_TYPE_DVDROM = 0x4,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDRAM"]/*' />
    IMAPI_MEDIA_TYPE_DVDRAM = 0x5,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSR"]/*' />
    IMAPI_MEDIA_TYPE_DVDPLUSR = 0x6,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSRW"]/*' />
    IMAPI_MEDIA_TYPE_DVDPLUSRW = 0x7,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSR_DUALLAYER"]/*' />
    IMAPI_MEDIA_TYPE_DVDPLUSR_DUALLAYER = 0x8,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDDASHR"]/*' />
    IMAPI_MEDIA_TYPE_DVDDASHR = 0x9,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDDASHRW"]/*' />
    IMAPI_MEDIA_TYPE_DVDDASHRW = 0xa,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDDASHR_DUALLAYER"]/*' />
    IMAPI_MEDIA_TYPE_DVDDASHR_DUALLAYER = 0xb,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DISK"]/*' />
    IMAPI_MEDIA_TYPE_DISK = 0xc,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSRW_DUALLAYER"]/*' />
    IMAPI_MEDIA_TYPE_DVDPLUSRW_DUALLAYER = 0xd,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_HDDVDROM"]/*' />
    IMAPI_MEDIA_TYPE_HDDVDROM = 0xe,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_HDDVDR"]/*' />
    IMAPI_MEDIA_TYPE_HDDVDR = 0xf,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_HDDVDRAM"]/*' />
    IMAPI_MEDIA_TYPE_HDDVDRAM = 0x10,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_BDROM"]/*' />
    IMAPI_MEDIA_TYPE_BDROM = 0x11,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_BDR"]/*' />
    IMAPI_MEDIA_TYPE_BDR = 0x12,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_BDRE"]/*' />
    IMAPI_MEDIA_TYPE_BDRE = 0x13,

    /// <include file='IMAPI_MEDIA_PHYSICAL_TYPE.xml' path='doc/member[@name="IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_MAX"]/*' />
    IMAPI_MEDIA_TYPE_MAX = 0x13,
}
