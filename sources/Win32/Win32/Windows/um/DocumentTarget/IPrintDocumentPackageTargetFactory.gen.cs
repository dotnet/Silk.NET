// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D2959BF7-B31B-4A3D-9600-712EB1335BA4")]
[NativeTypeName("struct IPrintDocumentPackageTargetFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IPrintDocumentPackageTargetFactory
    : IPrintDocumentPackageTargetFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDocumentPackageTargetFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintDocumentPackageTargetFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTargetFactory, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTargetFactory, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDocumentPackageTargetForPrintJob(
        [NativeTypeName("LPCWSTR")] ushort* printerName,
        [NativeTypeName("LPCWSTR")] ushort* jobName,
        IStream jobOutputStream,
        IStream jobPrintTicketStream,
        IPrintDocumentPackageTarget* docPackageTarget
    )
    {
        return (
            (delegate* unmanaged<
                IPrintDocumentPackageTargetFactory,
                ushort*,
                ushort*,
                IStream,
                IStream,
                IPrintDocumentPackageTarget*,
                int>)((*lpVtbl)[3])
        )(this, printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateDocumentPackageTargetForPrintJob(
            [NativeTypeName("LPCWSTR")] ushort* printerName,
            [NativeTypeName("LPCWSTR")] ushort* jobName,
            IStream jobOutputStream,
            IStream jobPrintTicketStream,
            IPrintDocumentPackageTarget* docPackageTarget
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

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, IStream *, IStream *, IPrintDocumentPackageTarget **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            IStream,
            IStream,
            IPrintDocumentPackageTarget*,
            int> CreateDocumentPackageTargetForPrintJob;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintDocumentPackageTargetFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintDocumentPackageTargetFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintDocumentPackageTargetFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintDocumentPackageTargetFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPrintDocumentPackageTargetFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintDocumentPackageTargetFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintDocumentPackageTargetFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPrintDocumentPackageTargetFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
