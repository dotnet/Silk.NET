// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYNCMGRHANDLERFLAGS.xml' path='doc/member[@name="SYNCMGRHANDLERFLAGS"]/*'/>
public enum SYNCMGRHANDLERFLAGS
{
    /// <include file='SYNCMGRHANDLERFLAGS.xml' path='doc/member[@name="SYNCMGRHANDLERFLAGS.SYNCMGRHANDLER_HASPROPERTIES"]/*'/>
    SYNCMGRHANDLER_HASPROPERTIES = 0x1,
    /// <include file='SYNCMGRHANDLERFLAGS.xml' path='doc/member[@name="SYNCMGRHANDLERFLAGS.SYNCMGRHANDLER_MAYESTABLISHCONNECTION"]/*'/>
    SYNCMGRHANDLER_MAYESTABLISHCONNECTION = 0x2,
    /// <include file='SYNCMGRHANDLERFLAGS.xml' path='doc/member[@name="SYNCMGRHANDLERFLAGS.SYNCMGRHANDLER_ALWAYSLISTHANDLER"]/*'/>
    SYNCMGRHANDLER_ALWAYSLISTHANDLER = 0x4,
    /// <include file='SYNCMGRHANDLERFLAGS.xml' path='doc/member[@name="SYNCMGRHANDLERFLAGS.SYNCMGRHANDLER_HIDDEN"]/*'/>
    SYNCMGRHANDLER_HIDDEN = 0x8,
}