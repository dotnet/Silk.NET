// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDMLOperatorInitializer.xml' path='doc/member[@name="IDMLOperatorInitializer"]/*' />
[Guid("427C1113-435C-469C-8676-4D5DD072F813")]
[NativeTypeName("struct IDMLOperatorInitializer : IDMLDispatchable")]
[NativeInheritance("IDMLDispatchable")]
public unsafe partial struct IDMLOperatorInitializer : IDMLOperatorInitializer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDMLOperatorInitializer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer*, Guid*, void**, int>)(lpVtbl[0]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer*, uint>)(lpVtbl[1]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer*, uint>)(lpVtbl[2]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDMLObject.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), guid, dataSize, data);
    }

    /// <inheritdoc cref="IDMLObject.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), guid, dataSize, data);
    }

    /// <inheritdoc cref="IDMLObject.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), guid, data);
    }

    /// <inheritdoc cref="IDMLObject.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer*, ushort*, int>)(lpVtbl[6]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), name);
    }

    /// <inheritdoc cref="IDMLDeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer*, Guid*, void**, int>)(lpVtbl[7]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <inheritdoc cref="IDMLDispatchable.GetBindingProperties" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public DML_BINDING_PROPERTIES GetBindingProperties()
    {
        DML_BINDING_PROPERTIES result;
        return *((delegate* unmanaged<IDMLOperatorInitializer*, DML_BINDING_PROPERTIES*, DML_BINDING_PROPERTIES*>)(lpVtbl[8]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='IDMLOperatorInitializer.xml' path='doc/member[@name="IDMLOperatorInitializer.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Reset(uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator** operators)
    {
        return ((delegate* unmanaged<IDMLOperatorInitializer*, uint, IDMLCompiledOperator**, int>)(lpVtbl[9]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), operatorCount, operators);
    }

    public interface Interface : IDMLDispatchable.Interface
    {
        [VtblIndex(9)]
        HRESULT Reset(uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator** operators);
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

        [NativeTypeName("DML_BINDING_PROPERTIES () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DML_BINDING_PROPERTIES*, DML_BINDING_PROPERTIES*> GetBindingProperties;

        [NativeTypeName("HRESULT (UINT, IDMLCompiledOperator *const *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDMLCompiledOperator**, int> Reset;
    }
}
