// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/knownfolderpathscom.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IUserDataPathsInterop.xml' path='doc/member[@name="IUserDataPathsInterop"]/*'/>
[Guid("F12EF0B5-BEFB-46C9-9EE5-8A0681F13F8C")]
[NativeTypeName("struct IUserDataPathsInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUserDataPathsInterop : IUserDataPathsInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataPathsInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop*, Guid*, void**, int> )(lpVtbl[0]))((IUserDataPathsInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUserDataPathsInterop*, uint> )(lpVtbl[1]))((IUserDataPathsInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserDataPathsInterop*, uint> )(lpVtbl[2]))((IUserDataPathsInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUserDataPathsInterop.xml' path='doc/member[@name="IUserDataPathsInterop.get_AdminTools"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_AdminTools([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop*, ushort**, int> )(lpVtbl[3]))((IUserDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPathsInterop.xml' path='doc/member[@name="IUserDataPathsInterop.get_CDBurning"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_CDBurning([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop*, ushort**, int> )(lpVtbl[4]))((IUserDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPathsInterop.xml' path='doc/member[@name="IUserDataPathsInterop.get_NetworkShortcuts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_NetworkShortcuts([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop*, ushort**, int> )(lpVtbl[5]))((IUserDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPathsInterop.xml' path='doc/member[@name="IUserDataPathsInterop.get_Programs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Programs([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop*, ushort**, int> )(lpVtbl[6]))((IUserDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPathsInterop.xml' path='doc/member[@name="IUserDataPathsInterop.get_SendTo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SendTo([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop*, ushort**, int> )(lpVtbl[7]))((IUserDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPathsInterop.xml' path='doc/member[@name="IUserDataPathsInterop.get_StartMenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_StartMenu([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop*, ushort**, int> )(lpVtbl[8]))((IUserDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataPathsInterop.xml' path='doc/member[@name="IUserDataPathsInterop.get_Startup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Startup([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop*, ushort**, int> )(lpVtbl[9]))((IUserDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_AdminTools([NativeTypeName("LPWSTR *")] ushort** value);
        [VtblIndex(4)]
        HRESULT get_CDBurning([NativeTypeName("LPWSTR *")] ushort** value);
        [VtblIndex(5)]
        HRESULT get_NetworkShortcuts([NativeTypeName("LPWSTR *")] ushort** value);
        [VtblIndex(6)]
        HRESULT get_Programs([NativeTypeName("LPWSTR *")] ushort** value);
        [VtblIndex(7)]
        HRESULT get_SendTo([NativeTypeName("LPWSTR *")] ushort** value);
        [VtblIndex(8)]
        HRESULT get_StartMenu([NativeTypeName("LPWSTR *")] ushort** value);
        [VtblIndex(9)]
        HRESULT get_Startup([NativeTypeName("LPWSTR *")] ushort** value);
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_AdminTools;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_CDBurning;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_NetworkShortcuts;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Programs;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_SendTo;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_StartMenu;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Startup;
    }
}