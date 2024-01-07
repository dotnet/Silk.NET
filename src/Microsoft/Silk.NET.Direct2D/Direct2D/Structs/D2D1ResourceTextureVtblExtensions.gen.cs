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

public unsafe static class D2D1ResourceTextureVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ResourceTexture> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ResourceTexture> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ResourceTexture> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ResourceTexture> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1ResourceTexture> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1ResourceTexture> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, strides, dimensions, data, dataCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, strides, dimensions, dataPtr, dataCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, strides, dimensions, dataPtr, dataCount);
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* stridesPtr = &strides)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, stridesPtr, dimensions, data, dataCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* stridesPtr = &strides)
        {
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, stridesPtr, dimensions, dataPtr, dataCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* stridesPtr = &strides)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, stridesPtr, dimensions, dataPtr, dataCount);
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* maximimumExtentsPtr = &maximimumExtents)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, strides, dimensions, data, dataCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* maximimumExtentsPtr = &maximimumExtents)
        {
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, strides, dimensions, dataPtr, dataCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* maximimumExtentsPtr = &maximimumExtents)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, strides, dimensions, dataPtr, dataCount);
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* maximimumExtentsPtr = &maximimumExtents)
        {
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, stridesPtr, dimensions, data, dataCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* maximimumExtentsPtr = &maximimumExtents)
        {
            fixed (uint* stridesPtr = &strides)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, stridesPtr, dimensions, dataPtr, dataCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* maximimumExtentsPtr = &maximimumExtents)
        {
            fixed (uint* stridesPtr = &strides)
            {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, stridesPtr, dimensions, dataPtr, dataCount);
        SilkMarshal.Free((nint)dataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, strides, dimensions, data, dataCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, strides, dimensions, dataPtr, dataCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, strides, dimensions, dataPtr, dataCount);
        SilkMarshal.Free((nint)dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, stridesPtr, dimensions, data, dataCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            fixed (uint* stridesPtr = &strides)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, stridesPtr, dimensions, dataPtr, dataCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            fixed (uint* stridesPtr = &strides)
            {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, stridesPtr, dimensions, dataPtr, dataCount);
        SilkMarshal.Free((nint)dataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, strides, dimensions, data, dataCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, strides, dimensions, dataPtr, dataCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, strides, dimensions, dataPtr, dataCount);
        SilkMarshal.Free((nint)dataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, stridesPtr, dimensions, data, dataCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (byte* dataPtr = &data)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, stridesPtr, dimensions, dataPtr, dataCount);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* minimumExtentsPtr = &minimumExtents)
        {
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
                fixed (uint* stridesPtr = &strides)
                {
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, stridesPtr, dimensions, dataPtr, dataCount);
        SilkMarshal.Free((nint)dataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1ResourceTexture> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ResourceTexture> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ResourceTexture> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(minimumExtents, maximimumExtents, strides, dimensions, in data.GetPinnableReference(), dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(minimumExtents, maximimumExtents, in strides.GetPinnableReference(), dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(minimumExtents, maximimumExtents, in strides.GetPinnableReference(), dimensions, in data.GetPinnableReference(), dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(minimumExtents, maximimumExtents, in strides.GetPinnableReference(), dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(minimumExtents, in maximimumExtents.GetPinnableReference(), strides, dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(minimumExtents, in maximimumExtents.GetPinnableReference(), strides, dimensions, in data.GetPinnableReference(), dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(minimumExtents, in maximimumExtents.GetPinnableReference(), strides, dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(minimumExtents, in maximimumExtents.GetPinnableReference(), in strides.GetPinnableReference(), dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(minimumExtents, in maximimumExtents.GetPinnableReference(), in strides.GetPinnableReference(), dimensions, in data.GetPinnableReference(), dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(minimumExtents, in maximimumExtents.GetPinnableReference(), in strides.GetPinnableReference(), dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), maximimumExtents, strides, dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), maximimumExtents, strides, dimensions, in data.GetPinnableReference(), dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), maximimumExtents, strides, dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), maximimumExtents, in strides.GetPinnableReference(), dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), maximimumExtents, in strides.GetPinnableReference(), dimensions, in data.GetPinnableReference(), dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), maximimumExtents, in strides.GetPinnableReference(), dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), in maximimumExtents.GetPinnableReference(), strides, dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), in maximimumExtents.GetPinnableReference(), strides, dimensions, in data.GetPinnableReference(), dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), in maximimumExtents.GetPinnableReference(), strides, dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), in maximimumExtents.GetPinnableReference(), in strides.GetPinnableReference(), dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), in maximimumExtents.GetPinnableReference(), in strides.GetPinnableReference(), dimensions, in data.GetPinnableReference(), dataCount);
    }

    /// <summary>To be documented.</summary>
    public static int Update(this ComPtr<ID2D1ResourceTexture> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in minimumExtents.GetPinnableReference(), in maximimumExtents.GetPinnableReference(), in strides.GetPinnableReference(), dimensions, data, dataCount);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1ResourceTexture> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
