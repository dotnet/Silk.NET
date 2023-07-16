// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM"]/*'/>
public enum PROC_THREAD_ATTRIBUTE_NUM
{
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeParentProcess"]/*'/>
    ProcThreadAttributeParentProcess = 0,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeHandleList"]/*'/>
    ProcThreadAttributeHandleList = 2,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeGroupAffinity"]/*'/>
    ProcThreadAttributeGroupAffinity = 3,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributePreferredNode"]/*'/>
    ProcThreadAttributePreferredNode = 4,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeIdealProcessor"]/*'/>
    ProcThreadAttributeIdealProcessor = 5,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeUmsThread"]/*'/>
    ProcThreadAttributeUmsThread = 6,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeMitigationPolicy"]/*'/>
    ProcThreadAttributeMitigationPolicy = 7,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeSecurityCapabilities"]/*'/>
    ProcThreadAttributeSecurityCapabilities = 9,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeProtectionLevel"]/*'/>
    ProcThreadAttributeProtectionLevel = 11,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeJobList"]/*'/>
    ProcThreadAttributeJobList = 13,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeChildProcessPolicy"]/*'/>
    ProcThreadAttributeChildProcessPolicy = 14,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeAllApplicationPackagesPolicy"]/*'/>
    ProcThreadAttributeAllApplicationPackagesPolicy = 15,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeWin32kFilter"]/*'/>
    ProcThreadAttributeWin32kFilter = 16,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeSafeOpenPromptOriginClaim"]/*'/>
    ProcThreadAttributeSafeOpenPromptOriginClaim = 17,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeDesktopAppPolicy"]/*'/>
    ProcThreadAttributeDesktopAppPolicy = 18,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributePseudoConsole"]/*'/>
    ProcThreadAttributePseudoConsole = 22,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeMitigationAuditPolicy"]/*'/>
    ProcThreadAttributeMitigationAuditPolicy = 24,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeMachineType"]/*'/>
    ProcThreadAttributeMachineType = 25,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeComponentFilter"]/*'/>
    ProcThreadAttributeComponentFilter = 26,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeEnableOptionalXStateFeatures"]/*'/>
    ProcThreadAttributeEnableOptionalXStateFeatures = 27,
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeTrustedApp"]/*'/>
    ProcThreadAttributeTrustedApp = 29,
}