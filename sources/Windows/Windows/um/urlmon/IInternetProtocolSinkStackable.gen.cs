// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IInternetProtocolSinkStackable.xml' path='doc/member[@name="IInternetProtocolSinkStackable"]/*'/>
[Guid("79EAC9F0-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetProtocolSinkStackable : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetProtocolSinkStackable : IInternetProtocolSinkStackable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolSinkStackable));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetProtocolSinkStackable*, Guid*, void**, int> )(lpVtbl[0]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetProtocolSinkStackable*, uint> )(lpVtbl[1]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetProtocolSinkStackable*, uint> )(lpVtbl[2]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInternetProtocolSinkStackable.xml' path='doc/member[@name="IInternetProtocolSinkStackable.SwitchSink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SwitchSink(IInternetProtocolSink* pOIProtSink)
    {
        return ((delegate* unmanaged<IInternetProtocolSinkStackable*, IInternetProtocolSink*, int> )(lpVtbl[3]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this), pOIProtSink);
    }

    /// <include file='IInternetProtocolSinkStackable.xml' path='doc/member[@name="IInternetProtocolSinkStackable.CommitSwitch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CommitSwitch()
    {
        return ((delegate* unmanaged<IInternetProtocolSinkStackable*, int> )(lpVtbl[4]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInternetProtocolSinkStackable.xml' path='doc/member[@name="IInternetProtocolSinkStackable.RollbackSwitch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RollbackSwitch()
    {
        return ((delegate* unmanaged<IInternetProtocolSinkStackable*, int> )(lpVtbl[5]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SwitchSink(IInternetProtocolSink* pOIProtSink);
        [VtblIndex(4)]
        HRESULT CommitSwitch();
        [VtblIndex(5)]
        HRESULT RollbackSwitch();
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
        [NativeTypeName("HRESULT (IInternetProtocolSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInternetProtocolSink*, int> SwitchSink;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CommitSwitch;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RollbackSwitch;
    }
}