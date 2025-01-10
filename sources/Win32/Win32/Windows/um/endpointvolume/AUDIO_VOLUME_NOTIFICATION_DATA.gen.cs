// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct AUDIO_VOLUME_NOTIFICATION_DATA
{
    public Guid guidEventContext;
    public BOOL bMuted;
    public float fMasterVolume;
    public uint nChannels;

    [NativeTypeName("float[1]")]
    public _afChannelVolumes_e__FixedBuffer afChannelVolumes;

    public partial struct _afChannelVolumes_e__FixedBuffer
    {
        public float e0;

        [UnscopedRef]
        public ref float this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<float> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
