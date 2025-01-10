// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3816F517-F631-49F0-8B51-16D6F0C6FFB2")]
[NativeTypeName("struct IHttpRequest4 : IHttpRequest3")]
[NativeInheritance("IHttpRequest3")]
public unsafe partial struct IHttpRequest4 : IHttpRequest4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpRequest4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("const HTTP_REQUEST *")]
    public HTTP_REQUEST_V2* GetRawHttpRequestConst()
    {
        return ((delegate* unmanaged<IHttpRequest4*, HTTP_REQUEST_V2*>)((*lpVtbl)[0]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("HTTP_REQUEST *")]
    public HTTP_REQUEST_V2* GetRawHttpRequest()
    {
        return ((delegate* unmanaged<IHttpRequest4*, HTTP_REQUEST_V2*>)((*lpVtbl)[1]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHeader(HTTP_HEADER_ID ulHeaderIndex, ushort* pcchHeaderValue = null)
    {
        return (
            (delegate* unmanaged<IHttpRequest4*, HTTP_HEADER_ID, ushort*, sbyte*>)((*lpVtbl)[2])
        )((IHttpRequest4*)Unsafe.AsPointer(ref this), ulHeaderIndex, pcchHeaderValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHeader(
        [NativeTypeName("PCSTR")] sbyte* pszHeaderName,
        ushort* pcchHeaderValue = null
    )
    {
        return ((delegate* unmanaged<IHttpRequest4*, sbyte*, ushort*, sbyte*>)((*lpVtbl)[3]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pszHeaderName,
            pcchHeaderValue
        );
    }

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
            (delegate* unmanaged<IHttpRequest4*, HTTP_HEADER_ID, sbyte*, ushort, BOOL, int>)(
                (*lpVtbl)[4]
            )
        )(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            ulHeaderIndex,
            pszHeaderValue,
            cchHeaderValue,
            fReplace
        );
    }

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
            (delegate* unmanaged<IHttpRequest4*, sbyte*, sbyte*, ushort, BOOL, int>)((*lpVtbl)[5])
        )(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pszHeaderName,
            pszHeaderValue,
            cchHeaderValue,
            fReplace
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteHeader(HTTP_HEADER_ID ulHeaderIndex)
    {
        return ((delegate* unmanaged<IHttpRequest4*, HTTP_HEADER_ID, int>)((*lpVtbl)[6]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            ulHeaderIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DeleteHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName)
    {
        return ((delegate* unmanaged<IHttpRequest4*, sbyte*, int>)((*lpVtbl)[7]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pszHeaderName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHttpMethod()
    {
        return ((delegate* unmanaged<IHttpRequest4*, sbyte*>)((*lpVtbl)[8]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetHttpMethod([NativeTypeName("PCSTR")] sbyte* pszHttpMethod)
    {
        return ((delegate* unmanaged<IHttpRequest4*, sbyte*, int>)((*lpVtbl)[9]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pszHttpMethod
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetUrl(
        [NativeTypeName("PCSTR")] sbyte* pszUrl,
        [NativeTypeName("DWORD")] uint cchUrl,
        BOOL fResetQueryString
    )
    {
        return ((delegate* unmanaged<IHttpRequest4*, sbyte*, uint, BOOL, int>)((*lpVtbl)[10]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pszUrl,
            cchUrl,
            fResetQueryString
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetUrl(
        [NativeTypeName("PCWSTR")] ushort* pszUrl,
        [NativeTypeName("DWORD")] uint cchUrl,
        BOOL fResetQueryString
    )
    {
        return ((delegate* unmanaged<IHttpRequest4*, ushort*, uint, BOOL, int>)((*lpVtbl)[11]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pszUrl,
            cchUrl,
            fResetQueryString
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public BOOL GetUrlChanged()
    {
        return ((delegate* unmanaged<IHttpRequest4*, int>)((*lpVtbl)[12]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetForwardedUrl()
    {
        return ((delegate* unmanaged<IHttpRequest4*, ushort*>)((*lpVtbl)[13]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("PSOCKADDR")]
    public SOCKADDR* GetLocalAddress()
    {
        return ((delegate* unmanaged<IHttpRequest4*, SOCKADDR*>)((*lpVtbl)[14]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [return: NativeTypeName("PSOCKADDR")]
    public SOCKADDR* GetRemoteAddress()
    {
        return ((delegate* unmanaged<IHttpRequest4*, SOCKADDR*>)((*lpVtbl)[15]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ReadEntityBody(
        void* pvBuffer,
        [NativeTypeName("DWORD")] uint cbBuffer,
        BOOL fAsync,
        [NativeTypeName("DWORD *")] uint* pcbBytesReceived,
        BOOL* pfCompletionPending = null
    )
    {
        return (
            (delegate* unmanaged<IHttpRequest4*, void*, uint, BOOL, uint*, BOOL*, int>)(
                (*lpVtbl)[16]
            )
        )(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pvBuffer,
            cbBuffer,
            fAsync,
            pcbBytesReceived,
            pfCompletionPending
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT InsertEntityBody(void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer)
    {
        return ((delegate* unmanaged<IHttpRequest4*, void*, uint, int>)((*lpVtbl)[17]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pvBuffer,
            cbBuffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("DWORD")]
    public uint GetRemainingEntityBytes()
    {
        return ((delegate* unmanaged<IHttpRequest4*, uint>)((*lpVtbl)[18]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void GetHttpVersion(ushort* pMajorVersion, ushort* pMinorVersion)
    {
        ((delegate* unmanaged<IHttpRequest4*, ushort*, ushort*, void>)((*lpVtbl)[19]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pMajorVersion,
            pMinorVersion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetClientCertificate(
        HTTP_SSL_CLIENT_CERT_INFO** ppClientCertInfo,
        BOOL* pfClientCertNegotiated
    )
    {
        return (
            (delegate* unmanaged<IHttpRequest4*, HTTP_SSL_CLIENT_CERT_INFO**, BOOL*, int>)(
                (*lpVtbl)[20]
            )
        )((IHttpRequest4*)Unsafe.AsPointer(ref this), ppClientCertInfo, pfClientCertNegotiated);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT NegotiateClientCertificate(BOOL fAsync, BOOL* pfCompletionPending = null)
    {
        return ((delegate* unmanaged<IHttpRequest4*, BOOL, BOOL*, int>)((*lpVtbl)[21]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            fAsync,
            pfCompletionPending
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("DWORD")]
    public uint GetSiteId()
    {
        return ((delegate* unmanaged<IHttpRequest4*, uint>)((*lpVtbl)[22]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetHeaderChanges(
        [NativeTypeName("DWORD")] uint dwOldChangeNumber,
        [NativeTypeName("DWORD *")] uint* pdwNewChangeNumber,
        [NativeTypeName("PCSTR[41]")] sbyte** knownHeaderSnapshot,
        [NativeTypeName("DWORD *")] uint* pdwUnknownHeaderSnapshot,
        [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderNameSnapshot,
        [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderValueSnapshot,
        [NativeTypeName("DWORD[42]")] uint* diffedKnownHeaderIndices,
        [NativeTypeName("DWORD *")] uint* pdwDiffedUnknownHeaders,
        [NativeTypeName("DWORD **")] uint** ppDiffedUnknownHeaderIndices
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequest4*,
                uint,
                uint*,
                sbyte**,
                uint*,
                sbyte***,
                sbyte***,
                uint*,
                uint*,
                uint**,
                int>)((*lpVtbl)[23])
        )(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetChannelBindingToken(
        [NativeTypeName("PBYTE *")] byte** ppToken,
        [NativeTypeName("DWORD *")] uint* pTokenSize
    )
    {
        return ((delegate* unmanaged<IHttpRequest4*, byte**, uint*, int>)((*lpVtbl)[24]))(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            ppToken,
            pTokenSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ReadEntityBody(
        void* pvBuffer,
        [NativeTypeName("DWORD")] uint cbBuffer,
        BOOL fAsync,
        [NativeTypeName("PFN_ASYNC_COMPLETION")]
            delegate* unmanaged<
            IHttpContext3*,
            IHttpCompletionInfo2*,
            void*,
            REQUEST_NOTIFICATION_STATUS> pfnCompletionCallback,
        void* pvCompletionContext,
        [NativeTypeName("DWORD *")] uint* pcbBytesReceived,
        BOOL* pfCompletionPending = null
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequest4*,
                void*,
                uint,
                BOOL,
                delegate* unmanaged<
                    IHttpContext3*,
                    IHttpCompletionInfo2*,
                    void*,
                    REQUEST_NOTIFICATION_STATUS>,
                void*,
                uint*,
                BOOL*,
                int>)((*lpVtbl)[25])
        )(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pvBuffer,
            cbBuffer,
            fAsync,
            pfnCompletionCallback,
            pvCompletionContext,
            pcbBytesReceived,
            pfCompletionPending
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT ReadEntityBody(
        void* pvBuffer,
        [NativeTypeName("DWORD")] uint cbBuffer,
        BOOL fAsync,
        [NativeTypeName("ULONG")] uint ulFlags,
        [NativeTypeName("DWORD *")] uint* pcbBytesReceived,
        BOOL* pfCompletionPending = null
    )
    {
        return (
            (delegate* unmanaged<IHttpRequest4*, void*, uint, BOOL, uint, uint*, BOOL*, int>)(
                (*lpVtbl)[26]
            )
        )(
            (IHttpRequest4*)Unsafe.AsPointer(ref this),
            pvBuffer,
            cbBuffer,
            fAsync,
            ulFlags,
            pcbBytesReceived,
            pfCompletionPending
        );
    }

    public interface Interface : IHttpRequest3.Interface
    {
        [VtblIndex(26)]
        HRESULT ReadEntityBody(
            void* pvBuffer,
            [NativeTypeName("DWORD")] uint cbBuffer,
            BOOL fAsync,
            [NativeTypeName("ULONG")] uint ulFlags,
            [NativeTypeName("DWORD *")] uint* pcbBytesReceived,
            BOOL* pfCompletionPending = null
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("const HTTP_REQUEST *() const")]
        public delegate* unmanaged<TSelf*, HTTP_REQUEST_V2*> GetRawHttpRequestConst;

        [NativeTypeName("HTTP_REQUEST *()")]
        public delegate* unmanaged<TSelf*, HTTP_REQUEST_V2*> GetRawHttpRequest1;

        [NativeTypeName("PCSTR (HTTP_HEADER_ID, USHORT *) const")]
        public delegate* unmanaged<TSelf*, HTTP_HEADER_ID, ushort*, sbyte*> GetHeader;

        [NativeTypeName("PCSTR (PCSTR, USHORT *) const")]
        public delegate* unmanaged<TSelf*, sbyte*, ushort*, sbyte*> GetHeader1;

        [NativeTypeName("HRESULT (HTTP_HEADER_ID, PCSTR, USHORT, BOOL)")]
        public delegate* unmanaged<TSelf*, HTTP_HEADER_ID, sbyte*, ushort, BOOL, int> SetHeader;

        [NativeTypeName("HRESULT (PCSTR, PCSTR, USHORT, BOOL)")]
        public delegate* unmanaged<TSelf*, sbyte*, sbyte*, ushort, BOOL, int> SetHeader1;

        [NativeTypeName("HRESULT (HTTP_HEADER_ID)")]
        public delegate* unmanaged<TSelf*, HTTP_HEADER_ID, int> DeleteHeader;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged<TSelf*, sbyte*, int> DeleteHeader1;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged<TSelf*, sbyte*> GetHttpMethod;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged<TSelf*, sbyte*, int> SetHttpMethod;

        [NativeTypeName("HRESULT (PCSTR, DWORD, BOOL)")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, BOOL, int> SetUrl;

        [NativeTypeName("HRESULT (PCWSTR, DWORD, BOOL)")]
        public delegate* unmanaged<TSelf*, ushort*, uint, BOOL, int> SetUrl1;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> GetUrlChanged;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetForwardedUrl;

        [NativeTypeName("PSOCKADDR () const")]
        public delegate* unmanaged<TSelf*, SOCKADDR*> GetLocalAddress;

        [NativeTypeName("PSOCKADDR () const")]
        public delegate* unmanaged<TSelf*, SOCKADDR*> GetRemoteAddress;

        [NativeTypeName("HRESULT (void *, DWORD, BOOL, DWORD *, BOOL *)")]
        public delegate* unmanaged<TSelf*, void*, uint, BOOL, uint*, BOOL*, int> ReadEntityBody;

        [NativeTypeName("HRESULT (void *, DWORD)")]
        public delegate* unmanaged<TSelf*, void*, uint, int> InsertEntityBody;

        [NativeTypeName("DWORD ()")]
        public delegate* unmanaged<TSelf*, uint> GetRemainingEntityBytes;

        [NativeTypeName("void (USHORT *, USHORT *) const")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, void> GetHttpVersion;

        [NativeTypeName("HRESULT (HTTP_SSL_CLIENT_CERT_INFO **, BOOL *)")]
        public delegate* unmanaged<
            TSelf*,
            HTTP_SSL_CLIENT_CERT_INFO**,
            BOOL*,
            int> GetClientCertificate;

        [NativeTypeName("HRESULT (BOOL, BOOL *)")]
        public delegate* unmanaged<TSelf*, BOOL, BOOL*, int> NegotiateClientCertificate;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetSiteId;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD *, PCSTR *, DWORD *, PCSTR **, PCSTR **, DWORD *, DWORD *, DWORD **)"
        )]
        public delegate* unmanaged<
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

        [NativeTypeName("HRESULT (PBYTE *, DWORD *)")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetChannelBindingToken;

        [NativeTypeName(
            "HRESULT (void *, DWORD, BOOL, PFN_ASYNC_COMPLETION, void *, DWORD *, BOOL *)"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            uint,
            BOOL,
            delegate* unmanaged<
                IHttpContext3*,
                IHttpCompletionInfo2*,
                void*,
                REQUEST_NOTIFICATION_STATUS>,
            void*,
            uint*,
            BOOL*,
            int> ReadEntityBody1;

        [NativeTypeName("HRESULT (void *, DWORD, BOOL, ULONG, DWORD *, BOOL *)")]
        public delegate* unmanaged<
            TSelf*,
            void*,
            uint,
            BOOL,
            uint,
            uint*,
            BOOL*,
            int> ReadEntityBody2;
    }
}
