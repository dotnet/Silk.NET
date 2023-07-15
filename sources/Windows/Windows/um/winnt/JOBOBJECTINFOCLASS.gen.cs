// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS"]/*'/>
public enum JOBOBJECTINFOCLASS
{
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectBasicAccountingInformation"]/*'/>
    JobObjectBasicAccountingInformation = 1,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectBasicLimitInformation"]/*'/>
    JobObjectBasicLimitInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectBasicProcessIdList"]/*'/>
    JobObjectBasicProcessIdList,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectBasicUIRestrictions"]/*'/>
    JobObjectBasicUIRestrictions,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectSecurityLimitInformation"]/*'/>
    JobObjectSecurityLimitInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectEndOfJobTimeInformation"]/*'/>
    JobObjectEndOfJobTimeInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectAssociateCompletionPortInformation"]/*'/>
    JobObjectAssociateCompletionPortInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectBasicAndIoAccountingInformation"]/*'/>
    JobObjectBasicAndIoAccountingInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectExtendedLimitInformation"]/*'/>
    JobObjectExtendedLimitInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectJobSetInformation"]/*'/>
    JobObjectJobSetInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectGroupInformation"]/*'/>
    JobObjectGroupInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectNotificationLimitInformation"]/*'/>
    JobObjectNotificationLimitInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectLimitViolationInformation"]/*'/>
    JobObjectLimitViolationInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectGroupInformationEx"]/*'/>
    JobObjectGroupInformationEx,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectCpuRateControlInformation"]/*'/>
    JobObjectCpuRateControlInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectCompletionFilter"]/*'/>
    JobObjectCompletionFilter,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectCompletionCounter"]/*'/>
    JobObjectCompletionCounter,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved1Information"]/*'/>
    JobObjectReserved1Information = 18,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved2Information"]/*'/>
    JobObjectReserved2Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved3Information"]/*'/>
    JobObjectReserved3Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved4Information"]/*'/>
    JobObjectReserved4Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved5Information"]/*'/>
    JobObjectReserved5Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved6Information"]/*'/>
    JobObjectReserved6Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved7Information"]/*'/>
    JobObjectReserved7Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved8Information"]/*'/>
    JobObjectReserved8Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved9Information"]/*'/>
    JobObjectReserved9Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved10Information"]/*'/>
    JobObjectReserved10Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved11Information"]/*'/>
    JobObjectReserved11Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved12Information"]/*'/>
    JobObjectReserved12Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved13Information"]/*'/>
    JobObjectReserved13Information,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved14Information"]/*'/>
    JobObjectReserved14Information = 31,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectNetRateControlInformation"]/*'/>
    JobObjectNetRateControlInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectNotificationLimitInformation2"]/*'/>
    JobObjectNotificationLimitInformation2,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectLimitViolationInformation2"]/*'/>
    JobObjectLimitViolationInformation2,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectCreateSilo"]/*'/>
    JobObjectCreateSilo,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectSiloBasicInformation"]/*'/>
    JobObjectSiloBasicInformation,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved15Information"]/*'/>
    JobObjectReserved15Information = 37,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved16Information"]/*'/>
    JobObjectReserved16Information = 38,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved17Information"]/*'/>
    JobObjectReserved17Information = 39,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved18Information"]/*'/>
    JobObjectReserved18Information = 40,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved19Information"]/*'/>
    JobObjectReserved19Information = 41,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved20Information"]/*'/>
    JobObjectReserved20Information = 42,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved21Information"]/*'/>
    JobObjectReserved21Information = 43,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved22Information"]/*'/>
    JobObjectReserved22Information = 44,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved23Information"]/*'/>
    JobObjectReserved23Information = 45,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved24Information"]/*'/>
    JobObjectReserved24Information = 46,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved25Information"]/*'/>
    JobObjectReserved25Information = 47,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved26Information"]/*'/>
    JobObjectReserved26Information = 48,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.JobObjectReserved27Information"]/*'/>
    JobObjectReserved27Information = 49,
    /// <include file='JOBOBJECTINFOCLASS.xml' path='doc/member[@name="JOBOBJECTINFOCLASS.MaxJobObjectInfoClass"]/*'/>
    MaxJobObjectInfoClass,
}