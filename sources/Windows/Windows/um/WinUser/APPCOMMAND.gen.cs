// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class APPCOMMAND
{
    [NativeTypeName("#define APPCOMMAND_BROWSER_BACKWARD 1")]
    public const int APPCOMMAND_BROWSER_BACKWARD = 1;

    [NativeTypeName("#define APPCOMMAND_BROWSER_FORWARD 2")]
    public const int APPCOMMAND_BROWSER_FORWARD = 2;

    [NativeTypeName("#define APPCOMMAND_BROWSER_REFRESH 3")]
    public const int APPCOMMAND_BROWSER_REFRESH = 3;

    [NativeTypeName("#define APPCOMMAND_BROWSER_STOP 4")]
    public const int APPCOMMAND_BROWSER_STOP = 4;

    [NativeTypeName("#define APPCOMMAND_BROWSER_SEARCH 5")]
    public const int APPCOMMAND_BROWSER_SEARCH = 5;

    [NativeTypeName("#define APPCOMMAND_BROWSER_FAVORITES 6")]
    public const int APPCOMMAND_BROWSER_FAVORITES = 6;

    [NativeTypeName("#define APPCOMMAND_BROWSER_HOME 7")]
    public const int APPCOMMAND_BROWSER_HOME = 7;

    [NativeTypeName("#define APPCOMMAND_VOLUME_MUTE 8")]
    public const int APPCOMMAND_VOLUME_MUTE = 8;

    [NativeTypeName("#define APPCOMMAND_VOLUME_DOWN 9")]
    public const int APPCOMMAND_VOLUME_DOWN = 9;

    [NativeTypeName("#define APPCOMMAND_VOLUME_UP 10")]
    public const int APPCOMMAND_VOLUME_UP = 10;

    [NativeTypeName("#define APPCOMMAND_MEDIA_NEXTTRACK 11")]
    public const int APPCOMMAND_MEDIA_NEXTTRACK = 11;

    [NativeTypeName("#define APPCOMMAND_MEDIA_PREVIOUSTRACK 12")]
    public const int APPCOMMAND_MEDIA_PREVIOUSTRACK = 12;

    [NativeTypeName("#define APPCOMMAND_MEDIA_STOP 13")]
    public const int APPCOMMAND_MEDIA_STOP = 13;

    [NativeTypeName("#define APPCOMMAND_MEDIA_PLAY_PAUSE 14")]
    public const int APPCOMMAND_MEDIA_PLAY_PAUSE = 14;

    [NativeTypeName("#define APPCOMMAND_LAUNCH_MAIL 15")]
    public const int APPCOMMAND_LAUNCH_MAIL = 15;

    [NativeTypeName("#define APPCOMMAND_LAUNCH_MEDIA_SELECT 16")]
    public const int APPCOMMAND_LAUNCH_MEDIA_SELECT = 16;

    [NativeTypeName("#define APPCOMMAND_LAUNCH_APP1 17")]
    public const int APPCOMMAND_LAUNCH_APP1 = 17;

    [NativeTypeName("#define APPCOMMAND_LAUNCH_APP2 18")]
    public const int APPCOMMAND_LAUNCH_APP2 = 18;

    [NativeTypeName("#define APPCOMMAND_BASS_DOWN 19")]
    public const int APPCOMMAND_BASS_DOWN = 19;

    [NativeTypeName("#define APPCOMMAND_BASS_BOOST 20")]
    public const int APPCOMMAND_BASS_BOOST = 20;

    [NativeTypeName("#define APPCOMMAND_BASS_UP 21")]
    public const int APPCOMMAND_BASS_UP = 21;

    [NativeTypeName("#define APPCOMMAND_TREBLE_DOWN 22")]
    public const int APPCOMMAND_TREBLE_DOWN = 22;

    [NativeTypeName("#define APPCOMMAND_TREBLE_UP 23")]
    public const int APPCOMMAND_TREBLE_UP = 23;

    [NativeTypeName("#define APPCOMMAND_MICROPHONE_VOLUME_MUTE 24")]
    public const int APPCOMMAND_MICROPHONE_VOLUME_MUTE = 24;

    [NativeTypeName("#define APPCOMMAND_MICROPHONE_VOLUME_DOWN 25")]
    public const int APPCOMMAND_MICROPHONE_VOLUME_DOWN = 25;

    [NativeTypeName("#define APPCOMMAND_MICROPHONE_VOLUME_UP 26")]
    public const int APPCOMMAND_MICROPHONE_VOLUME_UP = 26;

    [NativeTypeName("#define APPCOMMAND_HELP 27")]
    public const int APPCOMMAND_HELP = 27;

    [NativeTypeName("#define APPCOMMAND_FIND 28")]
    public const int APPCOMMAND_FIND = 28;

    [NativeTypeName("#define APPCOMMAND_NEW 29")]
    public const int APPCOMMAND_NEW = 29;

    [NativeTypeName("#define APPCOMMAND_OPEN 30")]
    public const int APPCOMMAND_OPEN = 30;

    [NativeTypeName("#define APPCOMMAND_CLOSE 31")]
    public const int APPCOMMAND_CLOSE = 31;

    [NativeTypeName("#define APPCOMMAND_SAVE 32")]
    public const int APPCOMMAND_SAVE = 32;

    [NativeTypeName("#define APPCOMMAND_PRINT 33")]
    public const int APPCOMMAND_PRINT = 33;

    [NativeTypeName("#define APPCOMMAND_UNDO 34")]
    public const int APPCOMMAND_UNDO = 34;

    [NativeTypeName("#define APPCOMMAND_REDO 35")]
    public const int APPCOMMAND_REDO = 35;

    [NativeTypeName("#define APPCOMMAND_COPY 36")]
    public const int APPCOMMAND_COPY = 36;

    [NativeTypeName("#define APPCOMMAND_CUT 37")]
    public const int APPCOMMAND_CUT = 37;

    [NativeTypeName("#define APPCOMMAND_PASTE 38")]
    public const int APPCOMMAND_PASTE = 38;

    [NativeTypeName("#define APPCOMMAND_REPLY_TO_MAIL 39")]
    public const int APPCOMMAND_REPLY_TO_MAIL = 39;

    [NativeTypeName("#define APPCOMMAND_FORWARD_MAIL 40")]
    public const int APPCOMMAND_FORWARD_MAIL = 40;

    [NativeTypeName("#define APPCOMMAND_SEND_MAIL 41")]
    public const int APPCOMMAND_SEND_MAIL = 41;

    [NativeTypeName("#define APPCOMMAND_SPELL_CHECK 42")]
    public const int APPCOMMAND_SPELL_CHECK = 42;

    [NativeTypeName("#define APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE 43")]
    public const int APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE = 43;

    [NativeTypeName("#define APPCOMMAND_MIC_ON_OFF_TOGGLE 44")]
    public const int APPCOMMAND_MIC_ON_OFF_TOGGLE = 44;

    [NativeTypeName("#define APPCOMMAND_CORRECTION_LIST 45")]
    public const int APPCOMMAND_CORRECTION_LIST = 45;

    [NativeTypeName("#define APPCOMMAND_MEDIA_PLAY 46")]
    public const int APPCOMMAND_MEDIA_PLAY = 46;

    [NativeTypeName("#define APPCOMMAND_MEDIA_PAUSE 47")]
    public const int APPCOMMAND_MEDIA_PAUSE = 47;

    [NativeTypeName("#define APPCOMMAND_MEDIA_RECORD 48")]
    public const int APPCOMMAND_MEDIA_RECORD = 48;

    [NativeTypeName("#define APPCOMMAND_MEDIA_FAST_FORWARD 49")]
    public const int APPCOMMAND_MEDIA_FAST_FORWARD = 49;

    [NativeTypeName("#define APPCOMMAND_MEDIA_REWIND 50")]
    public const int APPCOMMAND_MEDIA_REWIND = 50;

    [NativeTypeName("#define APPCOMMAND_MEDIA_CHANNEL_UP 51")]
    public const int APPCOMMAND_MEDIA_CHANNEL_UP = 51;

    [NativeTypeName("#define APPCOMMAND_MEDIA_CHANNEL_DOWN 52")]
    public const int APPCOMMAND_MEDIA_CHANNEL_DOWN = 52;

    [NativeTypeName("#define APPCOMMAND_DELETE 53")]
    public const int APPCOMMAND_DELETE = 53;

    [NativeTypeName("#define APPCOMMAND_DWM_FLIP3D 54")]
    public const int APPCOMMAND_DWM_FLIP3D = 54;
}
