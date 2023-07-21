// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPrintDocumentPackageTarget2.xml' path='doc/member[@name="IPrintDocumentPackageTarget2"]/*' />
[Guid("C560298A-535C-48F9-866A-632540660CB4")]
[NativeTypeName("struct IPrintDocumentPackageTarget2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPrintDocumentPackageTarget2 : IPrintDocumentPackageTarget2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDocumentPackageTarget2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget2*, Guid*, void**, int>)(lpVtbl[0]))((IPrintDocumentPackageTarget2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget2*, uint>)(lpVtbl[1]))((IPrintDocumentPackageTarget2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget2*, uint>)(lpVtbl[2]))((IPrintDocumentPackageTarget2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintDocumentPackageTarget2.xml' path='doc/member[@name="IPrintDocumentPackageTarget2.GetIsTargetIppPrinter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIsTargetIppPrinter(BOOL* isIppPrinter)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget2*, BOOL*, int>)(lpVtbl[3]))((IPrintDocumentPackageTarget2*)Unsafe.AsPointer(ref this), isIppPrinter);
    }

    /// <include file='IPrintDocumentPackageTarget2.xml' path='doc/member[@name="IPrintDocumentPackageTarget2.GetTargetIppPrintDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTargetIppPrintDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvTarget)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget2*, Guid*, void**, int>)(lpVtbl[4]))((IPrintDocumentPackageTarget2*)Unsafe.AsPointer(ref this), riid, ppvTarget);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIsTargetIppPrinter(BOOL* isIppPrinter);

        [VtblIndex(4)]
        HRESULT GetTargetIppPrintDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvTarget);
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetIsTargetIppPrinter;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetTargetIppPrintDevice;
    }
}
