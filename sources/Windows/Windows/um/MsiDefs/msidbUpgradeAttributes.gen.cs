// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='msidbUpgradeAttributes.xml' path='doc/member[@name="msidbUpgradeAttributes"]/*'/>
public enum msidbUpgradeAttributes
{
    /// <include file='msidbUpgradeAttributes.xml' path='doc/member[@name="msidbUpgradeAttributes.msidbUpgradeAttributesMigrateFeatures"]/*'/>
    msidbUpgradeAttributesMigrateFeatures = 0x00000001,
    /// <include file='msidbUpgradeAttributes.xml' path='doc/member[@name="msidbUpgradeAttributes.msidbUpgradeAttributesOnlyDetect"]/*'/>
    msidbUpgradeAttributesOnlyDetect = 0x00000002,
    /// <include file='msidbUpgradeAttributes.xml' path='doc/member[@name="msidbUpgradeAttributes.msidbUpgradeAttributesIgnoreRemoveFailure"]/*'/>
    msidbUpgradeAttributesIgnoreRemoveFailure = 0x00000004,
    /// <include file='msidbUpgradeAttributes.xml' path='doc/member[@name="msidbUpgradeAttributes.msidbUpgradeAttributesVersionMinInclusive"]/*'/>
    msidbUpgradeAttributesVersionMinInclusive = 0x00000100,
    /// <include file='msidbUpgradeAttributes.xml' path='doc/member[@name="msidbUpgradeAttributes.msidbUpgradeAttributesVersionMaxInclusive"]/*'/>
    msidbUpgradeAttributesVersionMaxInclusive = 0x00000200,
    /// <include file='msidbUpgradeAttributes.xml' path='doc/member[@name="msidbUpgradeAttributes.msidbUpgradeAttributesLanguagesExclusive"]/*'/>
    msidbUpgradeAttributesLanguagesExclusive = 0x00000400,
}