// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FsiFileSystems.xml' path='doc/member[@name="FsiFileSystems"]/*'/>
public enum FsiFileSystems
{
    /// <include file='FsiFileSystems.xml' path='doc/member[@name="FsiFileSystems.FsiFileSystemNone"]/*'/>
    FsiFileSystemNone = 0,
    /// <include file='FsiFileSystems.xml' path='doc/member[@name="FsiFileSystems.FsiFileSystemISO9660"]/*'/>
    FsiFileSystemISO9660 = 1,
    /// <include file='FsiFileSystems.xml' path='doc/member[@name="FsiFileSystems.FsiFileSystemJoliet"]/*'/>
    FsiFileSystemJoliet = 2,
    /// <include file='FsiFileSystems.xml' path='doc/member[@name="FsiFileSystems.FsiFileSystemUDF"]/*'/>
    FsiFileSystemUDF = 4,
    /// <include file='FsiFileSystems.xml' path='doc/member[@name="FsiFileSystems.FsiFileSystemUnknown"]/*'/>
    FsiFileSystemUnknown = 0x40000000,
}