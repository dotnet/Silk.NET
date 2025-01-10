// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BAB5F473-B423-477B-85F5-B5A332A04153")]
[NativeTypeName("struct ISpatialAudioObjectRenderStream : ISpatialAudioObjectRenderStreamBase")]
[NativeInheritance("ISpatialAudioObjectRenderStreamBase")]
public unsafe partial struct ISpatialAudioObjectRenderStream
    : ISpatialAudioObjectRenderStream.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectRenderStream));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStream, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream, uint*, int>)((*lpVtbl)[3]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** service)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStream, Guid*, void**, int>)((*lpVtbl)[4])
        )(this, riid, service);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BeginUpdatingAudioObjects(
        [NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount,
        [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer
    )
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectRenderStream, uint*, uint*, int>)((*lpVtbl)[8])
        )(this, availableDynamicObjectCount, frameCountPerBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EndUpdatingAudioObjects()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateSpatialAudioObject(
        AudioObjectType type,
        ISpatialAudioObject* audioObject
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAudioObjectRenderStream,
                AudioObjectType,
                ISpatialAudioObject*,
                int>)((*lpVtbl)[10])
        )(this, type, audioObject);
    }

    public interface Interface : ISpatialAudioObjectRenderStreamBase.Interface
    {
        [VtblIndex(10)]
        HRESULT ActivateSpatialAudioObject(AudioObjectType type, ISpatialAudioObject* audioObject);
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
            "HRESULT (AudioObjectType, ISpatialAudioObject **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioObjectType,
            ISpatialAudioObject*,
            int> ActivateSpatialAudioObject;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAudioObjectRenderStream"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAudioObjectRenderStream(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase"/> to <see cref = "ISpatialAudioObjectRenderStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase"/> instance to be converted </param>
    public static explicit operator ISpatialAudioObjectRenderStream(
        Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase value
    )
    {
        return new ISpatialAudioObjectRenderStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioObjectRenderStream"/> to <see cref = "Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioObjectRenderStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase(
        ISpatialAudioObjectRenderStream value
    )
    {
        return new Silk.NET.Windows.ISpatialAudioObjectRenderStreamBase(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAudioObjectRenderStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAudioObjectRenderStream(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialAudioObjectRenderStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioObjectRenderStream"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioObjectRenderStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialAudioObjectRenderStream value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
