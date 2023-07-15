// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDragSourceHelper.xml' path='doc/member[@name="IDragSourceHelper"]/*'/>
[Guid("DE5BF786-477A-11D2-839D-00C04FD918D0")]
[NativeTypeName("struct IDragSourceHelper : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDragSourceHelper : IDragSourceHelper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDragSourceHelper));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDragSourceHelper*, Guid*, void**, int> )(lpVtbl[0]))((IDragSourceHelper*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDragSourceHelper*, uint> )(lpVtbl[1]))((IDragSourceHelper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDragSourceHelper*, uint> )(lpVtbl[2]))((IDragSourceHelper*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDragSourceHelper.xml' path='doc/member[@name="IDragSourceHelper.InitializeFromBitmap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeFromBitmap([NativeTypeName("LPSHDRAGIMAGE")] SHDRAGIMAGE* pshdi, IDataObject* pDataObject)
    {
        return ((delegate* unmanaged<IDragSourceHelper*, SHDRAGIMAGE*, IDataObject*, int> )(lpVtbl[3]))((IDragSourceHelper*)Unsafe.AsPointer(ref this), pshdi, pDataObject);
    }

    /// <include file='IDragSourceHelper.xml' path='doc/member[@name="IDragSourceHelper.InitializeFromWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitializeFromWindow(HWND hwnd, POINT* ppt, IDataObject* pDataObject)
    {
        return ((delegate* unmanaged<IDragSourceHelper*, HWND, POINT*, IDataObject*, int> )(lpVtbl[4]))((IDragSourceHelper*)Unsafe.AsPointer(ref this), hwnd, ppt, pDataObject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeFromBitmap([NativeTypeName("LPSHDRAGIMAGE")] SHDRAGIMAGE* pshdi, IDataObject* pDataObject);
        [VtblIndex(4)]
        HRESULT InitializeFromWindow(HWND hwnd, POINT* ppt, IDataObject* pDataObject);
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
        [NativeTypeName("HRESULT (LPSHDRAGIMAGE, IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SHDRAGIMAGE*, IDataObject*, int> InitializeFromBitmap;
        [NativeTypeName("HRESULT (HWND, POINT *, IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, POINT*, IDataObject*, int> InitializeFromWindow;
    }
}