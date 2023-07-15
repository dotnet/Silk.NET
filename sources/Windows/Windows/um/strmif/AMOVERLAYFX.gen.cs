// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AMOVERLAYFX.xml' path='doc/member[@name="AMOVERLAYFX"]/*'/>
public enum AMOVERLAYFX
{
    /// <include file='AMOVERLAYFX.xml' path='doc/member[@name="AMOVERLAYFX.AMOVERFX_NOFX"]/*'/>
    AMOVERFX_NOFX = 0,
    /// <include file='AMOVERLAYFX.xml' path='doc/member[@name="AMOVERLAYFX.AMOVERFX_MIRRORLEFTRIGHT"]/*'/>
    AMOVERFX_MIRRORLEFTRIGHT = 0x2,
    /// <include file='AMOVERLAYFX.xml' path='doc/member[@name="AMOVERLAYFX.AMOVERFX_MIRRORUPDOWN"]/*'/>
    AMOVERFX_MIRRORUPDOWN = 0x4,
    /// <include file='AMOVERLAYFX.xml' path='doc/member[@name="AMOVERLAYFX.AMOVERFX_DEINTERLACE"]/*'/>
    AMOVERFX_DEINTERLACE = 0x8,
}