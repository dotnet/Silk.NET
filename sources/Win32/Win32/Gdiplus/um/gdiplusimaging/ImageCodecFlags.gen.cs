// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

[Flags]
public enum ImageCodecFlags
{
    ImageCodecFlagsEncoder = 0x00000001,
    ImageCodecFlagsDecoder = 0x00000002,
    ImageCodecFlagsSupportBitmap = 0x00000004,
    ImageCodecFlagsSupportVector = 0x00000008,
    ImageCodecFlagsSeekableEncode = 0x00000010,
    ImageCodecFlagsBlockingDecode = 0x00000020,
    ImageCodecFlagsBuiltin = 0x00010000,
    ImageCodecFlagsSystem = 0x00020000,
    ImageCodecFlagsUser = 0x00040000,
}
