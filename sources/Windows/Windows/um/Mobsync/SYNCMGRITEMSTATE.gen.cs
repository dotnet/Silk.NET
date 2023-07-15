// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYNCMGRITEMSTATE.xml' path='doc/member[@name="SYNCMGRITEMSTATE"]/*'/>
public enum SYNCMGRITEMSTATE
{
    /// <include file='SYNCMGRITEMSTATE.xml' path='doc/member[@name="SYNCMGRITEMSTATE.SYNCMGRITEMSTATE_UNCHECKED"]/*'/>
    SYNCMGRITEMSTATE_UNCHECKED = 0,
    /// <include file='SYNCMGRITEMSTATE.xml' path='doc/member[@name="SYNCMGRITEMSTATE.SYNCMGRITEMSTATE_CHECKED"]/*'/>
    SYNCMGRITEMSTATE_CHECKED = 0x1,
}