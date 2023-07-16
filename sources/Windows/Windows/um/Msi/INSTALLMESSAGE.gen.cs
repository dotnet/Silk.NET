// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE"]/*'/>
public enum INSTALLMESSAGE
{
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_FATALEXIT"]/*'/>
    INSTALLMESSAGE_FATALEXIT = 0x00000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_ERROR"]/*'/>
    INSTALLMESSAGE_ERROR = 0x01000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_WARNING"]/*'/>
    INSTALLMESSAGE_WARNING = 0x02000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_USER"]/*'/>
    INSTALLMESSAGE_USER = 0x03000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_INFO"]/*'/>
    INSTALLMESSAGE_INFO = 0x04000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_FILESINUSE"]/*'/>
    INSTALLMESSAGE_FILESINUSE = 0x05000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_RESOLVESOURCE"]/*'/>
    INSTALLMESSAGE_RESOLVESOURCE = 0x06000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_OUTOFDISKSPACE"]/*'/>
    INSTALLMESSAGE_OUTOFDISKSPACE = 0x07000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_ACTIONSTART"]/*'/>
    INSTALLMESSAGE_ACTIONSTART = 0x08000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_ACTIONDATA"]/*'/>
    INSTALLMESSAGE_ACTIONDATA = 0x09000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_PROGRESS"]/*'/>
    INSTALLMESSAGE_PROGRESS = 0x0A000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_COMMONDATA"]/*'/>
    INSTALLMESSAGE_COMMONDATA = 0x0B000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_INITIALIZE"]/*'/>
    INSTALLMESSAGE_INITIALIZE = 0x0C000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_TERMINATE"]/*'/>
    INSTALLMESSAGE_TERMINATE = 0x0D000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_SHOWDIALOG"]/*'/>
    INSTALLMESSAGE_SHOWDIALOG = 0x0E000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_PERFORMANCE"]/*'/>
    INSTALLMESSAGE_PERFORMANCE = 0x0F000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_RMFILESINUSE"]/*'/>
    INSTALLMESSAGE_RMFILESINUSE = 0x19000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_INSTALLSTART"]/*'/>
    INSTALLMESSAGE_INSTALLSTART = 0x1A000000,
    /// <include file='INSTALLMESSAGE.xml' path='doc/member[@name="INSTALLMESSAGE.INSTALLMESSAGE_INSTALLEND"]/*'/>
    INSTALLMESSAGE_INSTALLEND = 0x1B000000,
}