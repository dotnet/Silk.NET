// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("27354135-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IWriteEngine2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IWriteEngine2 : IWriteEngine2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWriteEngine2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWriteEngine2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWriteEngine2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWriteEngine2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IWriteEngine2, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IWriteEngine2, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IWriteEngine2, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IWriteEngine2,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WriteSection(
        IStream data,
        [NativeTypeName("LONG")] int startingBlockAddress,
        [NativeTypeName("LONG")] int numberOfBlocks
    )
    {
        return ((delegate* unmanaged<IWriteEngine2, IStream, int, int, int>)((*lpVtbl)[7]))(
            this,
            data,
            startingBlockAddress,
            numberOfBlocks
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CancelWrite()
    {
        return ((delegate* unmanaged<IWriteEngine2, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Recorder(IDiscRecorder2Ex value)
    {
        return ((delegate* unmanaged<IWriteEngine2, IDiscRecorder2Ex, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Recorder(IDiscRecorder2Ex* value)
    {
        return ((delegate* unmanaged<IWriteEngine2, IDiscRecorder2Ex*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_UseStreamingWrite12([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IWriteEngine2, short, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UseStreamingWrite12([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IWriteEngine2, short*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_StartingSectorsPerSecond([NativeTypeName("LONG")] int value)
    {
        return ((delegate* unmanaged<IWriteEngine2, int, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_StartingSectorsPerSecond([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IWriteEngine2, int*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_EndingSectorsPerSecond([NativeTypeName("LONG")] int value)
    {
        return ((delegate* unmanaged<IWriteEngine2, int, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_EndingSectorsPerSecond([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IWriteEngine2, int*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_BytesPerSector([NativeTypeName("LONG")] int value)
    {
        return ((delegate* unmanaged<IWriteEngine2, int, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_BytesPerSector([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IWriteEngine2, int*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_WriteInProgress([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IWriteEngine2, short*, int>)((*lpVtbl)[19]))(this, value);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT WriteSection(
            IStream data,
            [NativeTypeName("LONG")] int startingBlockAddress,
            [NativeTypeName("LONG")] int numberOfBlocks
        );

        [VtblIndex(8)]
        HRESULT CancelWrite();

        [VtblIndex(9)]
        HRESULT put_Recorder(IDiscRecorder2Ex value);

        [VtblIndex(10)]
        HRESULT get_Recorder(IDiscRecorder2Ex* value);

        [VtblIndex(11)]
        HRESULT put_UseStreamingWrite12([NativeTypeName("VARIANT_BOOL")] short value);

        [VtblIndex(12)]
        HRESULT get_UseStreamingWrite12([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(13)]
        HRESULT put_StartingSectorsPerSecond([NativeTypeName("LONG")] int value);

        [VtblIndex(14)]
        HRESULT get_StartingSectorsPerSecond([NativeTypeName("LONG *")] int* value);

        [VtblIndex(15)]
        HRESULT put_EndingSectorsPerSecond([NativeTypeName("LONG")] int value);

        [VtblIndex(16)]
        HRESULT get_EndingSectorsPerSecond([NativeTypeName("LONG *")] int* value);

        [VtblIndex(17)]
        HRESULT put_BytesPerSector([NativeTypeName("LONG")] int value);

        [VtblIndex(18)]
        HRESULT get_BytesPerSector([NativeTypeName("LONG *")] int* value);

        [VtblIndex(19)]
        HRESULT get_WriteInProgress([NativeTypeName("VARIANT_BOOL *")] short* value);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (IStream *, LONG, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int, int, int> WriteSection;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CancelWrite;

        [NativeTypeName("HRESULT (IDiscRecorder2Ex *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2Ex, int> put_Recorder;

        [NativeTypeName("HRESULT (IDiscRecorder2Ex **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2Ex*, int> get_Recorder;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_UseStreamingWrite12;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_UseStreamingWrite12;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_StartingSectorsPerSecond;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StartingSectorsPerSecond;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_EndingSectorsPerSecond;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_EndingSectorsPerSecond;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_BytesPerSector;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_BytesPerSector;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_WriteInProgress;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWriteEngine2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWriteEngine2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IWriteEngine2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IWriteEngine2(Silk.NET.Windows.IDispatch value)
    {
        return new IWriteEngine2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWriteEngine2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IWriteEngine2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IWriteEngine2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWriteEngine2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWriteEngine2(Silk.NET.Windows.IUnknown value)
    {
        return new IWriteEngine2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWriteEngine2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWriteEngine2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWriteEngine2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
