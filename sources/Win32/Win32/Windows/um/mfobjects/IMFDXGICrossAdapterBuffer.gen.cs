// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B25D03FB-D148-45EF-BFED-F778B7566C07")]
[NativeTypeName("struct IMFDXGICrossAdapterBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFDXGICrossAdapterBuffer
    : IMFDXGICrossAdapterBuffer.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFDXGICrossAdapterBuffer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFDXGICrossAdapterBuffer, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFDXGICrossAdapterBuffer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFDXGICrossAdapterBuffer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetResourceForDevice(
        IUnknown pUnkDevice,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<IMFDXGICrossAdapterBuffer, IUnknown, Guid*, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, pUnkDevice, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSubresourceIndexForDevice(IUnknown pUnkDevice, uint* puSubresource)
    {
        return (
            (delegate* unmanaged<IMFDXGICrossAdapterBuffer, IUnknown, uint*, int>)((*lpVtbl)[4])
        )(this, pUnkDevice, puSubresource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUnknownForDevice(
        IUnknown pUnkDevice,
        [NativeTypeName("const IID &")] Guid* guid,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<IMFDXGICrossAdapterBuffer, IUnknown, Guid*, Guid*, void**, int>)(
                (*lpVtbl)[5]
            )
        )(this, pUnkDevice, guid, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetUnknownForDevice(
        IUnknown pUnkDevice,
        [NativeTypeName("const IID &")] Guid* guid,
        IUnknown pUnkData
    )
    {
        return (
            (delegate* unmanaged<IMFDXGICrossAdapterBuffer, IUnknown, Guid*, IUnknown, int>)(
                (*lpVtbl)[6]
            )
        )(this, pUnkDevice, guid, pUnkData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetResourceForDevice(
            IUnknown pUnkDevice,
            [NativeTypeName("const IID &")] Guid* riid,
            [NativeTypeName("LPVOID *")] void** ppvObject
        );

        [VtblIndex(4)]
        HRESULT GetSubresourceIndexForDevice(IUnknown pUnkDevice, uint* puSubresource);

        [VtblIndex(5)]
        HRESULT GetUnknownForDevice(
            IUnknown pUnkDevice,
            [NativeTypeName("const IID &")] Guid* guid,
            [NativeTypeName("const IID &")] Guid* riid,
            [NativeTypeName("LPVOID *")] void** ppvObject
        );

        [VtblIndex(6)]
        HRESULT SetUnknownForDevice(
            IUnknown pUnkDevice,
            [NativeTypeName("const IID &")] Guid* guid,
            IUnknown pUnkData
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

        [NativeTypeName("HRESULT (IUnknown *, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, Guid*, void**, int> GetResourceForDevice;

        [NativeTypeName("HRESULT (IUnknown *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint*, int> GetSubresourceIndexForDevice;

        [NativeTypeName(
            "HRESULT (IUnknown *, const IID &, const IID &, LPVOID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, Guid*, Guid*, void**, int> GetUnknownForDevice;

        [NativeTypeName("HRESULT (IUnknown *, const IID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, Guid*, IUnknown, int> SetUnknownForDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFDXGICrossAdapterBuffer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFDXGICrossAdapterBuffer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFDXGICrossAdapterBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFDXGICrossAdapterBuffer(Silk.NET.Windows.IUnknown value)
    {
        return new IMFDXGICrossAdapterBuffer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFDXGICrossAdapterBuffer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFDXGICrossAdapterBuffer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFDXGICrossAdapterBuffer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
