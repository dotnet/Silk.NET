// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AppPolicyProcessTerminationMethod.xml' path='doc/member[@name="AppPolicyProcessTerminationMethod"]/*'/>
public enum AppPolicyProcessTerminationMethod
{
    /// <include file='AppPolicyProcessTerminationMethod.xml' path='doc/member[@name="AppPolicyProcessTerminationMethod.AppPolicyProcessTerminationMethod_ExitProcess"]/*'/>
    AppPolicyProcessTerminationMethod_ExitProcess = 0,
    /// <include file='AppPolicyProcessTerminationMethod.xml' path='doc/member[@name="AppPolicyProcessTerminationMethod.AppPolicyProcessTerminationMethod_TerminateProcess"]/*'/>
    AppPolicyProcessTerminationMethod_TerminateProcess = 1,
}