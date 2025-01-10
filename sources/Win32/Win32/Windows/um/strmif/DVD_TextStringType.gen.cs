// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_TextStringType
{
    DVD_Struct_Volume = 0x1,
    DVD_Struct_Title = 0x2,
    DVD_Struct_ParentalID = 0x3,
    DVD_Struct_PartOfTitle = 0x4,
    DVD_Struct_Cell = 0x5,
    DVD_Stream_Audio = 0x10,
    DVD_Stream_Subpicture = 0x11,
    DVD_Stream_Angle = 0x12,
    DVD_Channel_Audio = 0x20,
    DVD_General_Name = 0x30,
    DVD_General_Comments = 0x31,
    DVD_Title_Series = 0x38,
    DVD_Title_Movie = 0x39,
    DVD_Title_Video = 0x3a,
    DVD_Title_Album = 0x3b,
    DVD_Title_Song = 0x3c,
    DVD_Title_Other = 0x3f,
    DVD_Title_Sub_Series = 0x40,
    DVD_Title_Sub_Movie = 0x41,
    DVD_Title_Sub_Video = 0x42,
    DVD_Title_Sub_Album = 0x43,
    DVD_Title_Sub_Song = 0x44,
    DVD_Title_Sub_Other = 0x47,
    DVD_Title_Orig_Series = 0x48,
    DVD_Title_Orig_Movie = 0x49,
    DVD_Title_Orig_Video = 0x4a,
    DVD_Title_Orig_Album = 0x4b,
    DVD_Title_Orig_Song = 0x4c,
    DVD_Title_Orig_Other = 0x4f,
    DVD_Other_Scene = 0x50,
    DVD_Other_Cut = 0x51,
    DVD_Other_Take = 0x52,
}
