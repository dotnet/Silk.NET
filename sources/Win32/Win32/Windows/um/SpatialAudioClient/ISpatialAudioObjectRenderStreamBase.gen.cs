// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FEAAF403-C1D8-450D-AA05-E0CCEE7502A8")]
[NativeTypeName("struct ISpatialAudioObjectRenderStreamBase : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpatialAudioObjectRenderStreamBase
    : ISpatialAudioObjectRenderStreamBase.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectRenderStreamBase));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamBase, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamBase, uint*, int>)((*lpVtbl)[3])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** service)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamBase, Guid*, void**, int>)(
                (*lpVtbl)[4]
            )
        )(this, riid, service);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase, int>)((*lpVtbl)[5]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase, int>)((*lpVtbl)[6]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase, int>)((*lpVtbl)[7]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BeginUpdatingAudioObjects(
        [NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount,
        [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer
    )
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStreamBase, uint*, uint*, int>)(
                (*lpVtbl)[8]
            )
        )(this, availableDynamicObjectCount, frameCountPerBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EndUpdatingAudioObjects()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase, int>)((*lpVtbl)[9]))(
            this
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(4)]
        HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** service);

        [VtblIndex(5)]
        HRESULT Start();

        [VtblIndex(6)]
        HRESULT Stop();

        [VtblIndex(7)]
        HRESULT Reset();

        [VtblIndex(8)]
        HRESULT BeginUpdatingAudioObjects(
            [NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount,
            [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer
        );

        [VtblIndex(9)]
        HRESULT EndUpdatingAudioObjects();
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
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAudioObjectRenderStreamBase"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAudioObjectRenderStreamBase(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAudioObjectRenderStreamBase"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAudioObjectRenderStreamBase(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISpatialAudioObjectRenderStreamBase(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioObjectRenderStreamBase"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioObjectRenderStreamBase"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISpatialAudioObjectRenderStreamBase value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
