// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CoBuildVersion();

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoInitialize([NativeTypeName("LPVOID")] void* pvReserved);

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRegisterMallocSpy(
        [NativeTypeName("LPMALLOCSPY")] IMallocSpy pMallocSpy
    );

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRevokeMallocSpy();

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRegisterInitializeSpy(
        IInitializeSpy pSpy,
        ULARGE_INTEGER* puliCookie
    );

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRevokeInitializeSpy(ULARGE_INTEGER uliCookie);

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoGetSystemSecurityPermissions(
        COMSD comSDType,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ppSD
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HINSTANCE CoLoadLibrary(
        [NativeTypeName("LPOLESTR")] ushort* lpszLibName,
        BOOL bAutoFree
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoFreeLibrary(HINSTANCE hInst);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoFreeAllLibraries();

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoGetInstanceFromFile(
        COSERVERINFO* pServerInfo,
        [NativeTypeName("CLSID *")] Guid* pClsid,
        IUnknown punkOuter,
        [NativeTypeName("DWORD")] uint dwClsCtx,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("OLECHAR *")] ushort* pwszName,
        [NativeTypeName("DWORD")] uint dwCount,
        MULTI_QI* pResults
    );

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoGetInstanceFromIStorage(
        COSERVERINFO* pServerInfo,
        [NativeTypeName("CLSID *")] Guid* pClsid,
        IUnknown punkOuter,
        [NativeTypeName("DWORD")] uint dwClsCtx,
        [NativeTypeName("struct IStorage *")] IStorage pstg,
        [NativeTypeName("DWORD")] uint dwCount,
        MULTI_QI* pResults
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoAllowSetForegroundWindow(
        IUnknown pUnk,
        [NativeTypeName("LPVOID")] void* lpvReserved
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT DcomChannelSetHResult(
        [NativeTypeName("LPVOID")] void* pvReserved,
        [NativeTypeName("ULONG *")] uint* pulReserved,
        HRESULT appsHR
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern BOOL CoIsOle1Class([NativeTypeName("const IID &")] Guid* rclsid);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern BOOL CoFileTimeToDosDateTime(
        FILETIME* lpFileTime,
        [NativeTypeName("LPWORD")] ushort* lpDosDate,
        [NativeTypeName("LPWORD")] ushort* lpDosTime
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern BOOL CoDosDateTimeToFileTime(
        [NativeTypeName("WORD")] ushort nDosDate,
        [NativeTypeName("WORD")] ushort nDosTime,
        FILETIME* lpFileTime
    );

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRegisterMessageFilter(
        [NativeTypeName("LPMESSAGEFILTER")] IMessageFilter lpMessageFilter,
        [NativeTypeName("LPMESSAGEFILTER *")] IMessageFilter* lplpMessageFilter
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRegisterChannelHook(
        [NativeTypeName("const GUID &")] Guid* ExtensionUuid,
        IChannelHook pChannelHook
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoTreatAsClass(
        [NativeTypeName("const IID &")] Guid* clsidOld,
        [NativeTypeName("const IID &")] Guid* clsidNew
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateDataAdviseHolder(
        [NativeTypeName("LPDATAADVISEHOLDER *")] IDataAdviseHolder* ppDAHolder
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateDataCache(
        [NativeTypeName("LPUNKNOWN")] IUnknown pUnkOuter,
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const IID &")] Guid* iid,
        [NativeTypeName("LPVOID *")] void** ppv
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgOpenAsyncDocfileOnIFillLockBytes(
        IFillLockBytes pflb,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint asyncFlags,
        IStorage* ppstgOpen
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgGetIFillLockBytesOnILockBytes(
        ILockBytes pilb,
        IFillLockBytes* ppflb
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgGetIFillLockBytesOnFile(
        [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
        IFillLockBytes* ppflb
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoInstall(
        IBindCtx pbc,
        [NativeTypeName("DWORD")] uint dwFlags,
        uCLSSPEC* pClassSpec,
        QUERYCONTEXT* pQuery,
        [NativeTypeName("LPWSTR")] ushort* pszCodeBase
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT BindMoniker(
        [NativeTypeName("LPMONIKER")] IMoniker pmk,
        [NativeTypeName("DWORD")] uint grfOpt,
        [NativeTypeName("const IID &")] Guid* iidResult,
        [NativeTypeName("LPVOID *")] void** ppvResult
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetObject(
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        BIND_OPTS* pBindOptions,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT MkParseDisplayName(
        [NativeTypeName("LPBC")] IBindCtx pbc,
        [NativeTypeName("LPCOLESTR")] ushort* szUserName,
        [NativeTypeName("ULONG *")] uint* pchEaten,
        [NativeTypeName("LPMONIKER *")] IMoniker* ppmk
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT MonikerRelativePathTo(
        [NativeTypeName("LPMONIKER")] IMoniker pmkSrc,
        [NativeTypeName("LPMONIKER")] IMoniker pmkDest,
        [NativeTypeName("LPMONIKER *")] IMoniker* ppmkRelPath,
        BOOL dwReserved
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT MonikerCommonPrefixWith(
        [NativeTypeName("LPMONIKER")] IMoniker pmkThis,
        [NativeTypeName("LPMONIKER")] IMoniker pmkOther,
        [NativeTypeName("LPMONIKER *")] IMoniker* ppmkCommon
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateBindCtx(
        [NativeTypeName("DWORD")] uint reserved,
        [NativeTypeName("LPBC *")] IBindCtx* ppbc
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateGenericComposite(
        [NativeTypeName("LPMONIKER")] IMoniker pmkFirst,
        [NativeTypeName("LPMONIKER")] IMoniker pmkRest,
        [NativeTypeName("LPMONIKER *")] IMoniker* ppmkComposite
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT GetClassFile(
        [NativeTypeName("LPCOLESTR")] ushort* szFilename,
        [NativeTypeName("CLSID *")] Guid* pclsid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateClassMoniker(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LPMONIKER *")] IMoniker* ppmk
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateFileMoniker(
        [NativeTypeName("LPCOLESTR")] ushort* lpszPathName,
        [NativeTypeName("LPMONIKER *")] IMoniker* ppmk
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateItemMoniker(
        [NativeTypeName("LPCOLESTR")] ushort* lpszDelim,
        [NativeTypeName("LPCOLESTR")] ushort* lpszItem,
        [NativeTypeName("LPMONIKER *")] IMoniker* ppmk
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateAntiMoniker([NativeTypeName("LPMONIKER *")] IMoniker* ppmk);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreatePointerMoniker(
        [NativeTypeName("LPUNKNOWN")] IUnknown punk,
        [NativeTypeName("LPMONIKER *")] IMoniker* ppmk
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateObjrefMoniker(
        [NativeTypeName("LPUNKNOWN")] IUnknown punk,
        [NativeTypeName("LPMONIKER *")] IMoniker* ppmk
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT GetRunningObjectTable(
        [NativeTypeName("DWORD")] uint reserved,
        [NativeTypeName("LPRUNNINGOBJECTTABLE *")] IRunningObjectTable* pprot
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateStdProgressIndicator(
        HWND hwndParent,
        [NativeTypeName("LPCOLESTR")] ushort* pszTitle,
        IBindStatusCallback pIbscCaller,
        IBindStatusCallback* ppIbsc
    );

    [NativeTypeName("#define MARSHALINTERFACE_MIN 500")]
    public const int MARSHALINTERFACE_MIN = 500;

    [NativeTypeName("#define ASYNC_MODE_COMPATIBILITY 0x00000001L")]
    public const int ASYNC_MODE_COMPATIBILITY = 0x00000001;

    [NativeTypeName("#define ASYNC_MODE_DEFAULT 0x00000000L")]
    public const int ASYNC_MODE_DEFAULT = 0x00000000;

    [NativeTypeName("#define STGTY_REPEAT 0x00000100L")]
    public const int STGTY_REPEAT = 0x00000100;
}
