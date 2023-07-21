// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISpRecognizer3.xml' path='doc/member[@name="ISpRecognizer3"]/*' />
[Guid("DF1B943C-5838-4AA2-8706-D7CD5B333499")]
[NativeTypeName("struct ISpRecognizer3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpRecognizer3 : ISpRecognizer3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecognizer3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecognizer3*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecognizer3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpRecognizer3*, uint>)(lpVtbl[1]))((ISpRecognizer3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecognizer3*, uint>)(lpVtbl[2]))((ISpRecognizer3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpRecognizer3.xml' path='doc/member[@name="ISpRecognizer3.GetCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCategory(SPCATEGORYTYPE categoryType, ISpRecoCategory** ppCategory)
    {
        return ((delegate* unmanaged<ISpRecognizer3*, SPCATEGORYTYPE, ISpRecoCategory**, int>)(lpVtbl[3]))((ISpRecognizer3*)Unsafe.AsPointer(ref this), categoryType, ppCategory);
    }

    /// <include file='ISpRecognizer3.xml' path='doc/member[@name="ISpRecognizer3.SetActiveCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetActiveCategory(ISpRecoCategory* pCategory)
    {
        return ((delegate* unmanaged<ISpRecognizer3*, ISpRecoCategory*, int>)(lpVtbl[4]))((ISpRecognizer3*)Unsafe.AsPointer(ref this), pCategory);
    }

    /// <include file='ISpRecognizer3.xml' path='doc/member[@name="ISpRecognizer3.GetActiveCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetActiveCategory(ISpRecoCategory** ppCategory)
    {
        return ((delegate* unmanaged<ISpRecognizer3*, ISpRecoCategory**, int>)(lpVtbl[5]))((ISpRecognizer3*)Unsafe.AsPointer(ref this), ppCategory);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCategory(SPCATEGORYTYPE categoryType, ISpRecoCategory** ppCategory);

        [VtblIndex(4)]
        HRESULT SetActiveCategory(ISpRecoCategory* pCategory);

        [VtblIndex(5)]
        HRESULT GetActiveCategory(ISpRecoCategory** ppCategory);
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

        [NativeTypeName("HRESULT (SPCATEGORYTYPE, ISpRecoCategory **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPCATEGORYTYPE, ISpRecoCategory**, int> GetCategory;

        [NativeTypeName("HRESULT (ISpRecoCategory *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpRecoCategory*, int> SetActiveCategory;

        [NativeTypeName("HRESULT (ISpRecoCategory **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpRecoCategory**, int> GetActiveCategory;
    }
}
