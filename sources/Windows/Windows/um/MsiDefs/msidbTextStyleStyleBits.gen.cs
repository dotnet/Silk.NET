// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='msidbTextStyleStyleBits.xml' path='doc/member[@name="msidbTextStyleStyleBits"]/*'/>
public enum msidbTextStyleStyleBits
{
    /// <include file='msidbTextStyleStyleBits.xml' path='doc/member[@name="msidbTextStyleStyleBits.msidbTextStyleStyleBitsBold"]/*'/>
    msidbTextStyleStyleBitsBold = 0x00000001,
    /// <include file='msidbTextStyleStyleBits.xml' path='doc/member[@name="msidbTextStyleStyleBits.msidbTextStyleStyleBitsItalic"]/*'/>
    msidbTextStyleStyleBitsItalic = 0x00000002,
    /// <include file='msidbTextStyleStyleBits.xml' path='doc/member[@name="msidbTextStyleStyleBits.msidbTextStyleStyleBitsUnderline"]/*'/>
    msidbTextStyleStyleBitsUnderline = 0x00000004,
    /// <include file='msidbTextStyleStyleBits.xml' path='doc/member[@name="msidbTextStyleStyleBits.msidbTextStyleStyleBitsStrike"]/*'/>
    msidbTextStyleStyleBitsStrike = 0x00000008,
}