// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B722BCC9-4E68-101B-A2BC-00AA00404770")]
[NativeTypeName("struct IPrint : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPrint : IPrint.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrint));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrint, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPrint, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrint, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInitialPageNum([NativeTypeName("LONG")] int nFirstPage)
    {
        return ((delegate* unmanaged<IPrint, int, int>)((*lpVtbl)[3]))(this, nFirstPage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPageInfo(
        [NativeTypeName("LONG *")] int* pnFirstPage,
        [NativeTypeName("LONG *")] int* pcPages
    )
    {
        return ((delegate* unmanaged<IPrint, int*, int*, int>)((*lpVtbl)[4]))(
            this,
            pnFirstPage,
            pcPages
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Print(
        [NativeTypeName("DWORD")] uint grfFlags,
        DVTARGETDEVICE** pptd,
        PAGESET** ppPageSet,
        STGMEDIUM* pstgmOptions,
        IContinueCallback pcallback,
        [NativeTypeName("LONG")] int nFirstPage,
        [NativeTypeName("LONG *")] int* pcPagesPrinted,
        [NativeTypeName("LONG *")] int* pnLastPage
    )
    {
        return (
            (delegate* unmanaged<
                IPrint,
                uint,
                DVTARGETDEVICE**,
                PAGESET**,
                STGMEDIUM*,
                IContinueCallback,
                int,
                int*,
                int*,
                int>)((*lpVtbl)[5])
        )(
            this,
            grfFlags,
            pptd,
            ppPageSet,
            pstgmOptions,
            pcallback,
            nFirstPage,
            pcPagesPrinted,
            pnLastPage
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetInitialPageNum([NativeTypeName("LONG")] int nFirstPage);

        [VtblIndex(4)]
        HRESULT GetPageInfo(
            [NativeTypeName("LONG *")] int* pnFirstPage,
            [NativeTypeName("LONG *")] int* pcPages
        );

        [VtblIndex(5)]
        HRESULT Print(
            [NativeTypeName("DWORD")] uint grfFlags,
            DVTARGETDEVICE** pptd,
            PAGESET** ppPageSet,
            STGMEDIUM* pstgmOptions,
            IContinueCallback pcallback,
            [NativeTypeName("LONG")] int nFirstPage,
            [NativeTypeName("LONG *")] int* pcPagesPrinted,
            [NativeTypeName("LONG *")] int* pnLastPage
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

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetInitialPageNum;

        [NativeTypeName("HRESULT (LONG *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetPageInfo;

        [NativeTypeName(
            "HRESULT (DWORD, DVTARGETDEVICE **, PAGESET **, STGMEDIUM *, IContinueCallback *, LONG, LONG *, LONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DVTARGETDEVICE**,
            PAGESET**,
            STGMEDIUM*,
            IContinueCallback,
            int,
            int*,
            int*,
            int> Print;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrint"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrint(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrint"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrint(Silk.NET.Windows.IUnknown value)
    {
        return new IPrint(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrint"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrint"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrint value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
