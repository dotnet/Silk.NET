// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY"]/*'/>
public enum Uri_PROPERTY
{
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_ABSOLUTE_URI"]/*'/>
    Uri_PROPERTY_ABSOLUTE_URI = 0,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_STRING_START"]/*'/>
    Uri_PROPERTY_STRING_START = Uri_PROPERTY_ABSOLUTE_URI,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_AUTHORITY"]/*'/>
    Uri_PROPERTY_AUTHORITY = 1,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_DISPLAY_URI"]/*'/>
    Uri_PROPERTY_DISPLAY_URI = 2,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_DOMAIN"]/*'/>
    Uri_PROPERTY_DOMAIN = 3,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_EXTENSION"]/*'/>
    Uri_PROPERTY_EXTENSION = 4,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_FRAGMENT"]/*'/>
    Uri_PROPERTY_FRAGMENT = 5,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_HOST"]/*'/>
    Uri_PROPERTY_HOST = 6,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_PASSWORD"]/*'/>
    Uri_PROPERTY_PASSWORD = 7,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_PATH"]/*'/>
    Uri_PROPERTY_PATH = 8,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_PATH_AND_QUERY"]/*'/>
    Uri_PROPERTY_PATH_AND_QUERY = 9,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_QUERY"]/*'/>
    Uri_PROPERTY_QUERY = 10,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_RAW_URI"]/*'/>
    Uri_PROPERTY_RAW_URI = 11,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_SCHEME_NAME"]/*'/>
    Uri_PROPERTY_SCHEME_NAME = 12,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_USER_INFO"]/*'/>
    Uri_PROPERTY_USER_INFO = 13,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_USER_NAME"]/*'/>
    Uri_PROPERTY_USER_NAME = 14,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_STRING_LAST"]/*'/>
    Uri_PROPERTY_STRING_LAST = Uri_PROPERTY_USER_NAME,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_HOST_TYPE"]/*'/>
    Uri_PROPERTY_HOST_TYPE = 15,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_DWORD_START"]/*'/>
    Uri_PROPERTY_DWORD_START = Uri_PROPERTY_HOST_TYPE,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_PORT"]/*'/>
    Uri_PROPERTY_PORT = 16,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_SCHEME"]/*'/>
    Uri_PROPERTY_SCHEME = 17,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_ZONE"]/*'/>
    Uri_PROPERTY_ZONE = 18,
    /// <include file='Uri_PROPERTY.xml' path='doc/member[@name="Uri_PROPERTY.Uri_PROPERTY_DWORD_LAST"]/*'/>
    Uri_PROPERTY_DWORD_LAST = Uri_PROPERTY_ZONE,
}