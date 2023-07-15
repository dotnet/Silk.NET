// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PackagePathType.xml' path='doc/member[@name="PackagePathType"]/*'/>
[SupportedOSPlatform("windows10.0")]
public enum PackagePathType
{
    /// <include file='PackagePathType.xml' path='doc/member[@name="PackagePathType.PackagePathType_Install"]/*'/>
    PackagePathType_Install = 0,
    /// <include file='PackagePathType.xml' path='doc/member[@name="PackagePathType.PackagePathType_Mutable"]/*'/>
    PackagePathType_Mutable = 1,
    /// <include file='PackagePathType.xml' path='doc/member[@name="PackagePathType.PackagePathType_Effective"]/*'/>
    PackagePathType_Effective = 2,
    /// <include file='PackagePathType.xml' path='doc/member[@name="PackagePathType.PackagePathType_MachineExternal"]/*'/>
    PackagePathType_MachineExternal = 3,
    /// <include file='PackagePathType.xml' path='doc/member[@name="PackagePathType.PackagePathType_UserExternal"]/*'/>
    PackagePathType_UserExternal = 4,
    /// <include file='PackagePathType.xml' path='doc/member[@name="PackagePathType.PackagePathType_EffectiveExternal"]/*'/>
    PackagePathType_EffectiveExternal = 5,
}