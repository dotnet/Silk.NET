// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6AC6206F-E1CF-486A-B485-A69C83E46FD1")]
[NativeTypeName("struct ICertificateKeyUsages : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateKeyUsages : ICertificateKeyUsages.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateKeyUsages));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICertificateKeyUsages, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EncipherOnly([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_EncipherOnly([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CrlSign([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CrlSign([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_KeyCertificateSign([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_KeyCertificateSign([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_KeyAgreement([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_KeyAgreement([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DataEncipherment([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_DataEncipherment([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_KeyEncipherment([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_KeyEncipherment([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_NonRepudiation([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_NonRepudiation([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_DigitalSignature([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_DigitalSignature([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICertificateKeyUsages, byte, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EncipherOnly([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_EncipherOnly([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_CrlSign([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_CrlSign([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_KeyCertificateSign([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_KeyCertificateSign([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_KeyAgreement([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_KeyAgreement([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_DataEncipherment([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_DataEncipherment([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_KeyEncipherment([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_KeyEncipherment([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT get_NonRepudiation([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT put_NonRepudiation([NativeTypeName("boolean")] byte value);

        [VtblIndex(20)]
        HRESULT get_DigitalSignature([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT put_DigitalSignature([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_EncipherOnly;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_EncipherOnly;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CrlSign;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CrlSign;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_KeyCertificateSign;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_KeyCertificateSign;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_KeyAgreement;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_KeyAgreement;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_DataEncipherment;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_DataEncipherment;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_KeyEncipherment;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_KeyEncipherment;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_NonRepudiation;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_NonRepudiation;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_DigitalSignature;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_DigitalSignature;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICertificateKeyUsages"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICertificateKeyUsages(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICertificateKeyUsages"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICertificateKeyUsages(Silk.NET.WinRT.IInspectable value)
    {
        return new ICertificateKeyUsages(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificateKeyUsages"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificateKeyUsages"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICertificateKeyUsages value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICertificateKeyUsages"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICertificateKeyUsages(Silk.NET.Windows.IUnknown value)
    {
        return new ICertificateKeyUsages(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificateKeyUsages"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificateKeyUsages"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICertificateKeyUsages value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
