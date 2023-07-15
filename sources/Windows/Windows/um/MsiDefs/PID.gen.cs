// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PID
{
    [NativeTypeName("#define PID_TITLE 2")]
    public const int PID_TITLE = 2;
    [NativeTypeName("#define PID_SUBJECT 3")]
    public const int PID_SUBJECT = 3;
    [NativeTypeName("#define PID_AUTHOR 4")]
    public const int PID_AUTHOR = 4;
    [NativeTypeName("#define PID_KEYWORDS 5")]
    public const int PID_KEYWORDS = 5;
    [NativeTypeName("#define PID_COMMENTS 6")]
    public const int PID_COMMENTS = 6;
    [NativeTypeName("#define PID_TEMPLATE 7")]
    public const int PID_TEMPLATE = 7;
    [NativeTypeName("#define PID_LASTAUTHOR 8")]
    public const int PID_LASTAUTHOR = 8;
    [NativeTypeName("#define PID_REVNUMBER 9")]
    public const int PID_REVNUMBER = 9;
    [NativeTypeName("#define PID_EDITTIME 10")]
    public const int PID_EDITTIME = 10;
    [NativeTypeName("#define PID_LASTPRINTED 11")]
    public const int PID_LASTPRINTED = 11;
    [NativeTypeName("#define PID_CREATE_DTM 12")]
    public const int PID_CREATE_DTM = 12;
    [NativeTypeName("#define PID_LASTSAVE_DTM 13")]
    public const int PID_LASTSAVE_DTM = 13;
    [NativeTypeName("#define PID_PAGECOUNT 14")]
    public const int PID_PAGECOUNT = 14;
    [NativeTypeName("#define PID_WORDCOUNT 15")]
    public const int PID_WORDCOUNT = 15;
    [NativeTypeName("#define PID_CHARCOUNT 16")]
    public const int PID_CHARCOUNT = 16;
    [NativeTypeName("#define PID_THUMBNAIL 17")]
    public const int PID_THUMBNAIL = 17;
    [NativeTypeName("#define PID_APPNAME 18")]
    public const int PID_APPNAME = 18;
    [NativeTypeName("#define PID_MSIVERSION PID_PAGECOUNT")]
    public const int PID_MSIVERSION = 14;
    [NativeTypeName("#define PID_MSISOURCE PID_WORDCOUNT")]
    public const int PID_MSISOURCE = 15;
    [NativeTypeName("#define PID_MSIRESTRICT PID_CHARCOUNT")]
    public const int PID_MSIRESTRICT = 16;
}