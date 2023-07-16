// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPrintDialogServices.xml' path='doc/member[@name="IPrintDialogServices"]/*'/>
[Guid("509AAEDA-5639-11D1-B6A1-0000F8757BF9")]
[NativeTypeName("struct IPrintDialogServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPrintDialogServices : IPrintDialogServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDialogServices));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintDialogServices*, Guid*, void**, int> )(lpVtbl[0]))((IPrintDialogServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintDialogServices*, uint> )(lpVtbl[1]))((IPrintDialogServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintDialogServices*, uint> )(lpVtbl[2]))((IPrintDialogServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintDialogServices.xml' path='doc/member[@name="IPrintDialogServices.GetCurrentDevMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrentDevMode([NativeTypeName("LPDEVMODE")] DEVMODEW* pDevMode, uint* pcbSize)
    {
        return ((delegate* unmanaged<IPrintDialogServices*, DEVMODEW*, uint*, int> )(lpVtbl[3]))((IPrintDialogServices*)Unsafe.AsPointer(ref this), pDevMode, pcbSize);
    }

    /// <include file='IPrintDialogServices.xml' path='doc/member[@name="IPrintDialogServices.GetCurrentPrinterName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentPrinterName([NativeTypeName("LPWSTR")] ushort* pPrinterName, uint* pcchSize)
    {
        return ((delegate* unmanaged<IPrintDialogServices*, ushort*, uint*, int> )(lpVtbl[4]))((IPrintDialogServices*)Unsafe.AsPointer(ref this), pPrinterName, pcchSize);
    }

    /// <include file='IPrintDialogServices.xml' path='doc/member[@name="IPrintDialogServices.GetCurrentPortName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentPortName([NativeTypeName("LPWSTR")] ushort* pPortName, uint* pcchSize)
    {
        return ((delegate* unmanaged<IPrintDialogServices*, ushort*, uint*, int> )(lpVtbl[5]))((IPrintDialogServices*)Unsafe.AsPointer(ref this), pPortName, pcchSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrentDevMode([NativeTypeName("LPDEVMODE")] DEVMODEW* pDevMode, uint* pcbSize);
        [VtblIndex(4)]
        HRESULT GetCurrentPrinterName([NativeTypeName("LPWSTR")] ushort* pPrinterName, uint* pcchSize);
        [VtblIndex(5)]
        HRESULT GetCurrentPortName([NativeTypeName("LPWSTR")] ushort* pPortName, uint* pcchSize);
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
        [NativeTypeName("HRESULT (LPDEVMODE, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEVMODEW*, uint*, int> GetCurrentDevMode;
        [NativeTypeName("HRESULT (LPWSTR, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, int> GetCurrentPrinterName;
        [NativeTypeName("HRESULT (LPWSTR, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, int> GetCurrentPortName;
    }
}