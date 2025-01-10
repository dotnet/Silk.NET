// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E9931663-80BF-4C6E-98AF-5DCF58747D1F")]
[NativeTypeName("struct IMFSaveJob : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSaveJob : IMFSaveJob.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSaveJob));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSaveJob, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSaveJob, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSaveJob, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginSave(IMFByteStream pStream, IMFAsyncCallback pCallback, IUnknown pState)
    {
        return (
            (delegate* unmanaged<IMFSaveJob, IMFByteStream, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[3]
            )
        )(this, pStream, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndSave(IMFAsyncResult pResult)
    {
        return ((delegate* unmanaged<IMFSaveJob, IMFAsyncResult, int>)((*lpVtbl)[4]))(
            this,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelSave()
    {
        return ((delegate* unmanaged<IMFSaveJob, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProgress([NativeTypeName("DWORD *")] uint* pdwPercentComplete)
    {
        return ((delegate* unmanaged<IMFSaveJob, uint*, int>)((*lpVtbl)[6]))(
            this,
            pdwPercentComplete
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginSave(IMFByteStream pStream, IMFAsyncCallback pCallback, IUnknown pState);

        [VtblIndex(4)]
        HRESULT EndSave(IMFAsyncResult pResult);

        [VtblIndex(5)]
        HRESULT CancelSave();

        [VtblIndex(6)]
        HRESULT GetProgress([NativeTypeName("DWORD *")] uint* pdwPercentComplete);
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

        [NativeTypeName(
            "HRESULT (IMFByteStream *, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFByteStream,
            IMFAsyncCallback,
            IUnknown,
            int> BeginSave;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult, int> EndSave;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CancelSave;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetProgress;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSaveJob"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSaveJob(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSaveJob"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSaveJob(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSaveJob(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSaveJob"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSaveJob"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSaveJob value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
