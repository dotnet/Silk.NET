// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.CLSCTX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetMalloc(
        [NativeTypeName("DWORD")] uint dwMemContext,
        [NativeTypeName("LPMALLOC *")] IMalloc* ppMalloc
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateStreamOnHGlobal(
        HGLOBAL hGlobal,
        BOOL fDeleteOnRelease,
        [NativeTypeName("LPSTREAM *")] IStream* ppstm
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT GetHGlobalFromStream(
        [NativeTypeName("LPSTREAM")] IStream pstm,
        HGLOBAL* phglobal
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoUninitialize();

    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CoGetCurrentProcess();

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoInitializeEx(
        [NativeTypeName("LPVOID")] void* pvReserved,
        [NativeTypeName("DWORD")] uint dwCoInit
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetCallerTID([NativeTypeName("LPDWORD")] uint* lpdwTID);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetCurrentLogicalThreadId(Guid* pguid);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetContextToken([NativeTypeName("ULONG_PTR *")] nuint* pToken);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetDefaultContext(
        APTTYPE aptType,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetApartmentType(
        APTTYPE* pAptType,
        APTTYPEQUALIFIER* pAptQualifier
    );

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoDecodeProxy(
        [NativeTypeName("DWORD")] uint dwClientPid,
        [NativeTypeName("UINT64")] ulong ui64ProxyAddress,
        [NativeTypeName("PServerInformation")] ServerInformation* pServerInformation
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoIncrementMTAUsage(CO_MTA_USAGE_COOKIE* pCookie);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoDecrementMTAUsage(CO_MTA_USAGE_COOKIE Cookie);

    [DllImport("ole32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CoAllowUnmarshalerCLSID(
        [NativeTypeName("const IID &")] Guid* clsid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetObjectContext(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppv
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetClassObject(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("DWORD")] uint dwClsContext,
        [NativeTypeName("LPVOID")] void* pvReserved,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppv
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRegisterClassObject(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LPUNKNOWN")] IUnknown pUnk,
        [NativeTypeName("DWORD")] uint dwClsContext,
        [NativeTypeName("DWORD")] uint flags,
        [NativeTypeName("LPDWORD")] uint* lpdwRegister
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRevokeClassObject([NativeTypeName("DWORD")] uint dwRegister);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoResumeClassObjects();

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoSuspendClassObjects();

    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint CoAddRefServerProcess();

    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint CoReleaseServerProcess();

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetPSClsid(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("CLSID *")] Guid* pClsid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRegisterPSClsid(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("const IID &")] Guid* rclsid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRegisterSurrogate(
        [NativeTypeName("LPSURROGATE")] ISurrogate pSurrogate
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetMarshalSizeMax(
        [NativeTypeName("ULONG *")] uint* pulSize,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPUNKNOWN")] IUnknown pUnk,
        [NativeTypeName("DWORD")] uint dwDestContext,
        [NativeTypeName("LPVOID")] void* pvDestContext,
        [NativeTypeName("DWORD")] uint mshlflags
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoMarshalInterface(
        [NativeTypeName("LPSTREAM")] IStream pStm,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPUNKNOWN")] IUnknown pUnk,
        [NativeTypeName("DWORD")] uint dwDestContext,
        [NativeTypeName("LPVOID")] void* pvDestContext,
        [NativeTypeName("DWORD")] uint mshlflags
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoUnmarshalInterface(
        [NativeTypeName("LPSTREAM")] IStream pStm,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppv
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoMarshalHresult(
        [NativeTypeName("LPSTREAM")] IStream pstm,
        HRESULT hresult
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoUnmarshalHresult(
        [NativeTypeName("LPSTREAM")] IStream pstm,
        HRESULT* phresult
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoReleaseMarshalData([NativeTypeName("LPSTREAM")] IStream pStm);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoDisconnectObject(
        [NativeTypeName("LPUNKNOWN")] IUnknown pUnk,
        [NativeTypeName("DWORD")] uint dwReserved
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoLockObjectExternal(
        [NativeTypeName("LPUNKNOWN")] IUnknown pUnk,
        BOOL fLock,
        BOOL fLastUnlockReleases
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetStandardMarshal(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPUNKNOWN")] IUnknown pUnk,
        [NativeTypeName("DWORD")] uint dwDestContext,
        [NativeTypeName("LPVOID")] void* pvDestContext,
        [NativeTypeName("DWORD")] uint mshlflags,
        [NativeTypeName("LPMARSHAL *")] IMarshal* ppMarshal
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetStdMarshalEx(
        [NativeTypeName("LPUNKNOWN")] IUnknown pUnkOuter,
        [NativeTypeName("DWORD")] uint smexflags,
        [NativeTypeName("LPUNKNOWN *")] IUnknown* ppUnkInner
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern BOOL CoIsHandlerConnected([NativeTypeName("LPUNKNOWN")] IUnknown pUnk);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoMarshalInterThreadInterfaceInStream(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPUNKNOWN")] IUnknown pUnk,
        [NativeTypeName("LPSTREAM *")] IStream* ppStm
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetInterfaceAndReleaseStream(
        [NativeTypeName("LPSTREAM")] IStream pStm,
        [NativeTypeName("const IID &")] Guid* iid,
        [NativeTypeName("LPVOID *")] void** ppv
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCreateFreeThreadedMarshaler(
        [NativeTypeName("LPUNKNOWN")] IUnknown punkOuter,
        [NativeTypeName("LPUNKNOWN *")] IUnknown* ppunkMarshal
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoFreeUnusedLibraries();

    [DllImport("combase", ExactSpelling = true)]
    public static extern void CoFreeUnusedLibrariesEx(
        [NativeTypeName("DWORD")] uint dwUnloadDelay,
        [NativeTypeName("DWORD")] uint dwReserved
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoDisconnectContext([NativeTypeName("DWORD")] uint dwTimeout);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoInitializeSecurity(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecDesc,
        [NativeTypeName("LONG")] int cAuthSvc,
        SOLE_AUTHENTICATION_SERVICE* asAuthSvc,
        void* pReserved1,
        [NativeTypeName("DWORD")] uint dwAuthnLevel,
        [NativeTypeName("DWORD")] uint dwImpLevel,
        void* pAuthList,
        [NativeTypeName("DWORD")] uint dwCapabilities,
        void* pReserved3
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetCallContext(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppInterface
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoQueryProxyBlanket(
        IUnknown pProxy,
        [NativeTypeName("DWORD *")] uint* pwAuthnSvc,
        [NativeTypeName("DWORD *")] uint* pAuthzSvc,
        [NativeTypeName("LPOLESTR *")] ushort** pServerPrincName,
        [NativeTypeName("DWORD *")] uint* pAuthnLevel,
        [NativeTypeName("DWORD *")] uint* pImpLevel,
        [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** pAuthInfo,
        [NativeTypeName("DWORD *")] uint* pCapabilites
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoSetProxyBlanket(
        IUnknown pProxy,
        [NativeTypeName("DWORD")] uint dwAuthnSvc,
        [NativeTypeName("DWORD")] uint dwAuthzSvc,
        [NativeTypeName("OLECHAR *")] ushort* pServerPrincName,
        [NativeTypeName("DWORD")] uint dwAuthnLevel,
        [NativeTypeName("DWORD")] uint dwImpLevel,
        [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* pAuthInfo,
        [NativeTypeName("DWORD")] uint dwCapabilities
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCopyProxy(IUnknown pProxy, IUnknown* ppCopy);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoQueryClientBlanket(
        [NativeTypeName("DWORD *")] uint* pAuthnSvc,
        [NativeTypeName("DWORD *")] uint* pAuthzSvc,
        [NativeTypeName("LPOLESTR *")] ushort** pServerPrincName,
        [NativeTypeName("DWORD *")] uint* pAuthnLevel,
        [NativeTypeName("DWORD *")] uint* pImpLevel,
        [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** pPrivs,
        [NativeTypeName("DWORD *")] uint* pCapabilities
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoImpersonateClient();

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRevertToSelf();

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoQueryAuthenticationServices(
        [NativeTypeName("DWORD *")] uint* pcAuthSvc,
        SOLE_AUTHENTICATION_SERVICE** asAuthSvc
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoSwitchCallContext(IUnknown pNewObject, IUnknown* ppOldObject);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCreateInstance(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LPUNKNOWN")] IUnknown pUnkOuter,
        [NativeTypeName("DWORD")] uint dwClsContext,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppv
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCreateInstanceEx(
        [NativeTypeName("const IID &")] Guid* Clsid,
        IUnknown punkOuter,
        [NativeTypeName("DWORD")] uint dwClsCtx,
        COSERVERINFO* pServerInfo,
        [NativeTypeName("DWORD")] uint dwCount,
        MULTI_QI* pResults
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CoCreateInstanceFromApp(
        [NativeTypeName("const IID &")] Guid* Clsid,
        IUnknown punkOuter,
        [NativeTypeName("DWORD")] uint dwClsCtx,
        [NativeTypeName("PVOID")] void* reserved,
        [NativeTypeName("DWORD")] uint dwCount,
        MULTI_QI* pResults
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRegisterActivationFilter(IActivationFilter pActivationFilter);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetCancelObject(
        [NativeTypeName("DWORD")] uint dwThreadId,
        [NativeTypeName("const IID &")] Guid* iid,
        void** ppUnk
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoSetCancelObject(IUnknown pUnk);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCancelCall(
        [NativeTypeName("DWORD")] uint dwThreadId,
        [NativeTypeName("ULONG")] uint ulTimeout
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoTestCancel();

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoEnableCallCancellation(
        [NativeTypeName("LPVOID")] void* pReserved
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoDisableCallCancellation(
        [NativeTypeName("LPVOID")] void* pReserved
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StringFromCLSID(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LPOLESTR *")] ushort** lplpsz
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CLSIDFromString(
        [NativeTypeName("LPCOLESTR")] ushort* lpsz,
        [NativeTypeName("LPCLSID")] Guid* pclsid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StringFromIID(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LPOLESTR *")] ushort** lplpsz
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT IIDFromString(
        [NativeTypeName("LPCOLESTR")] ushort* lpsz,
        [NativeTypeName("LPIID")] Guid* lpiid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT ProgIDFromCLSID(
        [NativeTypeName("const IID &")] Guid* clsid,
        [NativeTypeName("LPOLESTR *")] ushort** lplpszProgID
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CLSIDFromProgID(
        [NativeTypeName("LPCOLESTR")] ushort* lpszProgID,
        [NativeTypeName("LPCLSID")] Guid* lpclsid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern int StringFromGUID2(
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("LPOLESTR")] ushort* lpsz,
        int cchMax
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCreateGuid(Guid* pguid);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT PropVariantCopy(
        PROPVARIANT* pvarDest,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSrc
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT PropVariantClear(PROPVARIANT* pvar);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT FreePropVariantArray(
        [NativeTypeName("ULONG")] uint cVariants,
        PROPVARIANT* rgvars
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoWaitForMultipleHandles(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwTimeout,
        [NativeTypeName("ULONG")] uint cHandles,
        [NativeTypeName("LPHANDLE")] HANDLE* pHandles,
        [NativeTypeName("LPDWORD")] uint* lpdwindex
    );

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoWaitForMultipleObjects(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwTimeout,
        [NativeTypeName("ULONG")] uint cHandles,
        [NativeTypeName("const HANDLE *")] HANDLE* pHandles,
        [NativeTypeName("LPDWORD")] uint* lpdwindex
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetTreatAsClass(
        [NativeTypeName("const IID &")] Guid* clsidOld,
        [NativeTypeName("LPCLSID")] Guid* pClsidNew
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoInvalidateRemoteMachineBindings(
        [NativeTypeName("LPOLESTR")] ushort* pszMachineName
    );

    [DllImport("ole32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RoGetAgileReference(
        [NativeTypeName("enum AgileReferenceOptions")] AgileReferenceOptions options,
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown pUnk,
        IAgileReference* ppAgileReference
    );

    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* CoTaskMemAlloc([NativeTypeName("SIZE_T")] nuint cb);

    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* CoTaskMemRealloc(
        [NativeTypeName("LPVOID")] void* pv,
        [NativeTypeName("SIZE_T")] nuint cb
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoTaskMemFree([NativeTypeName("LPVOID")] void* pv);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoFileTimeNow(FILETIME* lpFileTime);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CLSIDFromProgIDEx(
        [NativeTypeName("LPCOLESTR")] ushort* lpszProgID,
        [NativeTypeName("LPCLSID")] Guid* lpclsid
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HRESULT CoRegisterDeviceCatalog(
        [NativeTypeName("PCWSTR")] ushort* deviceInstanceId,
        CO_DEVICE_CATALOG_COOKIE* cookie
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HRESULT CoRevokeDeviceCatalog(CO_DEVICE_CATALOG_COOKIE cookie);

    [NativeTypeName("#define CLSCTX_INPROC (CLSCTX_INPROC_SERVER|CLSCTX_INPROC_HANDLER)")]
    public const int CLSCTX_INPROC = ((int)(CLSCTX_INPROC_SERVER) | (int)(CLSCTX_INPROC_HANDLER));

    [NativeTypeName(
        "#define CLSCTX_ALL (CLSCTX_INPROC_SERVER| \\\r\n                                 CLSCTX_INPROC_HANDLER| \\\r\n                                 CLSCTX_LOCAL_SERVER| \\\r\n                                 CLSCTX_REMOTE_SERVER)"
    )]
    public const int CLSCTX_ALL = (
        (int)(CLSCTX_INPROC_SERVER)
        | (int)(CLSCTX_INPROC_HANDLER)
        | (int)(CLSCTX_LOCAL_SERVER)
        | (int)(CLSCTX_REMOTE_SERVER)
    );

    [NativeTypeName(
        "#define CLSCTX_SERVER (CLSCTX_INPROC_SERVER|CLSCTX_LOCAL_SERVER|CLSCTX_REMOTE_SERVER)"
    )]
    public const int CLSCTX_SERVER = (
        (int)(CLSCTX_INPROC_SERVER) | (int)(CLSCTX_LOCAL_SERVER) | (int)(CLSCTX_REMOTE_SERVER)
    );

    [NativeTypeName("#define COM_RIGHTS_EXECUTE 1")]
    public const int COM_RIGHTS_EXECUTE = 1;

    [NativeTypeName("#define COM_RIGHTS_EXECUTE_LOCAL 2")]
    public const int COM_RIGHTS_EXECUTE_LOCAL = 2;

    [NativeTypeName("#define COM_RIGHTS_EXECUTE_REMOTE 4")]
    public const int COM_RIGHTS_EXECUTE_REMOTE = 4;

    [NativeTypeName("#define COM_RIGHTS_ACTIVATE_LOCAL 8")]
    public const int COM_RIGHTS_ACTIVATE_LOCAL = 8;

    [NativeTypeName("#define COM_RIGHTS_ACTIVATE_REMOTE 16")]
    public const int COM_RIGHTS_ACTIVATE_REMOTE = 16;

    [NativeTypeName("#define COM_RIGHTS_RESERVED1 32")]
    public const int COM_RIGHTS_RESERVED1 = 32;

    [NativeTypeName("#define COM_RIGHTS_RESERVED2 64")]
    public const int COM_RIGHTS_RESERVED2 = 64;

    [NativeTypeName("#define CWMO_MAX_HANDLES 56")]
    public const int CWMO_MAX_HANDLES = 56;
}
