// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDropTarget.xml' path='doc/member[@name="IDropTarget"]/*'/>
[Guid("00000122-0000-0000-C000-000000000046")]
[NativeTypeName("struct IDropTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDropTarget : IDropTarget.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDropTarget));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDropTarget*, Guid*, void**, int> )(lpVtbl[0]))((IDropTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDropTarget*, uint> )(lpVtbl[1]))((IDropTarget*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDropTarget*, uint> )(lpVtbl[2]))((IDropTarget*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDropTarget.xml' path='doc/member[@name="IDropTarget.DragEnter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DragEnter(IDataObject* pDataObj, [NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect)
    {
        return ((delegate* unmanaged<IDropTarget*, IDataObject*, uint, POINTL, uint*, int> )(lpVtbl[3]))((IDropTarget*)Unsafe.AsPointer(ref this), pDataObj, grfKeyState, pt, pdwEffect);
    }

    /// <include file='IDropTarget.xml' path='doc/member[@name="IDropTarget.DragOver"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DragOver([NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect)
    {
        return ((delegate* unmanaged<IDropTarget*, uint, POINTL, uint*, int> )(lpVtbl[4]))((IDropTarget*)Unsafe.AsPointer(ref this), grfKeyState, pt, pdwEffect);
    }

    /// <include file='IDropTarget.xml' path='doc/member[@name="IDropTarget.DragLeave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DragLeave()
    {
        return ((delegate* unmanaged<IDropTarget*, int> )(lpVtbl[5]))((IDropTarget*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDropTarget.xml' path='doc/member[@name="IDropTarget.Drop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Drop(IDataObject* pDataObj, [NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect)
    {
        return ((delegate* unmanaged<IDropTarget*, IDataObject*, uint, POINTL, uint*, int> )(lpVtbl[6]))((IDropTarget*)Unsafe.AsPointer(ref this), pDataObj, grfKeyState, pt, pdwEffect);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DragEnter(IDataObject* pDataObj, [NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect);
        [VtblIndex(4)]
        HRESULT DragOver([NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect);
        [VtblIndex(5)]
        HRESULT DragLeave();
        [VtblIndex(6)]
        HRESULT Drop(IDataObject* pDataObj, [NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect);
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
        [NativeTypeName("HRESULT (IDataObject *, DWORD, POINTL, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject*, uint, POINTL, uint*, int> DragEnter;
        [NativeTypeName("HRESULT (DWORD, POINTL, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, POINTL, uint*, int> DragOver;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DragLeave;
        [NativeTypeName("HRESULT (IDataObject *, DWORD, POINTL, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject*, uint, POINTL, uint*, int> Drop;
    }
}