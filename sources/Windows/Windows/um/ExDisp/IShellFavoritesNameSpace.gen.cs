// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace"]/*' />
[Guid("55136804-B2DE-11D1-B9F2-00A0C98BC547")]
[NativeTypeName("struct IShellFavoritesNameSpace : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IShellFavoritesNameSpace : IShellFavoritesNameSpace.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellFavoritesNameSpace));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, Guid*, void**, int>)(lpVtbl[0]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint>)(lpVtbl[1]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint>)(lpVtbl[2]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint*, int>)(lpVtbl[3]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.MoveSelectionUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MoveSelectionUp()
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[7]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.MoveSelectionDown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MoveSelectionDown()
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[8]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.ResetSort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ResetSort()
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[9]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.NewFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT NewFolder()
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[10]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.Synchronize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Synchronize()
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[11]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.Import"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Import()
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[12]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.Export"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Export()
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[13]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.InvokeContextMenuCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT InvokeContextMenuCommand([NativeTypeName("BSTR")] ushort* strCommand)
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, ushort*, int>)(lpVtbl[14]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), strCommand);
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.MoveSelectionTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT MoveSelectionTo()
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[15]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.get_SubscriptionsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SubscriptionsEnabled([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, short*, int>)(lpVtbl[16]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.CreateSubscriptionForSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, short*, int>)(lpVtbl[17]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.DeleteSubscriptionForSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DeleteSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, short*, int>)(lpVtbl[18]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <include file='IShellFavoritesNameSpace.xml' path='doc/member[@name="IShellFavoritesNameSpace.SetRoot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetRoot([NativeTypeName("BSTR")] ushort* bstrFullPath)
    {
        return ((delegate* unmanaged<IShellFavoritesNameSpace*, ushort*, int>)(lpVtbl[19]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), bstrFullPath);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT MoveSelectionUp();

        [VtblIndex(8)]
        HRESULT MoveSelectionDown();

        [VtblIndex(9)]
        HRESULT ResetSort();

        [VtblIndex(10)]
        HRESULT NewFolder();

        [VtblIndex(11)]
        HRESULT Synchronize();

        [VtblIndex(12)]
        HRESULT Import();

        [VtblIndex(13)]
        HRESULT Export();

        [VtblIndex(14)]
        HRESULT InvokeContextMenuCommand([NativeTypeName("BSTR")] ushort* strCommand);

        [VtblIndex(15)]
        HRESULT MoveSelectionTo();

        [VtblIndex(16)]
        HRESULT get_SubscriptionsEnabled([NativeTypeName("VARIANT_BOOL *")] short* pBool);

        [VtblIndex(17)]
        HRESULT CreateSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool);

        [VtblIndex(18)]
        HRESULT DeleteSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool);

        [VtblIndex(19)]
        HRESULT SetRoot([NativeTypeName("BSTR")] ushort* bstrFullPath);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MoveSelectionUp;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MoveSelectionDown;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetSort;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NewFolder;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Synchronize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Import;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Export;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> InvokeContextMenuCommand;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MoveSelectionTo;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_SubscriptionsEnabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> CreateSubscriptionForSelection;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> DeleteSubscriptionForSelection;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetRoot;
    }
}
