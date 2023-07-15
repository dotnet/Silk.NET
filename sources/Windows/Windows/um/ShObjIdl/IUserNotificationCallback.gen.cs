// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUserNotificationCallback.xml' path='doc/member[@name="IUserNotificationCallback"]/*'/>
[Guid("19108294-0441-4AFF-8013-FA0A730B0BEA")]
[NativeTypeName("struct IUserNotificationCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUserNotificationCallback : IUserNotificationCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserNotificationCallback));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserNotificationCallback*, Guid*, void**, int> )(lpVtbl[0]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUserNotificationCallback*, uint> )(lpVtbl[1]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserNotificationCallback*, uint> )(lpVtbl[2]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUserNotificationCallback.xml' path='doc/member[@name="IUserNotificationCallback.OnBalloonUserClick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnBalloonUserClick(POINT* pt)
    {
        return ((delegate* unmanaged<IUserNotificationCallback*, POINT*, int> )(lpVtbl[3]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this), pt);
    }

    /// <include file='IUserNotificationCallback.xml' path='doc/member[@name="IUserNotificationCallback.OnLeftClick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnLeftClick(POINT* pt)
    {
        return ((delegate* unmanaged<IUserNotificationCallback*, POINT*, int> )(lpVtbl[4]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this), pt);
    }

    /// <include file='IUserNotificationCallback.xml' path='doc/member[@name="IUserNotificationCallback.OnContextMenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnContextMenu(POINT* pt)
    {
        return ((delegate* unmanaged<IUserNotificationCallback*, POINT*, int> )(lpVtbl[5]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this), pt);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnBalloonUserClick(POINT* pt);
        [VtblIndex(4)]
        HRESULT OnLeftClick(POINT* pt);
        [VtblIndex(5)]
        HRESULT OnContextMenu(POINT* pt);
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
        [NativeTypeName("HRESULT (POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, int> OnBalloonUserClick;
        [NativeTypeName("HRESULT (POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, int> OnLeftClick;
        [NativeTypeName("HRESULT (POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, int> OnContextMenu;
    }
}