// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfCreatePropertyStore.xml' path='doc/member[@name="ITfCreatePropertyStore"]/*'/>
[Guid("2463FBF0-B0AF-11D2-AFC5-00105A2799B5")]
[NativeTypeName("struct ITfCreatePropertyStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCreatePropertyStore : ITfCreatePropertyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCreatePropertyStore));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCreatePropertyStore*, Guid*, void**, int> )(lpVtbl[0]))((ITfCreatePropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCreatePropertyStore*, uint> )(lpVtbl[1]))((ITfCreatePropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCreatePropertyStore*, uint> )(lpVtbl[2]))((ITfCreatePropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfCreatePropertyStore.xml' path='doc/member[@name="ITfCreatePropertyStore.IsStoreSerializable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsStoreSerializable([NativeTypeName("const GUID &")] Guid* guidProp, ITfRange* pRange, ITfPropertyStore* pPropStore, BOOL* pfSerializable)
    {
        return ((delegate* unmanaged<ITfCreatePropertyStore*, Guid*, ITfRange*, ITfPropertyStore*, BOOL*, int> )(lpVtbl[3]))((ITfCreatePropertyStore*)Unsafe.AsPointer(ref this), guidProp, pRange, pPropStore, pfSerializable);
    }

    /// <include file='ITfCreatePropertyStore.xml' path='doc/member[@name="ITfCreatePropertyStore.CreatePropertyStore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreatePropertyStore([NativeTypeName("const GUID &")] Guid* guidProp, ITfRange* pRange, [NativeTypeName("ULONG")] uint cb, IStream* pStream, ITfPropertyStore** ppStore)
    {
        return ((delegate* unmanaged<ITfCreatePropertyStore*, Guid*, ITfRange*, uint, IStream*, ITfPropertyStore**, int> )(lpVtbl[4]))((ITfCreatePropertyStore*)Unsafe.AsPointer(ref this), guidProp, pRange, cb, pStream, ppStore);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsStoreSerializable([NativeTypeName("const GUID &")] Guid* guidProp, ITfRange* pRange, ITfPropertyStore* pPropStore, BOOL* pfSerializable);
        [VtblIndex(4)]
        HRESULT CreatePropertyStore([NativeTypeName("const GUID &")] Guid* guidProp, ITfRange* pRange, [NativeTypeName("ULONG")] uint cb, IStream* pStream, ITfPropertyStore** ppStore);
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
        [NativeTypeName("HRESULT (const GUID &, ITfRange *, ITfPropertyStore *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ITfRange*, ITfPropertyStore*, BOOL*, int> IsStoreSerializable;
        [NativeTypeName("HRESULT (const GUID &, ITfRange *, ULONG, IStream *, ITfPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ITfRange*, uint, IStream*, ITfPropertyStore**, int> CreatePropertyStore;
    }
}