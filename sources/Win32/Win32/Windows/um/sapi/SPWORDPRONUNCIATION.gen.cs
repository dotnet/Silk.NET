// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SPWORDPRONUNCIATION
{
    [NativeTypeName("struct SPWORDPRONUNCIATION *")]
    public SPWORDPRONUNCIATION* pNextWordPronunciation;
    public SPLEXICONTYPE eLexiconType;

    [NativeTypeName("WORD")]
    public ushort LangID;

    [NativeTypeName("WORD")]
    public ushort wPronunciationFlags;
    public SPPARTOFSPEECH ePartOfSpeech;

    [NativeTypeName("SPPHONEID[1]")]
    public _szPronunciation_e__FixedBuffer szPronunciation;

    public partial struct _szPronunciation_e__FixedBuffer
    {
        public ushort e0;

        [UnscopedRef]
        public ref ushort this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
