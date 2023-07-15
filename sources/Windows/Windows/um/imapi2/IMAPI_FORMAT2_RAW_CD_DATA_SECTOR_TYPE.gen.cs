// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE"]/*'/>
public enum IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE
{
    /// <include file='IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE.IMAPI_FORMAT2_RAW_CD_SUBCODE_PQ_ONLY"]/*'/>
    IMAPI_FORMAT2_RAW_CD_SUBCODE_PQ_ONLY = 0x1,
    /// <include file='IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE.IMAPI_FORMAT2_RAW_CD_SUBCODE_IS_COOKED"]/*'/>
    IMAPI_FORMAT2_RAW_CD_SUBCODE_IS_COOKED = 0x2,
    /// <include file='IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE.xml' path='doc/member[@name="IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE.IMAPI_FORMAT2_RAW_CD_SUBCODE_IS_RAW"]/*'/>
    IMAPI_FORMAT2_RAW_CD_SUBCODE_IS_RAW = 0x3,
}