// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation;

public unsafe static class MFTimedTextBinaryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBinary> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBinary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBinary> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBinary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBinary> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBinary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBinary> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBinary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedTextBinary> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBinary*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedTextBinary> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBinary*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IMFTimedTextBinary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** data, uint* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBinary*, byte**, uint*, int>)@this->LpVtbl[3])(@this, data, length);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IMFTimedTextBinary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** data, ref uint length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* lengthPtr = &length)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBinary*, byte**, uint*, int>)@this->LpVtbl[3])(@this, data, lengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IMFTimedTextBinary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* data, uint* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBinary*, byte**, uint*, int>)@this->LpVtbl[3])(@this, dataPtr, length);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IMFTimedTextBinary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* data, ref uint length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** dataPtr = &data)
        {
            fixed (uint* lengthPtr = &length)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBinary*, byte**, uint*, int>)@this->LpVtbl[3])(@this, dataPtr, lengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedTextBinary> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBinary> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBinary> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IMFTimedTextBinary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] dataSa, uint* length)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var data = (byte**) SilkMarshal.StringArrayToPtr(dataSa);
        var ret = @this->GetData(data, length);
        SilkMarshal.CopyPtrToStringArray((nint) data, dataSa);
        SilkMarshal.Free((nint) data);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetData(this ComPtr<IMFTimedTextBinary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] dataSa, ref uint length)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var data = (byte**) SilkMarshal.StringArrayToPtr(dataSa);
        var ret = @this->GetData(data, ref length);
        SilkMarshal.CopyPtrToStringArray((nint) data, dataSa);
        SilkMarshal.Free((nint) data);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IMFTimedTextBinary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** data, Span<uint> length)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetData(data, ref length.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IMFTimedTextBinary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* data, Span<uint> length)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetData(in data, ref length.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedTextBinary> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
