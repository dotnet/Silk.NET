// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E825A30A-5C7F-546F-B918-3AD2FE70FB34")]
[NativeTypeName("struct IPhoneLineDialResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLineDialResult : IPhoneLineDialResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneLineDialResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPhoneLineDialResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPhoneLineDialResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhoneLineDialResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPhoneLineDialResult, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPhoneLineDialResult, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPhoneLineDialResult, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DialCallStatus(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
            PhoneCallOperationStatus* value
    )
    {
        return (
            (delegate* unmanaged<IPhoneLineDialResult, PhoneCallOperationStatus*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DialedCall(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCall **")] IPhoneCall* value
    )
    {
        return ((delegate* unmanaged<IPhoneLineDialResult, IPhoneCall*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DialCallStatus(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
                PhoneCallOperationStatus* value
        );

        [VtblIndex(7)]
        HRESULT get_DialedCall(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCall **")]
                IPhoneCall* value
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
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallOperationStatus*, int> get_DialCallStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCall **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPhoneCall*, int> get_DialedCall;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneLineDialResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneLineDialResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneLineDialResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneLineDialResult(Silk.NET.WinRT.IInspectable value)
    {
        return new IPhoneLineDialResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneLineDialResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneLineDialResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPhoneLineDialResult value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneLineDialResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneLineDialResult(Silk.NET.Windows.IUnknown value)
    {
        return new IPhoneLineDialResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneLineDialResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneLineDialResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPhoneLineDialResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
