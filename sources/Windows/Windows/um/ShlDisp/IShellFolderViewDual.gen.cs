// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IShellFolderViewDual.xml' path='doc/member[@name="IShellFolderViewDual"]/*' />
[Guid("E7A1AF80-4D96-11CF-960C-0080C7F4EE85")]
[NativeTypeName("struct IShellFolderViewDual : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IShellFolderViewDual : IShellFolderViewDual.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellFolderViewDual));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, uint>)(lpVtbl[1]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, uint>)(lpVtbl[2]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, uint*, int>)(lpVtbl[3]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IShellFolderViewDual.xml' path='doc/member[@name="IShellFolderViewDual.get_Application"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Application(IDispatch** ppid)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, IDispatch**, int>)(lpVtbl[7]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='IShellFolderViewDual.xml' path='doc/member[@name="IShellFolderViewDual.get_Parent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Parent(IDispatch** ppid)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, IDispatch**, int>)(lpVtbl[8]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='IShellFolderViewDual.xml' path='doc/member[@name="IShellFolderViewDual.get_Folder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Folder(Folder** ppid)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, Folder**, int>)(lpVtbl[9]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='IShellFolderViewDual.xml' path='doc/member[@name="IShellFolderViewDual.SelectedItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SelectedItems(FolderItems** ppid)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, FolderItems**, int>)(lpVtbl[10]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='IShellFolderViewDual.xml' path='doc/member[@name="IShellFolderViewDual.get_FocusedItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_FocusedItem(FolderItem** ppid)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, FolderItem**, int>)(lpVtbl[11]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='IShellFolderViewDual.xml' path='doc/member[@name="IShellFolderViewDual.SelectItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SelectItem(VARIANT* pvfi, int dwFlags)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, VARIANT*, int, int>)(lpVtbl[12]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), pvfi, dwFlags);
    }

    /// <include file='IShellFolderViewDual.xml' path='doc/member[@name="IShellFolderViewDual.PopupItemMenu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT PopupItemMenu(FolderItem* pfi, VARIANT vx, VARIANT vy, [NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, FolderItem*, VARIANT, VARIANT, ushort**, int>)(lpVtbl[13]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), pfi, vx, vy, pbs);
    }

    /// <include file='IShellFolderViewDual.xml' path='doc/member[@name="IShellFolderViewDual.get_Script"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Script(IDispatch** ppDisp)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, IDispatch**, int>)(lpVtbl[14]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppDisp);
    }

    /// <include file='IShellFolderViewDual.xml' path='doc/member[@name="IShellFolderViewDual.get_ViewOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ViewOptions([NativeTypeName("long *")] int* plViewOptions)
    {
        return ((delegate* unmanaged<IShellFolderViewDual*, int*, int>)(lpVtbl[15]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), plViewOptions);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Application(IDispatch** ppid);

        [VtblIndex(8)]
        HRESULT get_Parent(IDispatch** ppid);

        [VtblIndex(9)]
        HRESULT get_Folder(Folder** ppid);

        [VtblIndex(10)]
        HRESULT SelectedItems(FolderItems** ppid);

        [VtblIndex(11)]
        HRESULT get_FocusedItem(FolderItem** ppid);

        [VtblIndex(12)]
        HRESULT SelectItem(VARIANT* pvfi, int dwFlags);

        [VtblIndex(13)]
        HRESULT PopupItemMenu(FolderItem* pfi, VARIANT vx, VARIANT vy, [NativeTypeName("BSTR *")] ushort** pbs);

        [VtblIndex(14)]
        HRESULT get_Script(IDispatch** ppDisp);

        [VtblIndex(15)]
        HRESULT get_ViewOptions([NativeTypeName("long *")] int* plViewOptions);
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

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Application;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Parent;

        [NativeTypeName("HRESULT (Folder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Folder**, int> get_Folder;

        [NativeTypeName("HRESULT (FolderItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItems**, int> SelectedItems;

        [NativeTypeName("HRESULT (FolderItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItem**, int> get_FocusedItem;

        [NativeTypeName("HRESULT (VARIANT *, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int, int> SelectItem;

        [NativeTypeName("HRESULT (FolderItem *, VARIANT, VARIANT, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItem*, VARIANT, VARIANT, ushort**, int> PopupItemMenu;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Script;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ViewOptions;
    }
}
