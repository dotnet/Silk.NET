// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("ACF92459-6A61-42BD-B57C-B43E51203CB0")]
[NativeTypeName("struct IMFContentProtectionManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFContentProtectionManager
    : IMFContentProtectionManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentProtectionManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFContentProtectionManager, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentProtectionManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentProtectionManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginEnableContent(
        IMFActivate pEnablerActivate,
        IMFTopology pTopo,
        IMFAsyncCallback pCallback,
        IUnknown punkState
    )
    {
        return (
            (delegate* unmanaged<
                IMFContentProtectionManager,
                IMFActivate,
                IMFTopology,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[3])
        )(this, pEnablerActivate, pTopo, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndEnableContent(IMFAsyncResult pResult)
    {
        return (
            (delegate* unmanaged<IMFContentProtectionManager, IMFAsyncResult, int>)((*lpVtbl)[4])
        )(this, pResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginEnableContent(
            IMFActivate pEnablerActivate,
            IMFTopology pTopo,
            IMFAsyncCallback pCallback,
            IUnknown punkState
        );

        [VtblIndex(4)]
        HRESULT EndEnableContent(IMFAsyncResult pResult);
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

        [NativeTypeName(
            "HRESULT (IMFActivate *, IMFTopology *, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFActivate,
            IMFTopology,
            IMFAsyncCallback,
            IUnknown,
            int> BeginEnableContent;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult, int> EndEnableContent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFContentProtectionManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFContentProtectionManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFContentProtectionManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFContentProtectionManager(Silk.NET.Windows.IUnknown value)
    {
        return new IMFContentProtectionManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFContentProtectionManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFContentProtectionManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFContentProtectionManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
