// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAppxPackagingDiagnosticEventSink.xml' path='doc/member[@name="IAppxPackagingDiagnosticEventSink"]/*' />
[Guid("17239D47-6ADB-45D2-80F6-F9CBC3BF059D")]
[NativeTypeName("struct IAppxPackagingDiagnosticEventSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxPackagingDiagnosticEventSink : IAppxPackagingDiagnosticEventSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxPackagingDiagnosticEventSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackagingDiagnosticEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink*, uint>)(lpVtbl[1]))((IAppxPackagingDiagnosticEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink*, uint>)(lpVtbl[2]))((IAppxPackagingDiagnosticEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxPackagingDiagnosticEventSink.xml' path='doc/member[@name="IAppxPackagingDiagnosticEventSink.ReportContextChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportContextChange(APPX_PACKAGING_CONTEXT_CHANGE_TYPE changeType, [NativeTypeName("LONG")] int contextId, [NativeTypeName("LPCSTR")] sbyte* contextName, [NativeTypeName("LPCWSTR")] ushort* contextMessage, [NativeTypeName("LPCWSTR")] ushort* detailsMessage)
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink*, APPX_PACKAGING_CONTEXT_CHANGE_TYPE, int, sbyte*, ushort*, ushort*, int>)(lpVtbl[3]))((IAppxPackagingDiagnosticEventSink*)Unsafe.AsPointer(ref this), changeType, contextId, contextName, contextMessage, detailsMessage);
    }

    /// <include file='IAppxPackagingDiagnosticEventSink.xml' path='doc/member[@name="IAppxPackagingDiagnosticEventSink.ReportError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReportError([NativeTypeName("LPCWSTR")] ushort* errorMessage)
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink*, ushort*, int>)(lpVtbl[4]))((IAppxPackagingDiagnosticEventSink*)Unsafe.AsPointer(ref this), errorMessage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReportContextChange(APPX_PACKAGING_CONTEXT_CHANGE_TYPE changeType, [NativeTypeName("LONG")] int contextId, [NativeTypeName("LPCSTR")] sbyte* contextName, [NativeTypeName("LPCWSTR")] ushort* contextMessage, [NativeTypeName("LPCWSTR")] ushort* detailsMessage);

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

        [NativeTypeName("HRESULT (APPX_PACKAGING_CONTEXT_CHANGE_TYPE, LONG, LPCSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPX_PACKAGING_CONTEXT_CHANGE_TYPE, int, sbyte*, ushort*, ushort*, int> ReportContextChange;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> ReportError;
    }
}
