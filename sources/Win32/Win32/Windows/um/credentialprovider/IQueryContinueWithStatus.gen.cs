// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9090BE5B-502B-41FB-BCCC-0049A6C7254B")]
[NativeTypeName("struct IQueryContinueWithStatus : IQueryContinue")]
[NativeInheritance("IQueryContinue")]
public unsafe partial struct IQueryContinueWithStatus
    : IQueryContinueWithStatus.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueryContinueWithStatus));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQueryContinueWithStatus, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IQueryContinueWithStatus, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQueryContinueWithStatus, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryContinue()
    {
        return ((delegate* unmanaged<IQueryContinueWithStatus, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetStatusMessage([NativeTypeName("LPCWSTR")] ushort* psz)
    {
        return ((delegate* unmanaged<IQueryContinueWithStatus, ushort*, int>)((*lpVtbl)[4]))(
            this,
            psz
        );
    }

    public interface Interface : IQueryContinue.Interface
    {
        [VtblIndex(4)]
        HRESULT SetStatusMessage([NativeTypeName("LPCWSTR")] ushort* psz);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> QueryContinue;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetStatusMessage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IQueryContinueWithStatus"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IQueryContinueWithStatus(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IQueryContinue"/> to <see cref = "IQueryContinueWithStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IQueryContinue"/> instance to be converted </param>
    public static explicit operator IQueryContinueWithStatus(Silk.NET.Windows.IQueryContinue value)
    {
        return new IQueryContinueWithStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQueryContinueWithStatus"/> to <see cref = "Silk.NET.Windows.IQueryContinue"/>.</summary>
    /// <param name = "value">The <see cref = "IQueryContinueWithStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IQueryContinue(IQueryContinueWithStatus value)
    {
        return new Silk.NET.Windows.IQueryContinue(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IQueryContinueWithStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IQueryContinueWithStatus(Silk.NET.Windows.IUnknown value)
    {
        return new IQueryContinueWithStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQueryContinueWithStatus"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IQueryContinueWithStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IQueryContinueWithStatus value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
