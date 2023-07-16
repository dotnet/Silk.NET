// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDMLCompiledOperator.xml' path='doc/member[@name="IDMLCompiledOperator"]/*'/>
[Guid("6B15E56A-BF5C-4902-92D8-DA3A650AFEA4")]
[NativeTypeName("struct IDMLCompiledOperator : IDMLDispatchable")]
[NativeInheritance("IDMLDispatchable")]
public unsafe partial struct IDMLCompiledOperator : IDMLCompiledOperator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDMLCompiledOperator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDMLCompiledOperator*, Guid*, void**, int> )(lpVtbl[0]))((IDMLCompiledOperator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDMLCompiledOperator*, uint> )(lpVtbl[1]))((IDMLCompiledOperator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDMLCompiledOperator*, uint> )(lpVtbl[2]))((IDMLCompiledOperator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDMLObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
    {
        return ((delegate* unmanaged<IDMLCompiledOperator*, Guid*, uint*, void*, int> )(lpVtbl[3]))((IDMLCompiledOperator*)Unsafe.AsPointer(ref this), guid, dataSize, data);
    }

    /// <inheritdoc cref = "IDMLObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
    {
        return ((delegate* unmanaged<IDMLCompiledOperator*, Guid*, uint, void*, int> )(lpVtbl[4]))((IDMLCompiledOperator*)Unsafe.AsPointer(ref this), guid, dataSize, data);
    }

    /// <inheritdoc cref = "IDMLObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
    {
        return ((delegate* unmanaged<IDMLCompiledOperator*, Guid*, IUnknown*, int> )(lpVtbl[5]))((IDMLCompiledOperator*)Unsafe.AsPointer(ref this), guid, data);
    }

    /// <inheritdoc cref = "IDMLObject.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
    {
        return ((delegate* unmanaged<IDMLCompiledOperator*, ushort*, int> )(lpVtbl[6]))((IDMLCompiledOperator*)Unsafe.AsPointer(ref this), name);
    }

    /// <inheritdoc cref = "IDMLDeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IDMLCompiledOperator*, Guid*, void**, int> )(lpVtbl[7]))((IDMLCompiledOperator*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <inheritdoc cref = "IDMLDispatchable.GetBindingProperties"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public DML_BINDING_PROPERTIES GetBindingProperties()
    {
        DML_BINDING_PROPERTIES result;
        return *((delegate* unmanaged<IDMLCompiledOperator*, DML_BINDING_PROPERTIES*, DML_BINDING_PROPERTIES*> )(lpVtbl[8]))((IDMLCompiledOperator*)Unsafe.AsPointer(ref this), &result);
    }

    public interface Interface : IDMLDispatchable.Interface
    {
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
    }
}