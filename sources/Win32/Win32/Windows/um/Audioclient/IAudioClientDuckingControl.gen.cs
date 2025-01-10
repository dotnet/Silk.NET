// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C789D381-A28C-4168-B28F-D3A837924DC3")]
[NativeTypeName("struct IAudioClientDuckingControl : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IAudioClientDuckingControl
    : IAudioClientDuckingControl.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioClientDuckingControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAudioClientDuckingControl, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioClientDuckingControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioClientDuckingControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDuckingOptionsForCurrentStream(AUDIO_DUCKING_OPTIONS options)
    {
        return (
            (delegate* unmanaged<IAudioClientDuckingControl, AUDIO_DUCKING_OPTIONS, int>)(
                (*lpVtbl)[3]
            )
        )(this, options);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDuckingOptionsForCurrentStream(AUDIO_DUCKING_OPTIONS options);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (AUDIO_DUCKING_OPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            AUDIO_DUCKING_OPTIONS,
            int> SetDuckingOptionsForCurrentStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioClientDuckingControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioClientDuckingControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioClientDuckingControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioClientDuckingControl(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioClientDuckingControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioClientDuckingControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioClientDuckingControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioClientDuckingControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
