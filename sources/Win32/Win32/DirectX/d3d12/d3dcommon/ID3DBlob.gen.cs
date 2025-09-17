// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob"]/*'/>
[Guid("8BA5FB08-5195-40E2-AC58-0D989C3A0102")]
[NativeTypeName("struct ID3D10Blob : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DBlob : ID3DBlob.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID.ID3D10Blob);
    public void** LpVtbl;

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("LPVOID")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        Ptr GetBufferPointer();

        [VtblIndex(3)]
        [return: NativeTypeName("LPVOID")]
        void* GetBufferPointerRaw();

        [VtblIndex(4)]
        [return: NativeTypeName("SIZE_T")]
        nuint GetBufferSize();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, HResult> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("LPVOID () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetBufferPointer;

        [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint> GetBufferSize;
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3DBlob*, uint>)(LpVtbl[1]))(
            (ID3DBlob*)Unsafe.AsPointer(ref this)
        );
    }

    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Ptr GetBufferPointer() => (void*)GetBufferPointerRaw();

    /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferPointer"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointerRaw()
    {
        return ((delegate* unmanaged<ID3DBlob*, void*>)(LpVtbl[3]))(
            (ID3DBlob*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferSize"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged<ID3DBlob*, nuint>)(LpVtbl[4]))(
            (ID3DBlob*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3DBlob*, Guid*, void**, HResult>)(LpVtbl[0]))(
            (ID3DBlob*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(0)]
    [Transformed]
    public HResult QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3DBlob*, uint>)(LpVtbl[2]))(
            (ID3DBlob*)Unsafe.AsPointer(ref this)
        );
    }
}
