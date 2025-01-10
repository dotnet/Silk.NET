// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("82BA7092-4C88-427D-A7BC-16DD93FEB67E")]
[NativeTypeName("struct IRestrictedErrorInfo : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IRestrictedErrorInfo : IRestrictedErrorInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRestrictedErrorInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRestrictedErrorInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRestrictedErrorInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRestrictedErrorInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetErrorDetails(
        [NativeTypeName("BSTR *")] ushort** description,
        HRESULT* error,
        [NativeTypeName("BSTR *")] ushort** restrictedDescription,
        [NativeTypeName("BSTR *")] ushort** capabilitySid
    )
    {
        return (
            (delegate* unmanaged<
                IRestrictedErrorInfo,
                ushort**,
                HRESULT*,
                ushort**,
                ushort**,
                int>)((*lpVtbl)[3])
        )(this, description, error, restrictedDescription, capabilitySid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetReference([NativeTypeName("BSTR *")] ushort** reference)
    {
        return ((delegate* unmanaged<IRestrictedErrorInfo, ushort**, int>)((*lpVtbl)[4]))(
            this,
            reference
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetErrorDetails(
            [NativeTypeName("BSTR *")] ushort** description,
            HRESULT* error,
            [NativeTypeName("BSTR *")] ushort** restrictedDescription,
            [NativeTypeName("BSTR *")] ushort** capabilitySid
        );

        [VtblIndex(4)]
        HRESULT GetReference([NativeTypeName("BSTR *")] ushort** reference);
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

        [NativeTypeName("HRESULT (BSTR *, HRESULT *, BSTR *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort**,
            HRESULT*,
            ushort**,
            ushort**,
            int> GetErrorDetails;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetReference;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRestrictedErrorInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRestrictedErrorInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRestrictedErrorInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRestrictedErrorInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IRestrictedErrorInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRestrictedErrorInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRestrictedErrorInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRestrictedErrorInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
