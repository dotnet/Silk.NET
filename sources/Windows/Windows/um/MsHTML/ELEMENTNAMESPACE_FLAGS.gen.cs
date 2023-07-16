// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ELEMENTNAMESPACE_FLAGS.xml' path='doc/member[@name="ELEMENTNAMESPACE_FLAGS"]/*'/>
public enum ELEMENTNAMESPACE_FLAGS
{
    /// <include file='ELEMENTNAMESPACE_FLAGS.xml' path='doc/member[@name="ELEMENTNAMESPACE_FLAGS.ELEMENTNAMESPACEFLAGS_ALLOWANYTAG"]/*'/>
    ELEMENTNAMESPACEFLAGS_ALLOWANYTAG = 0x1,
    /// <include file='ELEMENTNAMESPACE_FLAGS.xml' path='doc/member[@name="ELEMENTNAMESPACE_FLAGS.ELEMENTNAMESPACEFLAGS_QUERYFORUNKNOWNTAGS"]/*'/>
    ELEMENTNAMESPACEFLAGS_QUERYFORUNKNOWNTAGS = 0x2,
    /// <include file='ELEMENTNAMESPACE_FLAGS.xml' path='doc/member[@name="ELEMENTNAMESPACE_FLAGS.ELEMENTNAMESPACE_FLAGS_Max"]/*'/>
    ELEMENTNAMESPACE_FLAGS_Max = 2147483647,
}