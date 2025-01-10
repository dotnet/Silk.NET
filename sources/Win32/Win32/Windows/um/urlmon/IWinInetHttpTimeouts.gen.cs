// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F286FA56-C1FD-4270-8E67-B3EB790A81E8")]
[NativeTypeName("struct IWinInetHttpTimeouts : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWinInetHttpTimeouts : IWinInetHttpTimeouts.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetHttpTimeouts));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWinInetHttpTimeouts, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWinInetHttpTimeouts, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWinInetHttpTimeouts, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRequestTimeouts(
        [NativeTypeName("DWORD *")] uint* pdwConnectTimeout,
        [NativeTypeName("DWORD *")] uint* pdwSendTimeout,
        [NativeTypeName("DWORD *")] uint* pdwReceiveTimeout
    )
    {
        return (
            (delegate* unmanaged<IWinInetHttpTimeouts, uint*, uint*, uint*, int>)((*lpVtbl)[3])
        )(this, pdwConnectTimeout, pdwSendTimeout, pdwReceiveTimeout);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRequestTimeouts(
            [NativeTypeName("DWORD *")] uint* pdwConnectTimeout,
            [NativeTypeName("DWORD *")] uint* pdwSendTimeout,
            [NativeTypeName("DWORD *")] uint* pdwReceiveTimeout
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

        [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint*, int> GetRequestTimeouts;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWinInetHttpTimeouts"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWinInetHttpTimeouts(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWinInetHttpTimeouts"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWinInetHttpTimeouts(Silk.NET.Windows.IUnknown value)
    {
        return new IWinInetHttpTimeouts(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWinInetHttpTimeouts"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWinInetHttpTimeouts"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWinInetHttpTimeouts value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
