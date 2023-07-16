// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSV1_0_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="MSV1_0_LOGON_SUBMIT_TYPE"]/*'/>
public enum MSV1_0_LOGON_SUBMIT_TYPE
{
    /// <include file='MSV1_0_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="MSV1_0_LOGON_SUBMIT_TYPE.MsV1_0InteractiveLogon"]/*'/>
    MsV1_0InteractiveLogon = 2,
    /// <include file='MSV1_0_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="MSV1_0_LOGON_SUBMIT_TYPE.MsV1_0Lm20Logon"]/*'/>
    MsV1_0Lm20Logon,
    /// <include file='MSV1_0_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="MSV1_0_LOGON_SUBMIT_TYPE.MsV1_0NetworkLogon"]/*'/>
    MsV1_0NetworkLogon,
    /// <include file='MSV1_0_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="MSV1_0_LOGON_SUBMIT_TYPE.MsV1_0SubAuthLogon"]/*'/>
    MsV1_0SubAuthLogon,
    /// <include file='MSV1_0_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="MSV1_0_LOGON_SUBMIT_TYPE.MsV1_0WorkstationUnlockLogon"]/*'/>
    MsV1_0WorkstationUnlockLogon = 7,
    /// <include file='MSV1_0_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="MSV1_0_LOGON_SUBMIT_TYPE.MsV1_0S4ULogon"]/*'/>
    MsV1_0S4ULogon = 12,
    /// <include file='MSV1_0_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="MSV1_0_LOGON_SUBMIT_TYPE.MsV1_0VirtualLogon"]/*'/>
    MsV1_0VirtualLogon = 82,
    /// <include file='MSV1_0_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="MSV1_0_LOGON_SUBMIT_TYPE.MsV1_0NoElevationLogon"]/*'/>
    MsV1_0NoElevationLogon = 83,
    /// <include file='MSV1_0_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="MSV1_0_LOGON_SUBMIT_TYPE.MsV1_0LuidLogon"]/*'/>
    MsV1_0LuidLogon = 84,
}