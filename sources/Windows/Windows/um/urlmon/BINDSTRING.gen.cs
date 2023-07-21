// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING"]/*' />
public enum BINDSTRING
{
    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_HEADERS"]/*' />
    BINDSTRING_HEADERS = 1,

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_ACCEPT_MIMES"]/*' />
    BINDSTRING_ACCEPT_MIMES = (BINDSTRING_HEADERS + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_EXTRA_URL"]/*' />
    BINDSTRING_EXTRA_URL = (BINDSTRING_ACCEPT_MIMES + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_LANGUAGE"]/*' />
    BINDSTRING_LANGUAGE = (BINDSTRING_EXTRA_URL + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_USERNAME"]/*' />
    BINDSTRING_USERNAME = (BINDSTRING_LANGUAGE + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_PASSWORD"]/*' />
    BINDSTRING_PASSWORD = (BINDSTRING_USERNAME + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_UA_PIXELS"]/*' />
    BINDSTRING_UA_PIXELS = (BINDSTRING_PASSWORD + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_UA_COLOR"]/*' />
    BINDSTRING_UA_COLOR = (BINDSTRING_UA_PIXELS + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_OS"]/*' />
    BINDSTRING_OS = (BINDSTRING_UA_COLOR + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_USER_AGENT"]/*' />
    BINDSTRING_USER_AGENT = (BINDSTRING_OS + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_ACCEPT_ENCODINGS"]/*' />
    BINDSTRING_ACCEPT_ENCODINGS = (BINDSTRING_USER_AGENT + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_POST_COOKIE"]/*' />
    BINDSTRING_POST_COOKIE = (BINDSTRING_ACCEPT_ENCODINGS + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_POST_DATA_MIME"]/*' />
    BINDSTRING_POST_DATA_MIME = (BINDSTRING_POST_COOKIE + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_URL"]/*' />
    BINDSTRING_URL = (BINDSTRING_POST_DATA_MIME + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_IID"]/*' />
    BINDSTRING_IID = (BINDSTRING_URL + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_FLAG_BIND_TO_OBJECT"]/*' />
    BINDSTRING_FLAG_BIND_TO_OBJECT = (BINDSTRING_IID + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_PTR_BIND_CONTEXT"]/*' />
    BINDSTRING_PTR_BIND_CONTEXT = (BINDSTRING_FLAG_BIND_TO_OBJECT + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_XDR_ORIGIN"]/*' />
    BINDSTRING_XDR_ORIGIN = (BINDSTRING_PTR_BIND_CONTEXT + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_DOWNLOADPATH"]/*' />
    BINDSTRING_DOWNLOADPATH = (BINDSTRING_XDR_ORIGIN + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_ROOTDOC_URL"]/*' />
    BINDSTRING_ROOTDOC_URL = (BINDSTRING_DOWNLOADPATH + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_INITIAL_FILENAME"]/*' />
    BINDSTRING_INITIAL_FILENAME = (BINDSTRING_ROOTDOC_URL + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_PROXY_USERNAME"]/*' />
    BINDSTRING_PROXY_USERNAME = (BINDSTRING_INITIAL_FILENAME + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_PROXY_PASSWORD"]/*' />
    BINDSTRING_PROXY_PASSWORD = (BINDSTRING_PROXY_USERNAME + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_ENTERPRISE_ID"]/*' />
    BINDSTRING_ENTERPRISE_ID = (BINDSTRING_PROXY_PASSWORD + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_DOC_URL"]/*' />
    BINDSTRING_DOC_URL = (BINDSTRING_ENTERPRISE_ID + 1),

    /// <include file='BINDSTRING.xml' path='doc/member[@name="BINDSTRING.BINDSTRING_SAMESITE_COOKIE_LEVEL"]/*' />
    BINDSTRING_SAMESITE_COOKIE_LEVEL = (BINDSTRING_DOC_URL + 1),
}
