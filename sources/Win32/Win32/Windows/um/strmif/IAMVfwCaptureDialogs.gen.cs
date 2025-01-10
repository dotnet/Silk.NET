// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D8D715A0-6E5E-11D0-B3F0-00AA003761C5")]
[NativeTypeName("struct IAMVfwCaptureDialogs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMVfwCaptureDialogs : IAMVfwCaptureDialogs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMVfwCaptureDialogs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMVfwCaptureDialogs, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMVfwCaptureDialogs, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMVfwCaptureDialogs, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT HasDialog(int iDialog)
    {
        return ((delegate* unmanaged<IAMVfwCaptureDialogs, int, int>)((*lpVtbl)[3]))(this, iDialog);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShowDialog(int iDialog, HWND hwnd)
    {
        return ((delegate* unmanaged<IAMVfwCaptureDialogs, int, HWND, int>)((*lpVtbl)[4]))(
            this,
            iDialog,
            hwnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SendDriverMessage(
        int iDialog,
        int uMsg,
        [NativeTypeName("long")] int dw1,
        [NativeTypeName("long")] int dw2
    )
    {
        return ((delegate* unmanaged<IAMVfwCaptureDialogs, int, int, int, int, int>)((*lpVtbl)[5]))(
            this,
            iDialog,
            uMsg,
            dw1,
            dw2
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT HasDialog(int iDialog);

        [VtblIndex(4)]
        HRESULT ShowDialog(int iDialog, HWND hwnd);

        [VtblIndex(5)]
        HRESULT SendDriverMessage(
            int iDialog,
            int uMsg,
            [NativeTypeName("long")] int dw1,
            [NativeTypeName("long")] int dw2
        );
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

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> HasDialog;

        [NativeTypeName("HRESULT (int, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HWND, int> ShowDialog;

        [NativeTypeName("HRESULT (int, int, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int, int> SendDriverMessage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMVfwCaptureDialogs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMVfwCaptureDialogs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMVfwCaptureDialogs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMVfwCaptureDialogs(Silk.NET.Windows.IUnknown value)
    {
        return new IAMVfwCaptureDialogs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMVfwCaptureDialogs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMVfwCaptureDialogs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMVfwCaptureDialogs value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
