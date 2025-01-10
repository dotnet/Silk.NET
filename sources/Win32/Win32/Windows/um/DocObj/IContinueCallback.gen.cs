// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B722BCCA-4E68-101B-A2BC-00AA00404770")]
[NativeTypeName("struct IContinueCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContinueCallback : IContinueCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContinueCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContinueCallback, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContinueCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContinueCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FContinue()
    {
        return ((delegate* unmanaged<IContinueCallback, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FContinuePrinting(
        [NativeTypeName("LONG")] int nCntPrinted,
        [NativeTypeName("LONG")] int nCurPage,
        [NativeTypeName("wchar_t *")] ushort* pwszPrintStatus
    )
    {
        return ((delegate* unmanaged<IContinueCallback, int, int, ushort*, int>)((*lpVtbl)[4]))(
            this,
            nCntPrinted,
            nCurPage,
            pwszPrintStatus
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FContinue();

        [VtblIndex(4)]
        HRESULT FContinuePrinting(
            [NativeTypeName("LONG")] int nCntPrinted,
            [NativeTypeName("LONG")] int nCurPage,
            [NativeTypeName("wchar_t *")] ushort* pwszPrintStatus
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FContinue;

        [NativeTypeName("HRESULT (LONG, LONG, wchar_t *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ushort*, int> FContinuePrinting;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContinueCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContinueCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContinueCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContinueCallback(Silk.NET.Windows.IUnknown value)
    {
        return new IContinueCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContinueCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContinueCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContinueCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
