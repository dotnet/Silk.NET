// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/DocumentSource.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='IPrintDocumentPageSource.xml' path='doc/member[@name="IPrintDocumentPageSource"]/*' />
[Guid("A96BB1DB-172E-4667-82B5-AD97A252318F")]
[NativeTypeName("struct IPrintDocumentPageSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPrintDocumentPageSource : IPrintDocumentPageSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDocumentPageSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintDocumentPageSource*, Guid*, void**, int>)(lpVtbl[0]))((IPrintDocumentPageSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintDocumentPageSource*, uint>)(lpVtbl[1]))((IPrintDocumentPageSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintDocumentPageSource*, uint>)(lpVtbl[2]))((IPrintDocumentPageSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintDocumentPageSource.xml' path='doc/member[@name="IPrintDocumentPageSource.GetPreviewPageCollection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPreviewPageCollection(IPrintDocumentPackageTarget* docPackageTarget, IPrintPreviewPageCollection** docPageCollection)
    {
        return ((delegate* unmanaged<IPrintDocumentPageSource*, IPrintDocumentPackageTarget*, IPrintPreviewPageCollection**, int>)(lpVtbl[3]))((IPrintDocumentPageSource*)Unsafe.AsPointer(ref this), docPackageTarget, docPageCollection);
    }

    /// <include file='IPrintDocumentPageSource.xml' path='doc/member[@name="IPrintDocumentPageSource.MakeDocument"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MakeDocument(IInspectable* printTaskOptions, IPrintDocumentPackageTarget* docPackageTarget)
    {
        return ((delegate* unmanaged<IPrintDocumentPageSource*, IInspectable*, IPrintDocumentPackageTarget*, int>)(lpVtbl[4]))((IPrintDocumentPageSource*)Unsafe.AsPointer(ref this), printTaskOptions, docPackageTarget);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPreviewPageCollection(IPrintDocumentPackageTarget* docPackageTarget, IPrintPreviewPageCollection** docPageCollection);

        [VtblIndex(4)]
        HRESULT MakeDocument(IInspectable* printTaskOptions, IPrintDocumentPackageTarget* docPackageTarget);
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

        [NativeTypeName("HRESULT (IPrintDocumentPackageTarget *, IPrintPreviewPageCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPrintDocumentPackageTarget*, IPrintPreviewPageCollection**, int> GetPreviewPageCollection;

        [NativeTypeName("HRESULT (IInspectable *, IPrintDocumentPackageTarget *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, IPrintDocumentPackageTarget*, int> MakeDocument;
    }
}
