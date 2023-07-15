// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Graphics.Capture.Interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IGraphicsCaptureItemInterop.xml' path='doc/member[@name="IGraphicsCaptureItemInterop"]/*'/>
[Guid("3628E81B-3CAC-4C60-B7F4-23CE0E0C3356")]
[NativeTypeName("struct IGraphicsCaptureItemInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGraphicsCaptureItemInterop : IGraphicsCaptureItemInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGraphicsCaptureItemInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, Guid*, void**, int> )(lpVtbl[0]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, uint> )(lpVtbl[1]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, uint> )(lpVtbl[2]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGraphicsCaptureItemInterop.xml' path='doc/member[@name="IGraphicsCaptureItemInterop.CreateForWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateForWindow(HWND window, [NativeTypeName("const IID &")] Guid* riid, void** result)
    {
        return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, HWND, Guid*, void**, int> )(lpVtbl[3]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), window, riid, result);
    }

    /// <include file='IGraphicsCaptureItemInterop.xml' path='doc/member[@name="IGraphicsCaptureItemInterop.CreateForMonitor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateForMonitor(HMONITOR monitor, [NativeTypeName("const IID &")] Guid* riid, void** result)
    {
        return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, HMONITOR, Guid*, void**, int> )(lpVtbl[4]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), monitor, riid, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateForWindow(HWND window, [NativeTypeName("const IID &")] Guid* riid, void** result);
        [VtblIndex(4)]
        HRESULT CreateForMonitor(HMONITOR monitor, [NativeTypeName("const IID &")] Guid* riid, void** result);
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
        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> CreateForWindow;
        [NativeTypeName("HRESULT (HMONITOR, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMONITOR, Guid*, void**, int> CreateForMonitor;
    }
}