// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IRichChunk.xml' path='doc/member[@name="IRichChunk"]/*' />
[Guid("4FDEF69C-DBC9-454E-9910-B34F3C64B510")]
[NativeTypeName("struct IRichChunk : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRichChunk : IRichChunk.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRichChunk));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRichChunk*, Guid*, void**, int>)(lpVtbl[0]))((IRichChunk*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRichChunk*, uint>)(lpVtbl[1]))((IRichChunk*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRichChunk*, uint>)(lpVtbl[2]))((IRichChunk*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRichChunk.xml' path='doc/member[@name="IRichChunk.GetData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetData([NativeTypeName("ULONG *")] uint* pFirstPos, [NativeTypeName("ULONG *")] uint* pLength, [NativeTypeName("LPWSTR *")] ushort** ppsz, PROPVARIANT* pValue)
    {
        return ((delegate* unmanaged<IRichChunk*, uint*, uint*, ushort**, PROPVARIANT*, int>)(lpVtbl[3]))((IRichChunk*)Unsafe.AsPointer(ref this), pFirstPos, pLength, ppsz, pValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetData([NativeTypeName("ULONG *")] uint* pFirstPos, [NativeTypeName("ULONG *")] uint* pLength, [NativeTypeName("LPWSTR *")] ushort** ppsz, PROPVARIANT* pValue);
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

        [NativeTypeName("HRESULT (ULONG *, ULONG *, LPWSTR *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, ushort**, PROPVARIANT*, int> GetData;
    }
}
