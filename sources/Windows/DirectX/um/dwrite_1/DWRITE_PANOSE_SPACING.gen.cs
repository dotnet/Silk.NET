// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_PANOSE_SPACING.xml' path='doc/member[@name="DWRITE_PANOSE_SPACING"]/*'/>
public enum DWRITE_PANOSE_SPACING
{
    /// <include file='DWRITE_PANOSE_SPACING.xml' path='doc/member[@name="DWRITE_PANOSE_SPACING.DWRITE_PANOSE_SPACING_ANY"]/*'/>
    DWRITE_PANOSE_SPACING_ANY = 0,
    /// <include file='DWRITE_PANOSE_SPACING.xml' path='doc/member[@name="DWRITE_PANOSE_SPACING.DWRITE_PANOSE_SPACING_NO_FIT"]/*'/>
    DWRITE_PANOSE_SPACING_NO_FIT = 1,
    /// <include file='DWRITE_PANOSE_SPACING.xml' path='doc/member[@name="DWRITE_PANOSE_SPACING.DWRITE_PANOSE_SPACING_PROPORTIONAL_SPACED"]/*'/>
    DWRITE_PANOSE_SPACING_PROPORTIONAL_SPACED = 2,
    /// <include file='DWRITE_PANOSE_SPACING.xml' path='doc/member[@name="DWRITE_PANOSE_SPACING.DWRITE_PANOSE_SPACING_MONOSPACED"]/*'/>
    DWRITE_PANOSE_SPACING_MONOSPACED = 3,
}