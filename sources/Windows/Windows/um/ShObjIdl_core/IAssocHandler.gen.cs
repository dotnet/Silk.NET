// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAssocHandler.xml' path='doc/member[@name="IAssocHandler"]/*'/>
[Guid("F04061AC-1659-4A3F-A954-775AA57FC083")]
[NativeTypeName("struct IAssocHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAssocHandler : IAssocHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAssocHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAssocHandler*, Guid*, void**, int> )(lpVtbl[0]))((IAssocHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAssocHandler*, uint> )(lpVtbl[1]))((IAssocHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAssocHandler*, uint> )(lpVtbl[2]))((IAssocHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAssocHandler.xml' path='doc/member[@name="IAssocHandler.GetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppsz)
    {
        return ((delegate* unmanaged<IAssocHandler*, ushort**, int> )(lpVtbl[3]))((IAssocHandler*)Unsafe.AsPointer(ref this), ppsz);
    }

    /// <include file='IAssocHandler.xml' path='doc/member[@name="IAssocHandler.GetUIName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUIName([NativeTypeName("LPWSTR *")] ushort** ppsz)
    {
        return ((delegate* unmanaged<IAssocHandler*, ushort**, int> )(lpVtbl[4]))((IAssocHandler*)Unsafe.AsPointer(ref this), ppsz);
    }

    /// <include file='IAssocHandler.xml' path='doc/member[@name="IAssocHandler.GetIconLocation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIconLocation([NativeTypeName("LPWSTR *")] ushort** ppszPath, int* pIndex)
    {
        return ((delegate* unmanaged<IAssocHandler*, ushort**, int*, int> )(lpVtbl[5]))((IAssocHandler*)Unsafe.AsPointer(ref this), ppszPath, pIndex);
    }

    /// <include file='IAssocHandler.xml' path='doc/member[@name="IAssocHandler.IsRecommended"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsRecommended()
    {
        return ((delegate* unmanaged<IAssocHandler*, int> )(lpVtbl[6]))((IAssocHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAssocHandler.xml' path='doc/member[@name="IAssocHandler.MakeDefault"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MakeDefault([NativeTypeName("LPCWSTR")] ushort* pszDescription)
    {
        return ((delegate* unmanaged<IAssocHandler*, ushort*, int> )(lpVtbl[7]))((IAssocHandler*)Unsafe.AsPointer(ref this), pszDescription);
    }

    /// <include file='IAssocHandler.xml' path='doc/member[@name="IAssocHandler.Invoke"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Invoke(IDataObject* pdo)
    {
        return ((delegate* unmanaged<IAssocHandler*, IDataObject*, int> )(lpVtbl[8]))((IAssocHandler*)Unsafe.AsPointer(ref this), pdo);
    }

    /// <include file='IAssocHandler.xml' path='doc/member[@name="IAssocHandler.CreateInvoker"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateInvoker(IDataObject* pdo, IAssocHandlerInvoker** ppInvoker)
    {
        return ((delegate* unmanaged<IAssocHandler*, IDataObject*, IAssocHandlerInvoker**, int> )(lpVtbl[9]))((IAssocHandler*)Unsafe.AsPointer(ref this), pdo, ppInvoker);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppsz);
        [VtblIndex(4)]
        HRESULT GetUIName([NativeTypeName("LPWSTR *")] ushort** ppsz);
        [VtblIndex(5)]
        HRESULT GetIconLocation([NativeTypeName("LPWSTR *")] ushort** ppszPath, int* pIndex);
        [VtblIndex(6)]
        HRESULT IsRecommended();
        [VtblIndex(7)]
        HRESULT MakeDefault([NativeTypeName("LPCWSTR")] ushort* pszDescription);
        [VtblIndex(8)]
        HRESULT Invoke(IDataObject* pdo);
        [VtblIndex(9)]
        HRESULT CreateInvoker(IDataObject* pdo, IAssocHandlerInvoker** ppInvoker);
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetUIName;
        [NativeTypeName("HRESULT (LPWSTR *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int*, int> GetIconLocation;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsRecommended;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> MakeDefault;
        [NativeTypeName("HRESULT (IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject*, int> Invoke;
        [NativeTypeName("HRESULT (IDataObject *, IAssocHandlerInvoker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject*, IAssocHandlerInvoker**, int> CreateInvoker;
    }
}