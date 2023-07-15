// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.EndpointFormFactor;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid DEVINTERFACE_AUDIO_RENDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0x7C,
                0x32,
                0xE6,
                0xEC,
                0xDC,
                0x49,
                0x49,
                0xAE,
                0x8A,
                0x99,
                0x1E,
                0x97,
                0x6A,
                0x79,
                0xD2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DEVINTERFACE_AUDIO_CAPTURE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x81,
                0xEF,
                0x2E,
                0xFA,
                0x33,
                0x00,
                0x48,
                0x96,
                0x70,
                0x1C,
                0xD4,
                0x74,
                0x97,
                0x2C,
                0x3F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DEVINTERFACE_MIDI_OUTPUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x33,
                0xC2,
                0x6D,
                0x33,
                0xAB,
                0xE4,
                0x4C,
                0x80,
                0xD4,
                0xBB,
                0xB3,
                0xEB,
                0xBF,
                0x28,
                0x14
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DEVINTERFACE_MIDI_INPUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0xE3,
                0x4B,
                0x50,
                0xF6,
                0xCC,
                0x2C,
                0x4D,
                0xB7,
                0x3F,
                0x6F,
                0x8B,
                0x37,
                0x47,
                0xE2,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ActivateAudioInterfaceAsync"]/*'/>
    [DllImport("mmdevapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT ActivateAudioInterfaceAsync([NativeTypeName("LPCWSTR")] ushort* deviceInterfacePath, [NativeTypeName("const IID &")] Guid* riid, PROPVARIANT* activationParams, IActivateAudioInterfaceCompletionHandler* completionHandler, IActivateAudioInterfaceAsyncOperation** activationOperation);
    [NativeTypeName("#define ENDPOINT_SYSFX_ENABLED 0x00000000")]
    public const int ENDPOINT_SYSFX_ENABLED = 0x00000000;
    [NativeTypeName("#define ENDPOINT_SYSFX_DISABLED 0x00000001")]
    public const int ENDPOINT_SYSFX_DISABLED = 0x00000001;
    [NativeTypeName("#define HDMI DigitalAudioDisplayDevice")]
    public const EndpointFormFactor HDMI = DigitalAudioDisplayDevice;
}