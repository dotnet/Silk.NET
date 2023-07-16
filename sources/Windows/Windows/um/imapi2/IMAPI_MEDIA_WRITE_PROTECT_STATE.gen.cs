// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAPI_MEDIA_WRITE_PROTECT_STATE.xml' path='doc/member[@name="IMAPI_MEDIA_WRITE_PROTECT_STATE"]/*'/>
public enum IMAPI_MEDIA_WRITE_PROTECT_STATE
{
    /// <include file='IMAPI_MEDIA_WRITE_PROTECT_STATE.xml' path='doc/member[@name="IMAPI_MEDIA_WRITE_PROTECT_STATE.IMAPI_WRITEPROTECTED_UNTIL_POWERDOWN"]/*'/>
    IMAPI_WRITEPROTECTED_UNTIL_POWERDOWN = 0x1,
    /// <include file='IMAPI_MEDIA_WRITE_PROTECT_STATE.xml' path='doc/member[@name="IMAPI_MEDIA_WRITE_PROTECT_STATE.IMAPI_WRITEPROTECTED_BY_CARTRIDGE"]/*'/>
    IMAPI_WRITEPROTECTED_BY_CARTRIDGE = 0x2,
    /// <include file='IMAPI_MEDIA_WRITE_PROTECT_STATE.xml' path='doc/member[@name="IMAPI_MEDIA_WRITE_PROTECT_STATE.IMAPI_WRITEPROTECTED_BY_MEDIA_SPECIFIC_REASON"]/*'/>
    IMAPI_WRITEPROTECTED_BY_MEDIA_SPECIFIC_REASON = 0x4,
    /// <include file='IMAPI_MEDIA_WRITE_PROTECT_STATE.xml' path='doc/member[@name="IMAPI_MEDIA_WRITE_PROTECT_STATE.IMAPI_WRITEPROTECTED_BY_SOFTWARE_WRITE_PROTECT"]/*'/>
    IMAPI_WRITEPROTECTED_BY_SOFTWARE_WRITE_PROTECT = 0x8,
    /// <include file='IMAPI_MEDIA_WRITE_PROTECT_STATE.xml' path='doc/member[@name="IMAPI_MEDIA_WRITE_PROTECT_STATE.IMAPI_WRITEPROTECTED_BY_DISC_CONTROL_BLOCK"]/*'/>
    IMAPI_WRITEPROTECTED_BY_DISC_CONTROL_BLOCK = 0x10,
    /// <include file='IMAPI_MEDIA_WRITE_PROTECT_STATE.xml' path='doc/member[@name="IMAPI_MEDIA_WRITE_PROTECT_STATE.IMAPI_WRITEPROTECTED_READ_ONLY_MEDIA"]/*'/>
    IMAPI_WRITEPROTECTED_READ_ONLY_MEDIA = 0x4000,
}