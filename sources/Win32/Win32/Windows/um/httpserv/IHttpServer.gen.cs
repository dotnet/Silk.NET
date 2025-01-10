// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EDA2A40F-FB92-4D6D-B52B-C8C207380B4E")]
public unsafe partial struct IHttpServer : IHttpServer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpServer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public BOOL IsCommandLineLaunch()
    {
        return ((delegate* unmanaged<IHttpServer*, int>)((*lpVtbl)[0]))(
            (IHttpServer*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetAppPoolName()
    {
        return ((delegate* unmanaged<IHttpServer*, ushort*>)((*lpVtbl)[1]))(
            (IHttpServer*)Unsafe.AsPointer(ref this)
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
                IHttpServer*,
                HANDLE,
                delegate* unmanaged<uint, uint, OVERLAPPED*, void>,
                int>)((*lpVtbl)[2])
        )((IHttpServer*)Unsafe.AsPointer(ref this), hHandle, completionRoutine);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void IncrementThreadCount()
    {
        ((delegate* unmanaged<IHttpServer*, void>)((*lpVtbl)[3]))(
            (IHttpServer*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void DecrementThreadCount()
    {
        ((delegate* unmanaged<IHttpServer*, void>)((*lpVtbl)[4]))(
            (IHttpServer*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void ReportUnhealthy(
        [NativeTypeName("PCWSTR")] ushort* pszReasonString,
        HRESULT hrReason
    )
    {
        ((delegate* unmanaged<IHttpServer*, ushort*, HRESULT, void>)((*lpVtbl)[5]))(
            (IHttpServer*)Unsafe.AsPointer(ref this),
            pszReasonString,
            hrReason
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void RecycleProcess([NativeTypeName("PCWSTR")] ushort* pszReason)
    {
        ((delegate* unmanaged<IHttpServer*, ushort*, void>)((*lpVtbl)[6]))(
            (IHttpServer*)Unsafe.AsPointer(ref this),
            pszReason
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public IAppHostAdminManager GetAdminManager()
    {
        return ((delegate* unmanaged<IHttpServer*, IAppHostAdminManager>)((*lpVtbl)[7]))(
            (IHttpServer*)Unsafe.AsPointer(ref this)
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
                IHttpServer*,
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
            (IHttpServer*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IHttpServer*, ushort*, int>)((*lpVtbl)[9]))(
            (IHttpServer*)Unsafe.AsPointer(ref this),
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
                IHttpServer*,
                CACHE_OPERATION,
                IHttpCacheKey*,
                IHttpCacheSpecificData**,
                IHttpTraceContext*,
                int>)((*lpVtbl)[10])
        )(
            (IHttpServer*)Unsafe.AsPointer(ref this),
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
                IHttpServer*,
                ICustomNotificationProvider*,
                GLOBAL_NOTIFICATION_STATUS>)((*lpVtbl)[11])
        )((IHttpServer*)Unsafe.AsPointer(ref this), pCustomOutput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public IHttpPerfCounterInfo* GetPerfCounterInfo()
    {
        return ((delegate* unmanaged<IHttpServer*, IHttpPerfCounterInfo*>)((*lpVtbl)[12]))(
            (IHttpServer*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void RecycleApplication([NativeTypeName("PCWSTR")] ushort* pszAppConfigPath)
    {
        ((delegate* unmanaged<IHttpServer*, ushort*, void>)((*lpVtbl)[13]))(
            (IHttpServer*)Unsafe.AsPointer(ref this),
            pszAppConfigPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void NotifyConfigurationChange([NativeTypeName("PCWSTR")] ushort* pszPath)
    {
        ((delegate* unmanaged<IHttpServer*, ushort*, void>)((*lpVtbl)[14]))(
            (IHttpServer*)Unsafe.AsPointer(ref this),
            pszPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void NotifyFileChange([NativeTypeName("PCWSTR")] ushort* pszFileName)
    {
        ((delegate* unmanaged<IHttpServer*, ushort*, void>)((*lpVtbl)[15]))(
            (IHttpServer*)Unsafe.AsPointer(ref this),
            pszFileName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public IDispensedHttpModuleContextContainer* DispenseContainer()
    {
        return (
            (delegate* unmanaged<IHttpServer*, IDispensedHttpModuleContextContainer*>)(
                (*lpVtbl)[16]
            )
        )((IHttpServer*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddFragmentToCache(
        HTTP_DATA_CHUNK* pDataChunk,
        [NativeTypeName("PCWSTR")] ushort* pszFragmentName
    )
    {
        return ((delegate* unmanaged<IHttpServer*, HTTP_DATA_CHUNK*, ushort*, int>)((*lpVtbl)[17]))(
            (IHttpServer*)Unsafe.AsPointer(ref this),
            pDataChunk,
            pszFragmentName
        );
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
            (delegate* unmanaged<IHttpServer*, ushort*, byte*, uint, uint*, int>)((*lpVtbl)[18])
        )((IHttpServer*)Unsafe.AsPointer(ref this), pszFragmentName, pvBuffer, cbSize, pcbCopied);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RemoveFragmentFromCache([NativeTypeName("PCWSTR")] ushort* pszFragmentName)
    {
        return ((delegate* unmanaged<IHttpServer*, ushort*, int>)((*lpVtbl)[19]))(
            (IHttpServer*)Unsafe.AsPointer(ref this),
            pszFragmentName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetWorkerProcessSettings(IWpfSettings** ppWorkerProcessSettings)
    {
        return ((delegate* unmanaged<IHttpServer*, IWpfSettings**, int>)((*lpVtbl)[20]))(
            (IHttpServer*)Unsafe.AsPointer(ref this),
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
            (delegate* unmanaged<IHttpServer*, ushort*, ushort*, uint, void**, int>)((*lpVtbl)[21])
        )(
            (IHttpServer*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IHttpServer*, ushort*, BOOL*, int>)((*lpVtbl)[22]))(
            (IHttpServer*)Unsafe.AsPointer(ref this),
            pszPrecondition,
            pfUnknownPrecondition
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public IHttpTraceContext* GetTraceContext()
    {
        return ((delegate* unmanaged<IHttpServer*, IHttpTraceContext*>)((*lpVtbl)[23]))(
            (IHttpServer*)Unsafe.AsPointer(ref this)
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
            (delegate* unmanaged<IHttpServer*, ushort*, HANDLE, IHttpFileMonitor**, int>)(
                (*lpVtbl)[24]
            )
        )((IHttpServer*)Unsafe.AsPointer(ref this), pszPath, hToken, ppFileMonitor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetExtendedInterface(
        HTTP_SERVER_INTERFACE_VERSION version,
        [NativeTypeName("PVOID *")] void** ppInterface
    )
    {
        return (
            (delegate* unmanaged<IHttpServer*, HTTP_SERVER_INTERFACE_VERSION, void**, int>)(
                (*lpVtbl)[25]
            )
        )((IHttpServer*)Unsafe.AsPointer(ref this), version, ppInterface);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        BOOL IsCommandLineLaunch();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetAppPoolName();

        [VtblIndex(3)]
        void IncrementThreadCount();

        [VtblIndex(4)]
        void DecrementThreadCount();

        [VtblIndex(5)]
        void ReportUnhealthy([NativeTypeName("PCWSTR")] ushort* pszReasonString, HRESULT hrReason);

        [VtblIndex(6)]
        void RecycleProcess([NativeTypeName("PCWSTR")] ushort* pszReason);

        [VtblIndex(7)]
        IAppHostAdminManager GetAdminManager();

        [VtblIndex(8)]
        HRESULT GetFileInfo(
            [NativeTypeName("PCWSTR")] ushort* pszPhysicalPath,
            HANDLE hUserToken,
            [NativeTypeName("PSID")] void* pSid,
            [NativeTypeName("PCWSTR")] ushort* pszChangeNotificationPath,
            HANDLE hChangeNotificationToken,
            BOOL fCache,
            IHttpFileInfo** ppFileInfo,
            IHttpTraceContext* pHttpTraceContext = null
        );

        [VtblIndex(9)]
        HRESULT FlushKernelCache([NativeTypeName("PCWSTR")] ushort* pszUrl);

        [VtblIndex(10)]
        HRESULT DoCacheOperation(
            CACHE_OPERATION cacheOperation,
            IHttpCacheKey* pCacheKey,
            IHttpCacheSpecificData** ppCacheSpecificData,
            IHttpTraceContext* pHttpTraceContext = null
        );

        [VtblIndex(11)]
        GLOBAL_NOTIFICATION_STATUS NotifyCustomNotification(
            ICustomNotificationProvider* pCustomOutput
        );

        [VtblIndex(12)]
        IHttpPerfCounterInfo* GetPerfCounterInfo();

        [VtblIndex(13)]
        void RecycleApplication([NativeTypeName("PCWSTR")] ushort* pszAppConfigPath);

        [VtblIndex(14)]
        void NotifyConfigurationChange([NativeTypeName("PCWSTR")] ushort* pszPath);

        [VtblIndex(15)]
        void NotifyFileChange([NativeTypeName("PCWSTR")] ushort* pszFileName);

        [VtblIndex(16)]
        IDispensedHttpModuleContextContainer* DispenseContainer();

        [VtblIndex(17)]
        HRESULT AddFragmentToCache(
            HTTP_DATA_CHUNK* pDataChunk,
            [NativeTypeName("PCWSTR")] ushort* pszFragmentName
        );

        [VtblIndex(18)]
        HRESULT ReadFragmentFromCache(
            [NativeTypeName("PCWSTR")] ushort* pszFragmentName,
            byte* pvBuffer,
            [NativeTypeName("DWORD")] uint cbSize,
            [NativeTypeName("DWORD *")] uint* pcbCopied
        );

        [VtblIndex(19)]
        HRESULT RemoveFragmentFromCache([NativeTypeName("PCWSTR")] ushort* pszFragmentName);

        [VtblIndex(20)]
        HRESULT GetWorkerProcessSettings(IWpfSettings** ppWorkerProcessSettings);

        [VtblIndex(21)]
        HRESULT GetProtocolManagerCustomInterface(
            [NativeTypeName("PCWSTR")] ushort* pProtocolManagerDll,
            [NativeTypeName("PCWSTR")] ushort* pProtocolManagerDllInitFunction,
            [NativeTypeName("DWORD")] uint dwCustomInterfaceId,
            [NativeTypeName("PVOID *")] void** ppCustomInterface
        );

        [VtblIndex(22)]
        BOOL SatisfiesPrecondition(
            [NativeTypeName("PCWSTR")] ushort* pszPrecondition,
            BOOL* pfUnknownPrecondition = null
        );

        [VtblIndex(23)]
        IHttpTraceContext* GetTraceContext();

        [VtblIndex(24)]
        HRESULT RegisterFileChangeMonitor(
            [NativeTypeName("PCWSTR")] ushort* pszPath,
            HANDLE hToken,
            IHttpFileMonitor** ppFileMonitor
        );

        [VtblIndex(25)]
        HRESULT GetExtendedInterface(
            HTTP_SERVER_INTERFACE_VERSION version,
            [NativeTypeName("PVOID *")] void** ppInterface
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
    }
}
