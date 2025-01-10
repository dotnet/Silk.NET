// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

/// <include file='IHttpTraceContext.xml' path='doc/member[@name="IHttpTraceContext"]/*'/>
[Guid("9F9098D5-915C-4294-A52E-66532A232BC9")]
public unsafe partial struct IHttpTraceContext : IHttpTraceContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpTraceContext));
    public void*** lpVtbl;

    /// <include file='IHttpTraceContext.xml' path='doc/member[@name="IHttpTraceContext.GetTraceConfiguration"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetTraceConfiguration(HTTP_TRACE_CONFIGURATION* pHttpTraceConfiguration)
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpTraceContext*,
                HTTP_TRACE_CONFIGURATION*,
                int>)((*lpVtbl)[0])
        )((IHttpTraceContext*)Unsafe.AsPointer(ref this), pHttpTraceConfiguration);
    }

    /// <include file='IHttpTraceContext.xml' path='doc/member[@name="IHttpTraceContext.SetTraceConfiguration"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT SetTraceConfiguration(
        [NativeTypeName("HTTP_MODULE_ID")] void* moduleId,
        HTTP_TRACE_CONFIGURATION* pHttpTraceConfiguration,
        [NativeTypeName("DWORD")] uint cHttpTraceConfiguration = 1
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpTraceContext*,
                void*,
                HTTP_TRACE_CONFIGURATION*,
                uint,
                int>)((*lpVtbl)[1])
        )(
            (IHttpTraceContext*)Unsafe.AsPointer(ref this),
            moduleId,
            pHttpTraceConfiguration,
            cHttpTraceConfiguration
        );
    }

    /// <include file='IHttpTraceContext.xml' path='doc/member[@name="IHttpTraceContext.RaiseTraceEvent"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT RaiseTraceEvent(HTTP_TRACE_EVENT* pTraceEvent)
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpTraceContext*, HTTP_TRACE_EVENT*, int>)(
                (*lpVtbl)[2]
            )
        )((IHttpTraceContext*)Unsafe.AsPointer(ref this), pTraceEvent);
    }

    /// <include file='IHttpTraceContext.xml' path='doc/member[@name="IHttpTraceContext.GetTraceActivityId"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPCGUID")]
    public Guid* GetTraceActivityId()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTraceContext*, Guid*>)((*lpVtbl)[3]))(
            (IHttpTraceContext*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='IHttpTraceContext.xml' path='doc/member[@name="IHttpTraceContext.QuickTrace"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT QuickTrace(
        [NativeTypeName("PCWSTR")] char* pszData1,
        [NativeTypeName("PCWSTR")] [Optional] char* pszData2,
        [Optional, DefaultParameterValue(0)] HRESULT hrLastError,
        [NativeTypeName("UCHAR")] byte Level = 4
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpTraceContext*,
                char*,
                char*,
                HRESULT,
                byte,
                int>)((*lpVtbl)[4])
        )((IHttpTraceContext*)Unsafe.AsPointer(ref this), pszData1, pszData2, hrLastError, Level);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetTraceConfiguration(HTTP_TRACE_CONFIGURATION* pHttpTraceConfiguration);

        [VtblIndex(1)]
        HRESULT SetTraceConfiguration(
            [NativeTypeName("HTTP_MODULE_ID")] void* moduleId,
            HTTP_TRACE_CONFIGURATION* pHttpTraceConfiguration,
            [NativeTypeName("DWORD")] uint cHttpTraceConfiguration = 1
        );

        [VtblIndex(2)]
        HRESULT RaiseTraceEvent(HTTP_TRACE_EVENT* pTraceEvent);

        [VtblIndex(3)]
        [return: NativeTypeName("LPCGUID")]
        Guid* GetTraceActivityId();

        [VtblIndex(4)]
        HRESULT QuickTrace(
            [NativeTypeName("PCWSTR")] char* pszData1,
            [NativeTypeName("PCWSTR")] [Optional] char* pszData2,
            [Optional, DefaultParameterValue(0)] HRESULT hrLastError,
            [NativeTypeName("UCHAR")] byte Level = 4
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (HTTP_TRACE_CONFIGURATION *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            HTTP_TRACE_CONFIGURATION*,
            int> GetTraceConfiguration;

        [NativeTypeName("HRESULT (HTTP_MODULE_ID, HTTP_TRACE_CONFIGURATION *, DWORD)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            void*,
            HTTP_TRACE_CONFIGURATION*,
            uint,
            int> SetTraceConfiguration;

        [NativeTypeName("HRESULT (HTTP_TRACE_EVENT *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_TRACE_EVENT*, int> RaiseTraceEvent;

        [NativeTypeName("LPCGUID ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*> GetTraceActivityId;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, HRESULT, UCHAR)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            char*,
            char*,
            HRESULT,
            byte,
            int> QuickTrace;
    }
}
