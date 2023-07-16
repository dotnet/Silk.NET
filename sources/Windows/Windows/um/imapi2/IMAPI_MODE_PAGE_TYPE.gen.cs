// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAPI_MODE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_TYPE"]/*'/>
public enum IMAPI_MODE_PAGE_TYPE
{
    /// <include file='IMAPI_MODE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_TYPE.IMAPI_MODE_PAGE_TYPE_READ_WRITE_ERROR_RECOVERY"]/*'/>
    IMAPI_MODE_PAGE_TYPE_READ_WRITE_ERROR_RECOVERY = 0x1,
    /// <include file='IMAPI_MODE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_TYPE.IMAPI_MODE_PAGE_TYPE_MRW"]/*'/>
    IMAPI_MODE_PAGE_TYPE_MRW = 0x3,
    /// <include file='IMAPI_MODE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_TYPE.IMAPI_MODE_PAGE_TYPE_WRITE_PARAMETERS"]/*'/>
    IMAPI_MODE_PAGE_TYPE_WRITE_PARAMETERS = 0x5,
    /// <include file='IMAPI_MODE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_TYPE.IMAPI_MODE_PAGE_TYPE_CACHING"]/*'/>
    IMAPI_MODE_PAGE_TYPE_CACHING = 0x8,
    /// <include file='IMAPI_MODE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_TYPE.IMAPI_MODE_PAGE_TYPE_INFORMATIONAL_EXCEPTIONS"]/*'/>
    IMAPI_MODE_PAGE_TYPE_INFORMATIONAL_EXCEPTIONS = 0x1c,
    /// <include file='IMAPI_MODE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_TYPE.IMAPI_MODE_PAGE_TYPE_TIMEOUT_AND_PROTECT"]/*'/>
    IMAPI_MODE_PAGE_TYPE_TIMEOUT_AND_PROTECT = 0x1d,
    /// <include file='IMAPI_MODE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_TYPE.IMAPI_MODE_PAGE_TYPE_POWER_CONDITION"]/*'/>
    IMAPI_MODE_PAGE_TYPE_POWER_CONDITION = 0x1a,
    /// <include file='IMAPI_MODE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_TYPE.IMAPI_MODE_PAGE_TYPE_LEGACY_CAPABILITIES"]/*'/>
    IMAPI_MODE_PAGE_TYPE_LEGACY_CAPABILITIES = 0x2a,
}