// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

/// <include file='IHttpResponse4.xml' path='doc/member[@name="IHttpResponse4"]/*'/>
[Guid("1A2ACC57-CAE2-4F28-B4AB-00C8F96B12EC")]
[NativeTypeName("struct IHttpResponse4 : IHttpResponse3")]
[NativeInheritance("IHttpResponse3")]
public unsafe partial struct IHttpResponse4 : IHttpResponse4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpResponse4));
    public void*** lpVtbl;

    /// <inheritdoc cref = "IHttpResponse.GetRawHttpRequestConst"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("const HTTP_RESPONSE *")]
    public HTTP_RESPONSE_V2* GetRawHttpRequestConst()
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, HTTP_RESPONSE_V2*>)((*lpVtbl)[0])
        )((IHttpResponse4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IHttpResponse.GetRawHttpResponse"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("HTTP_RESPONSE *")]
    public HTTP_RESPONSE_V2* GetRawHttpResponse()
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, HTTP_RESPONSE_V2*>)((*lpVtbl)[1])
        )((IHttpResponse4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IHttpResponse.GetCachePolicy"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpCachePolicy* GetCachePolicy()
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, IHttpCachePolicy*>)((*lpVtbl)[2])
        )((IHttpResponse4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IHttpResponse.SetStatus"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetStatus(
        ushort statusCode,
        [NativeTypeName("PCSTR")] sbyte* pszReason,
        [Optional] ushort uSubStatus,
        [Optional, DefaultParameterValue(0)] HRESULT hrErrorToReport,
        [Optional] IAppHostConfigException pException,
        [Optional] BOOL fTrySkipCustomErrors
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpResponse4*,
                ushort,
                sbyte*,
                ushort,
                HRESULT,
                IAppHostConfigException,
                BOOL,
                int>)((*lpVtbl)[3])
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            statusCode,
            pszReason,
            uSubStatus,
            hrErrorToReport,
            pException,
            fTrySkipCustomErrors
        );
    }

    /// <inheritdoc cref = "IHttpResponse.SetHeader"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetHeader(
        HTTP_HEADER_ID ulHeaderIndex,
        [NativeTypeName("PCSTR")] sbyte* pszHeaderValue,
        ushort cchHeaderValue,
        BOOL fReplace
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpResponse4*,
                HTTP_HEADER_ID,
                sbyte*,
                ushort,
                BOOL,
                int>)((*lpVtbl)[4])
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            ulHeaderIndex,
            pszHeaderValue,
            cchHeaderValue,
            fReplace
        );
    }

    /// <inheritdoc cref = "IHttpResponse.SetHeader"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetHeader(
        [NativeTypeName("PCSTR")] sbyte* pszHeaderName,
        [NativeTypeName("PCSTR")] sbyte* pszHeaderValue,
        ushort cchHeaderValue,
        BOOL fReplace
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpResponse4*,
                sbyte*,
                sbyte*,
                ushort,
                BOOL,
                int>)((*lpVtbl)[5])
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            pszHeaderName,
            pszHeaderValue,
            cchHeaderValue,
            fReplace
        );
    }

    /// <inheritdoc cref = "IHttpResponse.DeleteHeader"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteHeader(HTTP_HEADER_ID ulHeaderIndex)
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, HTTP_HEADER_ID, int>)(
                (*lpVtbl)[6]
            )
        )((IHttpResponse4*)Unsafe.AsPointer(ref this), ulHeaderIndex);
    }

    /// <inheritdoc cref = "IHttpResponse.DeleteHeader"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DeleteHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, sbyte*, int>)((*lpVtbl)[7]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            pszHeaderName
        );
    }

    /// <inheritdoc cref = "IHttpResponse.GetHeader"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHeader(HTTP_HEADER_ID ulHeaderIndex, ushort* pcchHeaderValue = null)
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, HTTP_HEADER_ID, ushort*, sbyte*>)(
                (*lpVtbl)[8]
            )
        )((IHttpResponse4*)Unsafe.AsPointer(ref this), ulHeaderIndex, pcchHeaderValue);
    }

    /// <inheritdoc cref = "IHttpResponse.GetHeader"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHeader(
        [NativeTypeName("PCSTR")] sbyte* pszHeaderName,
        ushort* pcchHeaderValue = null
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, sbyte*, ushort*, sbyte*>)(
                (*lpVtbl)[9]
            )
        )((IHttpResponse4*)Unsafe.AsPointer(ref this), pszHeaderName, pcchHeaderValue);
    }

    /// <inheritdoc cref = "IHttpResponse.Clear"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void Clear()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, void>)((*lpVtbl)[10]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IHttpResponse.ClearHeaders"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void ClearHeaders()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, void>)((*lpVtbl)[11]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IHttpResponse.SetNeedDisconnect"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void SetNeedDisconnect()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, void>)((*lpVtbl)[12]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IHttpResponse.ResetConnection"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void ResetConnection()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, void>)((*lpVtbl)[13]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IHttpResponse.DisableKernelCache"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void DisableKernelCache([NativeTypeName("ULONG")] uint reason = 9)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, uint, void>)((*lpVtbl)[14]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            reason
        );
    }

    /// <inheritdoc cref = "IHttpResponse.GetKernelCacheEnabled"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public BOOL GetKernelCacheEnabled()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, int>)((*lpVtbl)[15]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IHttpResponse.SuppressHeaders"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void SuppressHeaders()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, void>)((*lpVtbl)[16]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IHttpResponse.GetHeadersSuppressed"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public BOOL GetHeadersSuppressed()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, int>)((*lpVtbl)[17]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IHttpResponse.Flush"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Flush(
        BOOL fAsync,
        BOOL fMoreData,
        [NativeTypeName("DWORD *")] uint* pcbSent,
        BOOL* pfCompletionExpected = null
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, BOOL, BOOL, uint*, BOOL*, int>)(
                (*lpVtbl)[18]
            )
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            fAsync,
            fMoreData,
            pcbSent,
            pfCompletionExpected
        );
    }

    /// <inheritdoc cref = "IHttpResponse.Redirect"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Redirect(
        [NativeTypeName("PCSTR")] sbyte* pszUrl,
        [Optional, DefaultParameterValue(1)] BOOL fResetStatusCode,
        [Optional] BOOL fIncludeParameters
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, sbyte*, BOOL, BOOL, int>)(
                (*lpVtbl)[19]
            )
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            pszUrl,
            fResetStatusCode,
            fIncludeParameters
        );
    }

    /// <inheritdoc cref = "IHttpResponse.WriteEntityChunkByReference"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteEntityChunkByReference(
        HTTP_DATA_CHUNK* pDataChunk,
        [NativeTypeName("LONG")] int lInsertPosition = -1
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, HTTP_DATA_CHUNK*, int, int>)(
                (*lpVtbl)[20]
            )
        )((IHttpResponse4*)Unsafe.AsPointer(ref this), pDataChunk, lInsertPosition);
    }

    /// <inheritdoc cref = "IHttpResponse.WriteEntityChunks"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT WriteEntityChunks(
        HTTP_DATA_CHUNK* pDataChunks,
        [NativeTypeName("DWORD")] uint nChunks,
        BOOL fAsync,
        BOOL fMoreData,
        [NativeTypeName("DWORD *")] uint* pcbSent,
        BOOL* pfCompletionExpected = null
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpResponse4*,
                HTTP_DATA_CHUNK*,
                uint,
                BOOL,
                BOOL,
                uint*,
                BOOL*,
                int>)((*lpVtbl)[21])
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            pDataChunks,
            nChunks,
            fAsync,
            fMoreData,
            pcbSent,
            pfCompletionExpected
        );
    }

    /// <inheritdoc cref = "IHttpResponse.DisableBuffering"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void DisableBuffering()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, void>)((*lpVtbl)[22]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IHttpResponse.GetStatus"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void GetStatus(
        ushort* pStatusCode,
        ushort* pSubStatus = null,
        [NativeTypeName("PCSTR *")] sbyte** ppszReason = null,
        ushort* pcchReason = null,
        HRESULT* phrErrorToReport = null,
        [NativeTypeName("PCWSTR *")] char** ppszModule = null,
        [NativeTypeName("DWORD *")] uint* pdwNotification = null,
        IAppHostConfigException* ppException = null,
        BOOL* pfTrySkipCustomErrors = null
    )
    {
        (
            (delegate* unmanaged[MemberFunction]<
                IHttpResponse4*,
                ushort*,
                ushort*,
                sbyte**,
                ushort*,
                HRESULT*,
                char**,
                uint*,
                IAppHostConfigException*,
                BOOL*,
                void>)((*lpVtbl)[23])
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            pStatusCode,
            pSubStatus,
            ppszReason,
            pcchReason,
            phrErrorToReport,
            ppszModule,
            pdwNotification,
            ppException,
            pfTrySkipCustomErrors
        );
    }

    /// <inheritdoc cref = "IHttpResponse.SetErrorDescription"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetErrorDescription(
        [NativeTypeName("PCWSTR")] char* pszDescription,
        [NativeTypeName("DWORD")] uint cchDescription,
        [Optional, DefaultParameterValue(1)] BOOL fHtmlEncode
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, char*, uint, BOOL, int>)(
                (*lpVtbl)[24]
            )
        )((IHttpResponse4*)Unsafe.AsPointer(ref this), pszDescription, cchDescription, fHtmlEncode);
    }

    /// <inheritdoc cref = "IHttpResponse.GetErrorDescription"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetErrorDescription([NativeTypeName("DWORD *")] uint* pcchDescription = null)
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, uint*, char*>)((*lpVtbl)[25])
        )((IHttpResponse4*)Unsafe.AsPointer(ref this), pcchDescription);
    }

    /// <inheritdoc cref = "IHttpResponse.GetHeaderChanges"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetHeaderChanges(
        [NativeTypeName("DWORD")] uint dwOldChangeNumber,
        [NativeTypeName("DWORD *")] uint* pdwNewChangeNumber,
        [NativeTypeName("PCSTR[30]")] sbyte** knownHeaderSnapshot,
        [NativeTypeName("DWORD *")] uint* pdwUnknownHeaderSnapshot,
        [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderNameSnapshot,
        [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderValueSnapshot,
        [NativeTypeName("DWORD[31]")] uint* diffedKnownHeaderIndices,
        [NativeTypeName("DWORD *")] uint* pdwDiffedUnknownHeaders,
        [NativeTypeName("DWORD **")] uint** ppDiffedUnknownHeaderIndices
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpResponse4*,
                uint,
                uint*,
                sbyte**,
                uint*,
                sbyte***,
                sbyte***,
                uint*,
                uint*,
                uint**,
                int>)((*lpVtbl)[26])
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            dwOldChangeNumber,
            pdwNewChangeNumber,
            knownHeaderSnapshot,
            pdwUnknownHeaderSnapshot,
            ppUnknownHeaderNameSnapshot,
            ppUnknownHeaderValueSnapshot,
            diffedKnownHeaderIndices,
            pdwDiffedUnknownHeaders,
            ppDiffedUnknownHeaderIndices
        );
    }

    /// <inheritdoc cref = "IHttpResponse.CloseConnection"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void CloseConnection()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, void>)((*lpVtbl)[27]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IHttpResponse2.WriteEntityChunks"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT WriteEntityChunks(
        HTTP_DATA_CHUNK* pDataChunks,
        [NativeTypeName("DWORD")] uint nChunks,
        BOOL fAsync,
        BOOL fMoreData,
        [NativeTypeName("PFN_ASYNC_COMPLETION")]
            delegate* unmanaged<
            IHttpContext3*,
            IHttpCompletionInfo2*,
            void*,
            REQUEST_NOTIFICATION_STATUS> pfnCompletionCallback,
        void* pvCompletionContext,
        [NativeTypeName("DWORD *")] uint* pcbSent,
        BOOL* pfCompletionExpected = null
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpResponse4*,
                HTTP_DATA_CHUNK*,
                uint,
                BOOL,
                BOOL,
                delegate* unmanaged<
                    IHttpContext3*,
                    IHttpCompletionInfo2*,
                    void*,
                    REQUEST_NOTIFICATION_STATUS>,
                void*,
                uint*,
                BOOL*,
                int>)((*lpVtbl)[28])
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            pDataChunks,
            nChunks,
            fAsync,
            fMoreData,
            pfnCompletionCallback,
            pvCompletionContext,
            pcbSent,
            pfCompletionExpected
        );
    }

    /// <inheritdoc cref = "IHttpResponse2.Flush"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT Flush(
        BOOL fAsync,
        BOOL fMoreData,
        [NativeTypeName("PFN_ASYNC_COMPLETION")]
            delegate* unmanaged<
            IHttpContext3*,
            IHttpCompletionInfo2*,
            void*,
            REQUEST_NOTIFICATION_STATUS> pfnCompletionCallback,
        void* pvCompletionContext,
        [NativeTypeName("DWORD *")] uint* pcbSent,
        BOOL* pfCompletionExpected = null
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpResponse4*,
                BOOL,
                BOOL,
                delegate* unmanaged<
                    IHttpContext3*,
                    IHttpCompletionInfo2*,
                    void*,
                    REQUEST_NOTIFICATION_STATUS>,
                void*,
                uint*,
                BOOL*,
                int>)((*lpVtbl)[29])
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            fAsync,
            fMoreData,
            pfnCompletionCallback,
            pvCompletionContext,
            pcbSent,
            pfCompletionExpected
        );
    }

    /// <inheritdoc cref = "IHttpResponse3.PushPromise"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT PushPromise(
        [NativeTypeName("PCSTR")] sbyte* pszVerb,
        [NativeTypeName("PCWSTR")] char* pwszPath,
        [NativeTypeName("PCWSTR")] char* pwszQuery,
        [NativeTypeName("DWORD")] uint cHeaders,
        [NativeTypeName("PCSTR *")] sbyte** rgHeaderNames,
        [NativeTypeName("PCSTR *")] sbyte** rgHeaderValues
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpResponse4*,
                sbyte*,
                char*,
                char*,
                uint,
                sbyte**,
                sbyte**,
                int>)((*lpVtbl)[30])
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            pszVerb,
            pwszPath,
            pwszQuery,
            cHeaders,
            rgHeaderNames,
            rgHeaderValues
        );
    }

    /// <include file='IHttpResponse4.xml' path='doc/member[@name="IHttpResponse4.DeleteTrailer"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT DeleteTrailer([NativeTypeName("PCSTR")] sbyte* pszHeaderName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, sbyte*, int>)((*lpVtbl)[31]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            pszHeaderName
        );
    }

    /// <include file='IHttpResponse4.xml' path='doc/member[@name="IHttpResponse4.GetTrailer"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetTrailer(
        [NativeTypeName("PCSTR")] sbyte* pszHeaderName,
        ushort* pcchHeaderValue = null
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse4*, sbyte*, ushort*, sbyte*>)(
                (*lpVtbl)[32]
            )
        )((IHttpResponse4*)Unsafe.AsPointer(ref this), pszHeaderName, pcchHeaderValue);
    }

    /// <include file='IHttpResponse4.xml' path='doc/member[@name="IHttpResponse4.ResetStream"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public void ResetStream([NativeTypeName("ULONG")] uint errorCode)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, uint, void>)((*lpVtbl)[33]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            errorCode
        );
    }

    /// <include file='IHttpResponse4.xml' path='doc/member[@name="IHttpResponse4.SetNeedGoAway"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void SetNeedGoAway()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse4*, void>)((*lpVtbl)[34]))(
            (IHttpResponse4*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='IHttpResponse4.xml' path='doc/member[@name="IHttpResponse4.SetTrailer"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetTrailer(
        [NativeTypeName("PCSTR")] sbyte* pszHeaderName,
        [NativeTypeName("PCSTR")] sbyte* pszHeaderValue,
        ushort cchHeaderValue,
        BOOL fReplace
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<
                IHttpResponse4*,
                sbyte*,
                sbyte*,
                ushort,
                BOOL,
                int>)((*lpVtbl)[35])
        )(
            (IHttpResponse4*)Unsafe.AsPointer(ref this),
            pszHeaderName,
            pszHeaderValue,
            cchHeaderValue,
            fReplace
        );
    }

    public interface Interface : IHttpResponse3.Interface
    {
        [VtblIndex(31)]
        HRESULT DeleteTrailer([NativeTypeName("PCSTR")] sbyte* pszHeaderName);

        [VtblIndex(32)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetTrailer(
            [NativeTypeName("PCSTR")] sbyte* pszHeaderName,
            ushort* pcchHeaderValue = null
        );

        [VtblIndex(33)]
        void ResetStream([NativeTypeName("ULONG")] uint errorCode);

        [VtblIndex(34)]
        void SetNeedGoAway();

        [VtblIndex(35)]
        HRESULT SetTrailer(
            [NativeTypeName("PCSTR")] sbyte* pszHeaderName,
            [NativeTypeName("PCSTR")] sbyte* pszHeaderValue,
            ushort cchHeaderValue,
            BOOL fReplace
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("const HTTP_RESPONSE *() const")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            HTTP_RESPONSE_V2*> GetRawHttpRequestConst;

        [NativeTypeName("HTTP_RESPONSE *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_RESPONSE_V2*> GetRawHttpResponse1;

        [NativeTypeName("IHttpCachePolicy *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCachePolicy*> GetCachePolicy;

        [NativeTypeName(
            "HRESULT (USHORT, PCSTR, USHORT, HRESULT, IAppHostConfigException *, BOOL)"
        )]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            ushort,
            sbyte*,
            ushort,
            HRESULT,
            IAppHostConfigException,
            BOOL,
            int> SetStatus;

        [NativeTypeName("HRESULT (HTTP_HEADER_ID, PCSTR, USHORT, BOOL)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            HTTP_HEADER_ID,
            sbyte*,
            ushort,
            BOOL,
            int> SetHeader;

        [NativeTypeName("HRESULT (PCSTR, PCSTR, USHORT, BOOL)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            sbyte*,
            sbyte*,
            ushort,
            BOOL,
            int> SetHeader1;

        [NativeTypeName("HRESULT (HTTP_HEADER_ID)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_HEADER_ID, int> DeleteHeader;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int> DeleteHeader1;

        [NativeTypeName("PCSTR (HTTP_HEADER_ID, USHORT *) const")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            HTTP_HEADER_ID,
            ushort*,
            sbyte*> GetHeader;

        [NativeTypeName("PCSTR (PCSTR, USHORT *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, ushort*, sbyte*> GetHeader1;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> Clear;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> ClearHeaders;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> SetNeedDisconnect;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> ResetConnection;

        [NativeTypeName("void (ULONG)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> DisableKernelCache;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> GetKernelCacheEnabled;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> SuppressHeaders;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> GetHeadersSuppressed;

        [NativeTypeName("HRESULT (BOOL, BOOL, DWORD *, BOOL *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, BOOL, uint*, BOOL*, int> Flush;

        [NativeTypeName("HRESULT (PCSTR, BOOL, BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, BOOL, BOOL, int> Redirect;

        [NativeTypeName("HRESULT (HTTP_DATA_CHUNK *, LONG)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            HTTP_DATA_CHUNK*,
            int,
            int> WriteEntityChunkByReference;

        [NativeTypeName("HRESULT (HTTP_DATA_CHUNK *, DWORD, BOOL, BOOL, DWORD *, BOOL *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            HTTP_DATA_CHUNK*,
            uint,
            BOOL,
            BOOL,
            uint*,
            BOOL*,
            int> WriteEntityChunks;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DisableBuffering;

        [NativeTypeName(
            "void (USHORT *, USHORT *, PCSTR *, USHORT *, HRESULT *, PCWSTR *, DWORD *, IAppHostConfigException **, BOOL *)"
        )]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            ushort*,
            ushort*,
            sbyte**,
            ushort*,
            HRESULT*,
            char**,
            uint*,
            IAppHostConfigException*,
            BOOL*,
            void> GetStatus;

        [NativeTypeName("HRESULT (PCWSTR, DWORD, BOOL)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            char*,
            uint,
            BOOL,
            int> SetErrorDescription;

        [NativeTypeName("PCWSTR (DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char*> GetErrorDescription;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD *, PCSTR *, DWORD *, PCSTR **, PCSTR **, DWORD *, DWORD *, DWORD **)"
        )]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            uint,
            uint*,
            sbyte**,
            uint*,
            sbyte***,
            sbyte***,
            uint*,
            uint*,
            uint**,
            int> GetHeaderChanges;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> CloseConnection;

        [NativeTypeName(
            "HRESULT (HTTP_DATA_CHUNK *, DWORD, BOOL, BOOL, PFN_ASYNC_COMPLETION, void *, DWORD *, BOOL *)"
        )]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            HTTP_DATA_CHUNK*,
            uint,
            BOOL,
            BOOL,
            delegate* unmanaged<
                IHttpContext3*,
                IHttpCompletionInfo2*,
                void*,
                REQUEST_NOTIFICATION_STATUS>,
            void*,
            uint*,
            BOOL*,
            int> WriteEntityChunks1;

        [NativeTypeName("HRESULT (BOOL, BOOL, PFN_ASYNC_COMPLETION, void *, DWORD *, BOOL *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            BOOL,
            BOOL,
            delegate* unmanaged<
                IHttpContext3*,
                IHttpCompletionInfo2*,
                void*,
                REQUEST_NOTIFICATION_STATUS>,
            void*,
            uint*,
            BOOL*,
            int> Flush1;

        [NativeTypeName("HRESULT (PCSTR, PCWSTR, PCWSTR, DWORD, PCSTR *, PCSTR *)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            sbyte*,
            char*,
            char*,
            uint,
            sbyte**,
            sbyte**,
            int> PushPromise;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int> DeleteTrailer;

        [NativeTypeName("PCSTR (PCSTR, USHORT *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, ushort*, sbyte*> GetTrailer;

        [NativeTypeName("void (ULONG)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> ResetStream;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> SetNeedGoAway;

        [NativeTypeName("HRESULT (PCSTR, PCSTR, USHORT, BOOL)")]
        public delegate* unmanaged[MemberFunction]<
            TSelf*,
            sbyte*,
            sbyte*,
            ushort,
            BOOL,
            int> SetTrailer;
    }
}
