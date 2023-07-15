// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IShellItem.xml' path='doc/member[@name="IShellItem"]/*'/>
[Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
[NativeTypeName("struct IShellItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellItem : IShellItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellItem));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellItem*, Guid*, void**, int> )(lpVtbl[0]))((IShellItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellItem*, uint> )(lpVtbl[1]))((IShellItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellItem*, uint> )(lpVtbl[2]))((IShellItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellItem.xml' path='doc/member[@name="IShellItem.BindToHandler"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BindToHandler(IBindCtx* pbc, [NativeTypeName("const GUID &")] Guid* bhid, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellItem*, IBindCtx*, Guid*, Guid*, void**, int> )(lpVtbl[3]))((IShellItem*)Unsafe.AsPointer(ref this), pbc, bhid, riid, ppv);
    }

    /// <include file='IShellItem.xml' path='doc/member[@name="IShellItem.GetParent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetParent(IShellItem** ppsi)
    {
        return ((delegate* unmanaged<IShellItem*, IShellItem**, int> )(lpVtbl[4]))((IShellItem*)Unsafe.AsPointer(ref this), ppsi);
    }

    /// <include file='IShellItem.xml' path='doc/member[@name="IShellItem.GetDisplayName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDisplayName(SIGDN sigdnName, [NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<IShellItem*, SIGDN, ushort**, int> )(lpVtbl[5]))((IShellItem*)Unsafe.AsPointer(ref this), sigdnName, ppszName);
    }

    /// <include file='IShellItem.xml' path='doc/member[@name="IShellItem.GetAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAttributes([NativeTypeName("SFGAOF")] uint sfgaoMask, [NativeTypeName("SFGAOF *")] uint* psfgaoAttribs)
    {
        return ((delegate* unmanaged<IShellItem*, uint, uint*, int> )(lpVtbl[6]))((IShellItem*)Unsafe.AsPointer(ref this), sfgaoMask, psfgaoAttribs);
    }

    /// <include file='IShellItem.xml' path='doc/member[@name="IShellItem.Compare"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Compare(IShellItem* psi, [NativeTypeName("SICHINTF")] uint hint, int* piOrder)
    {
        return ((delegate* unmanaged<IShellItem*, IShellItem*, uint, int*, int> )(lpVtbl[7]))((IShellItem*)Unsafe.AsPointer(ref this), psi, hint, piOrder);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BindToHandler(IBindCtx* pbc, [NativeTypeName("const GUID &")] Guid* bhid, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(4)]
        HRESULT GetParent(IShellItem** ppsi);
        [VtblIndex(5)]
        HRESULT GetDisplayName(SIGDN sigdnName, [NativeTypeName("LPWSTR *")] ushort** ppszName);
        [VtblIndex(6)]
        HRESULT GetAttributes([NativeTypeName("SFGAOF")] uint sfgaoMask, [NativeTypeName("SFGAOF *")] uint* psfgaoAttribs);
        [VtblIndex(7)]
        HRESULT Compare(IShellItem* psi, [NativeTypeName("SICHINTF")] uint hint, int* piOrder);
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
        [NativeTypeName("HRESULT (IBindCtx *, const GUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, Guid*, Guid*, void**, int> BindToHandler;
        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem**, int> GetParent;
        [NativeTypeName("HRESULT (SIGDN, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIGDN, ushort**, int> GetDisplayName;
        [NativeTypeName("HRESULT (SFGAOF, SFGAOF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetAttributes;
        [NativeTypeName("HRESULT (IShellItem *, SICHINTF, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, uint, int*, int> Compare;
    }
}