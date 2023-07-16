// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYNCMGRINVOKEFLAGS.xml' path='doc/member[@name="SYNCMGRINVOKEFLAGS"]/*'/>
public enum SYNCMGRINVOKEFLAGS
{
    /// <include file='SYNCMGRINVOKEFLAGS.xml' path='doc/member[@name="SYNCMGRINVOKEFLAGS.SYNCMGRINVOKE_STARTSYNC"]/*'/>
    SYNCMGRINVOKE_STARTSYNC = 0x2,
    /// <include file='SYNCMGRINVOKEFLAGS.xml' path='doc/member[@name="SYNCMGRINVOKEFLAGS.SYNCMGRINVOKE_MINIMIZED"]/*'/>
    SYNCMGRINVOKE_MINIMIZED = 0x4,
}