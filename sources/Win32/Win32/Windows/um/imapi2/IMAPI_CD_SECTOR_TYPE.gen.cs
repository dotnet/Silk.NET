// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum IMAPI_CD_SECTOR_TYPE
{
    IMAPI_CD_SECTOR_AUDIO = 0,
    IMAPI_CD_SECTOR_MODE_ZERO = 0x1,
    IMAPI_CD_SECTOR_MODE1 = 0x2,
    IMAPI_CD_SECTOR_MODE2FORM0 = 0x3,
    IMAPI_CD_SECTOR_MODE2FORM1 = 0x4,
    IMAPI_CD_SECTOR_MODE2FORM2 = 0x5,
    IMAPI_CD_SECTOR_MODE1RAW = 0x6,
    IMAPI_CD_SECTOR_MODE2FORM0RAW = 0x7,
    IMAPI_CD_SECTOR_MODE2FORM1RAW = 0x8,
    IMAPI_CD_SECTOR_MODE2FORM2RAW = 0x9,
}
