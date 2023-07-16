// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey"]/*'/>
public enum DISPID_SpeechDataKey
{
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKSetBinaryValue"]/*'/>
    DISPID_SDKSetBinaryValue = 1,
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKGetBinaryValue"]/*'/>
    DISPID_SDKGetBinaryValue = (DISPID_SDKSetBinaryValue + 1),
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKSetStringValue"]/*'/>
    DISPID_SDKSetStringValue = (DISPID_SDKGetBinaryValue + 1),
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKGetStringValue"]/*'/>
    DISPID_SDKGetStringValue = (DISPID_SDKSetStringValue + 1),
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKSetLongValue"]/*'/>
    DISPID_SDKSetLongValue = (DISPID_SDKGetStringValue + 1),
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKGetlongValue"]/*'/>
    DISPID_SDKGetlongValue = (DISPID_SDKSetLongValue + 1),
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKOpenKey"]/*'/>
    DISPID_SDKOpenKey = (DISPID_SDKGetlongValue + 1),
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKCreateKey"]/*'/>
    DISPID_SDKCreateKey = (DISPID_SDKOpenKey + 1),
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKDeleteKey"]/*'/>
    DISPID_SDKDeleteKey = (DISPID_SDKCreateKey + 1),
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKDeleteValue"]/*'/>
    DISPID_SDKDeleteValue = (DISPID_SDKDeleteKey + 1),
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKEnumKeys"]/*'/>
    DISPID_SDKEnumKeys = (DISPID_SDKDeleteValue + 1),
    /// <include file='DISPID_SpeechDataKey.xml' path='doc/member[@name="DISPID_SpeechDataKey.DISPID_SDKEnumValues"]/*'/>
    DISPID_SDKEnumValues = (DISPID_SDKEnumKeys + 1),
}