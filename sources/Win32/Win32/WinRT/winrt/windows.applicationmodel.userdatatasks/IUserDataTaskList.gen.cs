// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("49412E39-7C1D-4DF1-BED3-314B7CBF5E4E")]
[NativeTypeName("struct IUserDataTaskList : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTaskList : IUserDataTaskList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataTaskList));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserDataTaskList, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUserDataTaskList, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserDataTaskList, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUserDataTaskList, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUserDataTaskList, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUserDataTaskList, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IUserDataTaskList, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_UserDataAccountId(HSTRING* value)
    {
        return ((delegate* unmanaged<IUserDataTaskList, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IUserDataTaskList, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged<IUserDataTaskList, HSTRING, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SourceDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IUserDataTaskList, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_OtherAppReadAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess *"
        )]
            UserDataTaskListOtherAppReadAccess* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskList, UserDataTaskListOtherAppReadAccess*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_OtherAppReadAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess"
        )]
            UserDataTaskListOtherAppReadAccess value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskList, UserDataTaskListOtherAppReadAccess, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_OtherAppWriteAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess *"
        )]
            UserDataTaskListOtherAppWriteAccess* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskList, UserDataTaskListOtherAppWriteAccess*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_OtherAppWriteAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess"
        )]
            UserDataTaskListOtherAppWriteAccess value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskList, UserDataTaskListOtherAppWriteAccess, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_LimitedWriteOperations(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListLimitedWriteOperations **"
        )]
            IUserDataTaskListLimitedWriteOperations* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskList, IUserDataTaskListLimitedWriteOperations*, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SyncManager(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListSyncManager **"
        )]
            IUserDataTaskListSyncManager* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskList, IUserDataTaskListSyncManager*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RegisterSyncManagerAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IUserDataTaskList, IAsyncAction*, int>)((*lpVtbl)[17]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetTaskReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **")]
            IUserDataTaskReader* result
    )
    {
        return ((delegate* unmanaged<IUserDataTaskList, IUserDataTaskReader*, int>)((*lpVtbl)[18]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetTaskReaderWithOptions(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskQueryOptions *"
        )]
            IUserDataTaskQueryOptions options,
        [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **")]
            IUserDataTaskReader* value
    )
    {
        return (
            (delegate* unmanaged<
                IUserDataTaskList,
                IUserDataTaskQueryOptions,
                IUserDataTaskReader*,
                int>)((*lpVtbl)[19])
        )(this, options, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetTaskAsync(
        HSTRING userDataTask,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTask_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskList, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[20]
            )
        )(this, userDataTask, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SaveTaskAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTask *")]
            IUserDataTask userDataTask,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* action
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskList, IUserDataTask, IAsyncAction*, int>)(
                (*lpVtbl)[21]
            )
        )(this, userDataTask, action);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT DeleteTaskAsync(
        HSTRING userDataTaskId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* action
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskList, HSTRING, IAsyncAction*, int>)((*lpVtbl)[22])
        )(this, userDataTaskId, action);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT DeleteAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return ((delegate* unmanaged<IUserDataTaskList, IAsyncAction*, int>)((*lpVtbl)[23]))(
            this,
            asyncAction
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SaveAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return ((delegate* unmanaged<IUserDataTaskList, IAsyncAction*, int>)((*lpVtbl)[24]))(
            this,
            asyncAction
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_UserDataAccountId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_SourceDisplayName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_OtherAppReadAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess *"
            )]
                UserDataTaskListOtherAppReadAccess* value
        );

        [VtblIndex(12)]
        HRESULT put_OtherAppReadAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess"
            )]
                UserDataTaskListOtherAppReadAccess value
        );

        [VtblIndex(13)]
        HRESULT get_OtherAppWriteAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess *"
            )]
                UserDataTaskListOtherAppWriteAccess* value
        );

        [VtblIndex(14)]
        HRESULT put_OtherAppWriteAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess"
            )]
                UserDataTaskListOtherAppWriteAccess value
        );

        [VtblIndex(15)]
        HRESULT get_LimitedWriteOperations(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListLimitedWriteOperations **"
            )]
                IUserDataTaskListLimitedWriteOperations* value
        );

        [VtblIndex(16)]
        HRESULT get_SyncManager(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListSyncManager **"
            )]
                IUserDataTaskListSyncManager* value
        );

        [VtblIndex(17)]
        HRESULT RegisterSyncManagerAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(18)]
        HRESULT GetTaskReader(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **"
            )]
                IUserDataTaskReader* result
        );

        [VtblIndex(19)]
        HRESULT GetTaskReaderWithOptions(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskQueryOptions *"
            )]
                IUserDataTaskQueryOptions options,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **"
            )]
                IUserDataTaskReader* value
        );

        [VtblIndex(20)]
        HRESULT GetTaskAsync(
            HSTRING userDataTask,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTask_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(21)]
        HRESULT SaveTaskAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTask *")]
                IUserDataTask userDataTask,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* action
        );

        [VtblIndex(22)]
        HRESULT DeleteTaskAsync(
            HSTRING userDataTaskId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* action
        );

        [VtblIndex(23)]
        HRESULT DeleteAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(24)]
        HRESULT SaveAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserDataAccountId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SourceDisplayName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            UserDataTaskListOtherAppReadAccess*,
            int> get_OtherAppReadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            UserDataTaskListOtherAppReadAccess,
            int> put_OtherAppReadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            UserDataTaskListOtherAppWriteAccess*,
            int> get_OtherAppWriteAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            UserDataTaskListOtherAppWriteAccess,
            int> put_OtherAppWriteAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListLimitedWriteOperations **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUserDataTaskListLimitedWriteOperations*,
            int> get_LimitedWriteOperations;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListSyncManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUserDataTaskListSyncManager*, int> get_SyncManager;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> RegisterSyncManagerAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUserDataTaskReader*, int> GetTaskReader;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskQueryOptions *, ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUserDataTaskQueryOptions,
            IUserDataTaskReader*,
            int> GetTaskReaderWithOptions;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTask_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetTaskAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTask *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUserDataTask, IAsyncAction*, int> SaveTaskAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> DeleteTaskAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> DeleteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> SaveAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUserDataTaskList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUserDataTaskList(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUserDataTaskList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUserDataTaskList(Silk.NET.WinRT.IInspectable value)
    {
        return new IUserDataTaskList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataTaskList"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataTaskList"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUserDataTaskList value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUserDataTaskList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUserDataTaskList(Silk.NET.Windows.IUnknown value)
    {
        return new IUserDataTaskList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataTaskList"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataTaskList"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUserDataTaskList value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
