// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='XSAVE_AREA.xml' path='doc/member[@name="XSAVE_AREA"]/*'/>
public partial struct XSAVE_AREA
{
    /// <include file='XSAVE_AREA.xml' path='doc/member[@name="XSAVE_AREA.LegacyState"]/*'/>
    public XSAVE_FORMAT LegacyState;
    /// <include file='XSAVE_AREA.xml' path='doc/member[@name="XSAVE_AREA.Header"]/*'/>
    public XSAVE_AREA_HEADER Header;
}