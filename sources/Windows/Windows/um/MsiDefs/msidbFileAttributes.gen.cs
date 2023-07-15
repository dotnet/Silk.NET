// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes"]/*'/>
public enum msidbFileAttributes
{
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesReadOnly"]/*'/>
    msidbFileAttributesReadOnly = 0x00000001,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesHidden"]/*'/>
    msidbFileAttributesHidden = 0x00000002,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesSystem"]/*'/>
    msidbFileAttributesSystem = 0x00000004,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesReserved0"]/*'/>
    msidbFileAttributesReserved0 = 0x00000008,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesIsolatedComp"]/*'/>
    msidbFileAttributesIsolatedComp = 0x00000010,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesReserved1"]/*'/>
    msidbFileAttributesReserved1 = 0x00000040,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesReserved2"]/*'/>
    msidbFileAttributesReserved2 = 0x00000080,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesReserved3"]/*'/>
    msidbFileAttributesReserved3 = 0x00000100,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesVital"]/*'/>
    msidbFileAttributesVital = 0x00000200,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesChecksum"]/*'/>
    msidbFileAttributesChecksum = 0x00000400,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesPatchAdded"]/*'/>
    msidbFileAttributesPatchAdded = 0x00001000,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesNoncompressed"]/*'/>
    msidbFileAttributesNoncompressed = 0x00002000,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesCompressed"]/*'/>
    msidbFileAttributesCompressed = 0x00004000,
    /// <include file='msidbFileAttributes.xml' path='doc/member[@name="msidbFileAttributes.msidbFileAttributesReserved4"]/*'/>
    msidbFileAttributesReserved4 = 0x00008000,
}