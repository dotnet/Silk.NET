// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ICoreInputInterop.xml' path='doc/member[@name="ICoreInputInterop"]/*'/>
[Guid("40BFE3E3-B75A-4479-AC96-475365749BB8")]
[NativeTypeName("struct ICoreInputInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICoreInputInterop : ICoreInputInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreInputInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreInputInterop*, Guid*, void**, int> )(lpVtbl[0]))((ICoreInputInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICoreInputInterop*, uint> )(lpVtbl[1]))((ICoreInputInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreInputInterop*, uint> )(lpVtbl[2]))((ICoreInputInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoreInputInterop.xml' path='doc/member[@name="ICoreInputInterop.SetInputSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInputSource(IUnknown* value)
    {
        return ((delegate* unmanaged<ICoreInputInterop*, IUnknown*, int> )(lpVtbl[3]))((ICoreInputInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputInterop.xml' path='doc/member[@name="ICoreInputInterop.put_MessageHandled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_MessageHandled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICoreInputInterop*, byte, int> )(lpVtbl[4]))((ICoreInputInterop*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetInputSource(IUnknown* value);
        [VtblIndex(4)]
        HRESULT put_MessageHandled([NativeTypeName("boolean")] byte value);
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
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetInputSource;
        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_MessageHandled;
    }
}