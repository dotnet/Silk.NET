// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='URL_PART.xml' path='doc/member[@name="URL_PART"]/*'/>
public enum URL_PART
{
    /// <include file='URL_PART.xml' path='doc/member[@name="URL_PART.URL_PART_NONE"]/*'/>
    URL_PART_NONE = 0,
    /// <include file='URL_PART.xml' path='doc/member[@name="URL_PART.URL_PART_SCHEME"]/*'/>
    URL_PART_SCHEME = 1,
    /// <include file='URL_PART.xml' path='doc/member[@name="URL_PART.URL_PART_HOSTNAME"]/*'/>
    URL_PART_HOSTNAME,
    /// <include file='URL_PART.xml' path='doc/member[@name="URL_PART.URL_PART_USERNAME"]/*'/>
    URL_PART_USERNAME,
    /// <include file='URL_PART.xml' path='doc/member[@name="URL_PART.URL_PART_PASSWORD"]/*'/>
    URL_PART_PASSWORD,
    /// <include file='URL_PART.xml' path='doc/member[@name="URL_PART.URL_PART_PORT"]/*'/>
    URL_PART_PORT,
    /// <include file='URL_PART.xml' path='doc/member[@name="URL_PART.URL_PART_QUERY"]/*'/>
    URL_PART_QUERY,
}