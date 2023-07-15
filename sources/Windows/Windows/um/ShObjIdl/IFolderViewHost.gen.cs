// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFolderViewHost.xml' path='doc/member[@name="IFolderViewHost"]/*'/>
[Guid("1EA58F02-D55A-411D-B09E-9E65AC21605B")]
[NativeTypeName("struct IFolderViewHost : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFolderViewHost : IFolderViewHost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFolderViewHost));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFolderViewHost*, Guid*, void**, int> )(lpVtbl[0]))((IFolderViewHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFolderViewHost*, uint> )(lpVtbl[1]))((IFolderViewHost*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFolderViewHost*, uint> )(lpVtbl[2]))((IFolderViewHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFolderViewHost.xml' path='doc/member[@name="IFolderViewHost.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(HWND hwndParent, IDataObject* pdo, RECT* prc)
    {
        return ((delegate* unmanaged<IFolderViewHost*, HWND, IDataObject*, RECT*, int> )(lpVtbl[3]))((IFolderViewHost*)Unsafe.AsPointer(ref this), hwndParent, pdo, prc);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(HWND hwndParent, IDataObject* pdo, RECT* prc);
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
        [NativeTypeName("HRESULT (HWND, IDataObject *, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IDataObject*, RECT*, int> Initialize;
    }
}