// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F7A66D59-C0A2-48B5-A88F-BE5975C960FB")]
[NativeTypeName("struct IHttpServer3 : IHttpServer2")]
[NativeInheritance("IHttpServer2")]
public unsafe partial struct IHttpServer3 : IHttpServer3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpServer3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public BOOL IsCommandLineLaunch()
    {
        return ((delegate* unmanaged<IHttpServer3*, int>)((*lpVtbl)[0]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetAppPoolName()
    {
        return ((delegate* unmanaged<IHttpServer3*, ushort*>)((*lpVtbl)[1]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT AssociateWithThreadPool(
        HANDLE hHandle,
        [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")]
            delegate* unmanaged<uint, uint, OVERLAPPED*, void> completionRoutine
    )
    {
        return (
            (delegate* unmanaged<
                IHttpServer3*,
                HANDLE,
                delegate* unmanaged<uint, uint, OVERLAPPED*, void>,
                int>)((*lpVtbl)[2])
        )((IHttpServer3*)Unsafe.AsPointer(ref this), hHandle, completionRoutine);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void IncrementThreadCount()
    {
        ((delegate* unmanaged<IHttpServer3*, void>)((*lpVtbl)[3]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void DecrementThreadCount()
    {
        ((delegate* unmanaged<IHttpServer3*, void>)((*lpVtbl)[4]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void ReportUnhealthy(
        [NativeTypeName("PCWSTR")] ushort* pszReasonString,
        HRESULT hrReason
    )
    {
        ((delegate* unmanaged<IHttpServer3*, ushort*, HRESULT, void>)((*lpVtbl)[5]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pszReasonString,
            hrReason
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void RecycleProcess([NativeTypeName("PCWSTR")] ushort* pszReason)
    {
        ((delegate* unmanaged<IHttpServer3*, ushort*, void>)((*lpVtbl)[6]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pszReason
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public IAppHostAdminManager GetAdminManager()
    {
        return ((delegate* unmanaged<IHttpServer3*, IAppHostAdminManager>)((*lpVtbl)[7]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFileInfo(
        [NativeTypeName("PCWSTR")] ushort* pszPhysicalPath,
        HANDLE hUserToken,
        [NativeTypeName("PSID")] void* pSid,
        [NativeTypeName("PCWSTR")] ushort* pszChangeNotificationPath,
        HANDLE hChangeNotificationToken,
        BOOL fCache,
        IHttpFileInfo** ppFileInfo,
        IHttpTraceContext* pHttpTraceContext = null
    )
    {
        return (
            (delegate* unmanaged<
                IHttpServer3*,
                ushort*,
                HANDLE,
                void*,
                ushort*,
                HANDLE,
                BOOL,
                IHttpFileInfo**,
                IHttpTraceContext*,
                int>)((*lpVtbl)[8])
        )(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pszPhysicalPath,
            hUserToken,
            pSid,
            pszChangeNotificationPath,
            hChangeNotificationToken,
            fCache,
            ppFileInfo,
            pHttpTraceContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FlushKernelCache([NativeTypeName("PCWSTR")] ushort* pszUrl)
    {
        return ((delegate* unmanaged<IHttpServer3*, ushort*, int>)((*lpVtbl)[9]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pszUrl
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DoCacheOperation(
        CACHE_OPERATION cacheOperation,
        IHttpCacheKey* pCacheKey,
        IHttpCacheSpecificData** ppCacheSpecificData,
        IHttpTraceContext* pHttpTraceContext = null
    )
    {
        return (
            (delegate* unmanaged<
                IHttpServer3*,
                CACHE_OPERATION,
                IHttpCacheKey*,
                IHttpCacheSpecificData**,
                IHttpTraceContext*,
                int>)((*lpVtbl)[10])
        )(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            cacheOperation,
            pCacheKey,
            ppCacheSpecificData,
            pHttpTraceContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public GLOBAL_NOTIFICATION_STATUS NotifyCustomNotification(
        ICustomNotificationProvider* pCustomOutput
    )
    {
        return (
            (delegate* unmanaged<
                IHttpServer3*,
                ICustomNotificationProvider*,
                GLOBAL_NOTIFICATION_STATUS>)((*lpVtbl)[11])
        )((IHttpServer3*)Unsafe.AsPointer(ref this), pCustomOutput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public IHttpPerfCounterInfo* GetPerfCounterInfo()
    {
        return ((delegate* unmanaged<IHttpServer3*, IHttpPerfCounterInfo*>)((*lpVtbl)[12]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void RecycleApplication([NativeTypeName("PCWSTR")] ushort* pszAppConfigPath)
    {
        ((delegate* unmanaged<IHttpServer3*, ushort*, void>)((*lpVtbl)[13]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pszAppConfigPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void NotifyConfigurationChange([NativeTypeName("PCWSTR")] ushort* pszPath)
    {
        ((delegate* unmanaged<IHttpServer3*, ushort*, void>)((*lpVtbl)[14]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pszPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void NotifyFileChange([NativeTypeName("PCWSTR")] ushort* pszFileName)
    {
        ((delegate* unmanaged<IHttpServer3*, ushort*, void>)((*lpVtbl)[15]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pszFileName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public IDispensedHttpModuleContextContainer* DispenseContainer()
    {
        return (
            (delegate* unmanaged<IHttpServer3*, IDispensedHttpModuleContextContainer*>)(
                (*lpVtbl)[16]
            )
        )((IHttpServer3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddFragmentToCache(
        HTTP_DATA_CHUNK* pDataChunk,
        [NativeTypeName("PCWSTR")] ushort* pszFragmentName
    )
    {
        return (
            (delegate* unmanaged<IHttpServer3*, HTTP_DATA_CHUNK*, ushort*, int>)((*lpVtbl)[17])
        )((IHttpServer3*)Unsafe.AsPointer(ref this), pDataChunk, pszFragmentName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadFragmentFromCache(
        [NativeTypeName("PCWSTR")] ushort* pszFragmentName,
        byte* pvBuffer,
        [NativeTypeName("DWORD")] uint cbSize,
        [NativeTypeName("DWORD *")] uint* pcbCopied
    )
    {
        return (
            (delegate* unmanaged<IHttpServer3*, ushort*, byte*, uint, uint*, int>)((*lpVtbl)[18])
        )((IHttpServer3*)Unsafe.AsPointer(ref this), pszFragmentName, pvBuffer, cbSize, pcbCopied);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RemoveFragmentFromCache([NativeTypeName("PCWSTR")] ushort* pszFragmentName)
    {
        return ((delegate* unmanaged<IHttpServer3*, ushort*, int>)((*lpVtbl)[19]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pszFragmentName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetWorkerProcessSettings(IWpfSettings** ppWorkerProcessSettings)
    {
        return ((delegate* unmanaged<IHttpServer3*, IWpfSettings**, int>)((*lpVtbl)[20]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            ppWorkerProcessSettings
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetProtocolManagerCustomInterface(
        [NativeTypeName("PCWSTR")] ushort* pProtocolManagerDll,
        [NativeTypeName("PCWSTR")] ushort* pProtocolManagerDllInitFunction,
        [NativeTypeName("DWORD")] uint dwCustomInterfaceId,
        [NativeTypeName("PVOID *")] void** ppCustomInterface
    )
    {
        return (
            (delegate* unmanaged<IHttpServer3*, ushort*, ushort*, uint, void**, int>)((*lpVtbl)[21])
        )(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pProtocolManagerDll,
            pProtocolManagerDllInitFunction,
            dwCustomInterfaceId,
            ppCustomInterface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL SatisfiesPrecondition(
        [NativeTypeName("PCWSTR")] ushort* pszPrecondition,
        BOOL* pfUnknownPrecondition = null
    )
    {
        return ((delegate* unmanaged<IHttpServer3*, ushort*, BOOL*, int>)((*lpVtbl)[22]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pszPrecondition,
            pfUnknownPrecondition
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public IHttpTraceContext* GetTraceContext()
    {
        return ((delegate* unmanaged<IHttpServer3*, IHttpTraceContext*>)((*lpVtbl)[23]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT RegisterFileChangeMonitor(
        [NativeTypeName("PCWSTR")] ushort* pszPath,
        HANDLE hToken,
        IHttpFileMonitor** ppFileMonitor
    )
    {
        return (
            (delegate* unmanaged<IHttpServer3*, ushort*, HANDLE, IHttpFileMonitor**, int>)(
                (*lpVtbl)[24]
            )
        )((IHttpServer3*)Unsafe.AsPointer(ref this), pszPath, hToken, ppFileMonitor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetExtendedInterface(
        HTTP_SERVER_INTERFACE_VERSION version,
        [NativeTypeName("PVOID *")] void** ppInterface
    )
    {
        return (
            (delegate* unmanaged<IHttpServer3*, HTTP_SERVER_INTERFACE_VERSION, void**, int>)(
                (*lpVtbl)[25]
            )
        )((IHttpServer3*)Unsafe.AsPointer(ref this), version, ppInterface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetToken(
        [NativeTypeName("PCWSTR")] ushort* pszUserName,
        [NativeTypeName("PCWSTR")] ushort* pszPassword,
        [NativeTypeName("DWORD")] uint dwLogonMethod,
        IHttpTokenEntry** ppTokenEntry,
        [NativeTypeName("PCWSTR")] ushort* pszDefaultDomain = null,
        [NativeTypeName("PSOCKADDR")] SOCKADDR* pSockAddr = null,
        IHttpTraceContext* pHttpTraceContext = null
    )
    {
        return (
            (delegate* unmanaged<
                IHttpServer3*,
                ushort*,
                ushort*,
                uint,
                IHttpTokenEntry**,
                ushort*,
                SOCKADDR*,
                IHttpTraceContext*,
                int>)((*lpVtbl)[26])
        )(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pszUserName,
            pszPassword,
            dwLogonMethod,
            ppTokenEntry,
            pszDefaultDomain,
            pSockAddr,
            pHttpTraceContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetAppPoolConfigFile([NativeTypeName("DWORD *")] uint* pcchConfigFilePath = null)
    {
        return ((delegate* unmanaged<IHttpServer3*, uint*, ushort*>)((*lpVtbl)[27]))(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            pcchConfigFilePath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetExtendedInterface(
        [NativeTypeName("const GUID &")] Guid* Version1,
        [NativeTypeName("PVOID")] void* pInput,
        [NativeTypeName("const GUID &")] Guid* Version2,
        [NativeTypeName("PVOID *")] void** ppOutput
    )
    {
        return (
            (delegate* unmanaged<IHttpServer3*, Guid*, void*, Guid*, void**, int>)((*lpVtbl)[28])
        )((IHttpServer3*)Unsafe.AsPointer(ref this), Version1, pInput, Version2, ppOutput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetMetadata(
        [NativeTypeName("PCWSTR")] ushort* pszSiteName,
        [NativeTypeName("PCWSTR")] ushort* pszUrl,
        IReferencedMetadataInfo** ppMetadataInfo
    )
    {
        return (
            (delegate* unmanaged<IHttpServer3*, ushort*, ushort*, IReferencedMetadataInfo**, int>)(
                (*lpVtbl)[29]
            )
        )((IHttpServer3*)Unsafe.AsPointer(ref this), pszSiteName, pszUrl, ppMetadataInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetWorkerProcessFramework(IWorkerProcessFramework** ppWorkerProcessFramework)
    {
        return (
            (delegate* unmanaged<IHttpServer3*, IWorkerProcessFramework**, int>)((*lpVtbl)[30])
        )((IHttpServer3*)Unsafe.AsPointer(ref this), ppWorkerProcessFramework);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT QueryRequestProperty(
        [NativeTypeName("HTTP_OPAQUE_ID")] ulong id,
        HTTP_REQUEST_PROPERTY propertyId,
        [NativeTypeName("PVOID")] void* pQualifier,
        [NativeTypeName("ULONG")] uint qualifierSize,
        [NativeTypeName("PVOID")] void* pOutput,
        [NativeTypeName("ULONG")] uint outputBufferSize,
        [NativeTypeName("PULONG")] uint* pcbBytesReturned,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* pOverlapped
    )
    {
        return (
            (delegate* unmanaged<
                IHttpServer3*,
                ulong,
                HTTP_REQUEST_PROPERTY,
                void*,
                uint,
                void*,
                uint,
                uint*,
                OVERLAPPED*,
                int>)((*lpVtbl)[31])
        )(
            (IHttpServer3*)Unsafe.AsPointer(ref this),
            id,
            propertyId,
            pQualifier,
            qualifierSize,
            pOutput,
            outputBufferSize,
            pcbBytesReturned,
            pOverlapped
        );
    }

    public interface Interface : IHttpServer2.Interface
    {
        [VtblIndex(31)]
        HRESULT QueryRequestProperty(
            [NativeTypeName("HTTP_OPAQUE_ID")] ulong id,
            HTTP_REQUEST_PROPERTY propertyId,
            [NativeTypeName("PVOID")] void* pQualifier,
            [NativeTypeName("ULONG")] uint qualifierSize,
            [NativeTypeName("PVOID")] void* pOutput,
            [NativeTypeName("ULONG")] uint outputBufferSize,
            [NativeTypeName("PULONG")] uint* pcbBytesReturned,
            [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* pOverlapped
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> IsCommandLineLaunch;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetAppPoolName;

        [NativeTypeName("HRESULT (HANDLE, LPOVERLAPPED_COMPLETION_ROUTINE)")]
        public delegate* unmanaged<
            TSelf*,
            HANDLE,
            delegate* unmanaged<uint, uint, OVERLAPPED*, void>,
            int> AssociateWithThreadPool;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> IncrementThreadCount;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> DecrementThreadCount;

        [NativeTypeName("void (PCWSTR, HRESULT)")]
        public delegate* unmanaged<TSelf*, ushort*, HRESULT, void> ReportUnhealthy;

        [NativeTypeName("void (PCWSTR)")]
        public delegate* unmanaged<TSelf*, ushort*, void> RecycleProcess;

        [NativeTypeName("IAppHostAdminManager *() const")]
        public delegate* unmanaged<TSelf*, IAppHostAdminManager> GetAdminManager;

        [NativeTypeName(
            "HRESULT (PCWSTR, HANDLE, PSID, PCWSTR, HANDLE, BOOL, IHttpFileInfo **, IHttpTraceContext *)"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            HANDLE,
            void*,
            ushort*,
            HANDLE,
            BOOL,
            IHttpFileInfo**,
            IHttpTraceContext*,
            int> GetFileInfo;

        [NativeTypeName("HRESULT (PCWSTR)")]
        public delegate* unmanaged<TSelf*, ushort*, int> FlushKernelCache;

        [NativeTypeName(
            "HRESULT (CACHE_OPERATION, IHttpCacheKey *, IHttpCacheSpecificData **, IHttpTraceContext *)"
        )]
        public delegate* unmanaged<
            TSelf*,
            CACHE_OPERATION,
            IHttpCacheKey*,
            IHttpCacheSpecificData**,
            IHttpTraceContext*,
            int> DoCacheOperation;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (ICustomNotificationProvider *)")]
        public delegate* unmanaged<
            TSelf*,
            ICustomNotificationProvider*,
            GLOBAL_NOTIFICATION_STATUS> NotifyCustomNotification;

        [NativeTypeName("IHttpPerfCounterInfo *()")]
        public delegate* unmanaged<TSelf*, IHttpPerfCounterInfo*> GetPerfCounterInfo;

        [NativeTypeName("void (PCWSTR)")]
        public delegate* unmanaged<TSelf*, ushort*, void> RecycleApplication;

        [NativeTypeName("void (PCWSTR)")]
        public delegate* unmanaged<TSelf*, ushort*, void> NotifyConfigurationChange;

        [NativeTypeName("void (PCWSTR)")]
        public delegate* unmanaged<TSelf*, ushort*, void> NotifyFileChange;

        [NativeTypeName("IDispensedHttpModuleContextContainer *()")]
        public delegate* unmanaged<TSelf*, IDispensedHttpModuleContextContainer*> DispenseContainer;

        [NativeTypeName("HRESULT (HTTP_DATA_CHUNK *, PCWSTR)")]
        public delegate* unmanaged<TSelf*, HTTP_DATA_CHUNK*, ushort*, int> AddFragmentToCache;

        [NativeTypeName("HRESULT (PCWSTR, BYTE *, DWORD, DWORD *)")]
        public delegate* unmanaged<TSelf*, ushort*, byte*, uint, uint*, int> ReadFragmentFromCache;

        [NativeTypeName("HRESULT (PCWSTR)")]
        public delegate* unmanaged<TSelf*, ushort*, int> RemoveFragmentFromCache;

        [NativeTypeName("HRESULT (IWpfSettings **)")]
        public delegate* unmanaged<TSelf*, IWpfSettings**, int> GetWorkerProcessSettings;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, DWORD, PVOID *)")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            uint,
            void**,
            int> GetProtocolManagerCustomInterface;

        [NativeTypeName("BOOL (PCWSTR, BOOL *) const")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> SatisfiesPrecondition;

        [NativeTypeName("IHttpTraceContext *() const")]
        public delegate* unmanaged<TSelf*, IHttpTraceContext*> GetTraceContext;

        [NativeTypeName("HRESULT (PCWSTR, HANDLE, IHttpFileMonitor **)")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            HANDLE,
            IHttpFileMonitor**,
            int> RegisterFileChangeMonitor;

        [NativeTypeName("HRESULT (HTTP_SERVER_INTERFACE_VERSION, PVOID *)")]
        public delegate* unmanaged<
            TSelf*,
            HTTP_SERVER_INTERFACE_VERSION,
            void**,
            int> GetExtendedInterface;

        [NativeTypeName(
            "HRESULT (PCWSTR, PCWSTR, DWORD, IHttpTokenEntry **, PCWSTR, PSOCKADDR, IHttpTraceContext *)"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            uint,
            IHttpTokenEntry**,
            ushort*,
            SOCKADDR*,
            IHttpTraceContext*,
            int> GetToken;

        [NativeTypeName("PCWSTR (DWORD *) const")]
        public delegate* unmanaged<TSelf*, uint*, ushort*> GetAppPoolConfigFile;

        [NativeTypeName("HRESULT (const GUID &, PVOID, const GUID &, PVOID *)")]
        public delegate* unmanaged<TSelf*, Guid*, void*, Guid*, void**, int> GetExtendedInterface1;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, IReferencedMetadataInfo **)")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            IReferencedMetadataInfo**,
            int> GetMetadata;

        [NativeTypeName("HRESULT (IWorkerProcessFramework **)")]
        public delegate* unmanaged<
            TSelf*,
            IWorkerProcessFramework**,
            int> GetWorkerProcessFramework;

        [NativeTypeName(
            "HRESULT (HTTP_OPAQUE_ID, HTTP_REQUEST_PROPERTY, PVOID, ULONG, PVOID, ULONG, PULONG, LPOVERLAPPED)"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            HTTP_REQUEST_PROPERTY,
            void*,
            uint,
            void*,
            uint,
            uint*,
            OVERLAPPED*,
            int> QueryRequestProperty;
    }
}
