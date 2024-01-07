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

public unsafe static class D2D1DrawInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawInfo> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawInfo> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawInfo> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1DrawInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1DrawInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetInputDescription(this ComPtr<ID2D1DrawInfo> thisVtbl, uint inputIndex, InputDescription inputDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint, InputDescription, int>)@this->LpVtbl[3])(@this, inputIndex, inputDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputBuffer(this ComPtr<ID2D1DrawInfo> thisVtbl, BufferPrecision bufferPrecision, ChannelDepth channelDepth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, BufferPrecision, ChannelDepth, int>)@this->LpVtbl[4])(@this, bufferPrecision, channelDepth);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetCached(this ComPtr<ID2D1DrawInfo> thisVtbl, Silk.NET.Core.Bool32 isCached)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[5])(@this, isCached);
    }

    /// <summary>To be documented.</summary>
    public static void SetInstructionCountHint(this ComPtr<ID2D1DrawInfo> thisVtbl, uint instructionCount)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint, void>)@this->LpVtbl[6])(@this, instructionCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPixelShaderConstantBuffer(this ComPtr<ID2D1DrawInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buffer, uint bufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[7])(@this, buffer, bufferCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantBuffer(this ComPtr<ID2D1DrawInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte buffer, uint bufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* bufferPtr = &buffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[7])(@this, bufferPtr, bufferCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantBuffer(this ComPtr<ID2D1DrawInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer, uint bufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bufferPtr = (byte*) SilkMarshal.StringToPtr(buffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[7])(@this, bufferPtr, bufferCount);
        SilkMarshal.Free((nint)bufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResourceTexture(this ComPtr<ID2D1DrawInfo> thisVtbl, uint textureIndex, ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint, ID2D1ResourceTexture*, int>)@this->LpVtbl[8])(@this, textureIndex, resourceTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetResourceTexture(this ComPtr<ID2D1DrawInfo> thisVtbl, uint textureIndex, ref ID2D1ResourceTexture resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ResourceTexture* resourceTexturePtr = &resourceTexture)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint, ID2D1ResourceTexture*, int>)@this->LpVtbl[8])(@this, textureIndex, resourceTexturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexShaderConstantBuffer(this ComPtr<ID2D1DrawInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buffer, uint bufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[9])(@this, buffer, bufferCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantBuffer(this ComPtr<ID2D1DrawInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte buffer, uint bufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* bufferPtr = &buffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[9])(@this, bufferPtr, bufferCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantBuffer(this ComPtr<ID2D1DrawInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer, uint bufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bufferPtr = (byte*) SilkMarshal.StringToPtr(buffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[9])(@this, bufferPtr, bufferCount);
        SilkMarshal.Free((nint)bufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPixelShader(this ComPtr<ID2D1DrawInfo> thisVtbl, Guid* shaderId, PixelOptions pixelOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, PixelOptions, int>)@this->LpVtbl[10])(@this, shaderId, pixelOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShader(this ComPtr<ID2D1DrawInfo> thisVtbl, ref Guid shaderId, PixelOptions pixelOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* shaderIdPtr = &shaderId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, PixelOptions, int>)@this->LpVtbl[10])(@this, shaderIdPtr, pixelOptions);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescription, vertexRange, vertexShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* vertexShaderPtr = &vertexShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescription, vertexRange, vertexShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VertexRange* vertexRangePtr = &vertexRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescription, vertexRangePtr, vertexShader);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VertexRange* vertexRangePtr = &vertexRange)
        {
            fixed (Guid* vertexShaderPtr = &vertexShader)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescription, vertexRangePtr, vertexShaderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescriptionPtr, vertexRange, vertexShader);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
        {
            fixed (Guid* vertexShaderPtr = &vertexShader)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescriptionPtr, vertexRange, vertexShaderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
        {
            fixed (VertexRange* vertexRangePtr = &vertexRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescriptionPtr, vertexRangePtr, vertexShader);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
        {
            fixed (VertexRange* vertexRangePtr = &vertexRange)
            {
                fixed (Guid* vertexShaderPtr = &vertexShader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescriptionPtr, vertexRangePtr, vertexShaderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescription, vertexRange, vertexShader);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
        {
            fixed (Guid* vertexShaderPtr = &vertexShader)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescription, vertexRange, vertexShaderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
        {
            fixed (VertexRange* vertexRangePtr = &vertexRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescription, vertexRangePtr, vertexShader);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
        {
            fixed (VertexRange* vertexRangePtr = &vertexRange)
            {
                fixed (Guid* vertexShaderPtr = &vertexShader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescription, vertexRangePtr, vertexShaderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
        {
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescriptionPtr, vertexRange, vertexShader);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
        {
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                fixed (Guid* vertexShaderPtr = &vertexShader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescriptionPtr, vertexRange, vertexShaderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
        {
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                fixed (VertexRange* vertexRangePtr = &vertexRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescriptionPtr, vertexRangePtr, vertexShader);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
        {
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                fixed (VertexRange* vertexRangePtr = &vertexRange)
                {
                    fixed (Guid* vertexShaderPtr = &vertexShader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescriptionPtr, vertexRangePtr, vertexShaderPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantBuffer(this ComPtr<ID2D1DrawInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buffer, uint bufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPixelShaderConstantBuffer(in buffer.GetPinnableReference(), bufferCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetResourceTexture<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl, uint textureIndex, ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetResourceTexture(textureIndex, (ID2D1ResourceTexture*) resourceTexture.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetResourceTexture(this ComPtr<ID2D1DrawInfo> thisVtbl, uint textureIndex, Span<ID2D1ResourceTexture> resourceTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetResourceTexture(textureIndex, ref resourceTexture.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantBuffer(this ComPtr<ID2D1DrawInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buffer, uint bufferCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexShaderConstantBuffer(in buffer.GetPinnableReference(), bufferCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShader(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<Guid> shaderId, PixelOptions pixelOptions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPixelShader(ref shaderId.GetPinnableReference(), pixelOptions);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl, ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, blendDescription, vertexRange, vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(vertexBuffer, vertexOptions, blendDescription, vertexRange, in vertexShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl, ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, blendDescription, vertexRange, in vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexRange> vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(vertexBuffer, vertexOptions, blendDescription, in vertexRange.GetPinnableReference(), vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl, ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, blendDescription, in vertexRange, vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexRange> vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(vertexBuffer, vertexOptions, blendDescription, in vertexRange.GetPinnableReference(), in vertexShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl, ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, blendDescription, in vertexRange, in vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlendDescription> blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(vertexBuffer, vertexOptions, in blendDescription.GetPinnableReference(), vertexRange, vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl, ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, in blendDescription, vertexRange, vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlendDescription> blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(vertexBuffer, vertexOptions, in blendDescription.GetPinnableReference(), vertexRange, in vertexShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl, ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, in blendDescription, vertexRange, in vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlendDescription> blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexRange> vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(vertexBuffer, vertexOptions, in blendDescription.GetPinnableReference(), in vertexRange.GetPinnableReference(), vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl, ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, in blendDescription, in vertexRange, vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlendDescription> blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexRange> vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(vertexBuffer, vertexOptions, in blendDescription.GetPinnableReference(), in vertexRange.GetPinnableReference(), in vertexShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexProcessing<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl, ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, in blendDescription, in vertexRange, in vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<ID2D1VertexBuffer> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(ref vertexBuffer.GetPinnableReference(), vertexOptions, blendDescription, vertexRange, vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<ID2D1VertexBuffer> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(ref vertexBuffer.GetPinnableReference(), vertexOptions, blendDescription, vertexRange, in vertexShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<ID2D1VertexBuffer> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexRange> vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(ref vertexBuffer.GetPinnableReference(), vertexOptions, blendDescription, in vertexRange.GetPinnableReference(), vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<ID2D1VertexBuffer> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexRange> vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(ref vertexBuffer.GetPinnableReference(), vertexOptions, blendDescription, in vertexRange.GetPinnableReference(), in vertexShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<ID2D1VertexBuffer> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlendDescription> blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(ref vertexBuffer.GetPinnableReference(), vertexOptions, in blendDescription.GetPinnableReference(), vertexRange, vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<ID2D1VertexBuffer> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlendDescription> blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(ref vertexBuffer.GetPinnableReference(), vertexOptions, in blendDescription.GetPinnableReference(), vertexRange, in vertexShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<ID2D1VertexBuffer> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlendDescription> blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexRange> vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(ref vertexBuffer.GetPinnableReference(), vertexOptions, in blendDescription.GetPinnableReference(), in vertexRange.GetPinnableReference(), vertexShader);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexProcessing(this ComPtr<ID2D1DrawInfo> thisVtbl, Span<ID2D1VertexBuffer> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlendDescription> blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexRange> vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> vertexShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexProcessing(ref vertexBuffer.GetPinnableReference(), vertexOptions, in blendDescription.GetPinnableReference(), in vertexRange.GetPinnableReference(), in vertexShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1DrawInfo> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
