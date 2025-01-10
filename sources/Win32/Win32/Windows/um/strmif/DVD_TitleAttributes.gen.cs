// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DVD_TitleAttributes
{
    [NativeTypeName("__AnonymousRecord_strmif_L22382_C5")]
    public _Anonymous_e__Union Anonymous;
    public DVD_VideoAttributes VideoAttributes;

    [NativeTypeName("ULONG")]
    public uint ulNumberOfAudioStreams;

    [NativeTypeName("DVD_AudioAttributes[8]")]
    public _AudioAttributes_e__FixedBuffer AudioAttributes;

    [NativeTypeName("DVD_MultichannelAudioAttributes[8]")]
    public _MultichannelAudioAttributes_e__FixedBuffer MultichannelAudioAttributes;

    [NativeTypeName("ULONG")]
    public uint ulNumberOfSubpictureStreams;

    [NativeTypeName("DVD_SubpictureAttributes[32]")]
    public _SubpictureAttributes_e__FixedBuffer SubpictureAttributes;

    [UnscopedRef]
    public ref DVD_TITLE_APPMODE AppMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.AppMode; }
    }

    [UnscopedRef]
    public ref DVD_HMSF_TIMECODE TitleLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.TitleLength; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public DVD_TITLE_APPMODE AppMode;

        [FieldOffset(0)]
        public DVD_HMSF_TIMECODE TitleLength;
    }

    [InlineArray(8)]
    public partial struct _AudioAttributes_e__FixedBuffer
    {
        public DVD_AudioAttributes e0;
    }

    [InlineArray(8)]
    public partial struct _MultichannelAudioAttributes_e__FixedBuffer
    {
        public DVD_MultichannelAudioAttributes e0;
    }

    [InlineArray(32)]
    public partial struct _SubpictureAttributes_e__FixedBuffer
    {
        public DVD_SubpictureAttributes e0;
    }
}
