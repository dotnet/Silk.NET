// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID2D1GdiMetafileSink.xml' path='doc/member[@name="ID2D1GdiMetafileSink"]/*'/>
[Guid("82237326-8111-4F7C-BCF4-B5C1175564FE")]
[NativeTypeName("struct ID2D1GdiMetafileSink : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ID2D1GdiMetafileSink : ID2D1GdiMetafileSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GdiMetafileSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1GdiMetafileSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink*, uint> )(lpVtbl[1]))((ID2D1GdiMetafileSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink*, uint> )(lpVtbl[2]))((ID2D1GdiMetafileSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1GdiMetafileSink.xml' path='doc/member[@name="ID2D1GdiMetafileSink.ProcessRecord"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ProcessRecord([NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink*, uint, void*, uint, int> )(lpVtbl[3]))((ID2D1GdiMetafileSink*)Unsafe.AsPointer(ref this), recordType, recordData, recordDataSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ProcessRecord([NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize);
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
    }
}