// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OLECLOSE.xml' path='doc/member[@name="OLECLOSE"]/*'/>
public enum OLECLOSE
{
    /// <include file='OLECLOSE.xml' path='doc/member[@name="OLECLOSE.OLECLOSE_SAVEIFDIRTY"]/*'/>
    OLECLOSE_SAVEIFDIRTY = 0,
    /// <include file='OLECLOSE.xml' path='doc/member[@name="OLECLOSE.OLECLOSE_NOSAVE"]/*'/>
    OLECLOSE_NOSAVE = 1,
    /// <include file='OLECLOSE.xml' path='doc/member[@name="OLECLOSE.OLECLOSE_PROMPTSAVE"]/*'/>
    OLECLOSE_PROMPTSAVE = 2,
}