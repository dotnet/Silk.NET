// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ICoreWindowAdapterInterop.xml' path='doc/member[@name="ICoreWindowAdapterInterop"]/*'/>
[Guid("7A5B6FD1-CD73-4B6C-9CF4-2E869EAF470A")]
[NativeTypeName("struct ICoreWindowAdapterInterop : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindowAdapterInterop : ICoreWindowAdapterInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindowAdapterInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, Guid*, void**, int> )(lpVtbl[0]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, uint> )(lpVtbl[1]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, uint> )(lpVtbl[2]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, uint*, Guid**, int> )(lpVtbl[3]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, HSTRING*, int> )(lpVtbl[4]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, TrustLevel*, int> )(lpVtbl[5]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreWindowAdapterInterop.xml' path='doc/member[@name="ICoreWindowAdapterInterop.get_AppActivationClientAdapter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppActivationClientAdapter(IUnknown** value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> )(lpVtbl[6]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowAdapterInterop.xml' path='doc/member[@name="ICoreWindowAdapterInterop.get_ApplicationViewClientAdapter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ApplicationViewClientAdapter(IUnknown** value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> )(lpVtbl[7]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowAdapterInterop.xml' path='doc/member[@name="ICoreWindowAdapterInterop.get_CoreApplicationViewClientAdapter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CoreApplicationViewClientAdapter(IUnknown** value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> )(lpVtbl[8]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowAdapterInterop.xml' path='doc/member[@name="ICoreWindowAdapterInterop.get_HoloViewClientAdapter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HoloViewClientAdapter(IUnknown** value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> )(lpVtbl[9]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowAdapterInterop.xml' path='doc/member[@name="ICoreWindowAdapterInterop.get_PositionerClientAdapter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PositionerClientAdapter(IUnknown** value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> )(lpVtbl[10]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowAdapterInterop.xml' path='doc/member[@name="ICoreWindowAdapterInterop.get_SystemNavigationClientAdapter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SystemNavigationClientAdapter(IUnknown** value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> )(lpVtbl[11]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowAdapterInterop.xml' path='doc/member[@name="ICoreWindowAdapterInterop.get_TitleBarClientAdapter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_TitleBarClientAdapter(IUnknown** value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> )(lpVtbl[12]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowAdapterInterop.xml' path='doc/member[@name="ICoreWindowAdapterInterop.SetWindowClientAdapter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetWindowClientAdapter(IUnknown* value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown*, int> )(lpVtbl[13]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppActivationClientAdapter(IUnknown** value);
        [VtblIndex(7)]
        HRESULT get_ApplicationViewClientAdapter(IUnknown** value);
        [VtblIndex(8)]
        HRESULT get_CoreApplicationViewClientAdapter(IUnknown** value);
        [VtblIndex(9)]
        HRESULT get_HoloViewClientAdapter(IUnknown** value);
        [VtblIndex(10)]
        HRESULT get_PositionerClientAdapter(IUnknown** value);
        [VtblIndex(11)]
        HRESULT get_SystemNavigationClientAdapter(IUnknown** value);
        [VtblIndex(12)]
        HRESULT get_TitleBarClientAdapter(IUnknown** value);
        [VtblIndex(13)]
        HRESULT SetWindowClientAdapter(IUnknown* value);
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
        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;
        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;
        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get_AppActivationClientAdapter;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get_ApplicationViewClientAdapter;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get_CoreApplicationViewClientAdapter;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get_HoloViewClientAdapter;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get_PositionerClientAdapter;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get_SystemNavigationClientAdapter;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get_TitleBarClientAdapter;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetWindowClientAdapter;
    }
}