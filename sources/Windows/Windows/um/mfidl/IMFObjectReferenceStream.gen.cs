// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFObjectReferenceStream.xml' path='doc/member[@name="IMFObjectReferenceStream"]/*' />
[Guid("09EF5BE3-C8A7-469E-8B70-73BF25BB193F")]
[NativeTypeName("struct IMFObjectReferenceStream : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFObjectReferenceStream : IMFObjectReferenceStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFObjectReferenceStream));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFObjectReferenceStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFObjectReferenceStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFObjectReferenceStream*, uint>)(lpVtbl[1]))((IMFObjectReferenceStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFObjectReferenceStream*, uint>)(lpVtbl[2]))((IMFObjectReferenceStream*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFObjectReferenceStream.xml' path='doc/member[@name="IMFObjectReferenceStream.SaveReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SaveReference([NativeTypeName("const IID &")] Guid* riid, IUnknown* pUnk)
    {
        return ((delegate* unmanaged<IMFObjectReferenceStream*, Guid*, IUnknown*, int>)(lpVtbl[3]))((IMFObjectReferenceStream*)Unsafe.AsPointer(ref this), riid, pUnk);
    }

    /// <include file='IMFObjectReferenceStream.xml' path='doc/member[@name="IMFObjectReferenceStream.LoadReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LoadReference([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IMFObjectReferenceStream*, Guid*, void**, int>)(lpVtbl[4]))((IMFObjectReferenceStream*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SaveReference([NativeTypeName("const IID &")] Guid* riid, IUnknown* pUnk);

        [VtblIndex(4)]
        HRESULT LoadReference([NativeTypeName("const IID &")] Guid* riid, void** ppv);
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

        [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SaveReference;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> LoadReference;
    }
}
