// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType"]/*'/>
public enum DVD_TextStringType
{
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Struct_Volume"]/*'/>
    DVD_Struct_Volume = 0x1,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Struct_Title"]/*'/>
    DVD_Struct_Title = 0x2,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Struct_ParentalID"]/*'/>
    DVD_Struct_ParentalID = 0x3,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Struct_PartOfTitle"]/*'/>
    DVD_Struct_PartOfTitle = 0x4,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Struct_Cell"]/*'/>
    DVD_Struct_Cell = 0x5,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Stream_Audio"]/*'/>
    DVD_Stream_Audio = 0x10,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Stream_Subpicture"]/*'/>
    DVD_Stream_Subpicture = 0x11,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Stream_Angle"]/*'/>
    DVD_Stream_Angle = 0x12,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Channel_Audio"]/*'/>
    DVD_Channel_Audio = 0x20,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_General_Name"]/*'/>
    DVD_General_Name = 0x30,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_General_Comments"]/*'/>
    DVD_General_Comments = 0x31,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Series"]/*'/>
    DVD_Title_Series = 0x38,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Movie"]/*'/>
    DVD_Title_Movie = 0x39,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Video"]/*'/>
    DVD_Title_Video = 0x3a,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Album"]/*'/>
    DVD_Title_Album = 0x3b,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Song"]/*'/>
    DVD_Title_Song = 0x3c,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Other"]/*'/>
    DVD_Title_Other = 0x3f,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Sub_Series"]/*'/>
    DVD_Title_Sub_Series = 0x40,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Sub_Movie"]/*'/>
    DVD_Title_Sub_Movie = 0x41,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Sub_Video"]/*'/>
    DVD_Title_Sub_Video = 0x42,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Sub_Album"]/*'/>
    DVD_Title_Sub_Album = 0x43,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Sub_Song"]/*'/>
    DVD_Title_Sub_Song = 0x44,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Sub_Other"]/*'/>
    DVD_Title_Sub_Other = 0x47,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Orig_Series"]/*'/>
    DVD_Title_Orig_Series = 0x48,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Orig_Movie"]/*'/>
    DVD_Title_Orig_Movie = 0x49,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Orig_Video"]/*'/>
    DVD_Title_Orig_Video = 0x4a,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Orig_Album"]/*'/>
    DVD_Title_Orig_Album = 0x4b,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Orig_Song"]/*'/>
    DVD_Title_Orig_Song = 0x4c,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Title_Orig_Other"]/*'/>
    DVD_Title_Orig_Other = 0x4f,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Other_Scene"]/*'/>
    DVD_Other_Scene = 0x50,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Other_Cut"]/*'/>
    DVD_Other_Cut = 0x51,
    /// <include file='DVD_TextStringType.xml' path='doc/member[@name="DVD_TextStringType.DVD_Other_Take"]/*'/>
    DVD_Other_Take = 0x52,
}