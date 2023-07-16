// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_SUBPICTURE_TYPE.xml' path='doc/member[@name="DVD_SUBPICTURE_TYPE"]/*'/>
public enum DVD_SUBPICTURE_TYPE
{
    /// <include file='DVD_SUBPICTURE_TYPE.xml' path='doc/member[@name="DVD_SUBPICTURE_TYPE.DVD_SPType_NotSpecified"]/*'/>
    DVD_SPType_NotSpecified = 0,
    /// <include file='DVD_SUBPICTURE_TYPE.xml' path='doc/member[@name="DVD_SUBPICTURE_TYPE.DVD_SPType_Language"]/*'/>
    DVD_SPType_Language = 1,
    /// <include file='DVD_SUBPICTURE_TYPE.xml' path='doc/member[@name="DVD_SUBPICTURE_TYPE.DVD_SPType_Other"]/*'/>
    DVD_SPType_Other = 2,
}