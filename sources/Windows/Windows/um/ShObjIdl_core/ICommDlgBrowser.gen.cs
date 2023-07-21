// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ICommDlgBrowser.xml' path='doc/member[@name="ICommDlgBrowser"]/*' />
[Guid("000214F1-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICommDlgBrowser : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICommDlgBrowser : ICommDlgBrowser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICommDlgBrowser));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICommDlgBrowser*, Guid*, void**, int>)(lpVtbl[0]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICommDlgBrowser*, uint>)(lpVtbl[1]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICommDlgBrowser*, uint>)(lpVtbl[2]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommDlgBrowser.xml' path='doc/member[@name="ICommDlgBrowser.OnDefaultCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnDefaultCommand(IShellView* ppshv)
    {
        return ((delegate* unmanaged<ICommDlgBrowser*, IShellView*, int>)(lpVtbl[3]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this), ppshv);
    }

    /// <include file='ICommDlgBrowser.xml' path='doc/member[@name="ICommDlgBrowser.OnStateChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnStateChange(IShellView* ppshv, [NativeTypeName("ULONG")] uint uChange)
    {
        return ((delegate* unmanaged<ICommDlgBrowser*, IShellView*, uint, int>)(lpVtbl[4]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this), ppshv, uChange);
    }

    /// <include file='ICommDlgBrowser.xml' path='doc/member[@name="ICommDlgBrowser.IncludeObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IncludeObject(IShellView* ppshv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<ICommDlgBrowser*, IShellView*, ITEMIDLIST*, int>)(lpVtbl[5]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this), ppshv, pidl);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnDefaultCommand(IShellView* ppshv);

        [VtblIndex(4)]
        HRESULT OnStateChange(IShellView* ppshv, [NativeTypeName("ULONG")] uint uChange);

        [VtblIndex(5)]
        HRESULT IncludeObject(IShellView* ppshv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
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

        [NativeTypeName("HRESULT (IShellView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView*, int> OnDefaultCommand;

        [NativeTypeName("HRESULT (IShellView *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView*, uint, int> OnStateChange;

        [NativeTypeName("HRESULT (IShellView *, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView*, ITEMIDLIST*, int> IncludeObject;
    }
}
