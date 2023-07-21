// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='URL_ENCODING.xml' path='doc/member[@name="URL_ENCODING"]/*' />
public enum URL_ENCODING
{
    /// <include file='URL_ENCODING.xml' path='doc/member[@name="URL_ENCODING.URL_ENCODING_NONE"]/*' />
    URL_ENCODING_NONE = 0,

    /// <include file='URL_ENCODING.xml' path='doc/member[@name="URL_ENCODING.URL_ENCODING_ENABLE_UTF8"]/*' />
    URL_ENCODING_ENABLE_UTF8 = 0x10000000,

    /// <include file='URL_ENCODING.xml' path='doc/member[@name="URL_ENCODING.URL_ENCODING_DISABLE_UTF8"]/*' />
    URL_ENCODING_DISABLE_UTF8 = 0x20000000,
}
