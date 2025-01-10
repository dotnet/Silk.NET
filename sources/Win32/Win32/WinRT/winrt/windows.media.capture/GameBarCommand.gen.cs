// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum GameBarCommand
{
    GameBarCommand_OpenGameBar = 0,
    GameBarCommand_RecordHistoricalBuffer = 1,
    GameBarCommand_ToggleStartStopRecord = 2,
    GameBarCommand_StartRecord = 3,
    GameBarCommand_StopRecord = 4,
    GameBarCommand_TakeScreenshot = 5,
    GameBarCommand_StartBroadcast = 6,
    GameBarCommand_StopBroadcast = 7,
    GameBarCommand_PauseBroadcast = 8,
    GameBarCommand_ResumeBroadcast = 9,
    GameBarCommand_ToggleStartStopBroadcast = 10,
    GameBarCommand_ToggleMicrophoneCapture = 11,
    GameBarCommand_ToggleCameraCapture = 12,
    GameBarCommand_ToggleRecordingIndicator = 13,
}
