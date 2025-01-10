// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum MediaStreamSourceErrorStatus
{
    MediaStreamSourceErrorStatus_Other = 0,
    MediaStreamSourceErrorStatus_OutOfMemory = 1,
    MediaStreamSourceErrorStatus_FailedToOpenFile = 2,
    MediaStreamSourceErrorStatus_FailedToConnectToServer = 3,
    MediaStreamSourceErrorStatus_ConnectionToServerLost = 4,
    MediaStreamSourceErrorStatus_UnspecifiedNetworkError = 5,
    MediaStreamSourceErrorStatus_DecodeError = 6,
    MediaStreamSourceErrorStatus_UnsupportedMediaFormat = 7,
}
