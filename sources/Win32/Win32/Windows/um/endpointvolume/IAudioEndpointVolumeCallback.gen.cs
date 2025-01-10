// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("657804FA-D6AD-4496-8A60-352752AF4F89")]
[NativeTypeName("struct IAudioEndpointVolumeCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioEndpointVolumeCallback
    : IAudioEndpointVolumeCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEndpointVolumeCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAudioEndpointVolumeCallback, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnNotify(
        [NativeTypeName("PAUDIO_VOLUME_NOTIFICATION_DATA")] AUDIO_VOLUME_NOTIFICATION_DATA* pNotify
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEndpointVolumeCallback,
                AUDIO_VOLUME_NOTIFICATION_DATA*,
                int>)((*lpVtbl)[3])
        )(this, pNotify);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnNotify(
            [NativeTypeName("PAUDIO_VOLUME_NOTIFICATION_DATA")]
                AUDIO_VOLUME_NOTIFICATION_DATA* pNotify
        );
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

        [NativeTypeName("HRESULT (PAUDIO_VOLUME_NOTIFICATION_DATA) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDIO_VOLUME_NOTIFICATION_DATA*, int> OnNotify;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioEndpointVolumeCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioEndpointVolumeCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioEndpointVolumeCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioEndpointVolumeCallback(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioEndpointVolumeCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEndpointVolumeCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEndpointVolumeCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioEndpointVolumeCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
