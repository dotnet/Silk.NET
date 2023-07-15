// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DEV_CONSOLE_MESSAGE_LEVEL.xml' path='doc/member[@name="DEV_CONSOLE_MESSAGE_LEVEL"]/*'/>
public enum DEV_CONSOLE_MESSAGE_LEVEL
{
    /// <include file='DEV_CONSOLE_MESSAGE_LEVEL.xml' path='doc/member[@name="DEV_CONSOLE_MESSAGE_LEVEL.DCML_INFORMATIONAL"]/*'/>
    DCML_INFORMATIONAL = 0,
    /// <include file='DEV_CONSOLE_MESSAGE_LEVEL.xml' path='doc/member[@name="DEV_CONSOLE_MESSAGE_LEVEL.DCML_WARNING"]/*'/>
    DCML_WARNING = 0x1,
    /// <include file='DEV_CONSOLE_MESSAGE_LEVEL.xml' path='doc/member[@name="DEV_CONSOLE_MESSAGE_LEVEL.DCML_ERROR"]/*'/>
    DCML_ERROR = 0x2,
    /// <include file='DEV_CONSOLE_MESSAGE_LEVEL.xml' path='doc/member[@name="DEV_CONSOLE_MESSAGE_LEVEL.DEV_CONSOLE_MESSAGE_LEVEL_Max"]/*'/>
    DEV_CONSOLE_MESSAGE_LEVEL_Max = 2147483647,
}