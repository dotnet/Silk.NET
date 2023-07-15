// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION"]/*'/>
public enum QUERYOPTION
{
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_EXPIRATION_DATE"]/*'/>
    QUERY_EXPIRATION_DATE = 1,
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_TIME_OF_LAST_CHANGE"]/*'/>
    QUERY_TIME_OF_LAST_CHANGE = (QUERY_EXPIRATION_DATE + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_CONTENT_ENCODING"]/*'/>
    QUERY_CONTENT_ENCODING = (QUERY_TIME_OF_LAST_CHANGE + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_CONTENT_TYPE"]/*'/>
    QUERY_CONTENT_TYPE = (QUERY_CONTENT_ENCODING + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_REFRESH"]/*'/>
    QUERY_REFRESH = (QUERY_CONTENT_TYPE + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_RECOMBINE"]/*'/>
    QUERY_RECOMBINE = (QUERY_REFRESH + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_CAN_NAVIGATE"]/*'/>
    QUERY_CAN_NAVIGATE = (QUERY_RECOMBINE + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_USES_NETWORK"]/*'/>
    QUERY_USES_NETWORK = (QUERY_CAN_NAVIGATE + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_IS_CACHED"]/*'/>
    QUERY_IS_CACHED = (QUERY_USES_NETWORK + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_IS_INSTALLEDENTRY"]/*'/>
    QUERY_IS_INSTALLEDENTRY = (QUERY_IS_CACHED + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_IS_CACHED_OR_MAPPED"]/*'/>
    QUERY_IS_CACHED_OR_MAPPED = (QUERY_IS_INSTALLEDENTRY + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_USES_CACHE"]/*'/>
    QUERY_USES_CACHE = (QUERY_IS_CACHED_OR_MAPPED + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_IS_SECURE"]/*'/>
    QUERY_IS_SECURE = (QUERY_USES_CACHE + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_IS_SAFE"]/*'/>
    QUERY_IS_SAFE = (QUERY_IS_SECURE + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_USES_HISTORYFOLDER"]/*'/>
    QUERY_USES_HISTORYFOLDER = (QUERY_IS_SAFE + 1),
    /// <include file='QUERYOPTION.xml' path='doc/member[@name="QUERYOPTION.QUERY_IS_CACHED_AND_USABLE_OFFLINE"]/*'/>
    QUERY_IS_CACHED_AND_USABLE_OFFLINE = (QUERY_USES_HISTORYFOLDER + 1),
}