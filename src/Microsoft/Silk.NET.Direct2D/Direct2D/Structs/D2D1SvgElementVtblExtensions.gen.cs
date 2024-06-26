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

public unsafe static class D2D1SvgElementVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgElement> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgElement> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgElement> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgElement> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDocument(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgDocument** document)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgDocument**, void>)@this->LpVtbl[4])(@this, document);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDocument(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgDocument* document)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1SvgDocument** documentPtr = &document)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgDocument**, void>)@this->LpVtbl[4])(@this, documentPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTagName(this ComPtr<ID2D1SvgElement> thisVtbl, char* name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[5])(@this, name, nameCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTagName(this ComPtr<ID2D1SvgElement> thisVtbl, ref char name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[5])(@this, namePtr, nameCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTagName(this ComPtr<ID2D1SvgElement> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, uint, int>)@this->LpVtbl[5])(@this, namePtr, nameCount);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetTagNameLength(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsTextContent(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetParent(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement** parent)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[8])(@this, parent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetParent(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement* parent)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1SvgElement** parentPtr = &parent)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[8])(@this, parentPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasChildren(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Silk.NET.Core.Bool32>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFirstChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement** child)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[10])(@this, child);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFirstChild(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement* child)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1SvgElement** childPtr = &child)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[10])(@this, childPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetLastChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement** child)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[11])(@this, child);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetLastChild(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement* child)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1SvgElement** childPtr = &child)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[11])(@this, childPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreviousChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[12])(@this, referenceChild, previousChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreviousChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* referenceChild, ref ID2D1SvgElement* previousChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement** previousChildPtr = &previousChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[12])(@this, referenceChild, previousChildPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreviousChild(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement referenceChild, ID2D1SvgElement** previousChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[12])(@this, referenceChildPtr, previousChild);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreviousChild(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement referenceChild, ref ID2D1SvgElement* previousChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
        {
            fixed (ID2D1SvgElement** previousChildPtr = &previousChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[12])(@this, referenceChildPtr, previousChildPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNextChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[13])(@this, referenceChild, nextChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNextChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* referenceChild, ref ID2D1SvgElement* nextChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement** nextChildPtr = &nextChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[13])(@this, referenceChild, nextChildPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNextChild(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement referenceChild, ID2D1SvgElement** nextChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[13])(@this, referenceChildPtr, nextChild);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNextChild(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement referenceChild, ref ID2D1SvgElement* nextChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
        {
            fixed (ID2D1SvgElement** nextChildPtr = &nextChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[13])(@this, referenceChildPtr, nextChildPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InsertChildBefore(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* newChild, ID2D1SvgElement* referenceChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[14])(@this, newChild, referenceChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InsertChildBefore(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* newChild, ref ID2D1SvgElement referenceChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[14])(@this, newChild, referenceChildPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InsertChildBefore(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement newChild, ID2D1SvgElement* referenceChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* newChildPtr = &newChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[14])(@this, newChildPtr, referenceChild);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InsertChildBefore(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement newChild, ref ID2D1SvgElement referenceChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* newChildPtr = &newChild)
        {
            fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[14])(@this, newChildPtr, referenceChildPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AppendChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* newChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[15])(@this, newChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AppendChild(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement newChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* newChildPtr = &newChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[15])(@this, newChildPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReplaceChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* newChild, ID2D1SvgElement* oldChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[16])(@this, newChild, oldChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReplaceChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* newChild, ref ID2D1SvgElement oldChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* oldChildPtr = &oldChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[16])(@this, newChild, oldChildPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReplaceChild(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement newChild, ID2D1SvgElement* oldChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* newChildPtr = &newChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[16])(@this, newChildPtr, oldChild);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReplaceChild(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement newChild, ref ID2D1SvgElement oldChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* newChildPtr = &newChild)
        {
            fixed (ID2D1SvgElement* oldChildPtr = &oldChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[16])(@this, newChildPtr, oldChildPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* oldChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[17])(@this, oldChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveChild(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement oldChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* oldChildPtr = &oldChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[17])(@this, oldChildPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateChild(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* tagName, ID2D1SvgElement** newChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagName, newChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateChild(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* tagName, ref ID2D1SvgElement* newChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement** newChildPtr = &newChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagName, newChildPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateChild(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char tagName, ID2D1SvgElement** newChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* tagNamePtr = &tagName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagNamePtr, newChild);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateChild(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char tagName, ref ID2D1SvgElement* newChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* tagNamePtr = &tagName)
        {
            fixed (ID2D1SvgElement** newChildPtr = &newChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagNamePtr, newChildPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateChild(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tagName, ID2D1SvgElement** newChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var tagNamePtr = (byte*) SilkMarshal.StringToPtr(tagName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagNamePtr, newChild);
        SilkMarshal.Free((nint)tagNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateChild(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tagName, ref ID2D1SvgElement* newChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var tagNamePtr = (byte*) SilkMarshal.StringToPtr(tagName, NativeStringEncoding.UTF8);
        fixed (ID2D1SvgElement** newChildPtr = &newChild)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagNamePtr, newChildPtr);
        }
        SilkMarshal.Free((nint)tagNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, int* inherited)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, name, inherited);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, ref int inherited)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        fixed (int* inheritedPtr = &inherited)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, name, inheritedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, int* inherited)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, namePtr, inherited);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, ref int inherited)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        fixed (char* namePtr = &name)
        {
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, namePtr, inheritedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, int* inherited)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, namePtr, inherited);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref int inherited)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (int* inheritedPtr = &inherited)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, namePtr, inheritedPtr);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetSpecifiedAttributeCount(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[20])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, char* name, uint nameCount, int* inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)@this->LpVtbl[21])(@this, index, name, nameCount, inherited);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, char* name, uint nameCount, ref int inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* inheritedPtr = &inherited)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)@this->LpVtbl[21])(@this, index, name, nameCount, inheritedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, ref char name, uint nameCount, int* inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)@this->LpVtbl[21])(@this, index, namePtr, nameCount, inherited);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, ref char name, uint nameCount, ref int inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)@this->LpVtbl[21])(@this, index, namePtr, nameCount, inheritedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount, int* inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, byte*, uint, int*, int>)@this->LpVtbl[21])(@this, index, namePtr, nameCount, inherited);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount, ref int inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (int* inheritedPtr = &inherited)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, byte*, uint, int*, int>)@this->LpVtbl[21])(@this, index, namePtr, nameCount, inheritedPtr);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeNameLength(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, uint* nameLength, int* inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)@this->LpVtbl[22])(@this, index, nameLength, inherited);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeNameLength(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, uint* nameLength, ref int inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* inheritedPtr = &inherited)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)@this->LpVtbl[22])(@this, index, nameLength, inheritedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeNameLength(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, ref uint nameLength, int* inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* nameLengthPtr = &nameLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)@this->LpVtbl[22])(@this, index, nameLengthPtr, inherited);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecifiedAttributeNameLength(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, ref uint nameLength, ref int inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* nameLengthPtr = &nameLength)
        {
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)@this->LpVtbl[22])(@this, index, nameLengthPtr, inheritedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveAttribute(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int>)@this->LpVtbl[23])(@this, name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveAttribute(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int>)@this->LpVtbl[23])(@this, namePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveAttribute(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, int>)@this->LpVtbl[23])(@this, namePtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTextValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[24])(@this, name, nameCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[24])(@this, namePtr, nameCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, uint, int>)@this->LpVtbl[24])(@this, namePtr, nameCount);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextValue(this ComPtr<ID2D1SvgElement> thisVtbl, char* name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[25])(@this, name, nameCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTextValue(this ComPtr<ID2D1SvgElement> thisVtbl, ref char name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[25])(@this, namePtr, nameCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTextValue(this ComPtr<ID2D1SvgElement> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, uint, int>)@this->LpVtbl[25])(@this, namePtr, nameCount);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetTextValueLength(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, name, type, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* valuePtr = &value)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, name, type, valuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, int>)@this->LpVtbl[29])(@this, name, type, valuePtr);
        SilkMarshal.Free((nint)valuePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, namePtr, type, value);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            fixed (char* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, namePtr, type, valuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, int>)@this->LpVtbl[29])(@this, namePtr, type, valuePtr);
        SilkMarshal.Free((nint)valuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, namePtr, type, value);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (char* valuePtr = &value)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, namePtr, type, valuePtr);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, byte*, int>)@this->LpVtbl[29])(@this, namePtr, type, valuePtr);
        SilkMarshal.Free((nint)valuePtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, char* value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, name, type, value, valueCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, ref char value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* valuePtr = &value)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, name, type, valuePtr, valueCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, uint, int>)@this->LpVtbl[32])(@this, name, type, valuePtr, valueCount);
        SilkMarshal.Free((nint)valuePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, char* value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, value, valueCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, ref char value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            fixed (char* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, valuePtr, valueCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, valuePtr, valueCount);
        SilkMarshal.Free((nint)valuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, char* value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, value, valueCount);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, ref char value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (char* valuePtr = &value)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, valuePtr, valueCount);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, byte*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, valuePtr, valueCount);
        SilkMarshal.Free((nint)valuePtr);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, uint* valueLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, name, type, valueLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, ref uint valueLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* valueLengthPtr = &valueLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, name, type, valueLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, uint* valueLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, namePtr, type, valueLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, ref uint valueLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* namePtr = &name)
        {
            fixed (uint* valueLengthPtr = &valueLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, namePtr, type, valueLengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, uint* valueLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, namePtr, type, valueLength);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, ref uint valueLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (uint* valueLengthPtr = &valueLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, namePtr, type, valueLengthPtr);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgElement> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgElement> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetDocument<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ref ComPtr<TI0> document) where TI0 : unmanaged, IComVtbl<ID2D1SvgDocument>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetDocument((ID2D1SvgDocument**) document.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetTagName(this ComPtr<ID2D1SvgElement> thisVtbl, Span<char> name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTagName(ref name.GetPinnableReference(), nameCount);
    }

    /// <summary>To be documented.</summary>
    public static void GetParent<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ref ComPtr<TI0> parent) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetParent((ID2D1SvgElement**) parent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetFirstChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ref ComPtr<TI0> child) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFirstChild((ID2D1SvgElement**) child.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetLastChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ref ComPtr<TI0> child) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetLastChild((ID2D1SvgElement**) child.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetPreviousChild<TI0, TI1>(this ComPtr<ID2D1SvgElement> thisVtbl, ComPtr<TI0> referenceChild, ref ComPtr<TI1> previousChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPreviousChild((ID2D1SvgElement*) referenceChild.Handle, (ID2D1SvgElement**) previousChild.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreviousChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ComPtr<TI0> referenceChild, ref ID2D1SvgElement* previousChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPreviousChild((ID2D1SvgElement*) referenceChild.Handle, ref previousChild);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreviousChild(this ComPtr<ID2D1SvgElement> thisVtbl, Span<ID2D1SvgElement> referenceChild, ID2D1SvgElement** previousChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPreviousChild(ref referenceChild.GetPinnableReference(), previousChild);
    }

    /// <summary>To be documented.</summary>
    public static int GetPreviousChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement referenceChild, ref ComPtr<TI0> previousChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPreviousChild(ref referenceChild, (ID2D1SvgElement**) previousChild.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreviousChild(this ComPtr<ID2D1SvgElement> thisVtbl, Span<ID2D1SvgElement> referenceChild, ref ID2D1SvgElement* previousChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPreviousChild(ref referenceChild.GetPinnableReference(), ref previousChild);
    }

    /// <summary>To be documented.</summary>
    public static int GetNextChild<TI0, TI1>(this ComPtr<ID2D1SvgElement> thisVtbl, ComPtr<TI0> referenceChild, ref ComPtr<TI1> nextChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetNextChild((ID2D1SvgElement*) referenceChild.Handle, (ID2D1SvgElement**) nextChild.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNextChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ComPtr<TI0> referenceChild, ref ID2D1SvgElement* nextChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetNextChild((ID2D1SvgElement*) referenceChild.Handle, ref nextChild);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNextChild(this ComPtr<ID2D1SvgElement> thisVtbl, Span<ID2D1SvgElement> referenceChild, ID2D1SvgElement** nextChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNextChild(ref referenceChild.GetPinnableReference(), nextChild);
    }

    /// <summary>To be documented.</summary>
    public static int GetNextChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement referenceChild, ref ComPtr<TI0> nextChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetNextChild(ref referenceChild, (ID2D1SvgElement**) nextChild.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNextChild(this ComPtr<ID2D1SvgElement> thisVtbl, Span<ID2D1SvgElement> referenceChild, ref ID2D1SvgElement* nextChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNextChild(ref referenceChild.GetPinnableReference(), ref nextChild);
    }

    /// <summary>To be documented.</summary>
    public static int InsertChildBefore<TI0, TI1>(this ComPtr<ID2D1SvgElement> thisVtbl, ComPtr<TI0> newChild, ComPtr<TI1> referenceChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InsertChildBefore((ID2D1SvgElement*) newChild.Handle, (ID2D1SvgElement*) referenceChild.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InsertChildBefore(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* newChild, Span<ID2D1SvgElement> referenceChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InsertChildBefore(newChild, ref referenceChild.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int InsertChildBefore<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ComPtr<TI0> newChild, ref ID2D1SvgElement referenceChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InsertChildBefore((ID2D1SvgElement*) newChild.Handle, ref referenceChild);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InsertChildBefore(this ComPtr<ID2D1SvgElement> thisVtbl, Span<ID2D1SvgElement> newChild, ID2D1SvgElement* referenceChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InsertChildBefore(ref newChild.GetPinnableReference(), referenceChild);
    }

    /// <summary>To be documented.</summary>
    public static int InsertChildBefore<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement newChild, ComPtr<TI0> referenceChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InsertChildBefore(ref newChild, (ID2D1SvgElement*) referenceChild.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int InsertChildBefore(this ComPtr<ID2D1SvgElement> thisVtbl, Span<ID2D1SvgElement> newChild, Span<ID2D1SvgElement> referenceChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InsertChildBefore(ref newChild.GetPinnableReference(), ref referenceChild.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AppendChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ComPtr<TI0> newChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AppendChild((ID2D1SvgElement*) newChild.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AppendChild(this ComPtr<ID2D1SvgElement> thisVtbl, Span<ID2D1SvgElement> newChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AppendChild(ref newChild.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ReplaceChild<TI0, TI1>(this ComPtr<ID2D1SvgElement> thisVtbl, ComPtr<TI0> newChild, ComPtr<TI1> oldChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ReplaceChild((ID2D1SvgElement*) newChild.Handle, (ID2D1SvgElement*) oldChild.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReplaceChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* newChild, Span<ID2D1SvgElement> oldChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReplaceChild(newChild, ref oldChild.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ReplaceChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ComPtr<TI0> newChild, ref ID2D1SvgElement oldChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ReplaceChild((ID2D1SvgElement*) newChild.Handle, ref oldChild);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReplaceChild(this ComPtr<ID2D1SvgElement> thisVtbl, Span<ID2D1SvgElement> newChild, ID2D1SvgElement* oldChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReplaceChild(ref newChild.GetPinnableReference(), oldChild);
    }

    /// <summary>To be documented.</summary>
    public static int ReplaceChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ref ID2D1SvgElement newChild, ComPtr<TI0> oldChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ReplaceChild(ref newChild, (ID2D1SvgElement*) oldChild.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int ReplaceChild(this ComPtr<ID2D1SvgElement> thisVtbl, Span<ID2D1SvgElement> newChild, Span<ID2D1SvgElement> oldChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReplaceChild(ref newChild.GetPinnableReference(), ref oldChild.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RemoveChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, ComPtr<TI0> oldChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RemoveChild((ID2D1SvgElement*) oldChild.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveChild(this ComPtr<ID2D1SvgElement> thisVtbl, Span<ID2D1SvgElement> oldChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveChild(ref oldChild.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* tagName, ref ComPtr<TI0> newChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateChild(tagName, (ID2D1SvgElement**) newChild.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateChild(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> tagName, ID2D1SvgElement** newChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateChild(in tagName.GetPinnableReference(), newChild);
    }

    /// <summary>To be documented.</summary>
    public static int CreateChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char tagName, ref ComPtr<TI0> newChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateChild(in tagName, (ID2D1SvgElement**) newChild.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateChild(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> tagName, ref ID2D1SvgElement* newChild)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateChild(in tagName.GetPinnableReference(), ref newChild);
    }

    /// <summary>To be documented.</summary>
    public static int CreateChild<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tagName, ref ComPtr<TI0> newChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateChild(tagName, (ID2D1SvgElement**) newChild.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, Span<int> inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsAttributeSpecified(name, ref inherited.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, int* inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsAttributeSpecified(in name.GetPinnableReference(), inherited);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, Span<int> inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsAttributeSpecified(in name.GetPinnableReference(), ref inherited.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Span<int> inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsAttributeSpecified(name, ref inherited.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, char* name, uint nameCount, Span<int> inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecifiedAttributeName(index, name, nameCount, ref inherited.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, Span<char> name, uint nameCount, int* inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecifiedAttributeName(index, ref name.GetPinnableReference(), nameCount, inherited);
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, Span<char> name, uint nameCount, Span<int> inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecifiedAttributeName(index, ref name.GetPinnableReference(), nameCount, ref inherited.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount, Span<int> inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecifiedAttributeName(index, name, nameCount, ref inherited.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeNameLength(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, uint* nameLength, Span<int> inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecifiedAttributeNameLength(index, nameLength, ref inherited.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeNameLength(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, Span<uint> nameLength, int* inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecifiedAttributeNameLength(index, ref nameLength.GetPinnableReference(), inherited);
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecifiedAttributeNameLength(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, Span<uint> nameLength, Span<int> inherited)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecifiedAttributeNameLength(index, ref nameLength.GetPinnableReference(), ref inherited.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RemoveAttribute(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveAttribute(in name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetTextValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTextValue(in name.GetPinnableReference(), nameCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetTextValue(this ComPtr<ID2D1SvgElement> thisVtbl, Span<char> name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextValue(ref name.GetPinnableReference(), nameCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetAttributeValue(name, type, in value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetAttributeValue(in name.GetPinnableReference(), type, value);
    }

    /// <summary>To be documented.</summary>
    public static int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetAttributeValue(in name.GetPinnableReference(), type, in value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetAttributeValue(in name.GetPinnableReference(), type, value);
    }

    /// <summary>To be documented.</summary>
    public static int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetAttributeValue(name, type, in value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, Span<char> value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAttributeValue(name, type, ref value.GetPinnableReference(), valueCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, SvgAttributeStringType type, char* value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAttributeValue(in name.GetPinnableReference(), type, value, valueCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, SvgAttributeStringType type, Span<char> value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAttributeValue(in name.GetPinnableReference(), type, ref value.GetPinnableReference(), valueCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAttributeValue(in name.GetPinnableReference(), type, value, valueCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, Span<char> value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAttributeValue(name, type, ref value.GetPinnableReference(), valueCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, Span<uint> valueLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAttributeValueLength(name, type, ref valueLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, SvgAttributeStringType type, uint* valueLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAttributeValueLength(in name.GetPinnableReference(), type, valueLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> name, SvgAttributeStringType type, Span<uint> valueLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAttributeValueLength(in name.GetPinnableReference(), type, ref valueLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, Span<uint> valueLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAttributeValueLength(name, type, ref valueLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1SvgElement> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
