// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ICompositionGraphicsDeviceInterop.xml' path='doc/member[@name="ICompositionGraphicsDeviceInterop"]/*'/>
[Guid("A116FF71-F8BF-4C8A-9C98-70779A32A9C8")]
[NativeTypeName("struct ICompositionGraphicsDeviceInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositionGraphicsDeviceInterop : ICompositionGraphicsDeviceInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGraphicsDeviceInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop*, Guid*, void**, int> )(lpVtbl[0]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop*, uint> )(lpVtbl[1]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop*, uint> )(lpVtbl[2]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositionGraphicsDeviceInterop.xml' path='doc/member[@name="ICompositionGraphicsDeviceInterop.GetRenderingDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRenderingDevice(IUnknown** value)
    {
        return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop*, IUnknown**, int> )(lpVtbl[3]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionGraphicsDeviceInterop.xml' path='doc/member[@name="ICompositionGraphicsDeviceInterop.SetRenderingDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetRenderingDevice(IUnknown* value)
    {
        return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop*, IUnknown*, int> )(lpVtbl[4]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRenderingDevice(IUnknown** value);
        [VtblIndex(4)]
        HRESULT SetRenderingDevice(IUnknown* value);
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
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> GetRenderingDevice;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetRenderingDevice;
    }
}