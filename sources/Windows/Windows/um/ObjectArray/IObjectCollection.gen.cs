// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjectArray.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IObjectCollection.xml' path='doc/member[@name="IObjectCollection"]/*' />
[Guid("5632B1A4-E38A-400A-928A-D4CD63230295")]
[NativeTypeName("struct IObjectCollection : IObjectArray")]
[NativeInheritance("IObjectArray")]
public unsafe partial struct IObjectCollection : IObjectCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IObjectCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IObjectCollection*, Guid*, void**, int>)(lpVtbl[0]))((IObjectCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IObjectCollection*, uint>)(lpVtbl[1]))((IObjectCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObjectCollection*, uint>)(lpVtbl[2]))((IObjectCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IObjectArray.GetCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(uint* pcObjects)
    {
        return ((delegate* unmanaged<IObjectCollection*, uint*, int>)(lpVtbl[3]))((IObjectCollection*)Unsafe.AsPointer(ref this), pcObjects);
    }

    /// <inheritdoc cref="IObjectArray.GetAt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAt(uint uiIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IObjectCollection*, uint, Guid*, void**, int>)(lpVtbl[4]))((IObjectCollection*)Unsafe.AsPointer(ref this), uiIndex, riid, ppv);
    }

    /// <include file='IObjectCollection.xml' path='doc/member[@name="IObjectCollection.AddObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddObject(IUnknown* punk)
    {
        return ((delegate* unmanaged<IObjectCollection*, IUnknown*, int>)(lpVtbl[5]))((IObjectCollection*)Unsafe.AsPointer(ref this), punk);
    }

    /// <include file='IObjectCollection.xml' path='doc/member[@name="IObjectCollection.AddFromArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddFromArray(IObjectArray* poaSource)
    {
        return ((delegate* unmanaged<IObjectCollection*, IObjectArray*, int>)(lpVtbl[6]))((IObjectCollection*)Unsafe.AsPointer(ref this), poaSource);
    }

    /// <include file='IObjectCollection.xml' path='doc/member[@name="IObjectCollection.RemoveObjectAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveObjectAt(uint uiIndex)
    {
        return ((delegate* unmanaged<IObjectCollection*, uint, int>)(lpVtbl[7]))((IObjectCollection*)Unsafe.AsPointer(ref this), uiIndex);
    }

    /// <include file='IObjectCollection.xml' path='doc/member[@name="IObjectCollection.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IObjectCollection*, int>)(lpVtbl[8]))((IObjectCollection*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IObjectArray.Interface
    {
        [VtblIndex(5)]
        HRESULT AddObject(IUnknown* punk);

        [VtblIndex(6)]
        HRESULT AddFromArray(IObjectArray* poaSource);

        [VtblIndex(7)]
        HRESULT RemoveObjectAt(uint uiIndex);

        [VtblIndex(8)]
        HRESULT Clear();
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetAt;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> AddObject;

        [NativeTypeName("HRESULT (IObjectArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IObjectArray*, int> AddFromArray;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveObjectAt;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;
    }
}
