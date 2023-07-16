// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder"]/*'/>
[Guid("85AC9776-CA88-4CF2-894E-09598C078A41")]
[NativeTypeName("struct IDiscRecorder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiscRecorder : IDiscRecorder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscRecorder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscRecorder*, Guid*, void**, int> )(lpVtbl[0]))((IDiscRecorder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiscRecorder*, uint> )(lpVtbl[1]))((IDiscRecorder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscRecorder*, uint> )(lpVtbl[2]))((IDiscRecorder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.Init"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Init(byte* pbyUniqueID, [NativeTypeName("ULONG")] uint nulIDSize, [NativeTypeName("ULONG")] uint nulDriveNumber)
    {
        return ((delegate* unmanaged<IDiscRecorder*, byte*, uint, uint, int> )(lpVtbl[3]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbyUniqueID, nulIDSize, nulDriveNumber);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.GetRecorderGUID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRecorderGUID(byte* pbyUniqueID, [NativeTypeName("ULONG")] uint ulBufferSize, [NativeTypeName("ULONG *")] uint* pulReturnSizeRequired)
    {
        return ((delegate* unmanaged<IDiscRecorder*, byte*, uint, uint*, int> )(lpVtbl[4]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbyUniqueID, ulBufferSize, pulReturnSizeRequired);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.GetRecorderType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRecorderType([NativeTypeName("long *")] int* fTypeCode)
    {
        return ((delegate* unmanaged<IDiscRecorder*, int*, int> )(lpVtbl[5]))((IDiscRecorder*)Unsafe.AsPointer(ref this), fTypeCode);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.GetDisplayNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDisplayNames([NativeTypeName("BSTR *")] ushort** pbstrVendorID, [NativeTypeName("BSTR *")] ushort** pbstrProductID, [NativeTypeName("BSTR *")] ushort** pbstrRevision)
    {
        return ((delegate* unmanaged<IDiscRecorder*, ushort**, ushort**, ushort**, int> )(lpVtbl[6]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbstrVendorID, pbstrProductID, pbstrRevision);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.GetBasePnPID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetBasePnPID([NativeTypeName("BSTR *")] ushort** pbstrBasePnPID)
    {
        return ((delegate* unmanaged<IDiscRecorder*, ushort**, int> )(lpVtbl[7]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbstrBasePnPID);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.GetPath"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPath([NativeTypeName("BSTR *")] ushort** pbstrPath)
    {
        return ((delegate* unmanaged<IDiscRecorder*, ushort**, int> )(lpVtbl[8]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbstrPath);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.GetRecorderProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetRecorderProperties(IPropertyStorage** ppPropStg)
    {
        return ((delegate* unmanaged<IDiscRecorder*, IPropertyStorage**, int> )(lpVtbl[9]))((IDiscRecorder*)Unsafe.AsPointer(ref this), ppPropStg);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.SetRecorderProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetRecorderProperties(IPropertyStorage* pPropStg)
    {
        return ((delegate* unmanaged<IDiscRecorder*, IPropertyStorage*, int> )(lpVtbl[10]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pPropStg);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.GetRecorderState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetRecorderState([NativeTypeName("ULONG *")] uint* pulDevStateFlags)
    {
        return ((delegate* unmanaged<IDiscRecorder*, uint*, int> )(lpVtbl[11]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pulDevStateFlags);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.OpenExclusive"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT OpenExclusive()
    {
        return ((delegate* unmanaged<IDiscRecorder*, int> )(lpVtbl[12]))((IDiscRecorder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.QueryMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT QueryMediaType([NativeTypeName("long *")] int* fMediaType, [NativeTypeName("long *")] int* fMediaFlags)
    {
        return ((delegate* unmanaged<IDiscRecorder*, int*, int*, int> )(lpVtbl[13]))((IDiscRecorder*)Unsafe.AsPointer(ref this), fMediaType, fMediaFlags);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.QueryMediaInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT QueryMediaInfo(byte* pbSessions, byte* pbLastTrack, [NativeTypeName("ULONG *")] uint* ulStartAddress, [NativeTypeName("ULONG *")] uint* ulNextWritable, [NativeTypeName("ULONG *")] uint* ulFreeBlocks)
    {
        return ((delegate* unmanaged<IDiscRecorder*, byte*, byte*, uint*, uint*, uint*, int> )(lpVtbl[14]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbSessions, pbLastTrack, ulStartAddress, ulNextWritable, ulFreeBlocks);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.Eject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Eject()
    {
        return ((delegate* unmanaged<IDiscRecorder*, int> )(lpVtbl[15]))((IDiscRecorder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.Erase"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Erase([NativeTypeName("boolean")] byte bFullErase)
    {
        return ((delegate* unmanaged<IDiscRecorder*, byte, int> )(lpVtbl[16]))((IDiscRecorder*)Unsafe.AsPointer(ref this), bFullErase);
    }

    /// <include file='IDiscRecorder.xml' path='doc/member[@name="IDiscRecorder.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IDiscRecorder*, int> )(lpVtbl[17]))((IDiscRecorder*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Init(byte* pbyUniqueID, [NativeTypeName("ULONG")] uint nulIDSize, [NativeTypeName("ULONG")] uint nulDriveNumber);
        [VtblIndex(4)]
        HRESULT GetRecorderGUID(byte* pbyUniqueID, [NativeTypeName("ULONG")] uint ulBufferSize, [NativeTypeName("ULONG *")] uint* pulReturnSizeRequired);
        [VtblIndex(5)]
        HRESULT GetRecorderType([NativeTypeName("long *")] int* fTypeCode);
        [VtblIndex(6)]
        HRESULT GetDisplayNames([NativeTypeName("BSTR *")] ushort** pbstrVendorID, [NativeTypeName("BSTR *")] ushort** pbstrProductID, [NativeTypeName("BSTR *")] ushort** pbstrRevision);
        [VtblIndex(7)]
        HRESULT GetBasePnPID([NativeTypeName("BSTR *")] ushort** pbstrBasePnPID);
        [VtblIndex(8)]
        HRESULT GetPath([NativeTypeName("BSTR *")] ushort** pbstrPath);
        [VtblIndex(9)]
        HRESULT GetRecorderProperties(IPropertyStorage** ppPropStg);
        [VtblIndex(10)]
        HRESULT SetRecorderProperties(IPropertyStorage* pPropStg);
        [VtblIndex(11)]
        HRESULT GetRecorderState([NativeTypeName("ULONG *")] uint* pulDevStateFlags);
        [VtblIndex(12)]
        HRESULT OpenExclusive();
        [VtblIndex(13)]
        HRESULT QueryMediaType([NativeTypeName("long *")] int* fMediaType, [NativeTypeName("long *")] int* fMediaFlags);
        [VtblIndex(14)]
        HRESULT QueryMediaInfo(byte* pbSessions, byte* pbLastTrack, [NativeTypeName("ULONG *")] uint* ulStartAddress, [NativeTypeName("ULONG *")] uint* ulNextWritable, [NativeTypeName("ULONG *")] uint* ulFreeBlocks);
        [VtblIndex(15)]
        HRESULT Eject();
        [VtblIndex(16)]
        HRESULT Erase([NativeTypeName("boolean")] byte bFullErase);
        [VtblIndex(17)]
        HRESULT Close();
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
        [NativeTypeName("HRESULT (byte *, ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, uint, int> Init;
        [NativeTypeName("HRESULT (byte *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, uint*, int> GetRecorderGUID;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetRecorderType;
        [NativeTypeName("HRESULT (BSTR *, BSTR *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, ushort**, ushort**, int> GetDisplayNames;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetBasePnPID;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetPath;
        [NativeTypeName("HRESULT (IPropertyStorage **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStorage**, int> GetRecorderProperties;
        [NativeTypeName("HRESULT (IPropertyStorage *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStorage*, int> SetRecorderProperties;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetRecorderState;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OpenExclusive;
        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> QueryMediaType;
        [NativeTypeName("HRESULT (byte *, byte *, ULONG *, ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, byte*, uint*, uint*, uint*, int> QueryMediaInfo;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Eject;
        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> Erase;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }
}