// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_NavCmdType.xml' path='doc/member[@name="DVD_NavCmdType"]/*'/>
public enum DVD_NavCmdType
{
    /// <include file='DVD_NavCmdType.xml' path='doc/member[@name="DVD_NavCmdType.DVD_NavCmdType_Pre"]/*'/>
    DVD_NavCmdType_Pre = 1,
    /// <include file='DVD_NavCmdType.xml' path='doc/member[@name="DVD_NavCmdType.DVD_NavCmdType_Post"]/*'/>
    DVD_NavCmdType_Post = 2,
    /// <include file='DVD_NavCmdType.xml' path='doc/member[@name="DVD_NavCmdType.DVD_NavCmdType_Cell"]/*'/>
    DVD_NavCmdType_Cell = 3,
    /// <include file='DVD_NavCmdType.xml' path='doc/member[@name="DVD_NavCmdType.DVD_NavCmdType_Button"]/*'/>
    DVD_NavCmdType_Button = 4,
}