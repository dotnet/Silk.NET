// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1GdiMetafileSink1.xml' path='doc/member[@name="ID2D1GdiMetafileSink1"]/*' />
[Guid("FD0ECB6B-91E6-411E-8655-395E760F91B4")]
[NativeTypeName("struct ID2D1GdiMetafileSink1 : ID2D1GdiMetafileSink")]
[NativeInheritance("ID2D1GdiMetafileSink")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID2D1GdiMetafileSink1 : ID2D1GdiMetafileSink1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GdiMetafileSink1));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink1*, uint>)(lpVtbl[1]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink1*, uint>)(lpVtbl[2]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1GdiMetafileSink.ProcessRecord" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ProcessRecord([NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink1*, uint, void*, uint, int>)(lpVtbl[3]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), recordType, recordData, recordDataSize);
    }

    /// <include file='ID2D1GdiMetafileSink1.xml' path='doc/member[@name="ID2D1GdiMetafileSink1.ProcessRecord"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ProcessRecord([NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize, [NativeTypeName("UINT32")] uint flags)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink1*, uint, void*, uint, uint, int>)(lpVtbl[4]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), recordType, recordData, recordDataSize, flags);
    }

    public interface Interface : ID2D1GdiMetafileSink.Interface
    {
        [VtblIndex(4)]
        HRESULT ProcessRecord([NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize, [NativeTypeName("UINT32")] uint flags);
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

        [NativeTypeName("HRESULT (DWORD, const void *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, int> ProcessRecord;

        [NativeTypeName("HRESULT (DWORD, const void *, DWORD, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, uint, int> ProcessRecord1;
    }
}
