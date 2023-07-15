// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='msidbSumInfoSourceType.xml' path='doc/member[@name="msidbSumInfoSourceType"]/*'/>
public enum msidbSumInfoSourceType
{
    /// <include file='msidbSumInfoSourceType.xml' path='doc/member[@name="msidbSumInfoSourceType.msidbSumInfoSourceTypeSFN"]/*'/>
    msidbSumInfoSourceTypeSFN = 0x00000001,
    /// <include file='msidbSumInfoSourceType.xml' path='doc/member[@name="msidbSumInfoSourceType.msidbSumInfoSourceTypeCompressed"]/*'/>
    msidbSumInfoSourceTypeCompressed = 0x00000002,
    /// <include file='msidbSumInfoSourceType.xml' path='doc/member[@name="msidbSumInfoSourceType.msidbSumInfoSourceTypeAdminImage"]/*'/>
    msidbSumInfoSourceTypeAdminImage = 0x00000004,
    /// <include file='msidbSumInfoSourceType.xml' path='doc/member[@name="msidbSumInfoSourceType.msidbSumInfoSourceTypeLUAPackage"]/*'/>
    msidbSumInfoSourceTypeLUAPackage = 0x00000008,
}