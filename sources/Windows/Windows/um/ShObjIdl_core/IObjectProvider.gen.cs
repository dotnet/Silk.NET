// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IObjectProvider.xml' path='doc/member[@name="IObjectProvider"]/*'/>
[Guid("A6087428-3BE3-4D73-B308-7C04A540BF1A")]
[NativeTypeName("struct IObjectProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IObjectProvider : IObjectProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IObjectProvider));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IObjectProvider*, Guid*, void**, int> )(lpVtbl[0]))((IObjectProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IObjectProvider*, uint> )(lpVtbl[1]))((IObjectProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObjectProvider*, uint> )(lpVtbl[2]))((IObjectProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IObjectProvider.xml' path='doc/member[@name="IObjectProvider.QueryObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryObject([NativeTypeName("const GUID &")] Guid* guidObject, [NativeTypeName("const IID &")] Guid* riid, void** ppvOut)
    {
        return ((delegate* unmanaged<IObjectProvider*, Guid*, Guid*, void**, int> )(lpVtbl[3]))((IObjectProvider*)Unsafe.AsPointer(ref this), guidObject, riid, ppvOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryObject([NativeTypeName("const GUID &")] Guid* guidObject, [NativeTypeName("const IID &")] Guid* riid, void** ppvOut);
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
        [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> QueryObject;
    }
}