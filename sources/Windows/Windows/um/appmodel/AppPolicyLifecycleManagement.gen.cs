// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AppPolicyLifecycleManagement.xml' path='doc/member[@name="AppPolicyLifecycleManagement"]/*'/>
public enum AppPolicyLifecycleManagement
{
    /// <include file='AppPolicyLifecycleManagement.xml' path='doc/member[@name="AppPolicyLifecycleManagement.AppPolicyLifecycleManagement_Unmanaged"]/*'/>
    AppPolicyLifecycleManagement_Unmanaged = 0,
    /// <include file='AppPolicyLifecycleManagement.xml' path='doc/member[@name="AppPolicyLifecycleManagement.AppPolicyLifecycleManagement_Managed"]/*'/>
    AppPolicyLifecycleManagement_Managed = 1,
}