// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDataTransferManagerInterop.xml' path='doc/member[@name="IDataTransferManagerInterop"]/*'/>
[Guid("3A3DCD6C-3EAB-43DC-BCDE-45671CE800C8")]
[NativeTypeName("struct IDataTransferManagerInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDataTransferManagerInterop : IDataTransferManagerInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataTransferManagerInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataTransferManagerInterop*, Guid*, void**, int> )(lpVtbl[0]))((IDataTransferManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDataTransferManagerInterop*, uint> )(lpVtbl[1]))((IDataTransferManagerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataTransferManagerInterop*, uint> )(lpVtbl[2]))((IDataTransferManagerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDataTransferManagerInterop.xml' path='doc/member[@name="IDataTransferManagerInterop.GetForWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** dataTransferManager)
    {
        return ((delegate* unmanaged<IDataTransferManagerInterop*, HWND, Guid*, void**, int> )(lpVtbl[3]))((IDataTransferManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, dataTransferManager);
    }

    /// <include file='IDataTransferManagerInterop.xml' path='doc/member[@name="IDataTransferManagerInterop.ShowShareUIForWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShowShareUIForWindow(HWND appWindow)
    {
        return ((delegate* unmanaged<IDataTransferManagerInterop*, HWND, int> )(lpVtbl[4]))((IDataTransferManagerInterop*)Unsafe.AsPointer(ref this), appWindow);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** dataTransferManager);
        [VtblIndex(4)]
        HRESULT ShowShareUIForWindow(HWND appWindow);
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
        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> GetForWindow;
        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> ShowShareUIForWindow;
    }
}