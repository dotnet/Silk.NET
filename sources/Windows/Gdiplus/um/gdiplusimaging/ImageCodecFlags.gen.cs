// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Gdiplus;

/// <include file='ImageCodecFlags.xml' path='doc/member[@name="ImageCodecFlags"]/*' />
[Flags]
public enum ImageCodecFlags
{
    /// <include file='ImageCodecFlags.xml' path='doc/member[@name="ImageCodecFlags.ImageCodecFlagsEncoder"]/*' />
    ImageCodecFlagsEncoder = 0x00000001,

    /// <include file='ImageCodecFlags.xml' path='doc/member[@name="ImageCodecFlags.ImageCodecFlagsDecoder"]/*' />
    ImageCodecFlagsDecoder = 0x00000002,

    /// <include file='ImageCodecFlags.xml' path='doc/member[@name="ImageCodecFlags.ImageCodecFlagsSupportBitmap"]/*' />
    ImageCodecFlagsSupportBitmap = 0x00000004,

    /// <include file='ImageCodecFlags.xml' path='doc/member[@name="ImageCodecFlags.ImageCodecFlagsSupportVector"]/*' />
    ImageCodecFlagsSupportVector = 0x00000008,

    /// <include file='ImageCodecFlags.xml' path='doc/member[@name="ImageCodecFlags.ImageCodecFlagsSeekableEncode"]/*' />
    ImageCodecFlagsSeekableEncode = 0x00000010,

    /// <include file='ImageCodecFlags.xml' path='doc/member[@name="ImageCodecFlags.ImageCodecFlagsBlockingDecode"]/*' />
    ImageCodecFlagsBlockingDecode = 0x00000020,

    /// <include file='ImageCodecFlags.xml' path='doc/member[@name="ImageCodecFlags.ImageCodecFlagsBuiltin"]/*' />
    ImageCodecFlagsBuiltin = 0x00010000,

    /// <include file='ImageCodecFlags.xml' path='doc/member[@name="ImageCodecFlags.ImageCodecFlagsSystem"]/*' />
    ImageCodecFlagsSystem = 0x00020000,

    /// <include file='ImageCodecFlags.xml' path='doc/member[@name="ImageCodecFlags.ImageCodecFlagsUser"]/*' />
    ImageCodecFlagsUser = 0x00040000,
}
