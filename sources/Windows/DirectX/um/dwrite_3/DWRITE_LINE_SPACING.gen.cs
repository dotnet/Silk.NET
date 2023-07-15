// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_LINE_SPACING.xml' path='doc/member[@name="DWRITE_LINE_SPACING"]/*'/>
public partial struct DWRITE_LINE_SPACING
{
    /// <include file='DWRITE_LINE_SPACING.xml' path='doc/member[@name="DWRITE_LINE_SPACING.method"]/*'/>
    public DWRITE_LINE_SPACING_METHOD method;
    /// <include file='DWRITE_LINE_SPACING.xml' path='doc/member[@name="DWRITE_LINE_SPACING.height"]/*'/>
    public float height;
    /// <include file='DWRITE_LINE_SPACING.xml' path='doc/member[@name="DWRITE_LINE_SPACING.baseline"]/*'/>
    public float baseline;
    /// <include file='DWRITE_LINE_SPACING.xml' path='doc/member[@name="DWRITE_LINE_SPACING.leadingBefore"]/*'/>
    public float leadingBefore;
    /// <include file='DWRITE_LINE_SPACING.xml' path='doc/member[@name="DWRITE_LINE_SPACING.fontLineGapUsage"]/*'/>
    public DWRITE_FONT_LINE_GAP_USAGE fontLineGapUsage;
}