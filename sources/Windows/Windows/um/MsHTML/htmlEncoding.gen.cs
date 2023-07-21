// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='htmlEncoding.xml' path='doc/member[@name="htmlEncoding"]/*' />
public enum htmlEncoding
{
    /// <include file='htmlEncoding.xml' path='doc/member[@name="htmlEncoding.htmlEncodingURL"]/*' />
    htmlEncodingURL = 0,

    /// <include file='htmlEncoding.xml' path='doc/member[@name="htmlEncoding.htmlEncodingMultipart"]/*' />
    htmlEncodingMultipart = 1,

    /// <include file='htmlEncoding.xml' path='doc/member[@name="htmlEncoding.htmlEncodingText"]/*' />
    htmlEncodingText = 2,

    /// <include file='htmlEncoding.xml' path='doc/member[@name="htmlEncoding.htmlEncoding_Max"]/*' />
    htmlEncoding_Max = 2147483647,
}
