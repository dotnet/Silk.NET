// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE"]/*'/>
public enum SE_ADT_PARAMETER_TYPE
{
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeNone"]/*'/>
    SeAdtParmTypeNone = 0,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeString"]/*'/>
    SeAdtParmTypeString,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeFileSpec"]/*'/>
    SeAdtParmTypeFileSpec,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeUlong"]/*'/>
    SeAdtParmTypeUlong,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeSid"]/*'/>
    SeAdtParmTypeSid,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeLogonId"]/*'/>
    SeAdtParmTypeLogonId,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeNoLogonId"]/*'/>
    SeAdtParmTypeNoLogonId,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeAccessMask"]/*'/>
    SeAdtParmTypeAccessMask,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypePrivs"]/*'/>
    SeAdtParmTypePrivs,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeObjectTypes"]/*'/>
    SeAdtParmTypeObjectTypes,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeHexUlong"]/*'/>
    SeAdtParmTypeHexUlong,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypePtr"]/*'/>
    SeAdtParmTypePtr,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeTime"]/*'/>
    SeAdtParmTypeTime,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeGuid"]/*'/>
    SeAdtParmTypeGuid,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeLuid"]/*'/>
    SeAdtParmTypeLuid,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeHexInt64"]/*'/>
    SeAdtParmTypeHexInt64,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeStringList"]/*'/>
    SeAdtParmTypeStringList,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeSidList"]/*'/>
    SeAdtParmTypeSidList,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeDuration"]/*'/>
    SeAdtParmTypeDuration,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeUserAccountControl"]/*'/>
    SeAdtParmTypeUserAccountControl,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeNoUac"]/*'/>
    SeAdtParmTypeNoUac,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeMessage"]/*'/>
    SeAdtParmTypeMessage,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeDateTime"]/*'/>
    SeAdtParmTypeDateTime,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeSockAddr"]/*'/>
    SeAdtParmTypeSockAddr,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeSD"]/*'/>
    SeAdtParmTypeSD,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeLogonHours"]/*'/>
    SeAdtParmTypeLogonHours,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeLogonIdNoSid"]/*'/>
    SeAdtParmTypeLogonIdNoSid,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeUlongNoConv"]/*'/>
    SeAdtParmTypeUlongNoConv,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeSockAddrNoPort"]/*'/>
    SeAdtParmTypeSockAddrNoPort,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeAccessReason"]/*'/>
    SeAdtParmTypeAccessReason,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeStagingReason"]/*'/>
    SeAdtParmTypeStagingReason,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeResourceAttribute"]/*'/>
    SeAdtParmTypeResourceAttribute,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeClaims"]/*'/>
    SeAdtParmTypeClaims,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeLogonIdAsSid"]/*'/>
    SeAdtParmTypeLogonIdAsSid,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeMultiSzString"]/*'/>
    SeAdtParmTypeMultiSzString,
    /// <include file='SE_ADT_PARAMETER_TYPE.xml' path='doc/member[@name="SE_ADT_PARAMETER_TYPE.SeAdtParmTypeLogonIdEx"]/*'/>
    SeAdtParmTypeLogonIdEx,
}