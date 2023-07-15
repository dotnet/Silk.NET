// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CALLTYPE.xml' path='doc/member[@name="CALLTYPE"]/*'/>
public enum CALLTYPE
{
    /// <include file='CALLTYPE.xml' path='doc/member[@name="CALLTYPE.CALLTYPE_TOPLEVEL"]/*'/>
    CALLTYPE_TOPLEVEL = 1,
    /// <include file='CALLTYPE.xml' path='doc/member[@name="CALLTYPE.CALLTYPE_NESTED"]/*'/>
    CALLTYPE_NESTED = 2,
    /// <include file='CALLTYPE.xml' path='doc/member[@name="CALLTYPE.CALLTYPE_ASYNC"]/*'/>
    CALLTYPE_ASYNC = 3,
    /// <include file='CALLTYPE.xml' path='doc/member[@name="CALLTYPE.CALLTYPE_TOPLEVEL_CALLPENDING"]/*'/>
    CALLTYPE_TOPLEVEL_CALLPENDING = 4,
    /// <include file='CALLTYPE.xml' path='doc/member[@name="CALLTYPE.CALLTYPE_ASYNC_CALLPENDING"]/*'/>
    CALLTYPE_ASYNC_CALLPENDING = 5,
}