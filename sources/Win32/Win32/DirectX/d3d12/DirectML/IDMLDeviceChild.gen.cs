// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("27E83142-8165-49E3-974E-2FD66E4CB69D")]
[NativeTypeName("struct IDMLDeviceChild : IDMLObject")]
[NativeInheritance("IDMLObject")]
public unsafe partial struct IDMLDeviceChild : IDMLDeviceChild.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDMLDeviceChild));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDMLDeviceChild, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDMLDeviceChild, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDMLDeviceChild, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* dataSize,
        void* data
    )
    {
        return ((delegate* unmanaged<IDMLDeviceChild, Guid*, uint*, void*, int>)((*lpVtbl)[3]))(
            this,
            guid,
            dataSize,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint dataSize,
        [NativeTypeName("const void *")] void* data
    )
    {
        return ((delegate* unmanaged<IDMLDeviceChild, Guid*, uint, void*, int>)((*lpVtbl)[4]))(
            this,
            guid,
            dataSize,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        IUnknown data
    )
    {
        return ((delegate* unmanaged<IDMLDeviceChild, Guid*, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            guid,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
    {
        return ((delegate* unmanaged<IDMLDeviceChild, ushort*, int>)((*lpVtbl)[6]))(this, name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLDeviceChild, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppv
        );
    }

    public interface Interface : IDMLObject.Interface
    {
        [VtblIndex(7)]
        HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv);
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

        [NativeTypeName(
            "HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName(
            "HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName(
            "HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;

        [NativeTypeName(
            "HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDMLDeviceChild"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLDeviceChild(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDMLObject"/> to <see cref = "IDMLDeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDMLObject"/> instance to be converted </param>
    public static explicit operator IDMLDeviceChild(Silk.NET.DirectX.IDMLObject value)
    {
        return new IDMLDeviceChild(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMLDeviceChild"/> to <see cref = "Silk.NET.DirectX.IDMLObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLDeviceChild"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDMLObject(IDMLDeviceChild value)
    {
        return new Silk.NET.DirectX.IDMLObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDMLDeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDMLDeviceChild(Silk.NET.Windows.IUnknown value)
    {
        return new IDMLDeviceChild(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMLDeviceChild"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLDeviceChild"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDMLDeviceChild value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
