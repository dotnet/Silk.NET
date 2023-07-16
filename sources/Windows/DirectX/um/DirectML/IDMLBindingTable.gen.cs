// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable"]/*'/>
[Guid("29C687DC-DE74-4E3B-AB00-1168F2FC3CFC")]
[NativeTypeName("struct IDMLBindingTable : IDMLDeviceChild")]
[NativeInheritance("IDMLDeviceChild")]
public unsafe partial struct IDMLBindingTable : IDMLBindingTable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDMLBindingTable));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDMLBindingTable*, Guid*, void**, int> )(lpVtbl[0]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDMLBindingTable*, uint> )(lpVtbl[1]))((IDMLBindingTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDMLBindingTable*, uint> )(lpVtbl[2]))((IDMLBindingTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDMLObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
    {
        return ((delegate* unmanaged<IDMLBindingTable*, Guid*, uint*, void*, int> )(lpVtbl[3]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
    }

    /// <inheritdoc cref = "IDMLObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
    {
        return ((delegate* unmanaged<IDMLBindingTable*, Guid*, uint, void*, int> )(lpVtbl[4]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
    }

    /// <inheritdoc cref = "IDMLObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
    {
        return ((delegate* unmanaged<IDMLBindingTable*, Guid*, IUnknown*, int> )(lpVtbl[5]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, data);
    }

    /// <inheritdoc cref = "IDMLObject.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
    {
        return ((delegate* unmanaged<IDMLBindingTable*, ushort*, int> )(lpVtbl[6]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), name);
    }

    /// <inheritdoc cref = "IDMLDeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLBindingTable*, Guid*, void**, int> )(lpVtbl[7]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindInputs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void BindInputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings)
    {
        ((delegate* unmanaged<IDMLBindingTable*, uint, DML_BINDING_DESC*, void> )(lpVtbl[8]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), bindingCount, bindings);
    }

    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindOutputs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void BindOutputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings)
    {
        ((delegate* unmanaged<IDMLBindingTable*, uint, DML_BINDING_DESC*, void> )(lpVtbl[9]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), bindingCount, bindings);
    }

    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindTemporaryResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding)
    {
        ((delegate* unmanaged<IDMLBindingTable*, DML_BINDING_DESC*, void> )(lpVtbl[10]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), binding);
    }

    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.BindPersistentResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding)
    {
        ((delegate* unmanaged<IDMLBindingTable*, DML_BINDING_DESC*, void> )(lpVtbl[11]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), binding);
    }

    /// <include file='IDMLBindingTable.xml' path='doc/member[@name="IDMLBindingTable.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc)
    {
        return ((delegate* unmanaged<IDMLBindingTable*, DML_BINDING_TABLE_DESC*, int> )(lpVtbl[12]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), desc);
    }

    public interface Interface : IDMLDeviceChild.Interface
    {
        [VtblIndex(8)]
        void BindInputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings);
        [VtblIndex(9)]
        void BindOutputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings);
        [VtblIndex(10)]
        void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding);
        [VtblIndex(11)]
        void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding);
        [VtblIndex(12)]
        HRESULT Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc);
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
        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;
        [NativeTypeName("void (UINT, const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DML_BINDING_DESC*, void> BindInputs;
        [NativeTypeName("void (UINT, const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DML_BINDING_DESC*, void> BindOutputs;
        [NativeTypeName("void (const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DML_BINDING_DESC*, void> BindTemporaryResource;
        [NativeTypeName("void (const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DML_BINDING_DESC*, void> BindPersistentResource;
        [NativeTypeName("HRESULT (const DML_BINDING_TABLE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DML_BINDING_TABLE_DESC*, int> Reset;
    }
}