// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInitialize"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoInitialize([NativeTypeName("LPVOID")] void* pvReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRegisterMallocSpy"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRegisterMallocSpy([NativeTypeName("LPMALLOCSPY")] IMallocSpy* pMallocSpy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRevokeMallocSpy"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRevokeMallocSpy();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRegisterInitializeSpy"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRegisterInitializeSpy(IInitializeSpy* pSpy, ULARGE_INTEGER* puliCookie);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRevokeInitializeSpy"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRevokeInitializeSpy(ULARGE_INTEGER uliCookie);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetSystemSecurityPermissions"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoGetSystemSecurityPermissions(COMSD comSDType, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ppSD);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoLoadLibrary"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HINSTANCE CoLoadLibrary([NativeTypeName("LPOLESTR")] ushort* lpszLibName, BOOL bAutoFree);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoFreeLibrary"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoFreeLibrary(HINSTANCE hInst);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoFreeAllLibraries"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoFreeAllLibraries();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetInstanceFromFile"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoGetInstanceFromFile(COSERVERINFO* pServerInfo, [NativeTypeName("CLSID *")] Guid* pClsid, IUnknown* punkOuter, [NativeTypeName("DWORD")] uint dwClsCtx, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("OLECHAR *")] ushort* pwszName, [NativeTypeName("DWORD")] uint dwCount, MULTI_QI* pResults);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetInstanceFromIStorage"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoGetInstanceFromIStorage(COSERVERINFO* pServerInfo, [NativeTypeName("CLSID *")] Guid* pClsid, IUnknown* punkOuter, [NativeTypeName("DWORD")] uint dwClsCtx, [NativeTypeName("struct IStorage *")] IStorage* pstg, [NativeTypeName("DWORD")] uint dwCount, MULTI_QI* pResults);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoAllowSetForegroundWindow"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoAllowSetForegroundWindow(IUnknown* pUnk, [NativeTypeName("LPVOID")] void* lpvReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoIsOle1Class"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern BOOL CoIsOle1Class([NativeTypeName("const IID &")] Guid* rclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoFileTimeToDosDateTime"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern BOOL CoFileTimeToDosDateTime(FILETIME* lpFileTime, [NativeTypeName("LPWORD")] ushort* lpDosDate, [NativeTypeName("LPWORD")] ushort* lpDosTime);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoDosDateTimeToFileTime"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern BOOL CoDosDateTimeToFileTime([NativeTypeName("WORD")] ushort nDosDate, [NativeTypeName("WORD")] ushort nDosTime, FILETIME* lpFileTime);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRegisterMessageFilter"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT CoRegisterMessageFilter([NativeTypeName("LPMESSAGEFILTER")] IMessageFilter* lpMessageFilter, [NativeTypeName("LPMESSAGEFILTER *")] IMessageFilter** lplpMessageFilter);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoRegisterChannelHook"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoRegisterChannelHook([NativeTypeName("const GUID &")] Guid* ExtensionUuid, IChannelHook* pChannelHook);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoTreatAsClass"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoTreatAsClass([NativeTypeName("const IID &")] Guid* clsidOld, [NativeTypeName("const IID &")] Guid* clsidNew);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDataAdviseHolder"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateDataAdviseHolder([NativeTypeName("LPDATAADVISEHOLDER *")] IDataAdviseHolder** ppDAHolder);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDataCache"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateDataCache([NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("LPVOID *")] void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgOpenAsyncDocfileOnIFillLockBytes"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgOpenAsyncDocfileOnIFillLockBytes(IFillLockBytes* pflb, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint asyncFlags, IStorage** ppstgOpen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgGetIFillLockBytesOnILockBytes"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgGetIFillLockBytesOnILockBytes(ILockBytes* pilb, IFillLockBytes** ppflb);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgGetIFillLockBytesOnFile"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgGetIFillLockBytesOnFile([NativeTypeName("const OLECHAR *")] ushort* pwcsName, IFillLockBytes** ppflb);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoInstall"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoInstall(IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwFlags, uCLSSPEC* pClassSpec, QUERYCONTEXT* pQuery, [NativeTypeName("LPWSTR")] ushort* pszCodeBase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BindMoniker"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT BindMoniker([NativeTypeName("LPMONIKER")] IMoniker* pmk, [NativeTypeName("DWORD")] uint grfOpt, [NativeTypeName("const IID &")] Guid* iidResult, [NativeTypeName("LPVOID *")] void** ppvResult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CoGetObject"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CoGetObject([NativeTypeName("LPCWSTR")] ushort* pszName, BIND_OPTS* pBindOptions, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MkParseDisplayName"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT MkParseDisplayName([NativeTypeName("LPBC")] IBindCtx* pbc, [NativeTypeName("LPCOLESTR")] ushort* szUserName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MonikerRelativePathTo"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT MonikerRelativePathTo([NativeTypeName("LPMONIKER")] IMoniker* pmkSrc, [NativeTypeName("LPMONIKER")] IMoniker* pmkDest, [NativeTypeName("LPMONIKER *")] IMoniker** ppmkRelPath, BOOL dwReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MonikerCommonPrefixWith"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT MonikerCommonPrefixWith([NativeTypeName("LPMONIKER")] IMoniker* pmkThis, [NativeTypeName("LPMONIKER")] IMoniker* pmkOther, [NativeTypeName("LPMONIKER *")] IMoniker** ppmkCommon);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateBindCtx"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateBindCtx([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPBC *")] IBindCtx** ppbc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateGenericComposite"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateGenericComposite([NativeTypeName("LPMONIKER")] IMoniker* pmkFirst, [NativeTypeName("LPMONIKER")] IMoniker* pmkRest, [NativeTypeName("LPMONIKER *")] IMoniker** ppmkComposite);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassFile"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT GetClassFile([NativeTypeName("LPCOLESTR")] ushort* szFilename, [NativeTypeName("CLSID *")] Guid* pclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateClassMoniker"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateClassMoniker([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileMoniker"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateFileMoniker([NativeTypeName("LPCOLESTR")] ushort* lpszPathName, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateItemMoniker"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateItemMoniker([NativeTypeName("LPCOLESTR")] ushort* lpszDelim, [NativeTypeName("LPCOLESTR")] ushort* lpszItem, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateAntiMoniker"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateAntiMoniker([NativeTypeName("LPMONIKER *")] IMoniker** ppmk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePointerMoniker"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreatePointerMoniker([NativeTypeName("LPUNKNOWN")] IUnknown* punk, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateObjrefMoniker"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateObjrefMoniker([NativeTypeName("LPUNKNOWN")] IUnknown* punk, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRunningObjectTable"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT GetRunningObjectTable([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPRUNNINGOBJECTTABLE *")] IRunningObjectTable** pprot);
    [NativeTypeName("#define MARSHALINTERFACE_MIN 500")]
    public const int MARSHALINTERFACE_MIN = 500;
    [NativeTypeName("#define ASYNC_MODE_COMPATIBILITY 0x00000001L")]
    public const int ASYNC_MODE_COMPATIBILITY = 0x00000001;
    [NativeTypeName("#define ASYNC_MODE_DEFAULT 0x00000000L")]
    public const int ASYNC_MODE_DEFAULT = 0x00000000;
    [NativeTypeName("#define STGTY_REPEAT 0x00000100L")]
    public const int STGTY_REPEAT = 0x00000100;
}