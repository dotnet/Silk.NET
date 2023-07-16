// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IMessageDispatcher.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IMessageDispatcher.xml' path='doc/member[@name="IMessageDispatcher"]/*'/>
[Guid("F5F84C8F-CFD0-4CD6-B66B-C5D26FF1689D")]
[NativeTypeName("struct IMessageDispatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMessageDispatcher : IMessageDispatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMessageDispatcher));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMessageDispatcher*, Guid*, void**, int> )(lpVtbl[0]))((IMessageDispatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMessageDispatcher*, uint> )(lpVtbl[1]))((IMessageDispatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMessageDispatcher*, uint> )(lpVtbl[2]))((IMessageDispatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IMessageDispatcher*, uint*, Guid**, int> )(lpVtbl[3]))((IMessageDispatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMessageDispatcher*, HSTRING*, int> )(lpVtbl[4]))((IMessageDispatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMessageDispatcher*, TrustLevel*, int> )(lpVtbl[5]))((IMessageDispatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMessageDispatcher.xml' path='doc/member[@name="IMessageDispatcher.PumpMessages"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PumpMessages()
    {
        return ((delegate* unmanaged<IMessageDispatcher*, int> )(lpVtbl[6]))((IMessageDispatcher*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT PumpMessages();
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PumpMessages;
    }
}