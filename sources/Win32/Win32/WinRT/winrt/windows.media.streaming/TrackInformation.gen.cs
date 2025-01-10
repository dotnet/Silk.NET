// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public partial struct TrackInformation
{
    [NativeTypeName("UINT32")]
    public uint Track;

    [NativeTypeName("UINT32")]
    public uint TrackId;

    [NativeTypeName("ABI::Windows::Foundation::TimeSpan")]
    public TimeSpan TrackDuration;
}
