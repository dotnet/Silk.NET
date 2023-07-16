// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_SubpictureAttributes.xml' path='doc/member[@name="DVD_SubpictureAttributes"]/*'/>
public partial struct DVD_SubpictureAttributes
{
    /// <include file='DVD_SubpictureAttributes.xml' path='doc/member[@name="DVD_SubpictureAttributes.Type"]/*'/>
    public DVD_SUBPICTURE_TYPE Type;
    /// <include file='DVD_SubpictureAttributes.xml' path='doc/member[@name="DVD_SubpictureAttributes.CodingMode"]/*'/>
    public DVD_SUBPICTURE_CODING CodingMode;
    /// <include file='DVD_SubpictureAttributes.xml' path='doc/member[@name="DVD_SubpictureAttributes.Language"]/*'/>
    [NativeTypeName("LCID")]
    public uint Language;
    /// <include file='DVD_SubpictureAttributes.xml' path='doc/member[@name="DVD_SubpictureAttributes.LanguageExtension"]/*'/>
    public DVD_SUBPICTURE_LANG_EXT LanguageExtension;
}