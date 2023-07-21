// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFReadWriteClassFactory.xml' path='doc/member[@name="IMFReadWriteClassFactory"]/*' />
[Guid("E7FE2E12-661C-40DA-92F9-4F002AB67627")]
[NativeTypeName("struct IMFReadWriteClassFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFReadWriteClassFactory : IMFReadWriteClassFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFReadWriteClassFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFReadWriteClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFReadWriteClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFReadWriteClassFactory*, uint>)(lpVtbl[1]))((IMFReadWriteClassFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFReadWriteClassFactory*, uint>)(lpVtbl[2]))((IMFReadWriteClassFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFReadWriteClassFactory.xml' path='doc/member[@name="IMFReadWriteClassFactory.CreateInstanceFromURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstanceFromURL([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPCWSTR")] ushort* pwszURL, IMFAttributes* pAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMFReadWriteClassFactory*, Guid*, ushort*, IMFAttributes*, Guid*, void**, int>)(lpVtbl[3]))((IMFReadWriteClassFactory*)Unsafe.AsPointer(ref this), clsid, pwszURL, pAttributes, riid, ppvObject);
    }

    /// <include file='IMFReadWriteClassFactory.xml' path='doc/member[@name="IMFReadWriteClassFactory.CreateInstanceFromObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateInstanceFromObject([NativeTypeName("const IID &")] Guid* clsid, IUnknown* punkObject, IMFAttributes* pAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMFReadWriteClassFactory*, Guid*, IUnknown*, IMFAttributes*, Guid*, void**, int>)(lpVtbl[4]))((IMFReadWriteClassFactory*)Unsafe.AsPointer(ref this), clsid, punkObject, pAttributes, riid, ppvObject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateInstanceFromURL([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPCWSTR")] ushort* pwszURL, IMFAttributes* pAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [VtblIndex(4)]
        HRESULT CreateInstanceFromObject([NativeTypeName("const IID &")] Guid* clsid, IUnknown* punkObject, IMFAttributes* pAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);
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

        [NativeTypeName("HRESULT (const IID &, LPCWSTR, IMFAttributes *, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, IMFAttributes*, Guid*, void**, int> CreateInstanceFromURL;

        [NativeTypeName("HRESULT (const IID &, IUnknown *, IMFAttributes *, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, IMFAttributes*, Guid*, void**, int> CreateInstanceFromObject;
    }
}
