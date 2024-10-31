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

public unsafe static class DxcUtilsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcUtils> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcUtils> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcUtils> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcUtils> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcUtils> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcUtils> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pBlob, offset, length, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pBlob, offset, length, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, uint offset, uint length, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pBlobPtr, offset, length, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pBlobPtr, offset, length, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[4])(@this, pData, size, codePage, ppBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[4])(@this, pData, size, codePage, ppBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[4])(@this, pDataPtr, size, codePage, ppBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[4])(@this, pDataPtr, size, codePage, ppBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pData, pIMalloc, size, codePage, ppBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pData, pIMalloc, size, codePage, ppBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMalloc* pIMallocPtr = &pIMalloc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pData, pIMallocPtr, size, codePage, ppBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMalloc* pIMallocPtr = &pIMalloc)
        {
            fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pData, pIMallocPtr, size, codePage, ppBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pDataPtr, pIMalloc, size, codePage, ppBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pDataPtr, pIMalloc, size, codePage, ppBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pDataPtr, pIMallocPtr, size, codePage, ppBlobEncoding);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pDataPtr, pIMallocPtr, size, codePage, ppBlobEncodingPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pData, size, codePage, ppBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pData, size, codePage, ppBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pDataPtr, size, codePage, ppBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pDataPtr, size, codePage, ppBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, uint* pCodePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileName, pCodePage, ppBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, uint* pCodePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileName, pCodePage, ppBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, ref uint pCodePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCodePagePtr = &pCodePage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileName, pCodePagePtr, ppBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, ref uint pCodePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCodePagePtr = &pCodePage)
        {
            fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileName, pCodePagePtr, ppBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, uint* pCodePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePage, ppBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, uint* pCodePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePage, ppBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, ref uint pCodePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (uint* pCodePagePtr = &pCodePage)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, ppBlobEncoding);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, ref uint pCodePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (uint* pCodePagePtr = &pCodePage)
            {
                fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, ppBlobEncodingPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* pCodePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePage, ppBlobEncoding);
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* pCodePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePage, ppBlobEncodingPtr);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint pCodePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (uint* pCodePagePtr = &pCodePage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, ppBlobEncoding);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint pCodePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (uint* pCodePagePtr = &pCodePage)
        {
            fixed (IDxcBlobEncoding** ppBlobEncodingPtr = &ppBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, ppBlobEncodingPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, void** ppStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, void**, int>)@this->LpVtbl[8])(@this, pBlob, ppStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, ref void* ppStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppStreamPtr = &ppStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, void**, int>)@this->LpVtbl[8])(@this, pBlob, ppStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, void** ppStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, void**, int>)@this->LpVtbl[8])(@this, pBlobPtr, ppStream);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, ref void* ppStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (void** ppStreamPtr = &ppStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, void**, int>)@this->LpVtbl[8])(@this, pBlobPtr, ppStreamPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDefaultIncludeHandler(this ComPtr<IDxcUtils> thisVtbl, IDxcIncludeHandler** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDefaultIncludeHandler(this ComPtr<IDxcUtils> thisVtbl, ref IDxcIncludeHandler* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcIncludeHandler** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, IDxcBlobUtf8** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)@this->LpVtbl[10])(@this, pBlob, ppBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, ref IDxcBlobUtf8* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobUtf8** ppBlobEncodingPtr = &ppBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)@this->LpVtbl[10])(@this, pBlob, ppBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, IDxcBlobUtf8** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)@this->LpVtbl[10])(@this, pBlobPtr, ppBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, ref IDxcBlobUtf8* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlobUtf8** ppBlobEncodingPtr = &ppBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)@this->LpVtbl[10])(@this, pBlobPtr, ppBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, IDxcBlobWide** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobWide**, int>)@this->LpVtbl[11])(@this, pBlob, ppBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, ref IDxcBlobWide* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppBlobEncodingPtr = &ppBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobWide**, int>)@this->LpVtbl[11])(@this, pBlob, ppBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, IDxcBlobWide** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobWide**, int>)@this->LpVtbl[11])(@this, pBlobPtr, ppBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, ref IDxcBlobWide* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlobWide** ppBlobEncodingPtr = &ppBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobWide**, int>)@this->LpVtbl[11])(@this, pBlobPtr, ppBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShader, DxcPart, ppPartData, pPartSizeInBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pShader, uint DxcPart, void** ppPartData, ref uint pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShader, DxcPart, ppPartData, pPartSizeInBytesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pShader, uint DxcPart, ref void* ppPartData, uint* pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppPartDataPtr = &ppPartData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShader, DxcPart, ppPartDataPtr, pPartSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pShader, uint DxcPart, ref void* ppPartData, ref uint pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppPartDataPtr = &ppPartData)
        {
            fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShader, DxcPart, ppPartDataPtr, pPartSizeInBytesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Buffer* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartData, pPartSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pShader, uint DxcPart, void** ppPartData, ref uint pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Buffer* pShaderPtr = &pShader)
        {
            fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartData, pPartSizeInBytesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pShader, uint DxcPart, ref void* ppPartData, uint* pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Buffer* pShaderPtr = &pShader)
        {
            fixed (void** ppPartDataPtr = &ppPartData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartDataPtr, pPartSizeInBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pShader, uint DxcPart, ref void* ppPartData, ref uint pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Buffer* pShaderPtr = &pShader)
        {
            fixed (void** ppPartDataPtr = &ppPartData)
            {
                fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartDataPtr, pPartSizeInBytesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pData, Guid* iid, void** ppvReflection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pData, iid, ppvReflection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pData, Guid* iid, ref void* ppvReflection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvReflectionPtr = &ppvReflection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pData, iid, ppvReflectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pData, ref Guid iid, void** ppvReflection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pData, iidPtr, ppvReflection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pData, ref Guid iid, ref void* ppvReflection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** ppvReflectionPtr = &ppvReflection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pData, iidPtr, ppvReflectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pData, Guid* iid, void** ppvReflection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Buffer* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pDataPtr, iid, ppvReflection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pData, Guid* iid, ref void* ppvReflection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Buffer* pDataPtr = &pData)
        {
            fixed (void** ppvReflectionPtr = &ppvReflection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pDataPtr, iid, ppvReflectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pData, ref Guid iid, void** ppvReflection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Buffer* pDataPtr = &pData)
        {
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pDataPtr, iidPtr, ppvReflection);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pData, ref Guid iid, ref void* ppvReflection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Buffer* pDataPtr = &pData)
        {
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvReflectionPtr = &ppvReflection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pDataPtr, iidPtr, ppvReflectionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlob, ppHash, ppContainer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pPDBBlob, IDxcBlob** ppHash, ref IDxcBlob* ppContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppContainerPtr = &ppContainer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlob, ppHash, ppContainerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pPDBBlob, ref IDxcBlob* ppHash, IDxcBlob** ppContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppHashPtr = &ppHash)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlob, ppHashPtr, ppContainer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pPDBBlob, ref IDxcBlob* ppHash, ref IDxcBlob* ppContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppHashPtr = &ppHash)
        {
            fixed (IDxcBlob** ppContainerPtr = &ppContainer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlob, ppHashPtr, ppContainerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlobPtr, ppHash, ppContainer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pPDBBlob, IDxcBlob** ppHash, ref IDxcBlob* ppContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
        {
            fixed (IDxcBlob** ppContainerPtr = &ppContainer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlobPtr, ppHash, ppContainerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pPDBBlob, ref IDxcBlob* ppHash, IDxcBlob** ppContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
        {
            fixed (IDxcBlob** ppHashPtr = &ppHash)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlobPtr, ppHashPtr, ppContainer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pPDBBlob, ref IDxcBlob* ppHash, ref IDxcBlob* ppContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
        {
            fixed (IDxcBlob** ppHashPtr = &ppHash)
            {
                fixed (IDxcBlob** ppContainerPtr = &ppContainer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlobPtr, ppHashPtr, ppContainerPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcUtils> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcUtils> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcUtils> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobFromBlob<TI0, TI1>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pBlob, uint offset, uint length, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromBlob((IDxcBlob*) pBlob.Handle, offset, length, (IDxcBlob**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TI0>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pBlob, uint offset, uint length, ref IDxcBlob* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromBlob((IDxcBlob*) pBlob.Handle, offset, length, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pBlob, uint offset, uint length, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromBlob(ref pBlob.GetPinnableReference(), offset, length, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobFromBlob<TI0>(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, uint offset, uint length, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromBlob(ref pBlob, offset, length, (IDxcBlob**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromBlob(ref pBlob.GetPinnableReference(), offset, length, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint size, uint codePage, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromPinned(pData, size, codePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromPinned(in pData.GetPinnableReference(), size, codePage, ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlobFromPinned<T0, TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint size, uint codePage, ref ComPtr<TI0> ppBlobEncoding) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlobFromPinned(in pData, size, codePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlobFromPinned(in pData.GetPinnableReference(), size, codePage, ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<TI0, TI1>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, ComPtr<TI0> pIMalloc, uint size, uint codePage, ref ComPtr<TI1> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveToBlob(pData, (IMalloc*) pIMalloc.Handle, size, codePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, ComPtr<TI0> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveToBlob(pData, (IMalloc*) pIMalloc.Handle, size, codePage, ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, Span<IMalloc> pIMalloc, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveToBlob(pData, ref pIMalloc.GetPinnableReference(), size, codePage, ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, ref IMalloc pIMalloc, uint size, uint codePage, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveToBlob(pData, ref pIMalloc, size, codePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, Span<IMalloc> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveToBlob(pData, ref pIMalloc.GetPinnableReference(), size, codePage, ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveToBlob(in pData.GetPinnableReference(), pIMalloc, size, codePage, ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int MoveToBlob<T0, TI0, TI1>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, ComPtr<TI0> pIMalloc, uint size, uint codePage, ref ComPtr<TI1> ppBlobEncoding) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveToBlob(in pData, (IMalloc*) pIMalloc.Handle, size, codePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveToBlob(in pData.GetPinnableReference(), pIMalloc, size, codePage, ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0, TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, ComPtr<TI0> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveToBlob(in pData, (IMalloc*) pIMalloc.Handle, size, codePage, ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, Span<IMalloc> pIMalloc, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveToBlob(in pData.GetPinnableReference(), ref pIMalloc.GetPinnableReference(), size, codePage, ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int MoveToBlob<T0, TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, ref IMalloc pIMalloc, uint size, uint codePage, ref ComPtr<TI0> ppBlobEncoding) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MoveToBlob(in pData, ref pIMalloc, size, codePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, Span<IMalloc> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveToBlob(in pData.GetPinnableReference(), ref pIMalloc.GetPinnableReference(), size, codePage, ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint size, uint codePage, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlob(pData, size, codePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint size, uint codePage, IDxcBlobEncoding** ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlob(in pData.GetPinnableReference(), size, codePage, ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBlob<T0, TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint size, uint codePage, ref ComPtr<TI0> ppBlobEncoding) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBlob(in pData, size, codePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<T0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint size, uint codePage, ref IDxcBlobEncoding* ppBlobEncoding) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBlob(in pData.GetPinnableReference(), size, codePage, ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, uint* pCodePage, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadFile(pFileName, pCodePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, Span<uint> pCodePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(pFileName, ref pCodePage.GetPinnableReference(), ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, ref uint pCodePage, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadFile(pFileName, ref pCodePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, Span<uint> pCodePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(pFileName, ref pCodePage.GetPinnableReference(), ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFileName, uint* pCodePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(in pFileName.GetPinnableReference(), pCodePage, ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, uint* pCodePage, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadFile(in pFileName, pCodePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFileName, uint* pCodePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(in pFileName.GetPinnableReference(), pCodePage, ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFileName, Span<uint> pCodePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(in pFileName.GetPinnableReference(), ref pCodePage.GetPinnableReference(), ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int LoadFile<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFileName, ref uint pCodePage, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadFile(in pFileName, ref pCodePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFileName, Span<uint> pCodePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(in pFileName.GetPinnableReference(), ref pCodePage.GetPinnableReference(), ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* pCodePage, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadFile(pFileName, pCodePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, Span<uint> pCodePage, IDxcBlobEncoding** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(pFileName, ref pCodePage.GetPinnableReference(), ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int LoadFile<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint pCodePage, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadFile(pFileName, ref pCodePage, (IDxcBlobEncoding**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, Span<uint> pCodePage, ref IDxcBlobEncoding* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadFile(pFileName, ref pCodePage.GetPinnableReference(), ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob<TI0>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pBlob, void** ppStream) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateReadOnlyStreamFromBlob((IDxcBlob*) pBlob.Handle, ppStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob<TI0>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pBlob, ref void* ppStream) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateReadOnlyStreamFromBlob((IDxcBlob*) pBlob.Handle, ref ppStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pBlob, void** ppStream)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReadOnlyStreamFromBlob(ref pBlob.GetPinnableReference(), ppStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pBlob, ref void* ppStream)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReadOnlyStreamFromBlob(ref pBlob.GetPinnableReference(), ref ppStream);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDefaultIncludeHandler<TI0>(this ComPtr<IDxcUtils> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDefaultIncludeHandler((IDxcIncludeHandler**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetBlobAsUtf8<TI0, TI1>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pBlob, ref ComPtr<TI1> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobUtf8>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsUtf8((IDxcBlob*) pBlob.Handle, (IDxcBlobUtf8**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TI0>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pBlob, ref IDxcBlobUtf8* ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsUtf8((IDxcBlob*) pBlob.Handle, ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pBlob, IDxcBlobUtf8** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBlobAsUtf8(ref pBlob.GetPinnableReference(), ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int GetBlobAsUtf8<TI0>(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf8>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsUtf8(ref pBlob, (IDxcBlobUtf8**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pBlob, ref IDxcBlobUtf8* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBlobAsUtf8(ref pBlob.GetPinnableReference(), ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int GetBlobAsWide<TI0, TI1>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pBlob, ref ComPtr<TI1> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsWide((IDxcBlob*) pBlob.Handle, (IDxcBlobWide**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide<TI0>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pBlob, ref IDxcBlobWide* ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsWide((IDxcBlob*) pBlob.Handle, ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pBlob, IDxcBlobWide** ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBlobAsWide(ref pBlob.GetPinnableReference(), ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static int GetBlobAsWide<TI0>(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pBlob, ref ComPtr<TI0> ppBlobEncoding) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBlobAsWide(ref pBlob, (IDxcBlobWide**) ppBlobEncoding.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsWide(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pBlob, ref IDxcBlobWide* ppBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBlobAsWide(ref pBlob.GetPinnableReference(), ref ppBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pShader, uint DxcPart, void** ppPartData, Span<uint> pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDxilContainerPart(pShader, DxcPart, ppPartData, ref pPartSizeInBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pShader, uint DxcPart, ref void* ppPartData, Span<uint> pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDxilContainerPart(pShader, DxcPart, ref ppPartData, ref pPartSizeInBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDxilContainerPart(in pShader.GetPinnableReference(), DxcPart, ppPartData, pPartSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pShader, uint DxcPart, void** ppPartData, Span<uint> pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDxilContainerPart(in pShader.GetPinnableReference(), DxcPart, ppPartData, ref pPartSizeInBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pShader, uint DxcPart, ref void* ppPartData, uint* pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDxilContainerPart(in pShader.GetPinnableReference(), DxcPart, ref ppPartData, pPartSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pShader, uint DxcPart, ref void* ppPartData, Span<uint> pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDxilContainerPart(in pShader.GetPinnableReference(), DxcPart, ref ppPartData, ref pPartSizeInBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pData, out ComPtr<TI0> ppvReflection) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvReflection = default;
        return @this->CreateReflection(pData, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvReflection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pData, Span<Guid> iid, void** ppvReflection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReflection(pData, ref iid.GetPinnableReference(), ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pData, Span<Guid> iid, ref void* ppvReflection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReflection(pData, ref iid.GetPinnableReference(), ref ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pData, Guid* iid, void** ppvReflection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReflection(in pData.GetPinnableReference(), iid, ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static int CreateReflection<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pData, out ComPtr<TI0> ppvReflection) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvReflection = default;
        return @this->CreateReflection(in pData, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvReflection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pData, Guid* iid, ref void* ppvReflection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReflection(in pData.GetPinnableReference(), iid, ref ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pData, Span<Guid> iid, void** ppvReflection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReflection(in pData.GetPinnableReference(), ref iid.GetPinnableReference(), ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pData, Span<Guid> iid, ref void* ppvReflection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReflection(in pData.GetPinnableReference(), ref iid.GetPinnableReference(), ref ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(in pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, in pEntryPoint.GetPinnableReference(), pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, in pTargetProfile.GetPinnableReference(), in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Define pDefines, uint defineCount, ref ComPtr<TI0> ppArgs) where TI0 : unmanaged, IComVtbl<IDxcCompilerArgs>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcCompilerArgs**) ppArgs.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static int GetPDBContents<TI0, TI1, TI2>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pPDBBlob, ref ComPtr<TI1> ppHash, ref ComPtr<TI2> ppContainer) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPDBContents((IDxcBlob*) pPDBBlob.Handle, (IDxcBlob**) ppHash.GetAddressOf(), (IDxcBlob**) ppContainer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TI0, TI1>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pPDBBlob, ref ComPtr<TI1> ppHash, ref IDxcBlob* ppContainer) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPDBContents((IDxcBlob*) pPDBBlob.Handle, (IDxcBlob**) ppHash.GetAddressOf(), ref ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TI0, TI1>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pPDBBlob, ref IDxcBlob* ppHash, ref ComPtr<TI1> ppContainer) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPDBContents((IDxcBlob*) pPDBBlob.Handle, ref ppHash, (IDxcBlob**) ppContainer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TI0>(this ComPtr<IDxcUtils> thisVtbl, ComPtr<TI0> pPDBBlob, ref IDxcBlob* ppHash, ref IDxcBlob* ppContainer) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPDBContents((IDxcBlob*) pPDBBlob.Handle, ref ppHash, ref ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPDBContents(ref pPDBBlob.GetPinnableReference(), ppHash, ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static int GetPDBContents<TI0, TI1>(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pPDBBlob, ref ComPtr<TI0> ppHash, ref ComPtr<TI1> ppContainer) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPDBContents(ref pPDBBlob, (IDxcBlob**) ppHash.GetAddressOf(), (IDxcBlob**) ppContainer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pPDBBlob, IDxcBlob** ppHash, ref IDxcBlob* ppContainer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPDBContents(ref pPDBBlob.GetPinnableReference(), ppHash, ref ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TI0>(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pPDBBlob, ref ComPtr<TI0> ppHash, ref IDxcBlob* ppContainer) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPDBContents(ref pPDBBlob, (IDxcBlob**) ppHash.GetAddressOf(), ref ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pPDBBlob, ref IDxcBlob* ppHash, IDxcBlob** ppContainer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPDBContents(ref pPDBBlob.GetPinnableReference(), ref ppHash, ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TI0>(this ComPtr<IDxcUtils> thisVtbl, ref IDxcBlob pPDBBlob, ref IDxcBlob* ppHash, ref ComPtr<TI0> ppContainer) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPDBContents(ref pPDBBlob, ref ppHash, (IDxcBlob**) ppContainer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, Span<IDxcBlob> pPDBBlob, ref IDxcBlob* ppHash, ref IDxcBlob* ppContainer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPDBContents(ref pPDBBlob.GetPinnableReference(), ref ppHash, ref ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcUtils> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReflection<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pData) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReflection(pData, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateReflection<TI0>(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pData) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReflection(in pData, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
