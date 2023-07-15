// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHWEventHandler2.xml' path='doc/member[@name="IHWEventHandler2"]/*'/>
[Guid("CFCC809F-295D-42E8-9FFC-424B33C487E6")]
[NativeTypeName("struct IHWEventHandler2 : IHWEventHandler")]
[NativeInheritance("IHWEventHandler")]
public unsafe partial struct IHWEventHandler2 : IHWEventHandler2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHWEventHandler2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHWEventHandler2*, Guid*, void**, int> )(lpVtbl[0]))((IHWEventHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHWEventHandler2*, uint> )(lpVtbl[1]))((IHWEventHandler2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHWEventHandler2*, uint> )(lpVtbl[2]))((IHWEventHandler2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IHWEventHandler.Initialize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("LPCWSTR")] ushort* pszParams)
    {
        return ((delegate* unmanaged<IHWEventHandler2*, ushort*, int> )(lpVtbl[3]))((IHWEventHandler2*)Unsafe.AsPointer(ref this), pszParams);
    }

    /// <inheritdoc cref = "IHWEventHandler.HandleEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT HandleEvent([NativeTypeName("LPCWSTR")] ushort* pszDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszEventType)
    {
        return ((delegate* unmanaged<IHWEventHandler2*, ushort*, ushort*, ushort*, int> )(lpVtbl[4]))((IHWEventHandler2*)Unsafe.AsPointer(ref this), pszDeviceID, pszAltDeviceID, pszEventType);
    }

    /// <inheritdoc cref = "IHWEventHandler.HandleEventWithContent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT HandleEventWithContent([NativeTypeName("LPCWSTR")] ushort* pszDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszEventType, [NativeTypeName("LPCWSTR")] ushort* pszContentTypeHandler, IDataObject* pdataobject)
    {
        return ((delegate* unmanaged<IHWEventHandler2*, ushort*, ushort*, ushort*, ushort*, IDataObject*, int> )(lpVtbl[5]))((IHWEventHandler2*)Unsafe.AsPointer(ref this), pszDeviceID, pszAltDeviceID, pszEventType, pszContentTypeHandler, pdataobject);
    }

    /// <include file='IHWEventHandler2.xml' path='doc/member[@name="IHWEventHandler2.HandleEventWithHWND"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT HandleEventWithHWND([NativeTypeName("LPCWSTR")] ushort* pszDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszEventType, HWND hwndOwner)
    {
        return ((delegate* unmanaged<IHWEventHandler2*, ushort*, ushort*, ushort*, HWND, int> )(lpVtbl[6]))((IHWEventHandler2*)Unsafe.AsPointer(ref this), pszDeviceID, pszAltDeviceID, pszEventType, hwndOwner);
    }

    public interface Interface : IHWEventHandler.Interface
    {
        [VtblIndex(6)]
        HRESULT HandleEventWithHWND([NativeTypeName("LPCWSTR")] ushort* pszDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszEventType, HWND hwndOwner);
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
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Initialize;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> HandleEvent;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, ushort*, IDataObject*, int> HandleEventWithContent;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, HWND, int> HandleEventWithHWND;
    }
}