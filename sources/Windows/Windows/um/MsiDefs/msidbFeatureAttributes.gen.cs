// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='msidbFeatureAttributes.xml' path='doc/member[@name="msidbFeatureAttributes"]/*'/>
public enum msidbFeatureAttributes
{
    /// <include file='msidbFeatureAttributes.xml' path='doc/member[@name="msidbFeatureAttributes.msidbFeatureAttributesFavorLocal"]/*'/>
    msidbFeatureAttributesFavorLocal = 0x00000000,
    /// <include file='msidbFeatureAttributes.xml' path='doc/member[@name="msidbFeatureAttributes.msidbFeatureAttributesFavorSource"]/*'/>
    msidbFeatureAttributesFavorSource = 0x00000001,
    /// <include file='msidbFeatureAttributes.xml' path='doc/member[@name="msidbFeatureAttributes.msidbFeatureAttributesFollowParent"]/*'/>
    msidbFeatureAttributesFollowParent = 0x00000002,
    /// <include file='msidbFeatureAttributes.xml' path='doc/member[@name="msidbFeatureAttributes.msidbFeatureAttributesFavorAdvertise"]/*'/>
    msidbFeatureAttributesFavorAdvertise = 0x00000004,
    /// <include file='msidbFeatureAttributes.xml' path='doc/member[@name="msidbFeatureAttributes.msidbFeatureAttributesDisallowAdvertise"]/*'/>
    msidbFeatureAttributesDisallowAdvertise = 0x00000008,
    /// <include file='msidbFeatureAttributes.xml' path='doc/member[@name="msidbFeatureAttributes.msidbFeatureAttributesUIDisallowAbsent"]/*'/>
    msidbFeatureAttributesUIDisallowAbsent = 0x00000010,
    /// <include file='msidbFeatureAttributes.xml' path='doc/member[@name="msidbFeatureAttributes.msidbFeatureAttributesNoUnsupportedAdvertise"]/*'/>
    msidbFeatureAttributesNoUnsupportedAdvertise = 0x00000020,
}