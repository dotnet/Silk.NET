// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D2FFD834-958B-426D-8470-2A13879C6A91")]
[NativeTypeName("struct IBurnVerification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBurnVerification : IBurnVerification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBurnVerification));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBurnVerification, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBurnVerification, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBurnVerification, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT put_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL value)
    {
        return (
            (delegate* unmanaged<IBurnVerification, IMAPI_BURN_VERIFICATION_LEVEL, int>)(
                (*lpVtbl)[3]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL* value)
    {
        return (
            (delegate* unmanaged<IBurnVerification, IMAPI_BURN_VERIFICATION_LEVEL*, int>)(
                (*lpVtbl)[4]
            )
        )(this, value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT put_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL value);

        [VtblIndex(4)]
        HRESULT get_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL* value);
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

        [NativeTypeName("HRESULT (IMAPI_BURN_VERIFICATION_LEVEL) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_BURN_VERIFICATION_LEVEL,
            int> put_BurnVerificationLevel;

        [NativeTypeName("HRESULT (IMAPI_BURN_VERIFICATION_LEVEL *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_BURN_VERIFICATION_LEVEL*,
            int> get_BurnVerificationLevel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBurnVerification"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBurnVerification(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBurnVerification"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBurnVerification(Silk.NET.Windows.IUnknown value)
    {
        return new IBurnVerification(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBurnVerification"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBurnVerification"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBurnVerification value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
