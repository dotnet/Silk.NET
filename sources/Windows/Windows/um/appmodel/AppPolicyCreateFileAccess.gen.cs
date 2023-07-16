// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AppPolicyCreateFileAccess.xml' path='doc/member[@name="AppPolicyCreateFileAccess"]/*'/>
public enum AppPolicyCreateFileAccess
{
    /// <include file='AppPolicyCreateFileAccess.xml' path='doc/member[@name="AppPolicyCreateFileAccess.AppPolicyCreateFileAccess_Full"]/*'/>
    AppPolicyCreateFileAccess_Full = 0,
    /// <include file='AppPolicyCreateFileAccess.xml' path='doc/member[@name="AppPolicyCreateFileAccess.AppPolicyCreateFileAccess_Limited"]/*'/>
    AppPolicyCreateFileAccess_Limited = 1,
}