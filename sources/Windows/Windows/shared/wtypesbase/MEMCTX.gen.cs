// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MEMCTX.xml' path='doc/member[@name="MEMCTX"]/*'/>
public enum MEMCTX
{
    /// <include file='MEMCTX.xml' path='doc/member[@name="MEMCTX.MEMCTX_TASK"]/*'/>
    MEMCTX_TASK = 1,
    /// <include file='MEMCTX.xml' path='doc/member[@name="MEMCTX.MEMCTX_SHARED"]/*'/>
    MEMCTX_SHARED = 2,
    /// <include file='MEMCTX.xml' path='doc/member[@name="MEMCTX.MEMCTX_MACSYSTEM"]/*'/>
    MEMCTX_MACSYSTEM = 3,
    /// <include file='MEMCTX.xml' path='doc/member[@name="MEMCTX.MEMCTX_UNKNOWN"]/*'/>
    MEMCTX_UNKNOWN = -1,
    /// <include file='MEMCTX.xml' path='doc/member[@name="MEMCTX.MEMCTX_SAME"]/*'/>
    MEMCTX_SAME = -2,
}