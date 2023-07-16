// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDxcExtraOutputs.xml' path='doc/member[@name="IDxcExtraOutputs"]/*'/>
[Guid("319B37A2-A5C2-494A-A5DE-4801B2FAF989")]
[NativeTypeName("struct IDxcExtraOutputs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcExtraOutputs : IDxcExtraOutputs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcExtraOutputs));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcExtraOutputs*, Guid*, void**, int> )(lpVtbl[0]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcExtraOutputs*, uint> )(lpVtbl[1]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcExtraOutputs*, uint> )(lpVtbl[2]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcExtraOutputs.xml' path='doc/member[@name="IDxcExtraOutputs.GetOutputCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetOutputCount()
    {
        return ((delegate* unmanaged<IDxcExtraOutputs*, uint> )(lpVtbl[3]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcExtraOutputs.xml' path='doc/member[@name="IDxcExtraOutputs.GetOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOutput([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName)
    {
        return ((delegate* unmanaged<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int> )(lpVtbl[4]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this), uIndex, iid, ppvObject, ppOutputType, ppOutputName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        uint GetOutputCount();
        [VtblIndex(4)]
        HRESULT GetOutput([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName);
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
        [NativeTypeName("UINT32 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetOutputCount;
        [NativeTypeName("HRESULT (UINT32, const IID &, void **, IDxcBlobUtf16 **, IDxcBlobUtf16 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int> GetOutput;
    }
}