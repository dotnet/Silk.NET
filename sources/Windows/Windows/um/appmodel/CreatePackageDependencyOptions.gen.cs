// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='CreatePackageDependencyOptions.xml' path='doc/member[@name="CreatePackageDependencyOptions"]/*'/>
[SupportedOSPlatform("windows10.0.22621.0")]
public enum CreatePackageDependencyOptions
{
    /// <include file='CreatePackageDependencyOptions.xml' path='doc/member[@name="CreatePackageDependencyOptions.CreatePackageDependencyOptions_None"]/*'/>
    CreatePackageDependencyOptions_None = 0,
    /// <include file='CreatePackageDependencyOptions.xml' path='doc/member[@name="CreatePackageDependencyOptions.CreatePackageDependencyOptions_DoNotVerifyDependencyResolution"]/*'/>
    CreatePackageDependencyOptions_DoNotVerifyDependencyResolution = 0x00000001,
    /// <include file='CreatePackageDependencyOptions.xml' path='doc/member[@name="CreatePackageDependencyOptions.CreatePackageDependencyOptions_ScopeIsSystem"]/*'/>
    CreatePackageDependencyOptions_ScopeIsSystem = 0x00000002,
}