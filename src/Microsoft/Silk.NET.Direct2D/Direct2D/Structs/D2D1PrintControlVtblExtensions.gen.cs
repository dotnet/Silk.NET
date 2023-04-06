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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1PrintControlVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1PrintControl> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1PrintControl> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1PrintControl> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1PrintControl> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1PrintControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1PrintControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStream, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ulong* tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag2Ptr = &tag2)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStream, tag1, tag2Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ref ulong tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag1Ptr = &tag1)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStream, tag1Ptr, tag2);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ref ulong tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag1Ptr = &tag1)
        {
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStream, tag1Ptr, tag2Ptr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStreamPtr, tag1, tag2);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ulong* tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
        {
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStreamPtr, tag1, tag2Ptr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ref ulong tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
        {
            fixed (ulong* tag1Ptr = &tag1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStreamPtr, tag1Ptr, tag2);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ref ulong tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
        {
            fixed (ulong* tag1Ptr = &tag1)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStreamPtr, tag1Ptr, tag2Ptr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1CommandList* commandListPtr = &commandList)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStream, tag1, tag2);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ulong* tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1CommandList* commandListPtr = &commandList)
        {
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStream, tag1, tag2Ptr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ref ulong tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1CommandList* commandListPtr = &commandList)
        {
            fixed (ulong* tag1Ptr = &tag1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStream, tag1Ptr, tag2);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ref ulong tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1CommandList* commandListPtr = &commandList)
        {
            fixed (ulong* tag1Ptr = &tag1)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStream, tag1Ptr, tag2Ptr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1CommandList* commandListPtr = &commandList)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStreamPtr, tag1, tag2);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ulong* tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1CommandList* commandListPtr = &commandList)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStreamPtr, tag1, tag2Ptr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ref ulong tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1CommandList* commandListPtr = &commandList)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
            {
                fixed (ulong* tag1Ptr = &tag1)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStreamPtr, tag1Ptr, tag2);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ref ulong tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1CommandList* commandListPtr = &commandList)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
            {
                fixed (ulong* tag1Ptr = &tag1)
                {
                    fixed (ulong* tag2Ptr = &tag2)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStreamPtr, tag1Ptr, tag2Ptr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<ID2D1PrintControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1PrintControl> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1PrintControl> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1PrintControl> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage<TI0>(this ComPtr<ID2D1PrintControl> thisVtbl, ComPtr<TI0> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ulong* tag1, ulong* tag2) where TI0 : unmanaged, IComVtbl<ID2D1CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddPage((ID2D1CommandList*) commandList.Handle, pageSize, pagePrintTicketStream, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ulong* tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(commandList, pageSize, pagePrintTicketStream, tag1, ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage<TI0>(this ComPtr<ID2D1PrintControl> thisVtbl, ComPtr<TI0> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ulong* tag1, ref ulong tag2) where TI0 : unmanaged, IComVtbl<ID2D1CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddPage((ID2D1CommandList*) commandList.Handle, pageSize, pagePrintTicketStream, tag1, ref tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, Span<ulong> tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(commandList, pageSize, pagePrintTicketStream, ref tag1.GetPinnableReference(), tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage<TI0>(this ComPtr<ID2D1PrintControl> thisVtbl, ComPtr<TI0> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ref ulong tag1, ulong* tag2) where TI0 : unmanaged, IComVtbl<ID2D1CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddPage((ID2D1CommandList*) commandList.Handle, pageSize, pagePrintTicketStream, ref tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, Span<ulong> tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(commandList, pageSize, pagePrintTicketStream, ref tag1.GetPinnableReference(), ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage<TI0>(this ComPtr<ID2D1PrintControl> thisVtbl, ComPtr<TI0> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ref ulong tag1, ref ulong tag2) where TI0 : unmanaged, IComVtbl<ID2D1CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddPage((ID2D1CommandList*) commandList.Handle, pageSize, pagePrintTicketStream, ref tag1, ref tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Span<Silk.NET.Core.Win32Extras.IStream> pagePrintTicketStream, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(commandList, pageSize, ref pagePrintTicketStream.GetPinnableReference(), tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage<TI0>(this ComPtr<ID2D1PrintControl> thisVtbl, ComPtr<TI0> commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ulong* tag1, ulong* tag2) where TI0 : unmanaged, IComVtbl<ID2D1CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddPage((ID2D1CommandList*) commandList.Handle, pageSize, ref pagePrintTicketStream, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Span<Silk.NET.Core.Win32Extras.IStream> pagePrintTicketStream, ulong* tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(commandList, pageSize, ref pagePrintTicketStream.GetPinnableReference(), tag1, ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage<TI0>(this ComPtr<ID2D1PrintControl> thisVtbl, ComPtr<TI0> commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ulong* tag1, ref ulong tag2) where TI0 : unmanaged, IComVtbl<ID2D1CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddPage((ID2D1CommandList*) commandList.Handle, pageSize, ref pagePrintTicketStream, tag1, ref tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Span<Silk.NET.Core.Win32Extras.IStream> pagePrintTicketStream, Span<ulong> tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(commandList, pageSize, ref pagePrintTicketStream.GetPinnableReference(), ref tag1.GetPinnableReference(), tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage<TI0>(this ComPtr<ID2D1PrintControl> thisVtbl, ComPtr<TI0> commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ref ulong tag1, ulong* tag2) where TI0 : unmanaged, IComVtbl<ID2D1CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddPage((ID2D1CommandList*) commandList.Handle, pageSize, ref pagePrintTicketStream, ref tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Span<Silk.NET.Core.Win32Extras.IStream> pagePrintTicketStream, Span<ulong> tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(commandList, pageSize, ref pagePrintTicketStream.GetPinnableReference(), ref tag1.GetPinnableReference(), ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddPage<TI0>(this ComPtr<ID2D1PrintControl> thisVtbl, ComPtr<TI0> commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Win32Extras.IStream pagePrintTicketStream, ref ulong tag1, ref ulong tag2) where TI0 : unmanaged, IComVtbl<ID2D1CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddPage((ID2D1CommandList*) commandList.Handle, pageSize, ref pagePrintTicketStream, ref tag1, ref tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, Span<ID2D1CommandList> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(ref commandList.GetPinnableReference(), pageSize, pagePrintTicketStream, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, Span<ID2D1CommandList> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ulong* tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(ref commandList.GetPinnableReference(), pageSize, pagePrintTicketStream, tag1, ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, Span<ID2D1CommandList> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, Span<ulong> tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(ref commandList.GetPinnableReference(), pageSize, pagePrintTicketStream, ref tag1.GetPinnableReference(), tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, Span<ID2D1CommandList> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, Span<ulong> tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(ref commandList.GetPinnableReference(), pageSize, pagePrintTicketStream, ref tag1.GetPinnableReference(), ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, Span<ID2D1CommandList> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Span<Silk.NET.Core.Win32Extras.IStream> pagePrintTicketStream, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(ref commandList.GetPinnableReference(), pageSize, ref pagePrintTicketStream.GetPinnableReference(), tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, Span<ID2D1CommandList> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Span<Silk.NET.Core.Win32Extras.IStream> pagePrintTicketStream, ulong* tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(ref commandList.GetPinnableReference(), pageSize, ref pagePrintTicketStream.GetPinnableReference(), tag1, ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, Span<ID2D1CommandList> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Span<Silk.NET.Core.Win32Extras.IStream> pagePrintTicketStream, Span<ulong> tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(ref commandList.GetPinnableReference(), pageSize, ref pagePrintTicketStream.GetPinnableReference(), ref tag1.GetPinnableReference(), tag2);
    }

    /// <summary>To be documented.</summary>
    public static int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, Span<ID2D1CommandList> commandList, Silk.NET.Maths.Vector2D<float> pageSize, Span<Silk.NET.Core.Win32Extras.IStream> pagePrintTicketStream, Span<ulong> tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPage(ref commandList.GetPinnableReference(), pageSize, ref pagePrintTicketStream.GetPinnableReference(), ref tag1.GetPinnableReference(), ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1PrintControl> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
