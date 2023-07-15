// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.CLSCTX;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetMalloc"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetMalloc([NativeTypeName("DWORD")] uint dwMemContext, [NativeTypeName("LPMALLOC *")] IMalloc** ppMalloc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateStreamOnHGlobal"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateStreamOnHGlobal(HGLOBAL hGlobal, BOOL fDeleteOnRelease, [NativeTypeName("LPSTREAM *")] IStream** ppstm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetHGlobalFromStream"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT GetHGlobalFromStream([NativeTypeName("LPSTREAM")] IStream* pstm, HGLOBAL* phglobal);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoUninitialize"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoUninitialize();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetCurrentProcess"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CoGetCurrentProcess();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInitializeEx"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoInitializeEx([NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint dwCoInit);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetCallerTID"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetCallerTID([NativeTypeName("LPDWORD")] uint* lpdwTID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetCurrentLogicalThreadId"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetCurrentLogicalThreadId(Guid* pguid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetContextToken"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetContextToken([NativeTypeName("ULONG_PTR *")] nuint* pToken);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetDefaultContext"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetDefaultContext(APTTYPE aptType, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetApartmentType"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetApartmentType(APTTYPE* pAptType, APTTYPEQUALIFIER* pAptQualifier);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoDecodeProxy"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoDecodeProxy([NativeTypeName("DWORD")] uint dwClientPid, [NativeTypeName("UINT64")] ulong ui64ProxyAddress, [NativeTypeName("PServerInformation")] ServerInformation* pServerInformation);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoIncrementMTAUsage"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoIncrementMTAUsage(CO_MTA_USAGE_COOKIE* pCookie);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoDecrementMTAUsage"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoDecrementMTAUsage(CO_MTA_USAGE_COOKIE Cookie);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoAllowUnmarshalerCLSID"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CoAllowUnmarshalerCLSID([NativeTypeName("const IID &")] Guid* clsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetObjectContext"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetObjectContext([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetClassObject"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRegisterClassObject"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRegisterClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpdwRegister);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRevokeClassObject"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRevokeClassObject([NativeTypeName("DWORD")] uint dwRegister);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoResumeClassObjects"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoResumeClassObjects();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoSuspendClassObjects"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoSuspendClassObjects();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoAddRefServerProcess"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint CoAddRefServerProcess();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoReleaseServerProcess"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint CoReleaseServerProcess();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetPSClsid"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetPSClsid([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("CLSID *")] Guid* pClsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRegisterPSClsid"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRegisterPSClsid([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("const IID &")] Guid* rclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRegisterSurrogate"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRegisterSurrogate([NativeTypeName("LPSURROGATE")] ISurrogate* pSurrogate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetMarshalSizeMax"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetMarshalSizeMax([NativeTypeName("ULONG *")] uint* pulSize, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoMarshalInterface"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoMarshalInterface([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoUnmarshalInterface"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoUnmarshalInterface([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoMarshalHresult"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoMarshalHresult([NativeTypeName("LPSTREAM")] IStream* pstm, HRESULT hresult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoUnmarshalHresult"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoUnmarshalHresult([NativeTypeName("LPSTREAM")] IStream* pstm, HRESULT* phresult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoReleaseMarshalData"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoReleaseMarshalData([NativeTypeName("LPSTREAM")] IStream* pStm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoDisconnectObject"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoDisconnectObject([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoLockObjectExternal"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoLockObjectExternal([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, BOOL fLock, BOOL fLastUnlockReleases);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetStandardMarshal"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetStandardMarshal([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("LPMARSHAL *")] IMarshal** ppMarshal);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetStdMarshalEx"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetStdMarshalEx([NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint smexflags, [NativeTypeName("LPUNKNOWN *")] IUnknown** ppUnkInner);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoIsHandlerConnected"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern BOOL CoIsHandlerConnected([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoMarshalInterThreadInterfaceInStream"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoMarshalInterThreadInterfaceInStream([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("LPSTREAM *")] IStream** ppStm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetInterfaceAndReleaseStream"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetInterfaceAndReleaseStream([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("LPVOID *")] void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoCreateFreeThreadedMarshaler"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCreateFreeThreadedMarshaler([NativeTypeName("LPUNKNOWN")] IUnknown* punkOuter, [NativeTypeName("LPUNKNOWN *")] IUnknown** ppunkMarshal);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoFreeUnusedLibraries"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoFreeUnusedLibraries();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoFreeUnusedLibrariesEx"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern void CoFreeUnusedLibrariesEx([NativeTypeName("DWORD")] uint dwUnloadDelay, [NativeTypeName("DWORD")] uint dwReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoDisconnectContext"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoDisconnectContext([NativeTypeName("DWORD")] uint dwTimeout);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInitializeSecurity"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoInitializeSecurity([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecDesc, [NativeTypeName("LONG")] int cAuthSvc, SOLE_AUTHENTICATION_SERVICE* asAuthSvc, void* pReserved1, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, void* pAuthList, [NativeTypeName("DWORD")] uint dwCapabilities, void* pReserved3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetCallContext"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetCallContext([NativeTypeName("const IID &")] Guid* riid, void** ppInterface);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoQueryProxyBlanket"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoQueryProxyBlanket(IUnknown* pProxy, [NativeTypeName("DWORD *")] uint* pwAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("LPOLESTR *")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** pAuthInfo, [NativeTypeName("DWORD *")] uint* pCapabilites);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoSetProxyBlanket"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoSetProxyBlanket(IUnknown* pProxy, [NativeTypeName("DWORD")] uint dwAuthnSvc, [NativeTypeName("DWORD")] uint dwAuthzSvc, [NativeTypeName("OLECHAR *")] ushort* pServerPrincName, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* pAuthInfo, [NativeTypeName("DWORD")] uint dwCapabilities);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoCopyProxy"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCopyProxy(IUnknown* pProxy, IUnknown** ppCopy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoQueryClientBlanket"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoQueryClientBlanket([NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("LPOLESTR *")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** pPrivs, [NativeTypeName("DWORD *")] uint* pCapabilities);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoImpersonateClient"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoImpersonateClient();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRevertToSelf"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRevertToSelf();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoQueryAuthenticationServices"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoQueryAuthenticationServices([NativeTypeName("DWORD *")] uint* pcAuthSvc, SOLE_AUTHENTICATION_SERVICE** asAuthSvc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoSwitchCallContext"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoSwitchCallContext(IUnknown* pNewObject, IUnknown** ppOldObject);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoCreateInstance"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoCreateInstanceEx"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCreateInstanceEx([NativeTypeName("const IID &")] Guid* Clsid, IUnknown* punkOuter, [NativeTypeName("DWORD")] uint dwClsCtx, COSERVERINFO* pServerInfo, [NativeTypeName("DWORD")] uint dwCount, MULTI_QI* pResults);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoCreateInstanceFromApp"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CoCreateInstanceFromApp([NativeTypeName("const IID &")] Guid* Clsid, IUnknown* punkOuter, [NativeTypeName("DWORD")] uint dwClsCtx, [NativeTypeName("PVOID")] void* reserved, [NativeTypeName("DWORD")] uint dwCount, MULTI_QI* pResults);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRegisterActivationFilter"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRegisterActivationFilter(IActivationFilter* pActivationFilter);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetCancelObject"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetCancelObject([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("const IID &")] Guid* iid, void** ppUnk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoSetCancelObject"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoSetCancelObject(IUnknown* pUnk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoCancelCall"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCancelCall([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("ULONG")] uint ulTimeout);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoTestCancel"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoTestCancel();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoEnableCallCancellation"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoEnableCallCancellation([NativeTypeName("LPVOID")] void* pReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoDisableCallCancellation"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoDisableCallCancellation([NativeTypeName("LPVOID")] void* pReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringFromCLSID"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StringFromCLSID([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPOLESTR *")] ushort** lplpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLSIDFromString"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CLSIDFromString([NativeTypeName("LPCOLESTR")] ushort* lpsz, [NativeTypeName("LPCLSID")] Guid* pclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringFromIID"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StringFromIID([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPOLESTR *")] ushort** lplpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IIDFromString"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT IIDFromString([NativeTypeName("LPCOLESTR")] ushort* lpsz, [NativeTypeName("LPIID")] Guid* lpiid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ProgIDFromCLSID"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT ProgIDFromCLSID([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPOLESTR *")] ushort** lplpszProgID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLSIDFromProgID"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CLSIDFromProgID([NativeTypeName("LPCOLESTR")] ushort* lpszProgID, [NativeTypeName("LPCLSID")] Guid* lpclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringFromGUID2"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern int StringFromGUID2([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("LPOLESTR")] ushort* lpsz, int cchMax);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoCreateGuid"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoCreateGuid(Guid* pguid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantCopy"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT PropVariantCopy(PROPVARIANT* pvarDest, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSrc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantClear"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT PropVariantClear(PROPVARIANT* pvar);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreePropVariantArray"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT FreePropVariantArray([NativeTypeName("ULONG")] uint cVariants, PROPVARIANT* rgvars);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoWaitForMultipleHandles"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoWaitForMultipleHandles([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("ULONG")] uint cHandles, [NativeTypeName("LPHANDLE")] HANDLE* pHandles, [NativeTypeName("LPDWORD")] uint* lpdwindex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoWaitForMultipleObjects"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoWaitForMultipleObjects([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("ULONG")] uint cHandles, [NativeTypeName("const HANDLE *")] HANDLE* pHandles, [NativeTypeName("LPDWORD")] uint* lpdwindex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetTreatAsClass"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetTreatAsClass([NativeTypeName("const IID &")] Guid* clsidOld, [NativeTypeName("LPCLSID")] Guid* pClsidNew);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInvalidateRemoteMachineBindings"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoInvalidateRemoteMachineBindings([NativeTypeName("LPOLESTR")] ushort* pszMachineName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RoGetAgileReference"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RoGetAgileReference([NativeTypeName("enum AgileReferenceOptions")] AgileReferenceOptions options, [NativeTypeName("const IID &")] Guid* riid, IUnknown* pUnk, IAgileReference** ppAgileReference);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoTaskMemAlloc"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* CoTaskMemAlloc([NativeTypeName("SIZE_T")] nuint cb);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoTaskMemRealloc"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* CoTaskMemRealloc([NativeTypeName("LPVOID")] void* pv, [NativeTypeName("SIZE_T")] nuint cb);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoTaskMemFree"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoTaskMemFree([NativeTypeName("LPVOID")] void* pv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoFileTimeNow"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoFileTimeNow(FILETIME* lpFileTime);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLSIDFromProgIDEx"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CLSIDFromProgIDEx([NativeTypeName("LPCOLESTR")] ushort* lpszProgID, [NativeTypeName("LPCLSID")] Guid* lpclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRegisterDeviceCatalog"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRegisterDeviceCatalog([NativeTypeName("PCWSTR")] ushort* deviceInstanceId, CO_DEVICE_CATALOG_COOKIE* cookie);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRevokeDeviceCatalog"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRevokeDeviceCatalog(CO_DEVICE_CATALOG_COOKIE cookie);
    [NativeTypeName("#define CLSCTX_INPROC (CLSCTX_INPROC_SERVER|CLSCTX_INPROC_HANDLER)")]
    public const int CLSCTX_INPROC = ((int)(CLSCTX_INPROC_SERVER) | (int)(CLSCTX_INPROC_HANDLER));
    [NativeTypeName("#define CLSCTX_ALL (CLSCTX_INPROC_SERVER| \\\r\n                                 CLSCTX_INPROC_HANDLER| \\\r\n                                 CLSCTX_LOCAL_SERVER| \\\r\n                                 CLSCTX_REMOTE_SERVER)")]
    public const int CLSCTX_ALL = ((int)(CLSCTX_INPROC_SERVER) | (int)(CLSCTX_INPROC_HANDLER) | (int)(CLSCTX_LOCAL_SERVER) | (int)(CLSCTX_REMOTE_SERVER));
    [NativeTypeName("#define CLSCTX_SERVER (CLSCTX_INPROC_SERVER|CLSCTX_LOCAL_SERVER|CLSCTX_REMOTE_SERVER)")]
    public const int CLSCTX_SERVER = ((int)(CLSCTX_INPROC_SERVER) | (int)(CLSCTX_LOCAL_SERVER) | (int)(CLSCTX_REMOTE_SERVER));
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