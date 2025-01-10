// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

/// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule"]/*'/>
public unsafe partial struct CHttpModule : CHttpModule.Interface
{
    public void*** lpVtbl;

    public CHttpModule() { }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnBeginRequest"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public REQUEST_NOTIFICATION_STATUS OnBeginRequest(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[0])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostBeginRequest"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public REQUEST_NOTIFICATION_STATUS OnPostBeginRequest(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[1])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnAuthenticateRequest"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public REQUEST_NOTIFICATION_STATUS OnAuthenticateRequest(
        IHttpContext* pHttpContext,
        IAuthenticationProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IAuthenticationProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[2])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostAuthenticateRequest"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public REQUEST_NOTIFICATION_STATUS OnPostAuthenticateRequest(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[3])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnAuthorizeRequest"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public REQUEST_NOTIFICATION_STATUS OnAuthorizeRequest(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[4])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostAuthorizeRequest"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public REQUEST_NOTIFICATION_STATUS OnPostAuthorizeRequest(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[5])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnResolveRequestCache"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public REQUEST_NOTIFICATION_STATUS OnResolveRequestCache(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[6])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostResolveRequestCache"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public REQUEST_NOTIFICATION_STATUS OnPostResolveRequestCache(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[7])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnMapRequestHandler"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public REQUEST_NOTIFICATION_STATUS OnMapRequestHandler(
        IHttpContext* pHttpContext,
        IMapHandlerProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IMapHandlerProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[8])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostMapRequestHandler"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public REQUEST_NOTIFICATION_STATUS OnPostMapRequestHandler(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[9])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnAcquireRequestState"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public REQUEST_NOTIFICATION_STATUS OnAcquireRequestState(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[10])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostAcquireRequestState"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public REQUEST_NOTIFICATION_STATUS OnPostAcquireRequestState(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[11])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPreExecuteRequestHandler"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public REQUEST_NOTIFICATION_STATUS OnPreExecuteRequestHandler(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[12])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostPreExecuteRequestHandler"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public REQUEST_NOTIFICATION_STATUS OnPostPreExecuteRequestHandler(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[13])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnExecuteRequestHandler"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public REQUEST_NOTIFICATION_STATUS OnExecuteRequestHandler(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[14])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostExecuteRequestHandler"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public REQUEST_NOTIFICATION_STATUS OnPostExecuteRequestHandler(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[15])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnReleaseRequestState"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public REQUEST_NOTIFICATION_STATUS OnReleaseRequestState(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[16])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostReleaseRequestState"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public REQUEST_NOTIFICATION_STATUS OnPostReleaseRequestState(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[17])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnUpdateRequestCache"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public REQUEST_NOTIFICATION_STATUS OnUpdateRequestCache(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[18])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostUpdateRequestCache"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public REQUEST_NOTIFICATION_STATUS OnPostUpdateRequestCache(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[19])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnLogRequest"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public REQUEST_NOTIFICATION_STATUS OnLogRequest(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[20])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostLogRequest"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public REQUEST_NOTIFICATION_STATUS OnPostLogRequest(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[21])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnEndRequest"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public REQUEST_NOTIFICATION_STATUS OnEndRequest(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[22])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnPostEndRequest"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public REQUEST_NOTIFICATION_STATUS OnPostEndRequest(
        IHttpContext* pHttpContext,
        IHttpEventProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IHttpEventProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[23])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnSendResponse"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public REQUEST_NOTIFICATION_STATUS OnSendResponse(
        IHttpContext* pHttpContext,
        ISendResponseProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                ISendResponseProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[24])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnMapPath"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public REQUEST_NOTIFICATION_STATUS OnMapPath(
        IHttpContext* pHttpContext,
        IMapPathProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IMapPathProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[25])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnReadEntity"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public REQUEST_NOTIFICATION_STATUS OnReadEntity(
        IHttpContext* pHttpContext,
        IReadEntityProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                IReadEntityProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[26])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnCustomRequestNotification"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public REQUEST_NOTIFICATION_STATUS OnCustomRequestNotification(
        IHttpContext* pHttpContext,
        ICustomNotificationProvider* pProvider
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                ICustomNotificationProvider*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[27])
        )((CHttpModule*)Unsafe.AsPointer(ref this), pHttpContext, pProvider);
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.OnAsyncCompletion"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public REQUEST_NOTIFICATION_STATUS OnAsyncCompletion(
        IHttpContext* pHttpContext,
        [NativeTypeName("DWORD")] uint dwNotification,
        BOOL fPostNotification,
        IHttpEventProvider* pProvider,
        IHttpCompletionInfo* pCompletionInfo
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                CHttpModule*,
                IHttpContext*,
                uint,
                BOOL,
                IHttpEventProvider*,
                IHttpCompletionInfo*,
                REQUEST_NOTIFICATION_STATUS>)((*lpVtbl)[28])
        )(
            (CHttpModule*)Unsafe.AsPointer(ref this),
            pHttpContext,
            dwNotification,
            fPostNotification,
            pProvider,
            pCompletionInfo
        );
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.Dispose"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public void Dispose()
    {
        ((delegate* unmanaged[MemberFunction]<CHttpModule*, void>)((*lpVtbl)[29]))(
            (CHttpModule*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='CHttpModule.xml' path='doc/member[@name="CHttpModule.Finalize"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void Destructor()
    {
        ((delegate* unmanaged[MemberFunction]<CHttpModule*, void>)((*lpVtbl)[30]))(
            (CHttpModule*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        REQUEST_NOTIFICATION_STATUS OnBeginRequest(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(1)]
        REQUEST_NOTIFICATION_STATUS OnPostBeginRequest(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(2)]
        REQUEST_NOTIFICATION_STATUS OnAuthenticateRequest(
            IHttpContext* pHttpContext,
            IAuthenticationProvider* pProvider
        );

        [VtblIndex(3)]
        REQUEST_NOTIFICATION_STATUS OnPostAuthenticateRequest(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(4)]
        REQUEST_NOTIFICATION_STATUS OnAuthorizeRequest(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(5)]
        REQUEST_NOTIFICATION_STATUS OnPostAuthorizeRequest(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(6)]
        REQUEST_NOTIFICATION_STATUS OnResolveRequestCache(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(7)]
        REQUEST_NOTIFICATION_STATUS OnPostResolveRequestCache(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(8)]
        REQUEST_NOTIFICATION_STATUS OnMapRequestHandler(
            IHttpContext* pHttpContext,
            IMapHandlerProvider* pProvider
        );

        [VtblIndex(9)]
        REQUEST_NOTIFICATION_STATUS OnPostMapRequestHandler(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(10)]
        REQUEST_NOTIFICATION_STATUS OnAcquireRequestState(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(11)]
        REQUEST_NOTIFICATION_STATUS OnPostAcquireRequestState(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(12)]
        REQUEST_NOTIFICATION_STATUS OnPreExecuteRequestHandler(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(13)]
        REQUEST_NOTIFICATION_STATUS OnPostPreExecuteRequestHandler(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(14)]
        REQUEST_NOTIFICATION_STATUS OnExecuteRequestHandler(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(15)]
        REQUEST_NOTIFICATION_STATUS OnPostExecuteRequestHandler(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(16)]
        REQUEST_NOTIFICATION_STATUS OnReleaseRequestState(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(17)]
        REQUEST_NOTIFICATION_STATUS OnPostReleaseRequestState(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(18)]
        REQUEST_NOTIFICATION_STATUS OnUpdateRequestCache(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(19)]
        REQUEST_NOTIFICATION_STATUS OnPostUpdateRequestCache(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(20)]
        REQUEST_NOTIFICATION_STATUS OnLogRequest(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(21)]
        REQUEST_NOTIFICATION_STATUS OnPostLogRequest(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(22)]
        REQUEST_NOTIFICATION_STATUS OnEndRequest(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(23)]
        REQUEST_NOTIFICATION_STATUS OnPostEndRequest(
            IHttpContext* pHttpContext,
            IHttpEventProvider* pProvider
        );

        [VtblIndex(24)]
        REQUEST_NOTIFICATION_STATUS OnSendResponse(
            IHttpContext* pHttpContext,
            ISendResponseProvider* pProvider
        );

        [VtblIndex(25)]
        REQUEST_NOTIFICATION_STATUS OnMapPath(
            IHttpContext* pHttpContext,
            IMapPathProvider* pProvider
        );

        [VtblIndex(26)]
        REQUEST_NOTIFICATION_STATUS OnReadEntity(
            IHttpContext* pHttpContext,
            IReadEntityProvider* pProvider
        );

        [VtblIndex(27)]
        REQUEST_NOTIFICATION_STATUS OnCustomRequestNotification(
            IHttpContext* pHttpContext,
            ICustomNotificationProvider* pProvider
        );

        [VtblIndex(28)]
        REQUEST_NOTIFICATION_STATUS OnAsyncCompletion(
            IHttpContext* pHttpContext,
            [NativeTypeName("DWORD")] uint dwNotification,
            BOOL fPostNotification,
            IHttpEventProvider* pProvider,
            IHttpCompletionInfo* pCompletionInfo
        );

        [VtblIndex(29)]
        void Dispose();

        [VtblIndex(30)]
        void Destructor();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnBeginRequest;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostBeginRequest;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IAuthenticationProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IAuthenticationProvider*,
            REQUEST_NOTIFICATION_STATUS> OnAuthenticateRequest;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostAuthenticateRequest;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnAuthorizeRequest;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostAuthorizeRequest;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnResolveRequestCache;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostResolveRequestCache;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IMapHandlerProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IMapHandlerProvider*,
            REQUEST_NOTIFICATION_STATUS> OnMapRequestHandler;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostMapRequestHandler;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnAcquireRequestState;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostAcquireRequestState;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPreExecuteRequestHandler;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostPreExecuteRequestHandler;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnExecuteRequestHandler;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostExecuteRequestHandler;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnReleaseRequestState;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostReleaseRequestState;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnUpdateRequestCache;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostUpdateRequestCache;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnLogRequest;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostLogRequest;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnEndRequest;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IHttpEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IHttpEventProvider*,
            REQUEST_NOTIFICATION_STATUS> OnPostEndRequest;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, ISendResponseProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            ISendResponseProvider*,
            REQUEST_NOTIFICATION_STATUS> OnSendResponse;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IMapPathProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IMapPathProvider*,
            REQUEST_NOTIFICATION_STATUS> OnMapPath;

        [NativeTypeName("REQUEST_NOTIFICATION_STATUS (IHttpContext *, IReadEntityProvider *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            IReadEntityProvider*,
            REQUEST_NOTIFICATION_STATUS> OnReadEntity;

        [NativeTypeName(
            "REQUEST_NOTIFICATION_STATUS (IHttpContext *, ICustomNotificationProvider *)"
        )]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            ICustomNotificationProvider*,
            REQUEST_NOTIFICATION_STATUS> OnCustomRequestNotification;

        [NativeTypeName(
            "REQUEST_NOTIFICATION_STATUS (IHttpContext *, DWORD, BOOL, IHttpEventProvider *, IHttpCompletionInfo *)"
        )]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            IHttpContext*,
            uint,
            BOOL,
            IHttpEventProvider*,
            IHttpCompletionInfo*,
            REQUEST_NOTIFICATION_STATUS> OnAsyncCompletion;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> Dispose;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> Destructor;
    }
}
