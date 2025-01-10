// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("17239D47-6ADB-45D2-80F6-F9CBC3BF059D")]
[NativeTypeName("struct IAppxPackagingDiagnosticEventSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxPackagingDiagnosticEventSink
    : IAppxPackagingDiagnosticEventSink.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxPackagingDiagnosticEventSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxPackagingDiagnosticEventSink, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportContextChange(
        APPX_PACKAGING_CONTEXT_CHANGE_TYPE changeType,
        [NativeTypeName("LONG")] int contextId,
        [NativeTypeName("LPCSTR")] sbyte* contextName,
        [NativeTypeName("LPCWSTR")] ushort* contextMessage,
        [NativeTypeName("LPCWSTR")] ushort* detailsMessage
    )
    {
        return (
            (delegate* unmanaged<
                IAppxPackagingDiagnosticEventSink,
                APPX_PACKAGING_CONTEXT_CHANGE_TYPE,
                int,
                sbyte*,
                ushort*,
                ushort*,
                int>)((*lpVtbl)[3])
        )(this, changeType, contextId, contextName, contextMessage, detailsMessage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReportError([NativeTypeName("LPCWSTR")] ushort* errorMessage)
    {
        return (
            (delegate* unmanaged<IAppxPackagingDiagnosticEventSink, ushort*, int>)((*lpVtbl)[4])
        )(this, errorMessage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReportContextChange(
            APPX_PACKAGING_CONTEXT_CHANGE_TYPE changeType,
            [NativeTypeName("LONG")] int contextId,
            [NativeTypeName("LPCSTR")] sbyte* contextName,
            [NativeTypeName("LPCWSTR")] ushort* contextMessage,
            [NativeTypeName("LPCWSTR")] ushort* detailsMessage
        );

        [VtblIndex(4)]
        HRESULT ReportError([NativeTypeName("LPCWSTR")] ushort* errorMessage);
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
            "HRESULT (APPX_PACKAGING_CONTEXT_CHANGE_TYPE, LONG, LPCSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            APPX_PACKAGING_CONTEXT_CHANGE_TYPE,
            int,
            sbyte*,
            ushort*,
            ushort*,
            int> ReportContextChange;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> ReportError;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxPackagingDiagnosticEventSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxPackagingDiagnosticEventSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxPackagingDiagnosticEventSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxPackagingDiagnosticEventSink(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppxPackagingDiagnosticEventSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxPackagingDiagnosticEventSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxPackagingDiagnosticEventSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppxPackagingDiagnosticEventSink value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
