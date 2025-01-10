// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

/// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse"]/*'/>
[Guid("7E1C6B38-628F-4E6C-95DC-41237EB7F95E")]
public unsafe partial struct IHttpResponse : IHttpResponse.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpResponse));
    public void*** lpVtbl;

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.GetRawHttpRequestConst"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("const HTTP_RESPONSE *")]
    public HTTP_RESPONSE_V2* GetRawHttpRequestConst()
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse*, HTTP_RESPONSE_V2*>)((*lpVtbl)[0])
        )((IHttpResponse*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.GetRawHttpResponse"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("HTTP_RESPONSE *")]
    public HTTP_RESPONSE_V2* GetRawHttpResponse()
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse*, HTTP_RESPONSE_V2*>)((*lpVtbl)[1])
        )((IHttpResponse*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.GetCachePolicy"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpCachePolicy* GetCachePolicy()
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse*, IHttpCachePolicy*>)((*lpVtbl)[2])
        )((IHttpResponse*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.SetStatus"]/*'/>

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
                IHttpResponse*,
                ushort,
                sbyte*,
                ushort,
                HRESULT,
                IAppHostConfigException,
                BOOL,
                int>)((*lpVtbl)[3])
        )(
            (IHttpResponse*)Unsafe.AsPointer(ref this),
            statusCode,
            pszReason,
            uSubStatus,
            hrErrorToReport,
            pException,
            fTrySkipCustomErrors
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.SetHeader"]/*'/>

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
                IHttpResponse*,
                HTTP_HEADER_ID,
                sbyte*,
                ushort,
                BOOL,
                int>)((*lpVtbl)[4])
        )(
            (IHttpResponse*)Unsafe.AsPointer(ref this),
            ulHeaderIndex,
            pszHeaderValue,
            cchHeaderValue,
            fReplace
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.SetHeader"]/*'/>

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
                IHttpResponse*,
                sbyte*,
                sbyte*,
                ushort,
                BOOL,
                int>)((*lpVtbl)[5])
        )(
            (IHttpResponse*)Unsafe.AsPointer(ref this),
            pszHeaderName,
            pszHeaderValue,
            cchHeaderValue,
            fReplace
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.DeleteHeader"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteHeader(HTTP_HEADER_ID ulHeaderIndex)
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse*, HTTP_HEADER_ID, int>)((*lpVtbl)[6])
        )((IHttpResponse*)Unsafe.AsPointer(ref this), ulHeaderIndex);
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.DeleteHeader"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DeleteHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponse*, sbyte*, int>)((*lpVtbl)[7]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this),
            pszHeaderName
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.GetHeader"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHeader(HTTP_HEADER_ID ulHeaderIndex, ushort* pcchHeaderValue = null)
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse*, HTTP_HEADER_ID, ushort*, sbyte*>)(
                (*lpVtbl)[8]
            )
        )((IHttpResponse*)Unsafe.AsPointer(ref this), ulHeaderIndex, pcchHeaderValue);
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.GetHeader"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHeader(
        [NativeTypeName("PCSTR")] sbyte* pszHeaderName,
        ushort* pcchHeaderValue = null
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse*, sbyte*, ushort*, sbyte*>)(
                (*lpVtbl)[9]
            )
        )((IHttpResponse*)Unsafe.AsPointer(ref this), pszHeaderName, pcchHeaderValue);
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.Clear"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void Clear()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse*, void>)((*lpVtbl)[10]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.ClearHeaders"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void ClearHeaders()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse*, void>)((*lpVtbl)[11]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.SetNeedDisconnect"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void SetNeedDisconnect()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse*, void>)((*lpVtbl)[12]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.ResetConnection"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void ResetConnection()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse*, void>)((*lpVtbl)[13]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.DisableKernelCache"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void DisableKernelCache([NativeTypeName("ULONG")] uint reason = 9)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse*, uint, void>)((*lpVtbl)[14]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this),
            reason
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.GetKernelCacheEnabled"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public BOOL GetKernelCacheEnabled()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponse*, int>)((*lpVtbl)[15]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.SuppressHeaders"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void SuppressHeaders()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse*, void>)((*lpVtbl)[16]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.GetHeadersSuppressed"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public BOOL GetHeadersSuppressed()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponse*, int>)((*lpVtbl)[17]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.Flush"]/*'/>

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
            (delegate* unmanaged[MemberFunction]<IHttpResponse*, BOOL, BOOL, uint*, BOOL*, int>)(
                (*lpVtbl)[18]
            )
        )(
            (IHttpResponse*)Unsafe.AsPointer(ref this),
            fAsync,
            fMoreData,
            pcbSent,
            pfCompletionExpected
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.Redirect"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Redirect(
        [NativeTypeName("PCSTR")] sbyte* pszUrl,
        [Optional, DefaultParameterValue(1)] BOOL fResetStatusCode,
        [Optional] BOOL fIncludeParameters
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse*, sbyte*, BOOL, BOOL, int>)(
                (*lpVtbl)[19]
            )
        )((IHttpResponse*)Unsafe.AsPointer(ref this), pszUrl, fResetStatusCode, fIncludeParameters);
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.WriteEntityChunkByReference"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteEntityChunkByReference(
        HTTP_DATA_CHUNK* pDataChunk,
        [NativeTypeName("LONG")] int lInsertPosition = -1
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse*, HTTP_DATA_CHUNK*, int, int>)(
                (*lpVtbl)[20]
            )
        )((IHttpResponse*)Unsafe.AsPointer(ref this), pDataChunk, lInsertPosition);
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.WriteEntityChunks"]/*'/>

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
                IHttpResponse*,
                HTTP_DATA_CHUNK*,
                uint,
                BOOL,
                BOOL,
                uint*,
                BOOL*,
                int>)((*lpVtbl)[21])
        )(
            (IHttpResponse*)Unsafe.AsPointer(ref this),
            pDataChunks,
            nChunks,
            fAsync,
            fMoreData,
            pcbSent,
            pfCompletionExpected
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.DisableBuffering"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void DisableBuffering()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse*, void>)((*lpVtbl)[22]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.GetStatus"]/*'/>

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
                IHttpResponse*,
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
            (IHttpResponse*)Unsafe.AsPointer(ref this),
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

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.SetErrorDescription"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetErrorDescription(
        [NativeTypeName("PCWSTR")] char* pszDescription,
        [NativeTypeName("DWORD")] uint cchDescription,
        [Optional, DefaultParameterValue(1)] BOOL fHtmlEncode
    )
    {
        return (
            (delegate* unmanaged[MemberFunction]<IHttpResponse*, char*, uint, BOOL, int>)(
                (*lpVtbl)[24]
            )
        )((IHttpResponse*)Unsafe.AsPointer(ref this), pszDescription, cchDescription, fHtmlEncode);
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.GetErrorDescription"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetErrorDescription([NativeTypeName("DWORD *")] uint* pcchDescription = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponse*, uint*, char*>)((*lpVtbl)[25]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this),
            pcchDescription
        );
    }

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.GetHeaderChanges"]/*'/>

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
                IHttpResponse*,
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
            (IHttpResponse*)Unsafe.AsPointer(ref this),
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

    /// <include file='IHttpResponse.xml' path='doc/member[@name="IHttpResponse.CloseConnection"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void CloseConnection()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpResponse*, void>)((*lpVtbl)[27]))(
            (IHttpResponse*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("const HTTP_RESPONSE *")]
        HTTP_RESPONSE_V2* GetRawHttpRequestConst();

        [VtblIndex(1)]
        [return: NativeTypeName("HTTP_RESPONSE *")]
        HTTP_RESPONSE_V2* GetRawHttpResponse();

        [VtblIndex(2)]
        IHttpCachePolicy* GetCachePolicy();

        [VtblIndex(3)]
        HRESULT SetStatus(
            ushort statusCode,
            [NativeTypeName("PCSTR")] sbyte* pszReason,
            [Optional] ushort uSubStatus,
            [Optional, DefaultParameterValue(0)] HRESULT hrErrorToReport,
            [Optional] IAppHostConfigException pException,
            [Optional] BOOL fTrySkipCustomErrors
        );

        [VtblIndex(4)]
        HRESULT SetHeader(
            HTTP_HEADER_ID ulHeaderIndex,
            [NativeTypeName("PCSTR")] sbyte* pszHeaderValue,
            ushort cchHeaderValue,
            BOOL fReplace
        );

        [VtblIndex(5)]
        HRESULT SetHeader(
            [NativeTypeName("PCSTR")] sbyte* pszHeaderName,
            [NativeTypeName("PCSTR")] sbyte* pszHeaderValue,
            ushort cchHeaderValue,
            BOOL fReplace
        );

        [VtblIndex(6)]
        HRESULT DeleteHeader(HTTP_HEADER_ID ulHeaderIndex);

        [VtblIndex(7)]
        HRESULT DeleteHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName);

        [VtblIndex(8)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetHeader(HTTP_HEADER_ID ulHeaderIndex, ushort* pcchHeaderValue = null);

        [VtblIndex(9)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetHeader(
            [NativeTypeName("PCSTR")] sbyte* pszHeaderName,
            ushort* pcchHeaderValue = null
        );

        [VtblIndex(10)]
        void Clear();

        [VtblIndex(11)]
        void ClearHeaders();

        [VtblIndex(12)]
        void SetNeedDisconnect();

        [VtblIndex(13)]
        void ResetConnection();

        [VtblIndex(14)]
        void DisableKernelCache([NativeTypeName("ULONG")] uint reason = 9);

        [VtblIndex(15)]
        BOOL GetKernelCacheEnabled();

        [VtblIndex(16)]
        void SuppressHeaders();

        [VtblIndex(17)]
        BOOL GetHeadersSuppressed();

        [VtblIndex(18)]
        HRESULT Flush(
            BOOL fAsync,
            BOOL fMoreData,
            [NativeTypeName("DWORD *")] uint* pcbSent,
            BOOL* pfCompletionExpected = null
        );

        [VtblIndex(19)]
        HRESULT Redirect(
            [NativeTypeName("PCSTR")] sbyte* pszUrl,
            [Optional, DefaultParameterValue(1)] BOOL fResetStatusCode,
            [Optional] BOOL fIncludeParameters
        );

        [VtblIndex(20)]
        HRESULT WriteEntityChunkByReference(
            HTTP_DATA_CHUNK* pDataChunk,
            [NativeTypeName("LONG")] int lInsertPosition = -1
        );

        [VtblIndex(21)]
        HRESULT WriteEntityChunks(
            HTTP_DATA_CHUNK* pDataChunks,
            [NativeTypeName("DWORD")] uint nChunks,
            BOOL fAsync,
            BOOL fMoreData,
            [NativeTypeName("DWORD *")] uint* pcbSent,
            BOOL* pfCompletionExpected = null
        );

        [VtblIndex(22)]
        void DisableBuffering();

        [VtblIndex(23)]
        void GetStatus(
            ushort* pStatusCode,
            ushort* pSubStatus = null,
            [NativeTypeName("PCSTR *")] sbyte** ppszReason = null,
            ushort* pcchReason = null,
            HRESULT* phrErrorToReport = null,
            [NativeTypeName("PCWSTR *")] char** ppszModule = null,
            [NativeTypeName("DWORD *")] uint* pdwNotification = null,
            IAppHostConfigException* ppException = null,
            BOOL* pfTrySkipCustomErrors = null
        );

        [VtblIndex(24)]
        HRESULT SetErrorDescription(
            [NativeTypeName("PCWSTR")] char* pszDescription,
            [NativeTypeName("DWORD")] uint cchDescription,
            [Optional, DefaultParameterValue(1)] BOOL fHtmlEncode
        );

        [VtblIndex(25)]
        [return: NativeTypeName("PCWSTR")]
        char* GetErrorDescription([NativeTypeName("DWORD *")] uint* pcchDescription = null);

        [VtblIndex(26)]
        HRESULT GetHeaderChanges(
            [NativeTypeName("DWORD")] uint dwOldChangeNumber,
            [NativeTypeName("DWORD *")] uint* pdwNewChangeNumber,
            [NativeTypeName("PCSTR[30]")] sbyte** knownHeaderSnapshot,
            [NativeTypeName("DWORD *")] uint* pdwUnknownHeaderSnapshot,
            [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderNameSnapshot,
            [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderValueSnapshot,
            [NativeTypeName("DWORD[31]")] uint* diffedKnownHeaderIndices,
            [NativeTypeName("DWORD *")] uint* pdwDiffedUnknownHeaders,
            [NativeTypeName("DWORD **")] uint** ppDiffedUnknownHeaderIndices
        );

        [VtblIndex(27)]
        void CloseConnection();
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
    }
}
