// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2C9463D8-4EC4-4622-8917-D486321A9443")]
[NativeTypeName("struct IHttpContext4 : IHttpContext3")]
[NativeInheritance("IHttpContext3")]
public unsafe partial struct IHttpContext4 : IHttpContext4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpContext4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpSite* GetSite()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpSite*>)((*lpVtbl)[0]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public IHttpApplication* GetApplication()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpApplication*>)((*lpVtbl)[1]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpConnection* GetConnection()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpConnection*>)((*lpVtbl)[2]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpRequest* GetRequest()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpRequest*>)((*lpVtbl)[3]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public IHttpResponse* GetResponse()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpResponse*>)((*lpVtbl)[4]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public BOOL GetResponseHeadersSent()
    {
        return ((delegate* unmanaged<IHttpContext4*, int>)((*lpVtbl)[5]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public IHttpUser* GetUser()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpUser*>)((*lpVtbl)[6]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpModuleContextContainer*>)((*lpVtbl)[7]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void IndicateCompletion(REQUEST_NOTIFICATION_STATUS notificationStatus)
    {
        ((delegate* unmanaged<IHttpContext4*, REQUEST_NOTIFICATION_STATUS, void>)((*lpVtbl)[8]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            notificationStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PostCompletion([NativeTypeName("DWORD")] uint cbBytes)
    {
        return ((delegate* unmanaged<IHttpContext4*, uint, int>)((*lpVtbl)[9]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            cbBytes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void DisableNotifications(
        [NativeTypeName("DWORD")] uint dwNotifications,
        [NativeTypeName("DWORD")] uint dwPostNotifications
    )
    {
        ((delegate* unmanaged<IHttpContext4*, uint, uint, void>)((*lpVtbl)[10]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            dwNotifications,
            dwPostNotifications
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public BOOL GetNextNotification(
        REQUEST_NOTIFICATION_STATUS status,
        [NativeTypeName("DWORD *")] uint* pdwNotification,
        BOOL* pfIsPostNotification,
        CHttpModule** ppModuleInfo,
        IHttpEventProvider** ppRequestOutput
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContext4*,
                REQUEST_NOTIFICATION_STATUS,
                uint*,
                BOOL*,
                CHttpModule**,
                IHttpEventProvider**,
                int>)((*lpVtbl)[11])
        )(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            status,
            pdwNotification,
            pfIsPostNotification,
            ppModuleInfo,
            ppRequestOutput
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public BOOL GetIsLastNotification(REQUEST_NOTIFICATION_STATUS status)
    {
        return (
            (delegate* unmanaged<IHttpContext4*, REQUEST_NOTIFICATION_STATUS, int>)((*lpVtbl)[12])
        )((IHttpContext4*)Unsafe.AsPointer(ref this), status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ExecuteRequest(
        BOOL fAsync,
        IHttpContext* pHttpContext,
        [NativeTypeName("DWORD")] uint dwExecuteFlags,
        IHttpUser* pHttpUser,
        BOOL* pfCompletionExpected = null
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContext4*,
                BOOL,
                IHttpContext*,
                uint,
                IHttpUser*,
                BOOL*,
                int>)((*lpVtbl)[13])
        )(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            fAsync,
            pHttpContext,
            dwExecuteFlags,
            pHttpUser,
            pfCompletionExpected
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("DWORD")]
    public uint GetExecuteFlags()
    {
        return ((delegate* unmanaged<IHttpContext4*, uint>)((*lpVtbl)[14]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetServerVariable(
        [NativeTypeName("PCSTR")] sbyte* pszVariableName,
        [NativeTypeName("PCSTR *")] sbyte** ppszValue,
        [NativeTypeName("DWORD *")] uint* pcchValueLength
    )
    {
        return ((delegate* unmanaged<IHttpContext4*, sbyte*, sbyte**, uint*, int>)((*lpVtbl)[15]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            pszVariableName,
            ppszValue,
            pcchValueLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetServerVariable(
        [NativeTypeName("PCSTR")] sbyte* pszVariableName,
        [NativeTypeName("PCWSTR *")] ushort** ppszValue,
        [NativeTypeName("DWORD *")] uint* pcchValueLength
    )
    {
        return ((delegate* unmanaged<IHttpContext4*, sbyte*, ushort**, uint*, int>)((*lpVtbl)[16]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            pszVariableName,
            ppszValue,
            pcchValueLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetServerVariable(
        [NativeTypeName("PCSTR")] sbyte* pszVariableName,
        [NativeTypeName("PCWSTR")] ushort* pszVariableValue
    )
    {
        return ((delegate* unmanaged<IHttpContext4*, sbyte*, ushort*, int>)((*lpVtbl)[17]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            pszVariableName,
            pszVariableValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void* AllocateRequestMemory([NativeTypeName("DWORD")] uint cbAllocation)
    {
        return ((delegate* unmanaged<IHttpContext4*, uint, void*>)((*lpVtbl)[18]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            cbAllocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public IHttpUrlInfo* GetUrlInfo()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpUrlInfo*>)((*lpVtbl)[19]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public IMetadataInfo* GetMetadata()
    {
        return ((delegate* unmanaged<IHttpContext4*, IMetadataInfo*>)((*lpVtbl)[20]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetPhysicalPath([NativeTypeName("DWORD *")] uint* pcchPhysicalPath = null)
    {
        return ((delegate* unmanaged<IHttpContext4*, uint*, ushort*>)((*lpVtbl)[21]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            pcchPhysicalPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetScriptName([NativeTypeName("DWORD *")] uint* pcchScriptName = null)
    {
        return ((delegate* unmanaged<IHttpContext4*, uint*, ushort*>)((*lpVtbl)[22]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            pcchScriptName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetScriptTranslated(
        [NativeTypeName("DWORD *")] uint* pcchScriptTranslated = null
    )
    {
        return ((delegate* unmanaged<IHttpContext4*, uint*, ushort*>)((*lpVtbl)[23]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            pcchScriptTranslated
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public IScriptMapInfo* GetScriptMap()
    {
        return ((delegate* unmanaged<IHttpContext4*, IScriptMapInfo*>)((*lpVtbl)[24]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void SetRequestHandled()
    {
        ((delegate* unmanaged<IHttpContext4*, void>)((*lpVtbl)[25]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public IHttpFileInfo* GetFileInfo()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpFileInfo*>)((*lpVtbl)[26]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT MapPath(
        [NativeTypeName("PCWSTR")] ushort* pszUrl,
        [NativeTypeName("PWSTR")] ushort* pszPhysicalPath,
        [NativeTypeName("DWORD *")] uint* pcbPhysicalPath
    )
    {
        return ((delegate* unmanaged<IHttpContext4*, ushort*, ushort*, uint*, int>)((*lpVtbl)[27]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            pszUrl,
            pszPhysicalPath,
            pcbPhysicalPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT NotifyCustomNotification(
        ICustomNotificationProvider* pCustomOutput,
        BOOL* pfCompletionExpected
    )
    {
        return (
            (delegate* unmanaged<IHttpContext4*, ICustomNotificationProvider*, BOOL*, int>)(
                (*lpVtbl)[28]
            )
        )((IHttpContext4*)Unsafe.AsPointer(ref this), pCustomOutput, pfCompletionExpected);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public IHttpContext* GetParentContext()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpContext*>)((*lpVtbl)[29]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public IHttpContext* GetRootContext()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpContext*>)((*lpVtbl)[30]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CloneContext(
        [NativeTypeName("DWORD")] uint dwCloneFlags,
        IHttpContext** ppHttpContext
    )
    {
        return ((delegate* unmanaged<IHttpContext4*, uint, IHttpContext**, int>)((*lpVtbl)[31]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            dwCloneFlags,
            ppHttpContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT ReleaseClonedContext()
    {
        return ((delegate* unmanaged<IHttpContext4*, int>)((*lpVtbl)[32]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetCurrentExecutionStats(
        [NativeTypeName("DWORD *")] uint* pdwNotification,
        [NativeTypeName("DWORD *")] uint* pdwNotificationStartTickCount = null,
        [NativeTypeName("PCWSTR *")] ushort** ppszModule = null,
        [NativeTypeName("DWORD *")] uint* pdwModuleStartTickCount = null,
        [NativeTypeName("DWORD *")] uint* pdwAsyncNotification = null,
        [NativeTypeName("DWORD *")] uint* pdwAsyncNotificationStartTickCount = null
    )
    {
        return (
            (delegate* unmanaged<IHttpContext4*, uint*, uint*, ushort**, uint*, uint*, uint*, int>)(
                (*lpVtbl)[33]
            )
        )(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            pdwNotification,
            pdwNotificationStartTickCount,
            ppszModule,
            pdwModuleStartTickCount,
            pdwAsyncNotification,
            pdwAsyncNotificationStartTickCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public IHttpTraceContext* GetTraceContext()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpTraceContext*>)((*lpVtbl)[34]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetServerVarChanges(
        [NativeTypeName("DWORD")] uint dwOldChangeNumber,
        [NativeTypeName("DWORD *")] uint* pdwNewChangeNumber,
        [NativeTypeName("DWORD *")] uint* pdwVariableSnapshot,
        [NativeTypeName("PCSTR **")] sbyte*** ppVariableNameSnapshot,
        [NativeTypeName("PCWSTR **")] ushort*** ppVariableValueSnapshot,
        [NativeTypeName("DWORD *")] uint* pdwDiffedVariables,
        [NativeTypeName("DWORD **")] uint** ppDiffedVariableIndices
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContext4*,
                uint,
                uint*,
                uint*,
                sbyte***,
                ushort***,
                uint*,
                uint**,
                int>)((*lpVtbl)[35])
        )(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            dwOldChangeNumber,
            pdwNewChangeNumber,
            pdwVariableSnapshot,
            ppVariableNameSnapshot,
            ppVariableValueSnapshot,
            pdwDiffedVariables,
            ppDiffedVariableIndices
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CancelIo()
    {
        return ((delegate* unmanaged<IHttpContext4*, int>)((*lpVtbl)[36]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT MapHandler(
        [NativeTypeName("DWORD")] uint dwSiteId,
        [NativeTypeName("PCWSTR")] ushort* pszSiteName,
        [NativeTypeName("PCWSTR")] ushort* pszUrl,
        [NativeTypeName("PCSTR")] sbyte* pszVerb,
        IScriptMapInfo** ppScriptMap,
        [Optional] BOOL fIgnoreWildcardMappings
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContext4*,
                uint,
                ushort*,
                ushort*,
                sbyte*,
                IScriptMapInfo**,
                BOOL,
                int>)((*lpVtbl)[37])
        )(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            dwSiteId,
            pszSiteName,
            pszUrl,
            pszVerb,
            ppScriptMap,
            fIgnoreWildcardMappings
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    [Obsolete(
        "This method is deprecated. Use the HttpGetExtendedInterface helper function instead."
    )]
    public HRESULT GetExtendedInterface(
        HTTP_CONTEXT_INTERFACE_VERSION version,
        [NativeTypeName("PVOID *")] void** ppInterface
    )
    {
        return (
            (delegate* unmanaged<IHttpContext4*, HTTP_CONTEXT_INTERFACE_VERSION, void**, int>)(
                (*lpVtbl)[38]
            )
        )((IHttpContext4*)Unsafe.AsPointer(ref this), version, ppInterface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public IHttpUser* GetOriginalUser()
    {
        return ((delegate* unmanaged<IHttpContext4*, IHttpUser*>)((*lpVtbl)[39]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public INamedContextContainer* GetNamedContextContainer()
    {
        return ((delegate* unmanaged<IHttpContext4*, INamedContextContainer*>)((*lpVtbl)[40]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public void EnableFullDuplex()
    {
        ((delegate* unmanaged<IHttpContext4*, void>)((*lpVtbl)[41]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT InheritServerVariable(
        [NativeTypeName("PCSTR")] sbyte* szName,
        [Optional] BOOL fFailIfNotExist
    )
    {
        return ((delegate* unmanaged<IHttpContext4*, sbyte*, BOOL, int>)((*lpVtbl)[42]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            szName,
            fFailIfNotExist
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT PostCompletion(
        [NativeTypeName("DWORD")] uint cbBytes,
        [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")]
            delegate* unmanaged<uint, uint, OVERLAPPED*, void> pfnCompletionRoutine,
        void* pvCompletionContext
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContext4*,
                uint,
                delegate* unmanaged<uint, uint, OVERLAPPED*, void>,
                void*,
                int>)((*lpVtbl)[43])
        )(
            (IHttpContext4*)Unsafe.AsPointer(ref this),
            cbBytes,
            pfnCompletionRoutine,
            pvCompletionContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    [return: NativeTypeName("ULONGLONG")]
    public ulong GetRequestStartTime()
    {
        return ((delegate* unmanaged<IHttpContext4*, ulong>)((*lpVtbl)[44]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    [return: NativeTypeName("ULONGLONG")]
    public ulong GetRequestElapsedTime()
    {
        return ((delegate* unmanaged<IHttpContext4*, ulong>)((*lpVtbl)[45]))(
            (IHttpContext4*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpContext3.Interface
    {
        [VtblIndex(44)]
        [return: NativeTypeName("ULONGLONG")]
        ulong GetRequestStartTime();

        [VtblIndex(45)]
        [return: NativeTypeName("ULONGLONG")]
        ulong GetRequestElapsedTime();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpSite *()")]
        public delegate* unmanaged<TSelf*, IHttpSite*> GetSite;

        [NativeTypeName("IHttpApplication *()")]
        public delegate* unmanaged<TSelf*, IHttpApplication*> GetApplication;

        [NativeTypeName("IHttpConnection *()")]
        public delegate* unmanaged<TSelf*, IHttpConnection*> GetConnection;

        [NativeTypeName("IHttpRequest *()")]
        public delegate* unmanaged<TSelf*, IHttpRequest*> GetRequest;

        [NativeTypeName("IHttpResponse *()")]
        public delegate* unmanaged<TSelf*, IHttpResponse*> GetResponse;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> GetResponseHeadersSent;

        [NativeTypeName("IHttpUser *() const")]
        public delegate* unmanaged<TSelf*, IHttpUser*> GetUser;

        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;

        [NativeTypeName("void (REQUEST_NOTIFICATION_STATUS)")]
        public delegate* unmanaged<TSelf*, REQUEST_NOTIFICATION_STATUS, void> IndicateCompletion;

        [NativeTypeName("HRESULT (DWORD)")]
        public delegate* unmanaged<TSelf*, uint, int> PostCompletion;

        [NativeTypeName("void (DWORD, DWORD)")]
        public delegate* unmanaged<TSelf*, uint, uint, void> DisableNotifications;

        [NativeTypeName(
            "BOOL (REQUEST_NOTIFICATION_STATUS, DWORD *, BOOL *, CHttpModule **, IHttpEventProvider **)"
        )]
        public delegate* unmanaged<
            TSelf*,
            REQUEST_NOTIFICATION_STATUS,
            uint*,
            BOOL*,
            CHttpModule**,
            IHttpEventProvider**,
            int> GetNextNotification;

        [NativeTypeName("BOOL (REQUEST_NOTIFICATION_STATUS)")]
        public delegate* unmanaged<TSelf*, REQUEST_NOTIFICATION_STATUS, int> GetIsLastNotification;

        [NativeTypeName("HRESULT (BOOL, IHttpContext *, DWORD, IHttpUser *, BOOL *)")]
        public delegate* unmanaged<
            TSelf*,
            BOOL,
            IHttpContext*,
            uint,
            IHttpUser*,
            BOOL*,
            int> ExecuteRequest;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetExecuteFlags;

        [NativeTypeName("HRESULT (PCSTR, PCSTR *, DWORD *)")]
        public delegate* unmanaged<TSelf*, sbyte*, sbyte**, uint*, int> GetServerVariable;

        [NativeTypeName("HRESULT (PCSTR, PCWSTR *, DWORD *)")]
        public delegate* unmanaged<TSelf*, sbyte*, ushort**, uint*, int> GetServerVariable1;

        [NativeTypeName("HRESULT (PCSTR, PCWSTR)")]
        public delegate* unmanaged<TSelf*, sbyte*, ushort*, int> SetServerVariable;

        [NativeTypeName("void *(DWORD)")]
        public delegate* unmanaged<TSelf*, uint, void*> AllocateRequestMemory;

        [NativeTypeName("IHttpUrlInfo *()")]
        public delegate* unmanaged<TSelf*, IHttpUrlInfo*> GetUrlInfo;

        [NativeTypeName("IMetadataInfo *()")]
        public delegate* unmanaged<TSelf*, IMetadataInfo*> GetMetadata;

        [NativeTypeName("PCWSTR (DWORD *)")]
        public delegate* unmanaged<TSelf*, uint*, ushort*> GetPhysicalPath;

        [NativeTypeName("PCWSTR (DWORD *) const")]
        public delegate* unmanaged<TSelf*, uint*, ushort*> GetScriptName;

        [NativeTypeName("PCWSTR (DWORD *)")]
        public delegate* unmanaged<TSelf*, uint*, ushort*> GetScriptTranslated;

        [NativeTypeName("IScriptMapInfo *() const")]
        public delegate* unmanaged<TSelf*, IScriptMapInfo*> GetScriptMap;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> SetRequestHandled;

        [NativeTypeName("IHttpFileInfo *() const")]
        public delegate* unmanaged<TSelf*, IHttpFileInfo*> GetFileInfo;

        [NativeTypeName("HRESULT (PCWSTR, PWSTR, DWORD *)")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, uint*, int> MapPath;

        [NativeTypeName("HRESULT (ICustomNotificationProvider *, BOOL *)")]
        public delegate* unmanaged<
            TSelf*,
            ICustomNotificationProvider*,
            BOOL*,
            int> NotifyCustomNotification;

        [NativeTypeName("IHttpContext *() const")]
        public delegate* unmanaged<TSelf*, IHttpContext*> GetParentContext;

        [NativeTypeName("IHttpContext *() const")]
        public delegate* unmanaged<TSelf*, IHttpContext*> GetRootContext;

        [NativeTypeName("HRESULT (DWORD, IHttpContext **)")]
        public delegate* unmanaged<TSelf*, uint, IHttpContext**, int> CloneContext;

        [NativeTypeName("HRESULT ()")]
        public delegate* unmanaged<TSelf*, int> ReleaseClonedContext;

        [NativeTypeName("HRESULT (DWORD *, DWORD *, PCWSTR *, DWORD *, DWORD *, DWORD *) const")]
        public delegate* unmanaged<
            TSelf*,
            uint*,
            uint*,
            ushort**,
            uint*,
            uint*,
            uint*,
            int> GetCurrentExecutionStats;

        [NativeTypeName("IHttpTraceContext *() const")]
        public delegate* unmanaged<TSelf*, IHttpTraceContext*> GetTraceContext;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD *, DWORD *, PCSTR **, PCWSTR **, DWORD *, DWORD **)"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint*,
            uint*,
            sbyte***,
            ushort***,
            uint*,
            uint**,
            int> GetServerVarChanges;

        [NativeTypeName("HRESULT ()")]
        public delegate* unmanaged<TSelf*, int> CancelIo;

        [NativeTypeName("HRESULT (DWORD, PCWSTR, PCWSTR, PCSTR, IScriptMapInfo **, BOOL)")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort*,
            ushort*,
            sbyte*,
            IScriptMapInfo**,
            BOOL,
            int> MapHandler;

        [NativeTypeName("HRESULT (HTTP_CONTEXT_INTERFACE_VERSION, PVOID *)")]
        [Obsolete(
            "This method is deprecated. Use the HttpGetExtendedInterface helper function instead."
        )]
        public delegate* unmanaged<
            TSelf*,
            HTTP_CONTEXT_INTERFACE_VERSION,
            void**,
            int> GetExtendedInterface;

        [NativeTypeName("IHttpUser *() const")]
        public delegate* unmanaged<TSelf*, IHttpUser*> GetOriginalUser;

        [NativeTypeName("INamedContextContainer *()")]
        public delegate* unmanaged<TSelf*, INamedContextContainer*> GetNamedContextContainer;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> EnableFullDuplex;

        [NativeTypeName("HRESULT (PCSTR, BOOL)")]
        public delegate* unmanaged<TSelf*, sbyte*, BOOL, int> InheritServerVariable;

        [NativeTypeName("HRESULT (DWORD, LPOVERLAPPED_COMPLETION_ROUTINE, void *)")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            delegate* unmanaged<uint, uint, OVERLAPPED*, void>,
            void*,
            int> PostCompletion1;

        [NativeTypeName("ULONGLONG ()")]
        public delegate* unmanaged<TSelf*, ulong> GetRequestStartTime;

        [NativeTypeName("ULONGLONG ()")]
        public delegate* unmanaged<TSelf*, ulong> GetRequestElapsedTime;
    }
}
