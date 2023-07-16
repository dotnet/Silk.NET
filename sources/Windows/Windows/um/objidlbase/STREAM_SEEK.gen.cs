// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STREAM_SEEK.xml' path='doc/member[@name="STREAM_SEEK"]/*'/>
public enum STREAM_SEEK
{
    /// <include file='STREAM_SEEK.xml' path='doc/member[@name="STREAM_SEEK.STREAM_SEEK_SET"]/*'/>
    STREAM_SEEK_SET = 0,
    /// <include file='STREAM_SEEK.xml' path='doc/member[@name="STREAM_SEEK.STREAM_SEEK_CUR"]/*'/>
    STREAM_SEEK_CUR = 1,
    /// <include file='STREAM_SEEK.xml' path='doc/member[@name="STREAM_SEEK.STREAM_SEEK_END"]/*'/>
    STREAM_SEEK_END = 2,
}