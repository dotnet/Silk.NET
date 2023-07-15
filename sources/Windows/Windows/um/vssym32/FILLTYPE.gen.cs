// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILLTYPE.xml' path='doc/member[@name="FILLTYPE"]/*'/>
public enum FILLTYPE
{
    /// <include file='FILLTYPE.xml' path='doc/member[@name="FILLTYPE.FT_SOLID"]/*'/>
    FT_SOLID = 0,
    /// <include file='FILLTYPE.xml' path='doc/member[@name="FILLTYPE.FT_VERTGRADIENT"]/*'/>
    FT_VERTGRADIENT = 1,
    /// <include file='FILLTYPE.xml' path='doc/member[@name="FILLTYPE.FT_HORZGRADIENT"]/*'/>
    FT_HORZGRADIENT = 2,
    /// <include file='FILLTYPE.xml' path='doc/member[@name="FILLTYPE.FT_RADIALGRADIENT"]/*'/>
    FT_RADIALGRADIENT = 3,
    /// <include file='FILLTYPE.xml' path='doc/member[@name="FILLTYPE.FT_TILEIMAGE"]/*'/>
    FT_TILEIMAGE = 4,
}