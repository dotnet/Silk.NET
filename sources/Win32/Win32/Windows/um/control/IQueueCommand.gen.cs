// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868B7-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IQueueCommand : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IQueueCommand : IQueueCommand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueueCommand));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQueueCommand, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IQueueCommand, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQueueCommand, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InvokeAtStreamTime(
        IDeferredCommand* pCmd,
        [NativeTypeName("REFTIME")] double time,
        Guid* iid,
        [NativeTypeName("long")] int dispidMethod,
        short wFlags,
        [NativeTypeName("long")] int cArgs,
        VARIANT* pDispParams,
        VARIANT* pvarResult,
        short* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IQueueCommand,
                IDeferredCommand*,
                double,
                Guid*,
                int,
                short,
                int,
                VARIANT*,
                VARIANT*,
                short*,
                int>)((*lpVtbl)[3])
        )(this, pCmd, time, iid, dispidMethod, wFlags, cArgs, pDispParams, pvarResult, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InvokeAtPresentationTime(
        IDeferredCommand* pCmd,
        [NativeTypeName("REFTIME")] double time,
        Guid* iid,
        [NativeTypeName("long")] int dispidMethod,
        short wFlags,
        [NativeTypeName("long")] int cArgs,
        VARIANT* pDispParams,
        VARIANT* pvarResult,
        short* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IQueueCommand,
                IDeferredCommand*,
                double,
                Guid*,
                int,
                short,
                int,
                VARIANT*,
                VARIANT*,
                short*,
                int>)((*lpVtbl)[4])
        )(this, pCmd, time, iid, dispidMethod, wFlags, cArgs, pDispParams, pvarResult, puArgErr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InvokeAtStreamTime(
            IDeferredCommand* pCmd,
            [NativeTypeName("REFTIME")] double time,
            Guid* iid,
            [NativeTypeName("long")] int dispidMethod,
            short wFlags,
            [NativeTypeName("long")] int cArgs,
            VARIANT* pDispParams,
            VARIANT* pvarResult,
            short* puArgErr
        );

        [VtblIndex(4)]
        HRESULT InvokeAtPresentationTime(
            IDeferredCommand* pCmd,
            [NativeTypeName("REFTIME")] double time,
            Guid* iid,
            [NativeTypeName("long")] int dispidMethod,
            short wFlags,
            [NativeTypeName("long")] int cArgs,
            VARIANT* pDispParams,
            VARIANT* pvarResult,
            short* puArgErr
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

        [NativeTypeName(
            "HRESULT (IDeferredCommand **, REFTIME, GUID *, long, short, long, VARIANT *, VARIANT *, short *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDeferredCommand*,
            double,
            Guid*,
            int,
            short,
            int,
            VARIANT*,
            VARIANT*,
            short*,
            int> InvokeAtStreamTime;

        [NativeTypeName(
            "HRESULT (IDeferredCommand **, REFTIME, GUID *, long, short, long, VARIANT *, VARIANT *, short *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDeferredCommand*,
            double,
            Guid*,
            int,
            short,
            int,
            VARIANT*,
            VARIANT*,
            short*,
            int> InvokeAtPresentationTime;
    }

    /// <summary>Initializes a new instance of the <see cref = "IQueueCommand"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IQueueCommand(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IQueueCommand"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IQueueCommand(Silk.NET.Windows.IUnknown value)
    {
        return new IQueueCommand(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQueueCommand"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IQueueCommand"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IQueueCommand value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
