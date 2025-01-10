// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("4341AE3B-FC12-4E53-8C02-AC714C415A27")]
[NativeTypeName("struct IDataRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataRequest : IDataRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataRequest));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataRequest, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataRequest, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataRequest, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDataRequest, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataRequest, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDataRequest, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Data(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage **")]
            IDataPackage* value
    )
    {
        return ((delegate* unmanaged<IDataRequest, IDataPackage*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Data(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *")]
            IDataPackage value
    )
    {
        return ((delegate* unmanaged<IDataRequest, IDataPackage, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Deadline(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IDataRequest, WinRTDateTime*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FailWithDisplayText(HSTRING value)
    {
        return ((delegate* unmanaged<IDataRequest, HSTRING, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataRequestDeferral **")]
            IDataRequestDeferral* result
    )
    {
        return ((delegate* unmanaged<IDataRequest, IDataRequestDeferral*, int>)((*lpVtbl)[10]))(
            this,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Data(
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage **")]
                IDataPackage* value
        );

        [VtblIndex(7)]
        HRESULT put_Data(
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *")]
                IDataPackage value
        );

        [VtblIndex(8)]
        HRESULT get_Deadline(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(9)]
        HRESULT FailWithDisplayText(HSTRING value);

        [VtblIndex(10)]
        HRESULT GetDeferral(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::DataTransfer::IDataRequestDeferral **"
            )]
                IDataRequestDeferral* result
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataPackage*, int> get_Data;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataPackage, int> put_Data;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_Deadline;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> FailWithDisplayText;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataRequestDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataRequestDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataRequest"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataRequest(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataRequest(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataRequest"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataRequest value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataRequest(Silk.NET.Windows.IUnknown value)
    {
        return new IDataRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataRequest"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataRequest value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
