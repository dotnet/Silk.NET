// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.BINDF;
using static Silk.NET.Windows.PARSEACTION;
using static Silk.NET.Windows.PI_FLAGS;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateURLMoniker"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateURLMoniker([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateURLMonikerEx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateURLMonikerEx([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassURL"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT GetClassURL([NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("CLSID *")] Guid* pClsID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateAsyncBindCtx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateAsyncBindCtx([NativeTypeName("DWORD")] uint reserved, IBindStatusCallback* pBSCb, IEnumFORMATETC* pEFetc, IBindCtx** ppBC);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateURLMonikerEx2"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateURLMonikerEx2([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, IUri* pUri, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateAsyncBindCtxEx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateAsyncBindCtxEx(IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwOptions, IBindStatusCallback* pBSCb, IEnumFORMATETC* pEnum, IBindCtx** ppBC, [NativeTypeName("DWORD")] uint reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MkParseDisplayNameEx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT MkParseDisplayNameEx(IBindCtx* pbc, [NativeTypeName("LPCWSTR")] ushort* szDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterBindStatusCallback"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RegisterBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, IBindStatusCallback* pBSCb, IBindStatusCallback** ppBSCBPrev, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RevokeBindStatusCallback"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RevokeBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, IBindStatusCallback* pBSCb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassFileOrMime"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT GetClassFileOrMime([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szFilename, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] ushort* szMime, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("CLSID *")] Guid* pclsid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsValidURL"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT IsValidURL([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetClassObjectFromURL"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoGetClassObjectFromURL([NativeTypeName("const IID &")] Guid* rCLASSID, [NativeTypeName("LPCWSTR")] ushort* szCODE, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] ushort* szTYPE, [NativeTypeName("LPBINDCTX")] IBindCtx* pBindCtx, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IEInstallScope"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT IEInstallScope([NativeTypeName("LPDWORD")] uint* pdwScope);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FaultInIEFeature"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT FaultInIEFeature(HWND hWnd, uCLSSPEC* pClassSpec, QUERYCONTEXT* pQuery, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetComponentIDFromCLSSPEC"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT GetComponentIDFromCLSSPEC(uCLSSPEC* pClassspec, [NativeTypeName("LPSTR *")] sbyte** ppszComponentID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsAsyncMoniker"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT IsAsyncMoniker(IMoniker* pmk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterMediaTypes"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RegisterMediaTypes(uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindMediaType"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT FindMediaType([NativeTypeName("LPCSTR")] sbyte* rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFormatEnumerator"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateFormatEnumerator(uint cfmtetc, FORMATETC* rgfmtetc, IEnumFORMATETC** ppenumfmtetc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterFormatEnumerator"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RegisterFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, IEnumFORMATETC* pEFetc, [NativeTypeName("DWORD")] uint reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RevokeFormatEnumerator"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RevokeFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, IEnumFORMATETC* pEFetc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterMediaTypeClass"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT RegisterMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLSID *")] Guid* rgclsID, [NativeTypeName("DWORD")] uint reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindMediaTypeClass"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT FindMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCSTR")] sbyte* szType, [NativeTypeName("CLSID *")] Guid* pclsID, [NativeTypeName("DWORD")] uint reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlMkSetSessionOption"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT UrlMkSetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlMkGetSessionOption"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT UrlMkGetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD *")] uint* pdwBufferLengthOut, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindMimeFromData"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT FindMimeFromData([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* pwzUrl, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] ushort* pwzMimeProposed, [NativeTypeName("DWORD")] uint dwMimeFlags, [NativeTypeName("LPWSTR *")] ushort** ppwzMimeOut, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ObtainUserAgentString"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT ObtainUserAgentString([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPSTR")] sbyte* pszUAOut, [NativeTypeName("DWORD *")] uint* cbSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CompareSecurityIds"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CompareSecurityIds(byte* pbSecurityId1, [NativeTypeName("DWORD")] uint dwLen1, byte* pbSecurityId2, [NativeTypeName("DWORD")] uint dwLen2, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CompatFlagsFromClsid"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CompatFlagsFromClsid([NativeTypeName("CLSID *")] Guid* pclsid, [NativeTypeName("LPDWORD")] uint* pdwCompatFlags, [NativeTypeName("LPDWORD")] uint* pdwMiscStatusFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetAccessForIEAppContainer"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT SetAccessForIEAppContainer(HANDLE hObject, IEObjectType ieObjectType, [NativeTypeName("DWORD")] uint dwAccessMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateUri"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateUri([NativeTypeName("LPCWSTR")] ushort* pwzURI, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppURI);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateUriWithFragment"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateUriWithFragment([NativeTypeName("LPCWSTR")] ushort* pwzURI, [NativeTypeName("LPCWSTR")] ushort* pwzFragment, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppURI);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateUriFromMultiByteString"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateUriFromMultiByteString([NativeTypeName("LPCSTR")] sbyte* pszANSIInputUri, [NativeTypeName("DWORD")] uint dwEncodingFlags, [NativeTypeName("DWORD")] uint dwCodePage, [NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppUri);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateIUriBuilder"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CreateIUriBuilder(IUri* pIUri, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUriBuilder** ppIUriBuilder);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkSimpleNavigateToString"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkSimpleNavigateToString([NativeTypeName("LPCWSTR")] ushort* szTarget, [NativeTypeName("LPCWSTR")] ushort* szLocation, [NativeTypeName("LPCWSTR")] ushort* szTargetFrameName, IUnknown* pUnk, IBindCtx* pbc, IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkSimpleNavigateToMoniker"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkSimpleNavigateToMoniker(IMoniker* pmkTarget, [NativeTypeName("LPCWSTR")] ushort* szLocation, [NativeTypeName("LPCWSTR")] ushort* szTargetFrameName, IUnknown* pUnk, IBindCtx* pbc, IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenStreamA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenStreamW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenPullStreamA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenPullStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenPullStreamW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenPullStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLDownloadToFileA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLDownloadToFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPCSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLDownloadToFileW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLDownloadToFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPCWSTR")] ushort* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLDownloadToCacheFileA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLDownloadToCacheFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLDownloadToCacheFileW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLDownloadToCacheFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPWSTR")] ushort* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenBlockingStreamA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenBlockingStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLOpenBlockingStreamW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT URLOpenBlockingStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkGoBack"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkGoBack(IUnknown* pUnk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkGoForward"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkGoForward(IUnknown* pUnk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkNavigateString"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkNavigateString(IUnknown* pUnk, [NativeTypeName("LPCWSTR")] ushort* szTarget);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HlinkNavigateMoniker"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT HlinkNavigateMoniker(IUnknown* pUnk, IMoniker* pmkTarget);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetParseUrl"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetParseUrl([NativeTypeName("LPCWSTR")] ushort* pwzUrl, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetParseIUri"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetParseIUri(IUri* pIUri, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCombineUrl"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCombineUrl([NativeTypeName("LPCWSTR")] ushort* pwzBaseUrl, [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] ushort* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCombineUrlEx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCombineUrlEx(IUri* pBaseUri, [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCombineIUri"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCombineIUri(IUri* pBaseUri, IUri* pRelativeUri, [NativeTypeName("DWORD")] uint dwCombineFlags, IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCompareUrl"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCompareUrl([NativeTypeName("LPCWSTR")] ushort* pwzUrl1, [NativeTypeName("LPCWSTR")] ushort* pwzUrl2, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetGetProtocolFlags"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetGetProtocolFlags([NativeTypeName("LPCWSTR")] ushort* pwzUrl, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetQueryInfo"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetQueryInfo([NativeTypeName("LPCWSTR")] ushort* pwzUrl, QUERYOPTION QueryOptions, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuffer, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetGetSession"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetGetSession([NativeTypeName("DWORD")] uint dwSessionMode, IInternetSession** ppIInternetSession, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetGetSecurityUrl"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetGetSecurityUrl([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPWSTR *")] ushort** ppwszSecUrl, PSUACTION psuAction, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AsyncInstallDistributionUnit"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT AsyncInstallDistributionUnit([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("LPCWSTR")] ushort* szTYPE, [NativeTypeName("LPCWSTR")] ushort* szExt, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] ushort* szURL, IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetGetSecurityUrlEx"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetGetSecurityUrlEx(IUri* pUri, IUri** ppSecUri, PSUACTION psuAction, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetSetFeatureEnabled"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetSetFeatureEnabled(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, BOOL fEnable);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetIsFeatureEnabled"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetIsFeatureEnabled(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetIsFeatureEnabledForUrl"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetIsFeatureEnabledForUrl(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* szURL, IInternetSecurityManager* pSecMgr);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetIsFeatureEnabledForIUri"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetIsFeatureEnabledForIUri(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, IUri* pIUri, IInternetSecurityManagerEx2* pSecMgr);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetIsFeatureZoneElevationEnabled"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetIsFeatureZoneElevationEnabled([NativeTypeName("LPCWSTR")] ushort* szFromURL, [NativeTypeName("LPCWSTR")] ushort* szToURL, IInternetSecurityManager* pSecMgr, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyStgMedium"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CopyStgMedium([NativeTypeName("const STGMEDIUM *")] STGMEDIUM* pcstgmedSrc, STGMEDIUM* pstgmedDest);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyBindInfo"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CopyBindInfo([NativeTypeName("const BINDINFO *")] BINDINFO* pcbiSrc, BINDINFO* pbiDest);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseBindInfo"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern void ReleaseBindInfo(BINDINFO* pbindinfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IEGetUserPrivateNamespaceName"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* IEGetUserPrivateNamespaceName();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCreateSecurityManager"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCreateSecurityManager(IServiceProvider* pSP, IInternetSecurityManager** ppSM, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInternetCreateZoneManager"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT CoInternetCreateZoneManager(IServiceProvider* pSP, IInternetZoneManager** ppZM, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSoftwareUpdateInfo"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT GetSoftwareUpdateInfo([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* psdi);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSoftwareUpdateAdvertisementState"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern HRESULT SetSoftwareUpdateAdvertisementState([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("DWORD")] uint dwAdState, [NativeTypeName("DWORD")] uint dwAdvertisedVersionMS, [NativeTypeName("DWORD")] uint dwAdvertisedVersionLS);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsLoggingEnabledA"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern BOOL IsLoggingEnabledA([NativeTypeName("LPCSTR")] sbyte* pszUrl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsLoggingEnabledW"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern BOOL IsLoggingEnabledW([NativeTypeName("LPCWSTR")] ushort* pwszUrl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteHitLogging"]/*' />
    [DllImport("urlmon", ExactSpelling = true)]
    public static extern BOOL WriteHitLogging([NativeTypeName("LPHIT_LOGGING_INFO")] HIT_LOGGING_INFO* lpLogginginfo);

    [NativeTypeName("#define BINDF_DONTUSECACHE BINDF_GETNEWESTVERSION")]
    public const BINDF BINDF_DONTUSECACHE = BINDF_GETNEWESTVERSION;

    [NativeTypeName("#define BINDF_DONTPUTINCACHE BINDF_NOWRITECACHE")]
    public const BINDF BINDF_DONTPUTINCACHE = BINDF_NOWRITECACHE;

    [NativeTypeName("#define BINDF_NOCOPYDATA BINDF_PULLDATA")]
    public const BINDF BINDF_NOCOPYDATA = BINDF_PULLDATA;

    [NativeTypeName("#define INVALID_P_ROOT_SECURITY_ID ((BYTE*)-1)")]
    public static byte* INVALID_P_ROOT_SECURITY_ID => unchecked((byte*)(-1));

    [NativeTypeName("#define PI_DOCFILECLSIDLOOKUP PI_CLSIDLOOKUP")]
    public const PI_FLAGS PI_DOCFILECLSIDLOOKUP = PI_CLSIDLOOKUP;

    [NativeTypeName("#define MKSYS_URLMONIKER 6")]
    public const int MKSYS_URLMONIKER = 6;

    [NativeTypeName("#define FIEF_FLAG_FORCE_JITUI 0x1")]
    public const int FIEF_FLAG_FORCE_JITUI = 0x1;

    [NativeTypeName("#define FIEF_FLAG_PEEK 0x2")]
    public const int FIEF_FLAG_PEEK = 0x2;

    [NativeTypeName("#define FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK 0x4")]
    public const int FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK = 0x4;

    [NativeTypeName("#define FIEF_FLAG_RESERVED_0 0x8")]
    public const int FIEF_FLAG_RESERVED_0 = 0x8;

    [NativeTypeName("#define FMFD_DEFAULT 0x00000000")]
    public const int FMFD_DEFAULT = 0x00000000;

    [NativeTypeName("#define FMFD_URLASFILENAME 0x00000001")]
    public const int FMFD_URLASFILENAME = 0x00000001;

    [NativeTypeName("#define FMFD_ENABLEMIMESNIFFING 0x00000002")]
    public const int FMFD_ENABLEMIMESNIFFING = 0x00000002;

    [NativeTypeName("#define FMFD_IGNOREMIMETEXTPLAIN 0x00000004")]
    public const int FMFD_IGNOREMIMETEXTPLAIN = 0x00000004;

    [NativeTypeName("#define FMFD_SERVERMIME 0x00000008")]
    public const int FMFD_SERVERMIME = 0x00000008;

    [NativeTypeName("#define FMFD_RESPECTTEXTPLAIN 0x00000010")]
    public const int FMFD_RESPECTTEXTPLAIN = 0x00000010;

    [NativeTypeName("#define FMFD_RETURNUPDATEDIMGMIMES 0x00000020")]
    public const int FMFD_RETURNUPDATEDIMGMIMES = 0x00000020;

    [NativeTypeName("#define FMFD_RESERVED_1 0x00000040")]
    public const int FMFD_RESERVED_1 = 0x00000040;

    [NativeTypeName("#define FMFD_RESERVED_2 0x00000080")]
    public const int FMFD_RESERVED_2 = 0x00000080;

    [NativeTypeName("#define UAS_EXACTLEGACY 0x00001000")]
    public const int UAS_EXACTLEGACY = 0x00001000;

    [NativeTypeName("#define URLMON_OPTION_USERAGENT 0x10000001")]
    public const int URLMON_OPTION_USERAGENT = 0x10000001;

    [NativeTypeName("#define URLMON_OPTION_USERAGENT_REFRESH 0x10000002")]
    public const int URLMON_OPTION_USERAGENT_REFRESH = 0x10000002;

    [NativeTypeName("#define URLMON_OPTION_URL_ENCODING 0x10000004")]
    public const int URLMON_OPTION_URL_ENCODING = 0x10000004;

    [NativeTypeName("#define URLMON_OPTION_USE_BINDSTRINGCREDS 0x10000008")]
    public const int URLMON_OPTION_USE_BINDSTRINGCREDS = 0x10000008;

    [NativeTypeName("#define URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS 0x10000010")]
    public const int URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS = 0x10000010;

    [NativeTypeName("#define UriBuilder_USE_ORIGINAL_FLAGS 0x00000001")]
    public const int UriBuilder_USE_ORIGINAL_FLAGS = 0x00000001;

    [NativeTypeName("#define WININETINFO_OPTION_LOCK_HANDLE 65534")]
    public const int WININETINFO_OPTION_LOCK_HANDLE = 65534;

    [NativeTypeName("#define URLOSTRM_USECACHEDCOPY_ONLY 0x1")]
    public const int URLOSTRM_USECACHEDCOPY_ONLY = 0x1;

    [NativeTypeName("#define URLOSTRM_USECACHEDCOPY 0x2")]
    public const int URLOSTRM_USECACHEDCOPY = 0x2;

    [NativeTypeName("#define URLOSTRM_GETNEWESTVERSION 0x3")]
    public const int URLOSTRM_GETNEWESTVERSION = 0x3;

    [NativeTypeName("#define URLOpenStream URLOpenStreamW")]
    public static delegate*<IUnknown*, ushort*, uint, IBindStatusCallback*, HRESULT> URLOpenStream => &URLOpenStreamW;

    [NativeTypeName("#define URLOpenPullStream URLOpenPullStreamW")]
    public static delegate*<IUnknown*, ushort*, uint, IBindStatusCallback*, HRESULT> URLOpenPullStream => &URLOpenPullStreamW;

    [NativeTypeName("#define URLDownloadToFile URLDownloadToFileW")]
    public static delegate*<IUnknown*, ushort*, ushort*, uint, IBindStatusCallback*, HRESULT> URLDownloadToFile => &URLDownloadToFileW;

    [NativeTypeName("#define URLDownloadToCacheFile URLDownloadToCacheFileW")]
    public static delegate*<IUnknown*, ushort*, ushort*, uint, uint, IBindStatusCallback*, HRESULT> URLDownloadToCacheFile => &URLDownloadToCacheFileW;

    [NativeTypeName("#define URLOpenBlockingStream URLOpenBlockingStreamW")]
    public static delegate*<IUnknown*, ushort*, IStream**, uint, IBindStatusCallback*, HRESULT> URLOpenBlockingStream => &URLOpenBlockingStreamW;

    [NativeTypeName("#define PARSE_ENCODE PARSE_ENCODE_IS_UNESCAPE")]
    public const PARSEACTION PARSE_ENCODE = PARSE_ENCODE_IS_UNESCAPE;

    [NativeTypeName("#define PARSE_DECODE PARSE_DECODE_IS_ESCAPE")]
    public const PARSEACTION PARSE_DECODE = PARSE_DECODE_IS_ESCAPE;

    [NativeTypeName("#define OInetParseUrl CoInternetParseUrl")]
    public static delegate*<ushort*, PARSEACTION, uint, ushort*, uint, uint*, uint, HRESULT> OInetParseUrl => &CoInternetParseUrl;

    [NativeTypeName("#define OInetCombineUrl CoInternetCombineUrl")]
    public static delegate*<ushort*, ushort*, uint, ushort*, uint, uint*, uint, HRESULT> OInetCombineUrl => &CoInternetCombineUrl;

    [NativeTypeName("#define OInetCombineUrlEx CoInternetCombineUrlEx")]
    public static delegate*<IUri*, ushort*, uint, IUri**, nuint, HRESULT> OInetCombineUrlEx => &CoInternetCombineUrlEx;

    [NativeTypeName("#define OInetCombineIUri CoInternetCombineIUri")]
    public static delegate*<IUri*, IUri*, uint, IUri**, nuint, HRESULT> OInetCombineIUri => &CoInternetCombineIUri;

    [NativeTypeName("#define OInetCompareUrl CoInternetCompareUrl")]
    public static delegate*<ushort*, ushort*, uint, HRESULT> OInetCompareUrl => &CoInternetCompareUrl;

    [NativeTypeName("#define OInetQueryInfo CoInternetQueryInfo")]
    public static delegate*<ushort*, QUERYOPTION, uint, void*, uint, uint*, uint, HRESULT> OInetQueryInfo => &CoInternetQueryInfo;

    [NativeTypeName("#define OInetGetSession CoInternetGetSession")]
    public static delegate*<uint, IInternetSession**, uint, HRESULT> OInetGetSession => &CoInternetGetSession;

    [NativeTypeName("#define PROTOCOLFLAG_NO_PICS_CHECK 0x00000001")]
    public const int PROTOCOLFLAG_NO_PICS_CHECK = 0x00000001;

    [NativeTypeName("#define URLZONE_ESC_FLAG 0x100")]
    public const int URLZONE_ESC_FLAG = 0x100;

    [NativeTypeName("#define SOFTDIST_FLAG_USAGE_EMAIL 0x00000001")]
    public const int SOFTDIST_FLAG_USAGE_EMAIL = 0x00000001;

    [NativeTypeName("#define SOFTDIST_FLAG_USAGE_PRECACHE 0x00000002")]
    public const int SOFTDIST_FLAG_USAGE_PRECACHE = 0x00000002;

    [NativeTypeName("#define SOFTDIST_FLAG_USAGE_AUTOINSTALL 0x00000004")]
    public const int SOFTDIST_FLAG_USAGE_AUTOINSTALL = 0x00000004;

    [NativeTypeName("#define SOFTDIST_FLAG_DELETE_SUBSCRIPTION 0x00000008")]
    public const int SOFTDIST_FLAG_DELETE_SUBSCRIPTION = 0x00000008;

    [NativeTypeName("#define SOFTDIST_ADSTATE_NONE 0x00000000")]
    public const int SOFTDIST_ADSTATE_NONE = 0x00000000;

    [NativeTypeName("#define SOFTDIST_ADSTATE_AVAILABLE 0x00000001")]
    public const int SOFTDIST_ADSTATE_AVAILABLE = 0x00000001;

    [NativeTypeName("#define SOFTDIST_ADSTATE_DOWNLOADED 0x00000002")]
    public const int SOFTDIST_ADSTATE_DOWNLOADED = 0x00000002;

    [NativeTypeName("#define SOFTDIST_ADSTATE_INSTALLED 0x00000003")]
    public const int SOFTDIST_ADSTATE_INSTALLED = 0x00000003;

    [NativeTypeName("#define IsLoggingEnabled IsLoggingEnabledW")]
    public static delegate*<ushort*, BOOL> IsLoggingEnabled => &IsLoggingEnabledW;

    [NativeTypeName("#define CONFIRMSAFETYACTION_LOADOBJECT 0x00000001")]
    public const int CONFIRMSAFETYACTION_LOADOBJECT = 0x00000001;
}
