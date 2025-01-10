// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DVD_VideoAttributes
{
    public BOOL fPanscanPermitted;
    public BOOL fLetterboxPermitted;

    [NativeTypeName("ULONG")]
    public uint ulAspectX;

    [NativeTypeName("ULONG")]
    public uint ulAspectY;

    [NativeTypeName("ULONG")]
    public uint ulFrameRate;

    [NativeTypeName("ULONG")]
    public uint ulFrameHeight;
    public DVD_VIDEO_COMPRESSION Compression;
    public BOOL fLine21Field1InGOP;
    public BOOL fLine21Field2InGOP;

    [NativeTypeName("ULONG")]
    public uint ulSourceResolutionX;

    [NativeTypeName("ULONG")]
    public uint ulSourceResolutionY;
    public BOOL fIsSourceLetterboxed;
    public BOOL fIsFilmMode;
}
