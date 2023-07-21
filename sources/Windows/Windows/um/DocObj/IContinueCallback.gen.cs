// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IContinueCallback.xml' path='doc/member[@name="IContinueCallback"]/*' />
[Guid("B722BCCA-4E68-101B-A2BC-00AA00404770")]
[NativeTypeName("struct IContinueCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContinueCallback : IContinueCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContinueCallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContinueCallback*, Guid*, void**, int>)(lpVtbl[0]))((IContinueCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IContinueCallback*, uint>)(lpVtbl[1]))((IContinueCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContinueCallback*, uint>)(lpVtbl[2]))((IContinueCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IContinueCallback.xml' path='doc/member[@name="IContinueCallback.FContinue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FContinue()
    {
        return ((delegate* unmanaged<IContinueCallback*, int>)(lpVtbl[3]))((IContinueCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IContinueCallback.xml' path='doc/member[@name="IContinueCallback.FContinuePrinting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FContinuePrinting([NativeTypeName("LONG")] int nCntPrinted, [NativeTypeName("LONG")] int nCurPage, [NativeTypeName("wchar_t *")] ushort* pwszPrintStatus)
    {
        return ((delegate* unmanaged<IContinueCallback*, int, int, ushort*, int>)(lpVtbl[4]))((IContinueCallback*)Unsafe.AsPointer(ref this), nCntPrinted, nCurPage, pwszPrintStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FContinue();

        [VtblIndex(4)]
        HRESULT FContinuePrinting([NativeTypeName("LONG")] int nCntPrinted, [NativeTypeName("LONG")] int nCurPage, [NativeTypeName("wchar_t *")] ushort* pwszPrintStatus);
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
}
