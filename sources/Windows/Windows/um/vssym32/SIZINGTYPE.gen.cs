// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SIZINGTYPE.xml' path='doc/member[@name="SIZINGTYPE"]/*'/>
public enum SIZINGTYPE
{
    /// <include file='SIZINGTYPE.xml' path='doc/member[@name="SIZINGTYPE.ST_TRUESIZE"]/*'/>
    ST_TRUESIZE = 0,
    /// <include file='SIZINGTYPE.xml' path='doc/member[@name="SIZINGTYPE.ST_STRETCH"]/*'/>
    ST_STRETCH = 1,
    /// <include file='SIZINGTYPE.xml' path='doc/member[@name="SIZINGTYPE.ST_TILE"]/*'/>
    ST_TILE = 2,
}