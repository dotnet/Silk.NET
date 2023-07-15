// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumerableView.xml' path='doc/member[@name="IEnumerableView"]/*'/>
[Guid("8C8BF236-1AEC-495F-9894-91D57C3C686F")]
[NativeTypeName("struct IEnumerableView : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumerableView : IEnumerableView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumerableView));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumerableView*, Guid*, void**, int> )(lpVtbl[0]))((IEnumerableView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumerableView*, uint> )(lpVtbl[1]))((IEnumerableView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumerableView*, uint> )(lpVtbl[2]))((IEnumerableView*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumerableView.xml' path='doc/member[@name="IEnumerableView.SetEnumReadyCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetEnumReadyCallback(IEnumReadyCallback* percb)
    {
        return ((delegate* unmanaged<IEnumerableView*, IEnumReadyCallback*, int> )(lpVtbl[3]))((IEnumerableView*)Unsafe.AsPointer(ref this), percb);
    }

    /// <include file='IEnumerableView.xml' path='doc/member[@name="IEnumerableView.CreateEnumIDListFromContents"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateEnumIDListFromContents([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("DWORD")] uint dwEnumFlags, IEnumIDList** ppEnumIDList)
    {
        return ((delegate* unmanaged<IEnumerableView*, ITEMIDLIST*, uint, IEnumIDList**, int> )(lpVtbl[4]))((IEnumerableView*)Unsafe.AsPointer(ref this), pidlFolder, dwEnumFlags, ppEnumIDList);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetEnumReadyCallback(IEnumReadyCallback* percb);
        [VtblIndex(4)]
        HRESULT CreateEnumIDListFromContents([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("DWORD")] uint dwEnumFlags, IEnumIDList** ppEnumIDList);
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
        [NativeTypeName("HRESULT (IEnumReadyCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumReadyCallback*, int> SetEnumReadyCallback;
        [NativeTypeName("HRESULT (LPCITEMIDLIST, DWORD, IEnumIDList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, uint, IEnumIDList**, int> CreateEnumIDListFromContents;
    }
}