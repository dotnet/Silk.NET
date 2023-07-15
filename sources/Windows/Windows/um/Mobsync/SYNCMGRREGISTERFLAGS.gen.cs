// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYNCMGRREGISTERFLAGS.xml' path='doc/member[@name="SYNCMGRREGISTERFLAGS"]/*'/>
public enum SYNCMGRREGISTERFLAGS
{
    /// <include file='SYNCMGRREGISTERFLAGS.xml' path='doc/member[@name="SYNCMGRREGISTERFLAGS.SYNCMGRREGISTERFLAG_CONNECT"]/*'/>
    SYNCMGRREGISTERFLAG_CONNECT = 0x1,
    /// <include file='SYNCMGRREGISTERFLAGS.xml' path='doc/member[@name="SYNCMGRREGISTERFLAGS.SYNCMGRREGISTERFLAG_PENDINGDISCONNECT"]/*'/>
    SYNCMGRREGISTERFLAG_PENDINGDISCONNECT = 0x2,
    /// <include file='SYNCMGRREGISTERFLAGS.xml' path='doc/member[@name="SYNCMGRREGISTERFLAGS.SYNCMGRREGISTERFLAG_IDLE"]/*'/>
    SYNCMGRREGISTERFLAG_IDLE = 0x4,
}