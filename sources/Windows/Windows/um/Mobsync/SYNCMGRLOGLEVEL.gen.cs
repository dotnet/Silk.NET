// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYNCMGRLOGLEVEL.xml' path='doc/member[@name="SYNCMGRLOGLEVEL"]/*'/>
public enum SYNCMGRLOGLEVEL
{
    /// <include file='SYNCMGRLOGLEVEL.xml' path='doc/member[@name="SYNCMGRLOGLEVEL.SYNCMGRLOGLEVEL_INFORMATION"]/*'/>
    SYNCMGRLOGLEVEL_INFORMATION = 0x1,
    /// <include file='SYNCMGRLOGLEVEL.xml' path='doc/member[@name="SYNCMGRLOGLEVEL.SYNCMGRLOGLEVEL_WARNING"]/*'/>
    SYNCMGRLOGLEVEL_WARNING = 0x2,
    /// <include file='SYNCMGRLOGLEVEL.xml' path='doc/member[@name="SYNCMGRLOGLEVEL.SYNCMGRLOGLEVEL_ERROR"]/*'/>
    SYNCMGRLOGLEVEL_ERROR = 0x3,
    /// <include file='SYNCMGRLOGLEVEL.xml' path='doc/member[@name="SYNCMGRLOGLEVEL.SYNCMGRLOGLEVEL_LOGLEVELMAX"]/*'/>
    SYNCMGRLOGLEVEL_LOGLEVELMAX = 0x3,
}