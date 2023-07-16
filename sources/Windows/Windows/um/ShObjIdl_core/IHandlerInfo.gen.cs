// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHandlerInfo.xml' path='doc/member[@name="IHandlerInfo"]/*'/>
[Guid("997706EF-F880-453B-8118-39E1A2D2655A")]
[NativeTypeName("struct IHandlerInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHandlerInfo : IHandlerInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHandlerInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHandlerInfo*, Guid*, void**, int> )(lpVtbl[0]))((IHandlerInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHandlerInfo*, uint> )(lpVtbl[1]))((IHandlerInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHandlerInfo*, uint> )(lpVtbl[2]))((IHandlerInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHandlerInfo.xml' path='doc/member[@name="IHandlerInfo.GetApplicationDisplayName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetApplicationDisplayName([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IHandlerInfo*, ushort**, int> )(lpVtbl[3]))((IHandlerInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHandlerInfo.xml' path='doc/member[@name="IHandlerInfo.GetApplicationPublisher"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetApplicationPublisher([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IHandlerInfo*, ushort**, int> )(lpVtbl[4]))((IHandlerInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHandlerInfo.xml' path='doc/member[@name="IHandlerInfo.GetApplicationIconReference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetApplicationIconReference([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IHandlerInfo*, ushort**, int> )(lpVtbl[5]))((IHandlerInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetApplicationDisplayName([NativeTypeName("LPWSTR *")] ushort** value);
        [VtblIndex(4)]
        HRESULT GetApplicationPublisher([NativeTypeName("LPWSTR *")] ushort** value);
        [VtblIndex(5)]
        HRESULT GetApplicationIconReference([NativeTypeName("LPWSTR *")] ushort** value);
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
        public delegate* unmanaged<TSelf*, ushort**, int> GetApplicationDisplayName;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetApplicationPublisher;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetApplicationIconReference;
    }
}