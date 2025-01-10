// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DF1B943C-5838-4AA2-8706-D7CD5B333499")]
[NativeTypeName("struct ISpRecognizer3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpRecognizer3 : ISpRecognizer3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecognizer3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecognizer3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpRecognizer3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecognizer3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCategory(SPCATEGORYTYPE categoryType, ISpRecoCategory* ppCategory)
    {
        return (
            (delegate* unmanaged<ISpRecognizer3, SPCATEGORYTYPE, ISpRecoCategory*, int>)(
                (*lpVtbl)[3]
            )
        )(this, categoryType, ppCategory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetActiveCategory(ISpRecoCategory pCategory)
    {
        return ((delegate* unmanaged<ISpRecognizer3, ISpRecoCategory, int>)((*lpVtbl)[4]))(
            this,
            pCategory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetActiveCategory(ISpRecoCategory* ppCategory)
    {
        return ((delegate* unmanaged<ISpRecognizer3, ISpRecoCategory*, int>)((*lpVtbl)[5]))(
            this,
            ppCategory
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCategory(SPCATEGORYTYPE categoryType, ISpRecoCategory* ppCategory);

        [VtblIndex(4)]
        HRESULT SetActiveCategory(ISpRecoCategory pCategory);

        [VtblIndex(5)]
        HRESULT GetActiveCategory(ISpRecoCategory* ppCategory);
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
        public delegate* unmanaged<TSelf*, SPCATEGORYTYPE, ISpRecoCategory*, int> GetCategory;

        [NativeTypeName("HRESULT (ISpRecoCategory *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpRecoCategory, int> SetActiveCategory;

        [NativeTypeName("HRESULT (ISpRecoCategory **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpRecoCategory*, int> GetActiveCategory;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpRecognizer3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpRecognizer3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpRecognizer3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpRecognizer3(Silk.NET.Windows.IUnknown value)
    {
        return new ISpRecognizer3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecognizer3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecognizer3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpRecognizer3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
