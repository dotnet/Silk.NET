// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OLERENDER.xml' path='doc/member[@name="OLERENDER"]/*'/>
public enum OLERENDER
{
    /// <include file='OLERENDER.xml' path='doc/member[@name="OLERENDER.OLERENDER_NONE"]/*'/>
    OLERENDER_NONE = 0,
    /// <include file='OLERENDER.xml' path='doc/member[@name="OLERENDER.OLERENDER_DRAW"]/*'/>
    OLERENDER_DRAW = 1,
    /// <include file='OLERENDER.xml' path='doc/member[@name="OLERENDER.OLERENDER_FORMAT"]/*'/>
    OLERENDER_FORMAT = 2,
    /// <include file='OLERENDER.xml' path='doc/member[@name="OLERENDER.OLERENDER_ASIS"]/*'/>
    OLERENDER_ASIS = 3,
}