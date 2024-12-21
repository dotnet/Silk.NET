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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcLibraryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLibrary> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLibrary> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLibrary> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLibrary> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcLibrary> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcLibrary> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetMalloc(this ComPtr<IDxcLibrary> thisVtbl, IMalloc* pMalloc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IMalloc*, int>)@this->LpVtbl[3])(@this, pMalloc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMalloc(this ComPtr<IDxcLibrary> thisVtbl, ref IMalloc pMalloc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMalloc* pMallocPtr = &pMalloc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IMalloc*, int>)@this->LpVtbl[3])(@this, pMallocPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[4])(@this, pBlob, offset, length, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[4])(@this, pBlob, offset, length, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, uint offset, uint length, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[4])(@this, pBlobPtr, offset, length, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[4])(@this, pBlobPtr, offset, length, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileName, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileName, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* codePagePtr = &codePage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* codePagePtr = &codePage)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (uint* codePagePtr = &codePage)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (uint* codePagePtr = &codePage)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (uint* codePagePtr = &codePage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (uint* codePagePtr = &codePage)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pText, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pText, size, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pText, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pText, size, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMalloc* pIMallocPtr = &pIMalloc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMalloc* pIMallocPtr = &pIMalloc)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncoding);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIncludeHandler(this ComPtr<IDxcLibrary> thisVtbl, IDxcIncludeHandler** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIncludeHandler(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcIncludeHandler* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcIncludeHandler** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, void** ppStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)@this->LpVtbl[10])(@this, pBlob, ppStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, ref void* ppStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppStreamPtr = &ppStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)@this->LpVtbl[10])(@this, pBlob, ppStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, void** ppStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)@this->LpVtbl[10])(@this, pBlobPtr, ppStream);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, ref void* ppStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (void** ppStreamPtr = &ppStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)@this->LpVtbl[10])(@this, pBlobPtr, ppStreamPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[11])(@this, pBlob, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[11])(@this, pBlob, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[11])(@this, pBlobPtr, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[11])(@this, pBlobPtr, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[12])(@this, pBlob, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[12])(@this, pBlob, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[12])(@this, pBlobPtr, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[12])(@this, pBlobPtr, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcLibrary> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLibrary> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLibrary> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetMalloc<TI0>(this ComPtr<IDxcLibrary> thisVtbl, ComPtr<TI0> pMalloc) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetMalloc((IMalloc*) pMalloc.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetMalloc(this ComPtr<IDxcLibrary> thisVtbl, Span<IMalloc> pMalloc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetMalloc(ref pMalloc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobFromBlob<TI0, TI1>(this ComPtr<IDxcLibrary> thisVtbl, ComPtr<TI0> pBlob, uint offset, uint length, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromBlob((IDxcBlob*) pBlob.Handle, offset, length, (IDxcBlob**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TI0>(this ComPtr<IDxcLibrary> thisVtbl, ComPtr<TI0> pBlob, uint offset, uint length, ref IDxcBlob* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromBlob((IDxcBlob*) pBlob.Handle, offset, length, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcLibrary> thisVtbl, Span<IDxcBlob> pBlob, uint offset, uint length, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromBlob(ref pBlob.GetPinnableReference(), offset, length, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobFromBlob<TI0>(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, uint offset, uint length, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromBlob(ref pBlob, offset, length, (IDxcBlob**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcLibrary> thisVtbl, Span<IDxcBlob> pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromBlob(ref pBlob.GetPinnableReference(), offset, length, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, uint* codePage, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromFile(pFileName, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, Span<uint> codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromFile(pFileName, ref codePage.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, ref uint codePage, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromFile(pFileName, ref codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, Span<uint> codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromFile(pFileName, ref codePage.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromFile(in pFileName.GetPinnableReference(), codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, uint* codePage, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromFile(in pFileName, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromFile(in pFileName.GetPinnableReference(), codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFileName, Span<uint> codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromFile(in pFileName.GetPinnableReference(), ref codePage.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobFromFile<TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, ref uint codePage, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromFile(in pFileName, ref codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFileName, Span<uint> codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromFile(in pFileName.GetPinnableReference(), ref codePage.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* codePage, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromFile(pFileName, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, Span<uint> codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromFile(pFileName, ref codePage.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobFromFile<TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint codePage, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromFile(pFileName, ref codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, Span<uint> codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromFile(pFileName, ref codePage.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, uint size, uint codePage, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobWithEncodingFromPinned(pText, size, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobWithEncodingFromPinned(in pText.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobWithEncodingFromPinned<T0, TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, uint size, uint codePage, ref ComPtr<TI0> pBlobEncoding) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobWithEncodingFromPinned(in pText, size, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobWithEncodingFromPinned(in pText.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, uint size, uint codePage, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobWithEncodingOnHeapCopy(pText, size, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnHeapCopy(in pText.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobWithEncodingOnHeapCopy<T0, TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, uint size, uint codePage, ref ComPtr<TI0> pBlobEncoding) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobWithEncodingOnHeapCopy(in pText, size, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnHeapCopy(in pText.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<TI0, TI1>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, ComPtr<TI0> pIMalloc, uint size, uint codePage, ref ComPtr<TI1> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobWithEncodingOnMalloc(pText, (IMalloc*) pIMalloc.Handle, size, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, ComPtr<TI0> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobWithEncodingOnMalloc(pText, (IMalloc*) pIMalloc.Handle, size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, Span<IMalloc> pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(pText, ref pIMalloc.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, ref IMalloc pIMalloc, uint size, uint codePage, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobWithEncodingOnMalloc(pText, ref pIMalloc, size, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, Span<IMalloc> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(pText, ref pIMalloc.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(in pText.GetPinnableReference(), pIMalloc, size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobWithEncodingOnMalloc<T0, TI0, TI1>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, ComPtr<TI0> pIMalloc, uint size, uint codePage, ref ComPtr<TI1> pBlobEncoding) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobWithEncodingOnMalloc(in pText, (IMalloc*) pIMalloc.Handle, size, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(in pText.GetPinnableReference(), pIMalloc, size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0, TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, ComPtr<TI0> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobWithEncodingOnMalloc(in pText, (IMalloc*) pIMalloc.Handle, size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pText, Span<IMalloc> pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(in pText.GetPinnableReference(), ref pIMalloc.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobWithEncodingOnMalloc<T0, TI0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, ref ComPtr<TI0> pBlobEncoding) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobWithEncodingOnMalloc(in pText, ref pIMalloc, size, codePage, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0>(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pText, Span<IMalloc> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(in pText.GetPinnableReference(), ref pIMalloc.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int CreateIncludeHandler<TI0>(this ComPtr<IDxcLibrary> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateIncludeHandler((IDxcIncludeHandler**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly<TI0>(this ComPtr<IDxcLibrary> thisVtbl, ComPtr<TI0> pBlob, void** ppStream) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStreamFromBlobReadOnly((IDxcBlob*) pBlob.Handle, ppStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly<TI0>(this ComPtr<IDxcLibrary> thisVtbl, ComPtr<TI0> pBlob, ref void* ppStream) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStreamFromBlobReadOnly((IDxcBlob*) pBlob.Handle, ref ppStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly(this ComPtr<IDxcLibrary> thisVtbl, Span<IDxcBlob> pBlob, void** ppStream)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStreamFromBlobReadOnly(ref pBlob.GetPinnableReference(), ppStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly(this ComPtr<IDxcLibrary> thisVtbl, Span<IDxcBlob> pBlob, ref void* ppStream)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStreamFromBlobReadOnly(ref pBlob.GetPinnableReference(), ref ppStream);
    }

    /// <summary>To be documented.</summary>
    public static int GetBlobAsUtf8<TI0, TI1>(this ComPtr<IDxcLibrary> thisVtbl, ComPtr<TI0> pBlob, ref ComPtr<TI1> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsUtf8((IDxcBlob*) pBlob.Handle, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TI0>(this ComPtr<IDxcLibrary> thisVtbl, ComPtr<TI0> pBlob, ref IDxcBlobEncoding* pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsUtf8((IDxcBlob*) pBlob.Handle, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcLibrary> thisVtbl, Span<IDxcBlob> pBlob, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBlobAsUtf8(ref pBlob.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int GetBlobAsUtf8<TI0>(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsUtf8(ref pBlob, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcLibrary> thisVtbl, Span<IDxcBlob> pBlob, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBlobAsUtf8(ref pBlob.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int GetBlobAsWide<TI0, TI1>(this ComPtr<IDxcLibrary> thisVtbl, ComPtr<TI0> pBlob, ref ComPtr<TI1> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsWide((IDxcBlob*) pBlob.Handle, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide<TI0>(this ComPtr<IDxcLibrary> thisVtbl, ComPtr<TI0> pBlob, ref IDxcBlobEncoding* pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsWide((IDxcBlob*) pBlob.Handle, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcLibrary> thisVtbl, Span<IDxcBlob> pBlob, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBlobAsWide(ref pBlob.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int GetBlobAsWide<TI0>(this ComPtr<IDxcLibrary> thisVtbl, ref IDxcBlob pBlob, ref ComPtr<TI0> pBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsWide(ref pBlob, (IDxcBlobEncoding**) pBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcLibrary> thisVtbl, Span<IDxcBlob> pBlob, ref IDxcBlobEncoding* pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBlobAsWide(ref pBlob.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcLibrary> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
