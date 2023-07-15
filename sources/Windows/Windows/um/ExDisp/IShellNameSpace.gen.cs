// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace"]/*'/>
[Guid("E572D3C9-37BE-4AE2-825D-D521763E3108")]
[NativeTypeName("struct IShellNameSpace : IShellFavoritesNameSpace")]
[NativeInheritance("IShellFavoritesNameSpace")]
public unsafe partial struct IShellNameSpace : IShellNameSpace.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellNameSpace));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellNameSpace*, Guid*, void**, int> )(lpVtbl[0]))((IShellNameSpace*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellNameSpace*, uint> )(lpVtbl[1]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellNameSpace*, uint> )(lpVtbl[2]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellNameSpace*, uint*, int> )(lpVtbl[3]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IShellNameSpace*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IShellNameSpace*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IShellNameSpace*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IShellNameSpace*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IShellNameSpace*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IShellNameSpace*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.MoveSelectionUp"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MoveSelectionUp()
    {
        return ((delegate* unmanaged<IShellNameSpace*, int> )(lpVtbl[7]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.MoveSelectionDown"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MoveSelectionDown()
    {
        return ((delegate* unmanaged<IShellNameSpace*, int> )(lpVtbl[8]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.ResetSort"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ResetSort()
    {
        return ((delegate* unmanaged<IShellNameSpace*, int> )(lpVtbl[9]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.NewFolder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT NewFolder()
    {
        return ((delegate* unmanaged<IShellNameSpace*, int> )(lpVtbl[10]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.Synchronize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Synchronize()
    {
        return ((delegate* unmanaged<IShellNameSpace*, int> )(lpVtbl[11]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.Import"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Import()
    {
        return ((delegate* unmanaged<IShellNameSpace*, int> )(lpVtbl[12]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.Export"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Export()
    {
        return ((delegate* unmanaged<IShellNameSpace*, int> )(lpVtbl[13]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.InvokeContextMenuCommand"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT InvokeContextMenuCommand([NativeTypeName("BSTR")] ushort* strCommand)
    {
        return ((delegate* unmanaged<IShellNameSpace*, ushort*, int> )(lpVtbl[14]))((IShellNameSpace*)Unsafe.AsPointer(ref this), strCommand);
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.MoveSelectionTo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT MoveSelectionTo()
    {
        return ((delegate* unmanaged<IShellNameSpace*, int> )(lpVtbl[15]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.get_SubscriptionsEnabled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SubscriptionsEnabled([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IShellNameSpace*, short*, int> )(lpVtbl[16]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.CreateSubscriptionForSelection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IShellNameSpace*, short*, int> )(lpVtbl[17]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.DeleteSubscriptionForSelection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DeleteSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IShellNameSpace*, short*, int> )(lpVtbl[18]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <inheritdoc cref = "IShellFavoritesNameSpace.SetRoot"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetRoot([NativeTypeName("BSTR")] ushort* bstrFullPath)
    {
        return ((delegate* unmanaged<IShellNameSpace*, ushort*, int> )(lpVtbl[19]))((IShellNameSpace*)Unsafe.AsPointer(ref this), bstrFullPath);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.get_EnumOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_EnumOptions([NativeTypeName("LONG *")] int* pgrfEnumFlags)
    {
        return ((delegate* unmanaged<IShellNameSpace*, int*, int> )(lpVtbl[20]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pgrfEnumFlags);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.put_EnumOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_EnumOptions([NativeTypeName("LONG")] int lVal)
    {
        return ((delegate* unmanaged<IShellNameSpace*, int, int> )(lpVtbl[21]))((IShellNameSpace*)Unsafe.AsPointer(ref this), lVal);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.get_SelectedItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_SelectedItem(IDispatch** pItem)
    {
        return ((delegate* unmanaged<IShellNameSpace*, IDispatch**, int> )(lpVtbl[22]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pItem);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.put_SelectedItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_SelectedItem(IDispatch* pItem)
    {
        return ((delegate* unmanaged<IShellNameSpace*, IDispatch*, int> )(lpVtbl[23]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pItem);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.get_Root"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Root(VARIANT* pvar)
    {
        return ((delegate* unmanaged<IShellNameSpace*, VARIANT*, int> )(lpVtbl[24]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pvar);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.put_Root"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_Root(VARIANT var)
    {
        return ((delegate* unmanaged<IShellNameSpace*, VARIANT, int> )(lpVtbl[25]))((IShellNameSpace*)Unsafe.AsPointer(ref this), var);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.get_Depth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Depth(int* piDepth)
    {
        return ((delegate* unmanaged<IShellNameSpace*, int*, int> )(lpVtbl[26]))((IShellNameSpace*)Unsafe.AsPointer(ref this), piDepth);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.put_Depth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_Depth(int iDepth)
    {
        return ((delegate* unmanaged<IShellNameSpace*, int, int> )(lpVtbl[27]))((IShellNameSpace*)Unsafe.AsPointer(ref this), iDepth);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.get_Mode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Mode(uint* puMode)
    {
        return ((delegate* unmanaged<IShellNameSpace*, uint*, int> )(lpVtbl[28]))((IShellNameSpace*)Unsafe.AsPointer(ref this), puMode);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.put_Mode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_Mode(uint uMode)
    {
        return ((delegate* unmanaged<IShellNameSpace*, uint, int> )(lpVtbl[29]))((IShellNameSpace*)Unsafe.AsPointer(ref this), uMode);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.get_Flags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_Flags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IShellNameSpace*, uint*, int> )(lpVtbl[30]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.put_Flags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_Flags([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellNameSpace*, uint, int> )(lpVtbl[31]))((IShellNameSpace*)Unsafe.AsPointer(ref this), dwFlags);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.put_TVFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_TVFlags([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellNameSpace*, uint, int> )(lpVtbl[32]))((IShellNameSpace*)Unsafe.AsPointer(ref this), dwFlags);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.get_TVFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_TVFlags([NativeTypeName("DWORD *")] uint* dwFlags)
    {
        return ((delegate* unmanaged<IShellNameSpace*, uint*, int> )(lpVtbl[33]))((IShellNameSpace*)Unsafe.AsPointer(ref this), dwFlags);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.get_Columns"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_Columns([NativeTypeName("BSTR *")] ushort** bstrColumns)
    {
        return ((delegate* unmanaged<IShellNameSpace*, ushort**, int> )(lpVtbl[34]))((IShellNameSpace*)Unsafe.AsPointer(ref this), bstrColumns);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.put_Columns"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_Columns([NativeTypeName("BSTR")] ushort* bstrColumns)
    {
        return ((delegate* unmanaged<IShellNameSpace*, ushort*, int> )(lpVtbl[35]))((IShellNameSpace*)Unsafe.AsPointer(ref this), bstrColumns);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.get_CountViewTypes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_CountViewTypes(int* piTypes)
    {
        return ((delegate* unmanaged<IShellNameSpace*, int*, int> )(lpVtbl[36]))((IShellNameSpace*)Unsafe.AsPointer(ref this), piTypes);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.SetViewType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetViewType(int iType)
    {
        return ((delegate* unmanaged<IShellNameSpace*, int, int> )(lpVtbl[37]))((IShellNameSpace*)Unsafe.AsPointer(ref this), iType);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.SelectedItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT SelectedItems(IDispatch** ppid)
    {
        return ((delegate* unmanaged<IShellNameSpace*, IDispatch**, int> )(lpVtbl[38]))((IShellNameSpace*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.Expand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT Expand(VARIANT var, int iDepth)
    {
        return ((delegate* unmanaged<IShellNameSpace*, VARIANT, int, int> )(lpVtbl[39]))((IShellNameSpace*)Unsafe.AsPointer(ref this), var, iDepth);
    }

    /// <include file='IShellNameSpace.xml' path='doc/member[@name="IShellNameSpace.UnselectAll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT UnselectAll()
    {
        return ((delegate* unmanaged<IShellNameSpace*, int> )(lpVtbl[40]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IShellFavoritesNameSpace.Interface
    {
        [VtblIndex(20)]
        HRESULT get_EnumOptions([NativeTypeName("LONG *")] int* pgrfEnumFlags);
        [VtblIndex(21)]
        HRESULT put_EnumOptions([NativeTypeName("LONG")] int lVal);
        [VtblIndex(22)]
        HRESULT get_SelectedItem(IDispatch** pItem);
        [VtblIndex(23)]
        HRESULT put_SelectedItem(IDispatch* pItem);
        [VtblIndex(24)]
        HRESULT get_Root(VARIANT* pvar);
        [VtblIndex(25)]
        HRESULT put_Root(VARIANT var);
        [VtblIndex(26)]
        HRESULT get_Depth(int* piDepth);
        [VtblIndex(27)]
        HRESULT put_Depth(int iDepth);
        [VtblIndex(28)]
        HRESULT get_Mode(uint* puMode);
        [VtblIndex(29)]
        HRESULT put_Mode(uint uMode);
        [VtblIndex(30)]
        HRESULT get_Flags([NativeTypeName("DWORD *")] uint* pdwFlags);
        [VtblIndex(31)]
        HRESULT put_Flags([NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(32)]
        HRESULT put_TVFlags([NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(33)]
        HRESULT get_TVFlags([NativeTypeName("DWORD *")] uint* dwFlags);
        [VtblIndex(34)]
        HRESULT get_Columns([NativeTypeName("BSTR *")] ushort** bstrColumns);
        [VtblIndex(35)]
        HRESULT put_Columns([NativeTypeName("BSTR")] ushort* bstrColumns);
        [VtblIndex(36)]
        HRESULT get_CountViewTypes(int* piTypes);
        [VtblIndex(37)]
        HRESULT SetViewType(int iType);
        [VtblIndex(38)]
        HRESULT SelectedItems(IDispatch** ppid);
        [VtblIndex(39)]
        HRESULT Expand(VARIANT var, int iDepth);
        [VtblIndex(40)]
        HRESULT UnselectAll();
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
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_EnumOptions;
        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_EnumOptions;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_SelectedItem;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> put_SelectedItem;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_Root;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_Root;
        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Depth;
        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Depth;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Mode;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_Mode;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Flags;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_Flags;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_TVFlags;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_TVFlags;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Columns;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Columns;
        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_CountViewTypes;
        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetViewType;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> SelectedItems;
        [NativeTypeName("HRESULT (VARIANT, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int, int> Expand;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnselectAll;
    }
}