// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8445C581-0CAC-4A38-ABFE-9B2CE2826455")]
[NativeTypeName("struct ISpPhoneConverter : ISpObjectWithToken")]
[NativeInheritance("ISpObjectWithToken")]
public unsafe partial struct ISpPhoneConverter : ISpPhoneConverter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpPhoneConverter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpPhoneConverter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpPhoneConverter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpPhoneConverter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetObjectToken(ISpObjectToken pToken)
    {
        return ((delegate* unmanaged<ISpPhoneConverter, ISpObjectToken, int>)((*lpVtbl)[3]))(
            this,
            pToken
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetObjectToken(ISpObjectToken* ppToken)
    {
        return ((delegate* unmanaged<ISpPhoneConverter, ISpObjectToken*, int>)((*lpVtbl)[4]))(
            this,
            ppToken
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT PhoneToId(
        [NativeTypeName("LPCWSTR")] ushort* pszPhone,
        [NativeTypeName("SPPHONEID *")] ushort* pId
    )
    {
        return ((delegate* unmanaged<ISpPhoneConverter, ushort*, ushort*, int>)((*lpVtbl)[5]))(
            this,
            pszPhone,
            pId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IdToPhone(
        [NativeTypeName("PCSPPHONEID")] ushort* pId,
        [NativeTypeName("WCHAR *")] ushort* pszPhone
    )
    {
        return ((delegate* unmanaged<ISpPhoneConverter, ushort*, ushort*, int>)((*lpVtbl)[6]))(
            this,
            pId,
            pszPhone
        );
    }

    public interface Interface : ISpObjectWithToken.Interface
    {
        [VtblIndex(5)]
        HRESULT PhoneToId(
            [NativeTypeName("LPCWSTR")] ushort* pszPhone,
            [NativeTypeName("SPPHONEID *")] ushort* pId
        );

        [VtblIndex(6)]
        HRESULT IdToPhone(
            [NativeTypeName("PCSPPHONEID")] ushort* pId,
            [NativeTypeName("WCHAR *")] ushort* pszPhone
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

        [NativeTypeName("HRESULT (ISpObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpObjectToken, int> SetObjectToken;

        [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpObjectToken*, int> GetObjectToken;

        [NativeTypeName("HRESULT (LPCWSTR, SPPHONEID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> PhoneToId;

        [NativeTypeName("HRESULT (PCSPPHONEID, WCHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> IdToPhone;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpPhoneConverter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpPhoneConverter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpObjectWithToken"/> to <see cref = "ISpPhoneConverter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpObjectWithToken"/> instance to be converted </param>
    public static explicit operator ISpPhoneConverter(Silk.NET.Windows.ISpObjectWithToken value)
    {
        return new ISpPhoneConverter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpPhoneConverter"/> to <see cref = "Silk.NET.Windows.ISpObjectWithToken"/>.</summary>
    /// <param name = "value">The <see cref = "ISpPhoneConverter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpObjectWithToken(ISpPhoneConverter value)
    {
        return new Silk.NET.Windows.ISpObjectWithToken(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpPhoneConverter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpPhoneConverter(Silk.NET.Windows.IUnknown value)
    {
        return new ISpPhoneConverter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpPhoneConverter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpPhoneConverter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpPhoneConverter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
