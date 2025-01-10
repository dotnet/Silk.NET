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

[Guid("E6857A76-2E3E-4FDD-BFF4-5D2BA10FB453")]
[NativeTypeName("struct IDMLCommandRecorder : IDMLDeviceChild")]
[NativeInheritance("IDMLDeviceChild")]
public unsafe partial struct IDMLCommandRecorder : IDMLCommandRecorder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDMLCommandRecorder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDMLCommandRecorder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDMLCommandRecorder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDMLCommandRecorder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* dataSize,
        void* data
    )
    {
        return ((delegate* unmanaged<IDMLCommandRecorder, Guid*, uint*, void*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IDMLCommandRecorder, Guid*, uint, void*, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<IDMLCommandRecorder, Guid*, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            guid,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
    {
        return ((delegate* unmanaged<IDMLCommandRecorder, ushort*, int>)((*lpVtbl)[6]))(this, name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLCommandRecorder, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void RecordDispatch(
        ID3D12CommandList commandList,
        IDMLDispatchable dispatchable,
        IDMLBindingTable bindings
    )
    {
        (
            (delegate* unmanaged<
                IDMLCommandRecorder,
                ID3D12CommandList,
                IDMLDispatchable,
                IDMLBindingTable,
                void>)((*lpVtbl)[8])
        )(this, commandList, dispatchable, bindings);
    }

    public interface Interface : IDMLDeviceChild.Interface
    {
        [VtblIndex(8)]
        void RecordDispatch(
            ID3D12CommandList commandList,
            IDMLDispatchable dispatchable,
            IDMLBindingTable bindings
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

        [NativeTypeName(
            "void (ID3D12CommandList *, IDMLDispatchable *, IDMLBindingTable *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12CommandList,
            IDMLDispatchable,
            IDMLBindingTable,
            void> RecordDispatch;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDMLCommandRecorder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLCommandRecorder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDMLDeviceChild"/> to <see cref = "IDMLCommandRecorder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDMLDeviceChild"/> instance to be converted </param>
    public static explicit operator IDMLCommandRecorder(Silk.NET.DirectX.IDMLDeviceChild value)
    {
        return new IDMLCommandRecorder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMLCommandRecorder"/> to <see cref = "Silk.NET.DirectX.IDMLDeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLCommandRecorder"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDMLDeviceChild(IDMLCommandRecorder value)
    {
        return new Silk.NET.DirectX.IDMLDeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDMLObject"/> to <see cref = "IDMLCommandRecorder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDMLObject"/> instance to be converted </param>
    public static explicit operator IDMLCommandRecorder(Silk.NET.DirectX.IDMLObject value)
    {
        return new IDMLCommandRecorder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMLCommandRecorder"/> to <see cref = "Silk.NET.DirectX.IDMLObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLCommandRecorder"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDMLObject(IDMLCommandRecorder value)
    {
        return new Silk.NET.DirectX.IDMLObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDMLCommandRecorder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDMLCommandRecorder(Silk.NET.Windows.IUnknown value)
    {
        return new IDMLCommandRecorder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMLCommandRecorder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLCommandRecorder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDMLCommandRecorder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
