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

[Guid("A5DED44F-3C5D-4B2B-BD1E-5DC1EE20BBF6")]
[NativeTypeName("struct IAudioEffectsChangedNotificationClient : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22000.0")]
public unsafe partial struct IAudioEffectsChangedNotificationClient
    : IAudioEffectsChangedNotificationClient.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEffectsChangedNotificationClient));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAudioEffectsChangedNotificationClient, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioEffectsChangedNotificationClient, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioEffectsChangedNotificationClient, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnAudioEffectsChanged()
    {
        return ((delegate* unmanaged<IAudioEffectsChangedNotificationClient, int>)((*lpVtbl)[3]))(
            this
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnAudioEffectsChanged();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnAudioEffectsChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioEffectsChangedNotificationClient"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioEffectsChangedNotificationClient(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioEffectsChangedNotificationClient"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioEffectsChangedNotificationClient(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAudioEffectsChangedNotificationClient(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEffectsChangedNotificationClient"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEffectsChangedNotificationClient"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAudioEffectsChangedNotificationClient value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
