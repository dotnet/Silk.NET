// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ICastingController.xml' path='doc/member[@name="ICastingController"]/*'/>
[Guid("F0A56423-A664-4FBD-8B43-409A45E8D9A1")]
[NativeTypeName("struct ICastingController : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICastingController : ICastingController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingController));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICastingController*, Guid*, void**, int> )(lpVtbl[0]))((ICastingController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICastingController*, uint> )(lpVtbl[1]))((ICastingController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICastingController*, uint> )(lpVtbl[2]))((ICastingController*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICastingController.xml' path='doc/member[@name="ICastingController.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IUnknown* castingEngine, IUnknown* castingSource)
    {
        return ((delegate* unmanaged<ICastingController*, IUnknown*, IUnknown*, int> )(lpVtbl[3]))((ICastingController*)Unsafe.AsPointer(ref this), castingEngine, castingSource);
    }

    /// <include file='ICastingController.xml' path='doc/member[@name="ICastingController.Connect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Connect()
    {
        return ((delegate* unmanaged<ICastingController*, int> )(lpVtbl[4]))((ICastingController*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICastingController.xml' path='doc/member[@name="ICastingController.Disconnect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<ICastingController*, int> )(lpVtbl[5]))((ICastingController*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICastingController.xml' path='doc/member[@name="ICastingController.Advise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Advise(ICastingEventHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie)
    {
        return ((delegate* unmanaged<ICastingController*, ICastingEventHandler*, uint*, int> )(lpVtbl[6]))((ICastingController*)Unsafe.AsPointer(ref this), eventHandler, cookie);
    }

    /// <include file='ICastingController.xml' path='doc/member[@name="ICastingController.UnAdvise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnAdvise([NativeTypeName("DWORD")] uint cookie)
    {
        return ((delegate* unmanaged<ICastingController*, uint, int> )(lpVtbl[7]))((ICastingController*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(IUnknown* castingEngine, IUnknown* castingSource);
        [VtblIndex(4)]
        HRESULT Connect();
        [VtblIndex(5)]
        HRESULT Disconnect();
        [VtblIndex(6)]
        HRESULT Advise(ICastingEventHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie);
        [VtblIndex(7)]
        HRESULT UnAdvise([NativeTypeName("DWORD")] uint cookie);
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
        [NativeTypeName("HRESULT (IUnknown *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IUnknown*, int> Initialize;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Connect;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disconnect;
        [NativeTypeName("HRESULT (ICastingEventHandler *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICastingEventHandler*, uint*, int> Advise;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnAdvise;
    }
}