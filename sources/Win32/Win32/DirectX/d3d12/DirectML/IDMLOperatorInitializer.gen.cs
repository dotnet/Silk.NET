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

[Guid("427C1113-435C-469C-8676-4D5DD072F813")]
[NativeTypeName("struct IDMLOperatorInitializer : IDMLDispatchable")]
[NativeInheritance("IDMLDispatchable")]
public unsafe partial struct IDMLOperatorInitializer
    : IDMLOperatorInitializer.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDMLOperatorInitializer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDMLOperatorInitializer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* dataSize,
        void* data
    )
    {
        return (
            (delegate* unmanaged<IDMLOperatorInitializer, Guid*, uint*, void*, int>)((*lpVtbl)[3])
        )(this, guid, dataSize, data);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint dataSize,
        [NativeTypeName("const void *")] void* data
    )
    {
        return (
            (delegate* unmanaged<IDMLOperatorInitializer, Guid*, uint, void*, int>)((*lpVtbl)[4])
        )(this, guid, dataSize, data);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        IUnknown data
    )
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer, Guid*, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            guid,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer, ushort*, int>)((*lpVtbl)[6]))(
            this,
            name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public DML_BINDING_PROPERTIES GetBindingProperties()
    {
        DML_BINDING_PROPERTIES result;
        return *(
            (delegate* unmanaged<
                IDMLOperatorInitializer,
                DML_BINDING_PROPERTIES*,
                DML_BINDING_PROPERTIES*>)((*lpVtbl)[8])
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Reset(
        uint operatorCount,
        [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator* operators
    )
    {
        return (
            (delegate* unmanaged<IDMLOperatorInitializer, uint, IDMLCompiledOperator*, int>)(
                (*lpVtbl)[9]
            )
        )(this, operatorCount, operators);
    }

    public interface Interface : IDMLDispatchable.Interface
    {
        [VtblIndex(9)]
        HRESULT Reset(
            uint operatorCount,
            [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator* operators
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
            "DML_BINDING_PROPERTIES () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DML_BINDING_PROPERTIES*,
            DML_BINDING_PROPERTIES*> GetBindingProperties;

        [NativeTypeName(
            "HRESULT (UINT, IDMLCompiledOperator *const *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDMLCompiledOperator*, int> Reset;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDMLOperatorInitializer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMLOperatorInitializer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDMLDispatchable"/> to <see cref = "IDMLOperatorInitializer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDMLDispatchable"/> instance to be converted </param>
    public static explicit operator IDMLOperatorInitializer(Silk.NET.DirectX.IDMLDispatchable value)
    {
        return new IDMLOperatorInitializer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMLOperatorInitializer"/> to <see cref = "Silk.NET.DirectX.IDMLDispatchable"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLOperatorInitializer"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDMLDispatchable(IDMLOperatorInitializer value)
    {
        return new Silk.NET.DirectX.IDMLDispatchable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDMLPageable"/> to <see cref = "IDMLOperatorInitializer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDMLPageable"/> instance to be converted </param>
    public static explicit operator IDMLOperatorInitializer(Silk.NET.DirectX.IDMLPageable value)
    {
        return new IDMLOperatorInitializer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMLOperatorInitializer"/> to <see cref = "Silk.NET.DirectX.IDMLPageable"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLOperatorInitializer"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDMLPageable(IDMLOperatorInitializer value)
    {
        return new Silk.NET.DirectX.IDMLPageable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDMLDeviceChild"/> to <see cref = "IDMLOperatorInitializer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDMLDeviceChild"/> instance to be converted </param>
    public static explicit operator IDMLOperatorInitializer(Silk.NET.DirectX.IDMLDeviceChild value)
    {
        return new IDMLOperatorInitializer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMLOperatorInitializer"/> to <see cref = "Silk.NET.DirectX.IDMLDeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLOperatorInitializer"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDMLDeviceChild(IDMLOperatorInitializer value)
    {
        return new Silk.NET.DirectX.IDMLDeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDMLObject"/> to <see cref = "IDMLOperatorInitializer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDMLObject"/> instance to be converted </param>
    public static explicit operator IDMLOperatorInitializer(Silk.NET.DirectX.IDMLObject value)
    {
        return new IDMLOperatorInitializer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMLOperatorInitializer"/> to <see cref = "Silk.NET.DirectX.IDMLObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLOperatorInitializer"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDMLObject(IDMLOperatorInitializer value)
    {
        return new Silk.NET.DirectX.IDMLObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDMLOperatorInitializer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDMLOperatorInitializer(Silk.NET.Windows.IUnknown value)
    {
        return new IDMLOperatorInitializer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMLOperatorInitializer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDMLOperatorInitializer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDMLOperatorInitializer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
