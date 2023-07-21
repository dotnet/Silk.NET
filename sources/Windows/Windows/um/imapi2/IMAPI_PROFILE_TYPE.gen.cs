// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE"]/*' />
public enum IMAPI_PROFILE_TYPE
{
    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_INVALID"]/*' />
    IMAPI_PROFILE_TYPE_INVALID = 0,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_NON_REMOVABLE_DISK"]/*' />
    IMAPI_PROFILE_TYPE_NON_REMOVABLE_DISK = 0x1,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_REMOVABLE_DISK"]/*' />
    IMAPI_PROFILE_TYPE_REMOVABLE_DISK = 0x2,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_MO_ERASABLE"]/*' />
    IMAPI_PROFILE_TYPE_MO_ERASABLE = 0x3,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_MO_WRITE_ONCE"]/*' />
    IMAPI_PROFILE_TYPE_MO_WRITE_ONCE = 0x4,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_AS_MO"]/*' />
    IMAPI_PROFILE_TYPE_AS_MO = 0x5,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_CDROM"]/*' />
    IMAPI_PROFILE_TYPE_CDROM = 0x8,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_CD_RECORDABLE"]/*' />
    IMAPI_PROFILE_TYPE_CD_RECORDABLE = 0x9,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_CD_REWRITABLE"]/*' />
    IMAPI_PROFILE_TYPE_CD_REWRITABLE = 0xa,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVDROM"]/*' />
    IMAPI_PROFILE_TYPE_DVDROM = 0x10,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_RECORDABLE"]/*' />
    IMAPI_PROFILE_TYPE_DVD_DASH_RECORDABLE = 0x11,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_RAM"]/*' />
    IMAPI_PROFILE_TYPE_DVD_RAM = 0x12,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_REWRITABLE"]/*' />
    IMAPI_PROFILE_TYPE_DVD_DASH_REWRITABLE = 0x13,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_RW_SEQUENTIAL"]/*' />
    IMAPI_PROFILE_TYPE_DVD_DASH_RW_SEQUENTIAL = 0x14,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_R_DUAL_SEQUENTIAL"]/*' />
    IMAPI_PROFILE_TYPE_DVD_DASH_R_DUAL_SEQUENTIAL = 0x15,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_R_DUAL_LAYER_JUMP"]/*' />
    IMAPI_PROFILE_TYPE_DVD_DASH_R_DUAL_LAYER_JUMP = 0x16,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_RW"]/*' />
    IMAPI_PROFILE_TYPE_DVD_PLUS_RW = 0x1a,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_R"]/*' />
    IMAPI_PROFILE_TYPE_DVD_PLUS_R = 0x1b,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DDCDROM"]/*' />
    IMAPI_PROFILE_TYPE_DDCDROM = 0x20,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DDCD_RECORDABLE"]/*' />
    IMAPI_PROFILE_TYPE_DDCD_RECORDABLE = 0x21,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DDCD_REWRITABLE"]/*' />
    IMAPI_PROFILE_TYPE_DDCD_REWRITABLE = 0x22,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_RW_DUAL"]/*' />
    IMAPI_PROFILE_TYPE_DVD_PLUS_RW_DUAL = 0x2a,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_R_DUAL"]/*' />
    IMAPI_PROFILE_TYPE_DVD_PLUS_R_DUAL = 0x2b,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_ROM"]/*' />
    IMAPI_PROFILE_TYPE_BD_ROM = 0x40,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_R_SEQUENTIAL"]/*' />
    IMAPI_PROFILE_TYPE_BD_R_SEQUENTIAL = 0x41,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_R_RANDOM_RECORDING"]/*' />
    IMAPI_PROFILE_TYPE_BD_R_RANDOM_RECORDING = 0x42,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_REWRITABLE"]/*' />
    IMAPI_PROFILE_TYPE_BD_REWRITABLE = 0x43,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_HD_DVD_ROM"]/*' />
    IMAPI_PROFILE_TYPE_HD_DVD_ROM = 0x50,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_HD_DVD_RECORDABLE"]/*' />
    IMAPI_PROFILE_TYPE_HD_DVD_RECORDABLE = 0x51,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_HD_DVD_RAM"]/*' />
    IMAPI_PROFILE_TYPE_HD_DVD_RAM = 0x52,

    /// <include file='IMAPI_PROFILE_TYPE.xml' path='doc/member[@name="IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_NON_STANDARD"]/*' />
    IMAPI_PROFILE_TYPE_NON_STANDARD = 0xffff,
}
