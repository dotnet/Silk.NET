// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISearchBoxInfo.xml' path='doc/member[@name="ISearchBoxInfo"]/*'/>
[Guid("6AF6E03F-D664-4EF4-9626-F7E0ED36755E")]
[NativeTypeName("struct ISearchBoxInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISearchBoxInfo : ISearchBoxInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchBoxInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISearchBoxInfo*, Guid*, void**, int> )(lpVtbl[0]))((ISearchBoxInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISearchBoxInfo*, uint> )(lpVtbl[1]))((ISearchBoxInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISearchBoxInfo*, uint> )(lpVtbl[2]))((ISearchBoxInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISearchBoxInfo.xml' path='doc/member[@name="ISearchBoxInfo.GetCondition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCondition([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ISearchBoxInfo*, Guid*, void**, int> )(lpVtbl[3]))((ISearchBoxInfo*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='ISearchBoxInfo.xml' path='doc/member[@name="ISearchBoxInfo.GetText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetText([NativeTypeName("LPWSTR *")] ushort** ppsz)
    {
        return ((delegate* unmanaged<ISearchBoxInfo*, ushort**, int> )(lpVtbl[4]))((ISearchBoxInfo*)Unsafe.AsPointer(ref this), ppsz);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCondition([NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(4)]
        HRESULT GetText([NativeTypeName("LPWSTR *")] ushort** ppsz);
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
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetCondition;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetText;
    }
}