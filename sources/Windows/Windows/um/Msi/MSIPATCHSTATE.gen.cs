// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MSIPATCHSTATE.xml' path='doc/member[@name="MSIPATCHSTATE"]/*'/>
public enum MSIPATCHSTATE
{
    /// <include file='MSIPATCHSTATE.xml' path='doc/member[@name="MSIPATCHSTATE.MSIPATCHSTATE_INVALID"]/*'/>
    MSIPATCHSTATE_INVALID = 0,
    /// <include file='MSIPATCHSTATE.xml' path='doc/member[@name="MSIPATCHSTATE.MSIPATCHSTATE_APPLIED"]/*'/>
    MSIPATCHSTATE_APPLIED = 1,
    /// <include file='MSIPATCHSTATE.xml' path='doc/member[@name="MSIPATCHSTATE.MSIPATCHSTATE_SUPERSEDED"]/*'/>
    MSIPATCHSTATE_SUPERSEDED = 2,
    /// <include file='MSIPATCHSTATE.xml' path='doc/member[@name="MSIPATCHSTATE.MSIPATCHSTATE_OBSOLETED"]/*'/>
    MSIPATCHSTATE_OBSOLETED = 4,
    /// <include file='MSIPATCHSTATE.xml' path='doc/member[@name="MSIPATCHSTATE.MSIPATCHSTATE_REGISTERED"]/*'/>
    MSIPATCHSTATE_REGISTERED = 8,
    /// <include file='MSIPATCHSTATE.xml' path='doc/member[@name="MSIPATCHSTATE.MSIPATCHSTATE_ALL"]/*'/>
    MSIPATCHSTATE_ALL = (MSIPATCHSTATE_APPLIED | MSIPATCHSTATE_SUPERSEDED | MSIPATCHSTATE_OBSOLETED | MSIPATCHSTATE_REGISTERED),
}