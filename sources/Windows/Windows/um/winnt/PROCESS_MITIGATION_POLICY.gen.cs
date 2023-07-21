// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum PROCESS_MITIGATION_POLICY
{
    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessDEPPolicy"]/*' />
    ProcessDEPPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessASLRPolicy"]/*' />
    ProcessASLRPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessDynamicCodePolicy"]/*' />
    ProcessDynamicCodePolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessStrictHandleCheckPolicy"]/*' />
    ProcessStrictHandleCheckPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessSystemCallDisablePolicy"]/*' />
    ProcessSystemCallDisablePolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessMitigationOptionsMask"]/*' />
    ProcessMitigationOptionsMask,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessExtensionPointDisablePolicy"]/*' />
    ProcessExtensionPointDisablePolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessControlFlowGuardPolicy"]/*' />
    ProcessControlFlowGuardPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessSignaturePolicy"]/*' />
    ProcessSignaturePolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessFontDisablePolicy"]/*' />
    ProcessFontDisablePolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessImageLoadPolicy"]/*' />
    ProcessImageLoadPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessSystemCallFilterPolicy"]/*' />
    ProcessSystemCallFilterPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessPayloadRestrictionPolicy"]/*' />
    ProcessPayloadRestrictionPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessChildProcessPolicy"]/*' />
    ProcessChildProcessPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessSideChannelIsolationPolicy"]/*' />
    ProcessSideChannelIsolationPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessUserShadowStackPolicy"]/*' />
    ProcessUserShadowStackPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessRedirectionTrustPolicy"]/*' />
    ProcessRedirectionTrustPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessUserPointerAuthPolicy"]/*' />
    ProcessUserPointerAuthPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessSEHOPPolicy"]/*' />
    ProcessSEHOPPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessActivationContextTrustPolicy"]/*' />
    ProcessActivationContextTrustPolicy,

    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.MaxProcessMitigationPolicy"]/*' />
    MaxProcessMitigationPolicy,
}
