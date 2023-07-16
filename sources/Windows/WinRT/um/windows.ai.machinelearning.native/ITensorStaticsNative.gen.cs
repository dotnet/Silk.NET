// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ITensorStaticsNative.xml' path='doc/member[@name="ITensorStaticsNative"]/*'/>
[Guid("39D055A4-66F6-4EBC-95D9-7A29EBE7690A")]
[NativeTypeName("struct ITensorStaticsNative : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITensorStaticsNative : ITensorStaticsNative.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITensorStaticsNative));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITensorStaticsNative*, Guid*, void**, int> )(lpVtbl[0]))((ITensorStaticsNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITensorStaticsNative*, uint> )(lpVtbl[1]))((ITensorStaticsNative*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITensorStaticsNative*, uint> )(lpVtbl[2]))((ITensorStaticsNative*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITensorStaticsNative.xml' path='doc/member[@name="ITensorStaticsNative.CreateFromD3D12Resource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateFromD3D12Resource(ID3D12Resource* value, [NativeTypeName("long long *")] long* shape, int shapeCount, IUnknown** result)
    {
        return ((delegate* unmanaged<ITensorStaticsNative*, ID3D12Resource*, long*, int, IUnknown**, int> )(lpVtbl[3]))((ITensorStaticsNative*)Unsafe.AsPointer(ref this), value, shape, shapeCount, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateFromD3D12Resource(ID3D12Resource* value, [NativeTypeName("long long *")] long* shape, int shapeCount, IUnknown** result);
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
        [NativeTypeName("HRESULT (ID3D12Resource *, long long *, int, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, long*, int, IUnknown**, int> CreateFromD3D12Resource;
    }
}