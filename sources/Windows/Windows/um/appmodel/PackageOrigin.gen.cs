// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PackageOrigin.xml' path='doc/member[@name="PackageOrigin"]/*'/>
[SupportedOSPlatform("windows6.3")]
public enum PackageOrigin
{
    /// <include file='PackageOrigin.xml' path='doc/member[@name="PackageOrigin.PackageOrigin_Unknown"]/*'/>
    PackageOrigin_Unknown = 0,
    /// <include file='PackageOrigin.xml' path='doc/member[@name="PackageOrigin.PackageOrigin_Unsigned"]/*'/>
    PackageOrigin_Unsigned = 1,
    /// <include file='PackageOrigin.xml' path='doc/member[@name="PackageOrigin.PackageOrigin_Inbox"]/*'/>
    PackageOrigin_Inbox = 2,
    /// <include file='PackageOrigin.xml' path='doc/member[@name="PackageOrigin.PackageOrigin_Store"]/*'/>
    PackageOrigin_Store = 3,
    /// <include file='PackageOrigin.xml' path='doc/member[@name="PackageOrigin.PackageOrigin_DeveloperUnsigned"]/*'/>
    PackageOrigin_DeveloperUnsigned = 4,
    /// <include file='PackageOrigin.xml' path='doc/member[@name="PackageOrigin.PackageOrigin_DeveloperSigned"]/*'/>
    PackageOrigin_DeveloperSigned = 5,
    /// <include file='PackageOrigin.xml' path='doc/member[@name="PackageOrigin.PackageOrigin_LineOfBusiness"]/*'/>
    PackageOrigin_LineOfBusiness = 6,
}