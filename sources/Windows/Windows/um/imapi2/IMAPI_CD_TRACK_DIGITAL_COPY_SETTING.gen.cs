// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAPI_CD_TRACK_DIGITAL_COPY_SETTING.xml' path='doc/member[@name="IMAPI_CD_TRACK_DIGITAL_COPY_SETTING"]/*'/>
public enum IMAPI_CD_TRACK_DIGITAL_COPY_SETTING
{
    /// <include file='IMAPI_CD_TRACK_DIGITAL_COPY_SETTING.xml' path='doc/member[@name="IMAPI_CD_TRACK_DIGITAL_COPY_SETTING.IMAPI_CD_TRACK_DIGITAL_COPY_PERMITTED"]/*'/>
    IMAPI_CD_TRACK_DIGITAL_COPY_PERMITTED = 0,
    /// <include file='IMAPI_CD_TRACK_DIGITAL_COPY_SETTING.xml' path='doc/member[@name="IMAPI_CD_TRACK_DIGITAL_COPY_SETTING.IMAPI_CD_TRACK_DIGITAL_COPY_PROHIBITED"]/*'/>
    IMAPI_CD_TRACK_DIGITAL_COPY_PROHIBITED = 0x1,
    /// <include file='IMAPI_CD_TRACK_DIGITAL_COPY_SETTING.xml' path='doc/member[@name="IMAPI_CD_TRACK_DIGITAL_COPY_SETTING.IMAPI_CD_TRACK_DIGITAL_COPY_SCMS"]/*'/>
    IMAPI_CD_TRACK_DIGITAL_COPY_SCMS = 0x2,
}