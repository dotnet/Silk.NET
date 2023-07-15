// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE"]/*'/>
public enum KERB_LOGON_SUBMIT_TYPE
{
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbInteractiveLogon"]/*'/>
    KerbInteractiveLogon = 2,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbSmartCardLogon"]/*'/>
    KerbSmartCardLogon = 6,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbWorkstationUnlockLogon"]/*'/>
    KerbWorkstationUnlockLogon = 7,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbSmartCardUnlockLogon"]/*'/>
    KerbSmartCardUnlockLogon = 8,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbProxyLogon"]/*'/>
    KerbProxyLogon = 9,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbTicketLogon"]/*'/>
    KerbTicketLogon = 10,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbTicketUnlockLogon"]/*'/>
    KerbTicketUnlockLogon = 11,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbS4ULogon"]/*'/>
    KerbS4ULogon = 12,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbCertificateLogon"]/*'/>
    KerbCertificateLogon = 13,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbCertificateS4ULogon"]/*'/>
    KerbCertificateS4ULogon = 14,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbCertificateUnlockLogon"]/*'/>
    KerbCertificateUnlockLogon = 15,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbNoElevationLogon"]/*'/>
    KerbNoElevationLogon = 83,
    /// <include file='KERB_LOGON_SUBMIT_TYPE.xml' path='doc/member[@name="KERB_LOGON_SUBMIT_TYPE.KerbLuidLogon"]/*'/>
    KerbLuidLogon = 84,
}