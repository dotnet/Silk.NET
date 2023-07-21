// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE"]/*' />
public enum IMAPI_CD_SECTOR_TYPE
{
    /// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE.IMAPI_CD_SECTOR_AUDIO"]/*' />
    IMAPI_CD_SECTOR_AUDIO = 0,

    /// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE.IMAPI_CD_SECTOR_MODE_ZERO"]/*' />
    IMAPI_CD_SECTOR_MODE_ZERO = 0x1,

    /// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE.IMAPI_CD_SECTOR_MODE1"]/*' />
    IMAPI_CD_SECTOR_MODE1 = 0x2,

    /// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE.IMAPI_CD_SECTOR_MODE2FORM0"]/*' />
    IMAPI_CD_SECTOR_MODE2FORM0 = 0x3,

    /// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE.IMAPI_CD_SECTOR_MODE2FORM1"]/*' />
    IMAPI_CD_SECTOR_MODE2FORM1 = 0x4,

    /// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE.IMAPI_CD_SECTOR_MODE2FORM2"]/*' />
    IMAPI_CD_SECTOR_MODE2FORM2 = 0x5,

    /// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE.IMAPI_CD_SECTOR_MODE1RAW"]/*' />
    IMAPI_CD_SECTOR_MODE1RAW = 0x6,

    /// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE.IMAPI_CD_SECTOR_MODE2FORM0RAW"]/*' />
    IMAPI_CD_SECTOR_MODE2FORM0RAW = 0x7,

    /// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE.IMAPI_CD_SECTOR_MODE2FORM1RAW"]/*' />
    IMAPI_CD_SECTOR_MODE2FORM1RAW = 0x8,

    /// <include file='IMAPI_CD_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_CD_SECTOR_TYPE.IMAPI_CD_SECTOR_MODE2FORM2RAW"]/*' />
    IMAPI_CD_SECTOR_MODE2FORM2RAW = 0x9,
}
