// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("75D760B0-60B9-412D-994F-26B2CD5F7812")]
[NativeTypeName("struct IXblIdpAuthTokenResult2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXblIdpAuthTokenResult2
    : IXblIdpAuthTokenResult2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXblIdpAuthTokenResult2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXblIdpAuthTokenResult2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetModernGamertag([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult2, ushort**, int>)((*lpVtbl)[3]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetModernGamertagSuffix([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult2, ushort**, int>)((*lpVtbl)[4]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUniqueModernGamertag([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult2, ushort**, int>)((*lpVtbl)[5]))(
            this,
            value
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetModernGamertag([NativeTypeName("LPWSTR *")] ushort** value);

        [VtblIndex(4)]
        HRESULT GetModernGamertagSuffix([NativeTypeName("LPWSTR *")] ushort** value);

        [VtblIndex(5)]
        HRESULT GetUniqueModernGamertag([NativeTypeName("LPWSTR *")] ushort** value);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetModernGamertag;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetModernGamertagSuffix;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetUniqueModernGamertag;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXblIdpAuthTokenResult2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXblIdpAuthTokenResult2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXblIdpAuthTokenResult2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXblIdpAuthTokenResult2(Silk.NET.Windows.IUnknown value)
    {
        return new IXblIdpAuthTokenResult2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXblIdpAuthTokenResult2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXblIdpAuthTokenResult2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXblIdpAuthTokenResult2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
