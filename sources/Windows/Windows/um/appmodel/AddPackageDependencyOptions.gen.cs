// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='AddPackageDependencyOptions.xml' path='doc/member[@name="AddPackageDependencyOptions"]/*'/>
[SupportedOSPlatform("windows10.0.22621.0")]
public enum AddPackageDependencyOptions
{
    /// <include file='AddPackageDependencyOptions.xml' path='doc/member[@name="AddPackageDependencyOptions.AddPackageDependencyOptions_None"]/*'/>
    AddPackageDependencyOptions_None = 0,
    /// <include file='AddPackageDependencyOptions.xml' path='doc/member[@name="AddPackageDependencyOptions.AddPackageDependencyOptions_PrependIfRankCollision"]/*'/>
    AddPackageDependencyOptions_PrependIfRankCollision = 0x00000001,
}