// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDMLDevice1.xml' path='doc/member[@name="IDMLDevice1"]/*' />
[Guid("A0884F9A-D2BE-4355-AA5D-5901281AD1D2")]
[NativeTypeName("struct IDMLDevice1 : IDMLDevice")]
[NativeInheritance("IDMLDevice")]
public unsafe partial struct IDMLDevice1 : IDMLDevice1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDMLDevice1));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDMLDevice1*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDMLDevice1*, uint>)(lpVtbl[1]))((IDMLDevice1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDMLDevice1*, uint>)(lpVtbl[2]))((IDMLDevice1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDMLObject.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
    {
        return ((delegate* unmanaged<IDMLDevice1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLDevice1*)Unsafe.AsPointer(ref this), guid, dataSize, data);
    }

    /// <inheritdoc cref="IDMLObject.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
    {
        return ((delegate* unmanaged<IDMLDevice1*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLDevice1*)Unsafe.AsPointer(ref this), guid, dataSize, data);
    }

    /// <inheritdoc cref="IDMLObject.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
    {
        return ((delegate* unmanaged<IDMLDevice1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLDevice1*)Unsafe.AsPointer(ref this), guid, data);
    }

    /// <inheritdoc cref="IDMLObject.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
    {
        return ((delegate* unmanaged<IDMLDevice1*, ushort*, int>)(lpVtbl[6]))((IDMLDevice1*)Unsafe.AsPointer(ref this), name);
    }

    /// <inheritdoc cref="IDMLDevice.CheckFeatureSupport" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CheckFeatureSupport(DML_FEATURE feature, uint featureQueryDataSize, [NativeTypeName("const void *")] void* featureQueryData, uint featureSupportDataSize, void* featureSupportData)
    {
        return ((delegate* unmanaged<IDMLDevice1*, DML_FEATURE, uint, void*, uint, void*, int>)(lpVtbl[7]))((IDMLDevice1*)Unsafe.AsPointer(ref this), feature, featureQueryDataSize, featureQueryData, featureSupportDataSize, featureSupportData);
    }

    /// <inheritdoc cref="IDMLDevice.CreateOperator" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateOperator([NativeTypeName("const DML_OPERATOR_DESC *")] DML_OPERATOR_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLDevice1*, DML_OPERATOR_DESC*, Guid*, void**, int>)(lpVtbl[8]))((IDMLDevice1*)Unsafe.AsPointer(ref this), desc, riid, ppv);
    }

    /// <inheritdoc cref="IDMLDevice.CompileOperator" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CompileOperator(IDMLOperator* op, DML_EXECUTION_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLDevice1*, IDMLOperator*, DML_EXECUTION_FLAGS, Guid*, void**, int>)(lpVtbl[9]))((IDMLDevice1*)Unsafe.AsPointer(ref this), op, flags, riid, ppv);
    }

    /// <inheritdoc cref="IDMLDevice.CreateOperatorInitializer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateOperatorInitializer(uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator** operators, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLDevice1*, uint, IDMLCompiledOperator**, Guid*, void**, int>)(lpVtbl[10]))((IDMLDevice1*)Unsafe.AsPointer(ref this), operatorCount, operators, riid, ppv);
    }

    /// <inheritdoc cref="IDMLDevice.CreateCommandRecorder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateCommandRecorder([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLDevice1*, Guid*, void**, int>)(lpVtbl[11]))((IDMLDevice1*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <inheritdoc cref="IDMLDevice.CreateBindingTable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateBindingTable([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLDevice1*, DML_BINDING_TABLE_DESC*, Guid*, void**, int>)(lpVtbl[12]))((IDMLDevice1*)Unsafe.AsPointer(ref this), desc, riid, ppv);
    }

    /// <inheritdoc cref="IDMLDevice.Evict" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Evict(uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects)
    {
        return ((delegate* unmanaged<IDMLDevice1*, uint, IDMLPageable**, int>)(lpVtbl[13]))((IDMLDevice1*)Unsafe.AsPointer(ref this), count, ppObjects);
    }

    /// <inheritdoc cref="IDMLDevice.MakeResident" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT MakeResident(uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects)
    {
        return ((delegate* unmanaged<IDMLDevice1*, uint, IDMLPageable**, int>)(lpVtbl[14]))((IDMLDevice1*)Unsafe.AsPointer(ref this), count, ppObjects);
    }

    /// <inheritdoc cref="IDMLDevice.GetDeviceRemovedReason" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeviceRemovedReason()
    {
        return ((delegate* unmanaged<IDMLDevice1*, int>)(lpVtbl[15]))((IDMLDevice1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDMLDevice.GetParentDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetParentDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLDevice1*, Guid*, void**, int>)(lpVtbl[16]))((IDMLDevice1*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='IDMLDevice1.xml' path='doc/member[@name="IDMLDevice1.CompileGraph"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CompileGraph([NativeTypeName("const DML_GRAPH_DESC *")] DML_GRAPH_DESC* desc, DML_EXECUTION_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLDevice1*, DML_GRAPH_DESC*, DML_EXECUTION_FLAGS, Guid*, void**, int>)(lpVtbl[17]))((IDMLDevice1*)Unsafe.AsPointer(ref this), desc, flags, riid, ppv);
    }

    public interface Interface : IDMLDevice.Interface
    {
        [VtblIndex(17)]
        HRESULT CompileGraph([NativeTypeName("const DML_GRAPH_DESC *")] DML_GRAPH_DESC* desc, DML_EXECUTION_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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

        [NativeTypeName("HRESULT (DML_FEATURE, UINT, const void *, UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DML_FEATURE, uint, void*, uint, void*, int> CheckFeatureSupport;

        [NativeTypeName("HRESULT (const DML_OPERATOR_DESC *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DML_OPERATOR_DESC*, Guid*, void**, int> CreateOperator;

        [NativeTypeName("HRESULT (IDMLOperator *, DML_EXECUTION_FLAGS, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDMLOperator*, DML_EXECUTION_FLAGS, Guid*, void**, int> CompileOperator;

        [NativeTypeName("HRESULT (UINT, IDMLCompiledOperator *const *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDMLCompiledOperator**, Guid*, void**, int> CreateOperatorInitializer;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> CreateCommandRecorder;

        [NativeTypeName("HRESULT (const DML_BINDING_TABLE_DESC *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DML_BINDING_TABLE_DESC*, Guid*, void**, int> CreateBindingTable;

        [NativeTypeName("HRESULT (UINT, IDMLPageable *const *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDMLPageable**, int> Evict;

        [NativeTypeName("HRESULT (UINT, IDMLPageable *const *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDMLPageable**, int> MakeResident;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetDeviceRemovedReason;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetParentDevice;

        [NativeTypeName("HRESULT (const DML_GRAPH_DESC *, DML_EXECUTION_FLAGS, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DML_GRAPH_DESC*, DML_EXECUTION_FLAGS, Guid*, void**, int> CompileGraph;
    }
}
