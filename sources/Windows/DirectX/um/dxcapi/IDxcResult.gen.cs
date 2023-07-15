// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult"]/*'/>
[Guid("58346CDA-DDE7-4497-9461-6F87AF5E0659")]
[NativeTypeName("struct IDxcResult : IDxcOperationResult")]
[NativeInheritance("IDxcOperationResult")]
public unsafe partial struct IDxcResult : IDxcResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcResult));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcResult*, Guid*, void**, int> )(lpVtbl[0]))((IDxcResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcResult*, uint> )(lpVtbl[1]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcResult*, uint> )(lpVtbl[2]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDxcOperationResult.GetStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStatus(HRESULT* pStatus)
    {
        return ((delegate* unmanaged<IDxcResult*, HRESULT*, int> )(lpVtbl[3]))((IDxcResult*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <inheritdoc cref = "IDxcOperationResult.GetResult"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetResult(IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged<IDxcResult*, IDxcBlob**, int> )(lpVtbl[4]))((IDxcResult*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <inheritdoc cref = "IDxcOperationResult.GetErrorBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetErrorBuffer(IDxcBlobEncoding** ppErrors)
    {
        return ((delegate* unmanaged<IDxcResult*, IDxcBlobEncoding**, int> )(lpVtbl[5]))((IDxcResult*)Unsafe.AsPointer(ref this), ppErrors);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.HasOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL HasOutput(DXC_OUT_KIND dxcOutKind)
    {
        return ((delegate* unmanaged<IDxcResult*, DXC_OUT_KIND, int> )(lpVtbl[6]))((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOutput(DXC_OUT_KIND dxcOutKind, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputName)
    {
        return ((delegate* unmanaged<IDxcResult*, DXC_OUT_KIND, Guid*, void**, IDxcBlobUtf16**, int> )(lpVtbl[7]))((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind, iid, ppvObject, ppOutputName);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetNumOutputs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT32")]
    public uint GetNumOutputs()
    {
        return ((delegate* unmanaged<IDxcResult*, uint> )(lpVtbl[8]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetOutputByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index)
    {
        return ((delegate* unmanaged<IDxcResult*, uint, DXC_OUT_KIND> )(lpVtbl[9]))((IDxcResult*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.PrimaryOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public DXC_OUT_KIND PrimaryOutput()
    {
        return ((delegate* unmanaged<IDxcResult*, DXC_OUT_KIND> )(lpVtbl[10]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDxcOperationResult.Interface
    {
        [VtblIndex(6)]
        BOOL HasOutput(DXC_OUT_KIND dxcOutKind);
        [VtblIndex(7)]
        HRESULT GetOutput(DXC_OUT_KIND dxcOutKind, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputName);
        [VtblIndex(8)]
        [return: NativeTypeName("UINT32")]
        uint GetNumOutputs();
        [VtblIndex(9)]
        DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index);
        [VtblIndex(10)]
        DXC_OUT_KIND PrimaryOutput();
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
        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, int> GetStatus;
        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob**, int> GetResult;
        [NativeTypeName("HRESULT (IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlobEncoding**, int> GetErrorBuffer;
        [NativeTypeName("BOOL (DXC_OUT_KIND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXC_OUT_KIND, int> HasOutput;
        [NativeTypeName("HRESULT (DXC_OUT_KIND, const IID &, void **, IDxcBlobUtf16 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXC_OUT_KIND, Guid*, void**, IDxcBlobUtf16**, int> GetOutput;
        [NativeTypeName("UINT32 ()")]
        public delegate* unmanaged<TSelf*, uint> GetNumOutputs;
        [NativeTypeName("DXC_OUT_KIND (UINT32)")]
        public delegate* unmanaged<TSelf*, uint, DXC_OUT_KIND> GetOutputByIndex;
        [NativeTypeName("DXC_OUT_KIND ()")]
        public delegate* unmanaged<TSelf*, DXC_OUT_KIND> PrimaryOutput;
    }
}