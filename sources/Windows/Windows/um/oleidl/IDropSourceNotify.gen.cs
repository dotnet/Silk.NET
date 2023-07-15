// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDropSourceNotify.xml' path='doc/member[@name="IDropSourceNotify"]/*'/>
[Guid("0000012B-0000-0000-C000-000000000046")]
[NativeTypeName("struct IDropSourceNotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDropSourceNotify : IDropSourceNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDropSourceNotify));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDropSourceNotify*, Guid*, void**, int> )(lpVtbl[0]))((IDropSourceNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDropSourceNotify*, uint> )(lpVtbl[1]))((IDropSourceNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDropSourceNotify*, uint> )(lpVtbl[2]))((IDropSourceNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDropSourceNotify.xml' path='doc/member[@name="IDropSourceNotify.DragEnterTarget"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DragEnterTarget(HWND hwndTarget)
    {
        return ((delegate* unmanaged<IDropSourceNotify*, HWND, int> )(lpVtbl[3]))((IDropSourceNotify*)Unsafe.AsPointer(ref this), hwndTarget);
    }

    /// <include file='IDropSourceNotify.xml' path='doc/member[@name="IDropSourceNotify.DragLeaveTarget"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DragLeaveTarget()
    {
        return ((delegate* unmanaged<IDropSourceNotify*, int> )(lpVtbl[4]))((IDropSourceNotify*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DragEnterTarget(HWND hwndTarget);
        [VtblIndex(4)]
        HRESULT DragLeaveTarget();
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
        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> DragEnterTarget;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DragLeaveTarget;
    }
}