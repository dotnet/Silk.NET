// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='tagSFBS_FLAGS.xml' path='doc/member[@name="tagSFBS_FLAGS"]/*'/>
public enum tagSFBS_FLAGS
{
    /// <include file='tagSFBS_FLAGS.xml' path='doc/member[@name="tagSFBS_FLAGS.SFBS_FLAGS_ROUND_TO_NEAREST_DISPLAYED_DIGIT"]/*'/>
    SFBS_FLAGS_ROUND_TO_NEAREST_DISPLAYED_DIGIT = 0x0001,
    /// <include file='tagSFBS_FLAGS.xml' path='doc/member[@name="tagSFBS_FLAGS.SFBS_FLAGS_TRUNCATE_UNDISPLAYED_DECIMAL_DIGITS"]/*'/>
    SFBS_FLAGS_TRUNCATE_UNDISPLAYED_DECIMAL_DIGITS = 0x0002,
}