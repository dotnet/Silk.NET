// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDragSourceHelper2.xml' path='doc/member[@name="IDragSourceHelper2"]/*'/>
[Guid("83E07D0D-0C5F-4163-BF1A-60B274051E40")]
[NativeTypeName("struct IDragSourceHelper2 : IDragSourceHelper")]
[NativeInheritance("IDragSourceHelper")]
public unsafe partial struct IDragSourceHelper2 : IDragSourceHelper2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDragSourceHelper2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDragSourceHelper2*, Guid*, void**, int> )(lpVtbl[0]))((IDragSourceHelper2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDragSourceHelper2*, uint> )(lpVtbl[1]))((IDragSourceHelper2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDragSourceHelper2*, uint> )(lpVtbl[2]))((IDragSourceHelper2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDragSourceHelper.InitializeFromBitmap"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeFromBitmap([NativeTypeName("LPSHDRAGIMAGE")] SHDRAGIMAGE* pshdi, IDataObject* pDataObject)
    {
        return ((delegate* unmanaged<IDragSourceHelper2*, SHDRAGIMAGE*, IDataObject*, int> )(lpVtbl[3]))((IDragSourceHelper2*)Unsafe.AsPointer(ref this), pshdi, pDataObject);
    }

    /// <inheritdoc cref = "IDragSourceHelper.InitializeFromWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitializeFromWindow(HWND hwnd, POINT* ppt, IDataObject* pDataObject)
    {
        return ((delegate* unmanaged<IDragSourceHelper2*, HWND, POINT*, IDataObject*, int> )(lpVtbl[4]))((IDragSourceHelper2*)Unsafe.AsPointer(ref this), hwnd, ppt, pDataObject);
    }

    /// <include file='IDragSourceHelper2.xml' path='doc/member[@name="IDragSourceHelper2.SetFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFlags([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IDragSourceHelper2*, uint, int> )(lpVtbl[5]))((IDragSourceHelper2*)Unsafe.AsPointer(ref this), dwFlags);
    }

    public interface Interface : IDragSourceHelper.Interface
    {
        [VtblIndex(5)]
        HRESULT SetFlags([NativeTypeName("DWORD")] uint dwFlags);
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
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetFlags;
    }
}