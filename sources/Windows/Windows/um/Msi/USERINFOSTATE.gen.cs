// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='USERINFOSTATE.xml' path='doc/member[@name="USERINFOSTATE"]/*'/>
public enum USERINFOSTATE
{
    /// <include file='USERINFOSTATE.xml' path='doc/member[@name="USERINFOSTATE.USERINFOSTATE_MOREDATA"]/*'/>
    USERINFOSTATE_MOREDATA = -3,
    /// <include file='USERINFOSTATE.xml' path='doc/member[@name="USERINFOSTATE.USERINFOSTATE_INVALIDARG"]/*'/>
    USERINFOSTATE_INVALIDARG = -2,
    /// <include file='USERINFOSTATE.xml' path='doc/member[@name="USERINFOSTATE.USERINFOSTATE_UNKNOWN"]/*'/>
    USERINFOSTATE_UNKNOWN = -1,
    /// <include file='USERINFOSTATE.xml' path='doc/member[@name="USERINFOSTATE.USERINFOSTATE_ABSENT"]/*'/>
    USERINFOSTATE_ABSENT = 0,
    /// <include file='USERINFOSTATE.xml' path='doc/member[@name="USERINFOSTATE.USERINFOSTATE_PRESENT"]/*'/>
    USERINFOSTATE_PRESENT = 1,
}