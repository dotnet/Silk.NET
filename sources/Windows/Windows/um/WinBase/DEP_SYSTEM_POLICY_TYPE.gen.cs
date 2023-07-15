// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DEP_SYSTEM_POLICY_TYPE.xml' path='doc/member[@name="DEP_SYSTEM_POLICY_TYPE"]/*'/>
public enum DEP_SYSTEM_POLICY_TYPE
{
    /// <include file='DEP_SYSTEM_POLICY_TYPE.xml' path='doc/member[@name="DEP_SYSTEM_POLICY_TYPE.DEPPolicyAlwaysOff"]/*'/>
    DEPPolicyAlwaysOff = 0,
    /// <include file='DEP_SYSTEM_POLICY_TYPE.xml' path='doc/member[@name="DEP_SYSTEM_POLICY_TYPE.DEPPolicyAlwaysOn"]/*'/>
    DEPPolicyAlwaysOn,
    /// <include file='DEP_SYSTEM_POLICY_TYPE.xml' path='doc/member[@name="DEP_SYSTEM_POLICY_TYPE.DEPPolicyOptIn"]/*'/>
    DEPPolicyOptIn,
    /// <include file='DEP_SYSTEM_POLICY_TYPE.xml' path='doc/member[@name="DEP_SYSTEM_POLICY_TYPE.DEPPolicyOptOut"]/*'/>
    DEPPolicyOptOut,
    /// <include file='DEP_SYSTEM_POLICY_TYPE.xml' path='doc/member[@name="DEP_SYSTEM_POLICY_TYPE.DEPTotalPolicyCount"]/*'/>
    DEPTotalPolicyCount,
}