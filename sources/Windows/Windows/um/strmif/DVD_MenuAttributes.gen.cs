// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DVD_MenuAttributes.xml' path='doc/member[@name="DVD_MenuAttributes"]/*'/>
public partial struct DVD_MenuAttributes
{
    /// <include file='DVD_MenuAttributes.xml' path='doc/member[@name="DVD_MenuAttributes.fCompatibleRegion"]/*'/>
    [NativeTypeName("BOOL[8]")]
    public _fCompatibleRegion_e__FixedBuffer fCompatibleRegion;
    /// <include file='DVD_MenuAttributes.xml' path='doc/member[@name="DVD_MenuAttributes.VideoAttributes"]/*'/>
    public DVD_VideoAttributes VideoAttributes;
    /// <include file='DVD_MenuAttributes.xml' path='doc/member[@name="DVD_MenuAttributes.fAudioPresent"]/*'/>
    public BOOL fAudioPresent;
    /// <include file='DVD_MenuAttributes.xml' path='doc/member[@name="DVD_MenuAttributes.AudioAttributes"]/*'/>
    public DVD_AudioAttributes AudioAttributes;
    /// <include file='DVD_MenuAttributes.xml' path='doc/member[@name="DVD_MenuAttributes.fSubpicturePresent"]/*'/>
    public BOOL fSubpicturePresent;
    /// <include file='DVD_MenuAttributes.xml' path='doc/member[@name="DVD_MenuAttributes.SubpictureAttributes"]/*'/>
    public DVD_SubpictureAttributes SubpictureAttributes;
    /// <include file='_fCompatibleRegion_e__FixedBuffer.xml' path='doc/member[@name="_fCompatibleRegion_e__FixedBuffer"]/*'/>
    public partial struct _fCompatibleRegion_e__FixedBuffer
    {
        public BOOL e0;
        public BOOL e1;
        public BOOL e2;
        public BOOL e3;
        public BOOL e4;
        public BOOL e5;
        public BOOL e6;
        public BOOL e7;
        [UnscopedRef]
        public ref BOOL this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<BOOL> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }
}