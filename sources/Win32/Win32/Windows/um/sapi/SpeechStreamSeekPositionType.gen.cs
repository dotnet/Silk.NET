// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.STREAM_SEEK;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpeechStreamSeekPositionType
{
    SSSPTRelativeToStart = STREAM_SEEK_SET,
    SSSPTRelativeToCurrentPosition = STREAM_SEEK_CUR,
    SSSPTRelativeToEnd = STREAM_SEEK_END,
}
