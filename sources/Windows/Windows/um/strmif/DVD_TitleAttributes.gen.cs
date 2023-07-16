// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes"]/*'/>
public partial struct DVD_TitleAttributes
{
    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_strmif_L22382_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.VideoAttributes"]/*'/>
    public DVD_VideoAttributes VideoAttributes;
    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.ulNumberOfAudioStreams"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulNumberOfAudioStreams;
    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.AudioAttributes"]/*'/>
    [NativeTypeName("DVD_AudioAttributes[8]")]
    public _AudioAttributes_e__FixedBuffer AudioAttributes;
    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.MultichannelAudioAttributes"]/*'/>
    [NativeTypeName("DVD_MultichannelAudioAttributes[8]")]
    public _MultichannelAudioAttributes_e__FixedBuffer MultichannelAudioAttributes;
    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.ulNumberOfSubpictureStreams"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulNumberOfSubpictureStreams;
    /// <include file='DVD_TitleAttributes.xml' path='doc/member[@name="DVD_TitleAttributes.SubpictureAttributes"]/*'/>
    [NativeTypeName("DVD_SubpictureAttributes[32]")]
    public _SubpictureAttributes_e__FixedBuffer SubpictureAttributes;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AppMode"]/*'/>
    [UnscopedRef]
    public ref DVD_TITLE_APPMODE AppMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.AppMode;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TitleLength"]/*'/>
    [UnscopedRef]
    public ref DVD_HMSF_TIMECODE TitleLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.TitleLength;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AppMode"]/*'/>
        [FieldOffset(0)]
        public DVD_TITLE_APPMODE AppMode;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TitleLength"]/*'/>
        [FieldOffset(0)]
        public DVD_HMSF_TIMECODE TitleLength;
    }

    /// <include file='_AudioAttributes_e__FixedBuffer.xml' path='doc/member[@name="_AudioAttributes_e__FixedBuffer"]/*'/>
    public partial struct _AudioAttributes_e__FixedBuffer
    {
        public DVD_AudioAttributes e0;
        public DVD_AudioAttributes e1;
        public DVD_AudioAttributes e2;
        public DVD_AudioAttributes e3;
        public DVD_AudioAttributes e4;
        public DVD_AudioAttributes e5;
        public DVD_AudioAttributes e6;
        public DVD_AudioAttributes e7;
        [UnscopedRef]
        public ref DVD_AudioAttributes this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DVD_AudioAttributes> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }

    /// <include file='_MultichannelAudioAttributes_e__FixedBuffer.xml' path='doc/member[@name="_MultichannelAudioAttributes_e__FixedBuffer"]/*'/>
    public partial struct _MultichannelAudioAttributes_e__FixedBuffer
    {
        public DVD_MultichannelAudioAttributes e0;
        public DVD_MultichannelAudioAttributes e1;
        public DVD_MultichannelAudioAttributes e2;
        public DVD_MultichannelAudioAttributes e3;
        public DVD_MultichannelAudioAttributes e4;
        public DVD_MultichannelAudioAttributes e5;
        public DVD_MultichannelAudioAttributes e6;
        public DVD_MultichannelAudioAttributes e7;
        [UnscopedRef]
        public ref DVD_MultichannelAudioAttributes this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DVD_MultichannelAudioAttributes> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }

    /// <include file='_SubpictureAttributes_e__FixedBuffer.xml' path='doc/member[@name="_SubpictureAttributes_e__FixedBuffer"]/*'/>
    public partial struct _SubpictureAttributes_e__FixedBuffer
    {
        public DVD_SubpictureAttributes e0;
        public DVD_SubpictureAttributes e1;
        public DVD_SubpictureAttributes e2;
        public DVD_SubpictureAttributes e3;
        public DVD_SubpictureAttributes e4;
        public DVD_SubpictureAttributes e5;
        public DVD_SubpictureAttributes e6;
        public DVD_SubpictureAttributes e7;
        public DVD_SubpictureAttributes e8;
        public DVD_SubpictureAttributes e9;
        public DVD_SubpictureAttributes e10;
        public DVD_SubpictureAttributes e11;
        public DVD_SubpictureAttributes e12;
        public DVD_SubpictureAttributes e13;
        public DVD_SubpictureAttributes e14;
        public DVD_SubpictureAttributes e15;
        public DVD_SubpictureAttributes e16;
        public DVD_SubpictureAttributes e17;
        public DVD_SubpictureAttributes e18;
        public DVD_SubpictureAttributes e19;
        public DVD_SubpictureAttributes e20;
        public DVD_SubpictureAttributes e21;
        public DVD_SubpictureAttributes e22;
        public DVD_SubpictureAttributes e23;
        public DVD_SubpictureAttributes e24;
        public DVD_SubpictureAttributes e25;
        public DVD_SubpictureAttributes e26;
        public DVD_SubpictureAttributes e27;
        public DVD_SubpictureAttributes e28;
        public DVD_SubpictureAttributes e29;
        public DVD_SubpictureAttributes e30;
        public DVD_SubpictureAttributes e31;
        [UnscopedRef]
        public ref DVD_SubpictureAttributes this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DVD_SubpictureAttributes> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
    }
}