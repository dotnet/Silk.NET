// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BBC9C907-48D5-4A2E-A0C7-F7F0D67C1FB1")]
[NativeTypeName(
    "struct ISpatialAudioObjectRenderStreamForMetadata : ISpatialAudioObjectRenderStreamBase"
)]
[NativeInheritance("ISpatialAudioObjectRenderStreamBase")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioObjectRenderStreamForMetadata
    : ISpatialAudioObjectRenderStreamForMetadata.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectRenderStreamForMetadata));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** service)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata, Guid*, void**, int>)(
                (*lpVtbl)[4]
            )
        )(this, riid, service);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Start()
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata, int>)((*lpVtbl)[5])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Stop()
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata, int>)((*lpVtbl)[6])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata, int>)((*lpVtbl)[7])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BeginUpdatingAudioObjects(
        [NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount,
        [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer
    )
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata, uint*, uint*, int>)(
                (*lpVtbl)[8]
            )
        )(this, availableDynamicObjectCount, frameCountPerBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EndUpdatingAudioObjects()
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata, int>)((*lpVtbl)[9])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateSpatialAudioObjectForMetadataCommands(
        AudioObjectType type,
        ISpatialAudioObjectForMetadataCommands* audioObject
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAudioObjectRenderStreamForMetadata,
                AudioObjectType,
                ISpatialAudioObjectForMetadataCommands*,
                int>)((*lpVtbl)[10])
        )(this, type, audioObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ActivateSpatialAudioObjectForMetadataItems(
        AudioObjectType type,
        ISpatialAudioObjectForMetadataItems* audioObject
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAudioObjectRenderStreamForMetadata,
                AudioObjectType,
                ISpatialAudioObjectForMetadataItems*,
                int>)((*lpVtbl)[11])
        )(this, type, audioObject);
    }

    public interface Interface : ISpatialAudioObjectRenderStreamBase.Interface
    {
        [VtblIndex(10)]
        HRESULT ActivateSpatialAudioObjectForMetadataCommands(
            AudioObjectType type,
            ISpatialAudioObjectForMetadataCommands* audioObject
        );

        [VtblIndex(11)]
        HRESULT ActivateSpatialAudioObjectForMetadataItems(
            AudioObjectType type,
            ISpatialAudioObjectForMetadataItems* audioObject
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetAvailableDynamicObjectCount;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetService;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (UINT32 *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> BeginUpdatingAudioObjects;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndUpdatingAudioObjects;

        [NativeTypeName(
            "HRESULT (AudioObjectType, ISpatialAudioObjectForMetadataCommands **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioObjectType,
            ISpatialAudioObjectForMetadataCommands*,
            int> ActivateSpatialAudioObjectForMetadataCommands;

        [NativeTypeName(
            "HRESULT (AudioObjectType, ISpatialAudioObjectForMetadataItems **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioObjectType,
            ISpatialAudioObjectForMetadataItems*,
            int> ActivateSpatialAudioObjectForMetadataItems;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAudioObjectRenderStreamForMetadata"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAudioObjectRenderStreamForMetadata(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase"/> to <see cref = "ISpatialAudioObjectRenderStreamForMetadata"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase"/> instance to be converted </param>
    public static explicit operator ISpatialAudioObjectRenderStreamForMetadata(
        Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase value
    )
    {
        return new ISpatialAudioObjectRenderStreamForMetadata(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioObjectRenderStreamForMetadata"/> to <see cref = "Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioObjectRenderStreamForMetadata"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase(
        ISpatialAudioObjectRenderStreamForMetadata value
    )
    {
        return new Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAudioObjectRenderStreamForMetadata"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAudioObjectRenderStreamForMetadata(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISpatialAudioObjectRenderStreamForMetadata(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioObjectRenderStreamForMetadata"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioObjectRenderStreamForMetadata"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISpatialAudioObjectRenderStreamForMetadata value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
