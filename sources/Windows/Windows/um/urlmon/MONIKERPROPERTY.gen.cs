// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MONIKERPROPERTY.xml' path='doc/member[@name="MONIKERPROPERTY"]/*'/>
public enum MONIKERPROPERTY
{
    /// <include file='MONIKERPROPERTY.xml' path='doc/member[@name="MONIKERPROPERTY.MIMETYPEPROP"]/*'/>
    MIMETYPEPROP = 0,
    /// <include file='MONIKERPROPERTY.xml' path='doc/member[@name="MONIKERPROPERTY.USE_SRC_URL"]/*'/>
    USE_SRC_URL = 0x1,
    /// <include file='MONIKERPROPERTY.xml' path='doc/member[@name="MONIKERPROPERTY.CLASSIDPROP"]/*'/>
    CLASSIDPROP = 0x2,
    /// <include file='MONIKERPROPERTY.xml' path='doc/member[@name="MONIKERPROPERTY.TRUSTEDDOWNLOADPROP"]/*'/>
    TRUSTEDDOWNLOADPROP = 0x3,
    /// <include file='MONIKERPROPERTY.xml' path='doc/member[@name="MONIKERPROPERTY.POPUPLEVELPROP"]/*'/>
    POPUPLEVELPROP = 0x4,
}