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

public unsafe static class MFTimedTextVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedText> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedText> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedText> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedText> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedText> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedText> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterNotifications(this ComPtr<IMFTimedText> thisVtbl, IMFTimedTextNotify* notify)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextNotify*, int>)@this->LpVtbl[3])(@this, notify);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterNotifications(this ComPtr<IMFTimedText> thisVtbl, ref IMFTimedTextNotify notify)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextNotify* notifyPtr = &notify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextNotify*, int>)@this->LpVtbl[3])(@this, notifyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SelectTrack(this ComPtr<IMFTimedText> thisVtbl, uint trackId, Silk.NET.Core.Bool32 selected)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[4])(@this, trackId, selected);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, language, kind, isDefault, trackId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, language, kind, isDefault, trackIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* languagePtr = &language)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, languagePtr, kind, isDefault, trackId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* languagePtr = &language)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, languagePtr, kind, isDefault, trackIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, label, languagePtr, kind, isDefault, trackIdPtr);
        }
        SilkMarshal.Free((nint)languagePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, language, kind, isDefault, trackId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, language, kind, isDefault, trackIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackId);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
        SilkMarshal.Free((nint)languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, language, kind, isDefault, trackId);
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, language, kind, isDefault, trackIdPtr);
        }
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (char* languagePtr = &language)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackId);
        }
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (char* languagePtr = &language)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
        }
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStream, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
        }
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, language, kind, isDefault, trackId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, language, kind, isDefault, trackIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, languagePtr, kind, isDefault, trackId);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, label, languagePtr, kind, isDefault, trackIdPtr);
            }
        SilkMarshal.Free((nint)languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
            fixed (char* labelPtr = &label)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, language, kind, isDefault, trackId);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
            fixed (char* labelPtr = &label)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, language, kind, isDefault, trackIdPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackId);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
            fixed (char* labelPtr = &label)
            {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
            fixed (char* labelPtr = &label)
            {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
        SilkMarshal.Free((nint)languagePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, language, kind, isDefault, trackId);
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, language, kind, isDefault, trackIdPtr);
            }
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackId);
            }
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, ref IMFByteStream byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* byteStreamPtr = &byteStream)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[5])(@this, byteStreamPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, language, kind, isDefault, trackId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, language, kind, isDefault, trackIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* languagePtr = &language)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, languagePtr, kind, isDefault, trackId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* languagePtr = &language)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, languagePtr, kind, isDefault, trackIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, label, languagePtr, kind, isDefault, trackIdPtr);
        }
        SilkMarshal.Free((nint)languagePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, language, kind, isDefault, trackId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, language, kind, isDefault, trackIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackId);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
        SilkMarshal.Free((nint)languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, language, kind, isDefault, trackId);
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, language, kind, isDefault, trackIdPtr);
        }
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (char* languagePtr = &language)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackId);
        }
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (char* languagePtr = &language)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
        }
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, url, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
        }
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, language, kind, isDefault, trackId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, language, kind, isDefault, trackIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackId);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackIdPtr);
            }
        SilkMarshal.Free((nint)languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
            fixed (char* labelPtr = &label)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackId);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
            fixed (char* labelPtr = &label)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackIdPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
            fixed (char* labelPtr = &label)
            {
                fixed (char* languagePtr = &language)
                {
                    fixed (uint* trackIdPtr = &trackId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
            fixed (char* labelPtr = &label)
            {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
            fixed (char* labelPtr = &label)
            {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
        SilkMarshal.Free((nint)languagePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackId);
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackIdPtr);
            }
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
            }
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* urlPtr = &url)
        {
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, language, kind, isDefault, trackId);
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, language, kind, isDefault, trackIdPtr);
        }
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        fixed (char* languagePtr = &language)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackId);
        }
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        fixed (char* languagePtr = &language)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackIdPtr);
            }
        }
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, label, languagePtr, kind, isDefault, trackIdPtr);
        }
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        fixed (char* labelPtr = &label)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackId);
        }
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        fixed (char* labelPtr = &label)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackIdPtr);
            }
        }
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        fixed (char* labelPtr = &label)
        {
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
            }
        }
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        fixed (char* labelPtr = &label)
        {
            fixed (char* languagePtr = &language)
            {
                fixed (uint* trackIdPtr = &trackId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
                }
            }
        }
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        fixed (char* labelPtr = &label)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        }
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        fixed (char* labelPtr = &label)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
        SilkMarshal.Free((nint)languagePtr);
        }
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackId);
        SilkMarshal.Free((nint)labelPtr);
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, language, kind, isDefault, trackIdPtr);
        }
        SilkMarshal.Free((nint)labelPtr);
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (char* languagePtr = &language)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
        }
        SilkMarshal.Free((nint)labelPtr);
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (char* languagePtr = &language)
        {
            fixed (uint* trackIdPtr = &trackId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, char*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
            }
        }
        SilkMarshal.Free((nint)labelPtr);
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackId);
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, ref uint trackId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var urlPtr = (byte*) SilkMarshal.StringToPtr(url, NativeStringEncoding.LPWStr);
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        fixed (uint* trackIdPtr = &trackId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, byte*, TimedTextTrackKind, Silk.NET.Core.Bool32, uint*, int>)@this->LpVtbl[6])(@this, urlPtr, labelPtr, languagePtr, kind, isDefault, trackIdPtr);
        }
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        SilkMarshal.Free((nint)urlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, language, kind, track);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextTrack** trackPtr = &track)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, language, kind, trackPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* languagePtr = &language)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, languagePtr, kind, track);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* languagePtr = &language)
        {
            fixed (IMFTimedTextTrack** trackPtr = &track)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, languagePtr, kind, trackPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, languagePtr, kind, track);
        SilkMarshal.Free((nint)languagePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        fixed (IMFTimedTextTrack** trackPtr = &track)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, label, languagePtr, kind, trackPtr);
        }
        SilkMarshal.Free((nint)languagePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, language, kind, track);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            fixed (IMFTimedTextTrack** trackPtr = &track)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, language, kind, trackPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            fixed (char* languagePtr = &language)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, track);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            fixed (char* languagePtr = &language)
            {
                fixed (IMFTimedTextTrack** trackPtr = &track)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, trackPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, track);
        SilkMarshal.Free((nint)languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
            fixed (IMFTimedTextTrack** trackPtr = &track)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, char*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, trackPtr);
            }
        SilkMarshal.Free((nint)languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, language, kind, track);
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (IMFTimedTextTrack** trackPtr = &track)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, language, kind, trackPtr);
        }
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (char* languagePtr = &language)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, track);
        }
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        fixed (char* languagePtr = &language)
        {
            fixed (IMFTimedTextTrack** trackPtr = &track)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, char*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, trackPtr);
            }
        }
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, track);
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        var languagePtr = (byte*) SilkMarshal.StringToPtr(language, NativeStringEncoding.LPWStr);
        fixed (IMFTimedTextTrack** trackPtr = &track)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, byte*, byte*, TimedTextTrackKind, IMFTimedTextTrack**, int>)@this->LpVtbl[7])(@this, labelPtr, languagePtr, kind, trackPtr);
        }
        SilkMarshal.Free((nint)languagePtr);
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveTrack(this ComPtr<IMFTimedText> thisVtbl, IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrack*, int>)@this->LpVtbl[8])(@this, track);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveTrack(this ComPtr<IMFTimedText> thisVtbl, ref IMFTimedTextTrack track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextTrack* trackPtr = &track)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrack*, int>)@this->LpVtbl[8])(@this, trackPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueTimeOffset(this ComPtr<IMFTimedText> thisVtbl, double* offset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, double*, int>)@this->LpVtbl[9])(@this, offset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCueTimeOffset(this ComPtr<IMFTimedText> thisVtbl, ref double offset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* offsetPtr = &offset)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, double*, int>)@this->LpVtbl[9])(@this, offsetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCueTimeOffset(this ComPtr<IMFTimedText> thisVtbl, double offset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, double, int>)@this->LpVtbl[10])(@this, offset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTracks(this ComPtr<IMFTimedText> thisVtbl, IMFTimedTextTrackList** tracks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[11])(@this, tracks);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTracks(this ComPtr<IMFTimedText> thisVtbl, ref IMFTimedTextTrackList* tracks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextTrackList** tracksPtr = &tracks)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[11])(@this, tracksPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetActiveTracks(this ComPtr<IMFTimedText> thisVtbl, IMFTimedTextTrackList** activeTracks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[12])(@this, activeTracks);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetActiveTracks(this ComPtr<IMFTimedText> thisVtbl, ref IMFTimedTextTrackList* activeTracks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextTrackList** activeTracksPtr = &activeTracks)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[12])(@this, activeTracksPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextTracks(this ComPtr<IMFTimedText> thisVtbl, IMFTimedTextTrackList** textTracks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[13])(@this, textTracks);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextTracks(this ComPtr<IMFTimedText> thisVtbl, ref IMFTimedTextTrackList* textTracks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextTrackList** textTracksPtr = &textTracks)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[13])(@this, textTracksPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataTracks(this ComPtr<IMFTimedText> thisVtbl, IMFTimedTextTrackList** metadataTracks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[14])(@this, metadataTracks);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataTracks(this ComPtr<IMFTimedText> thisVtbl, ref IMFTimedTextTrackList* metadataTracks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextTrackList** metadataTracksPtr = &metadataTracks)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)@this->LpVtbl[14])(@this, metadataTracksPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetInBandEnabled(this ComPtr<IMFTimedText> thisVtbl, Silk.NET.Core.Bool32 enabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[15])(@this, enabled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsInBandEnabled(this ComPtr<IMFTimedText> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedText*, Silk.NET.Core.Bool32>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedText> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedText> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedText> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterNotifications<TI0>(this ComPtr<IMFTimedText> thisVtbl, ComPtr<TI0> notify) where TI0 : unmanaged, IComVtbl<IMFTimedTextNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterNotifications((IMFTimedTextNotify*) notify.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterNotifications(this ComPtr<IMFTimedText> thisVtbl, Span<IMFTimedTextNotify> notify)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterNotifications(ref notify.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, label, in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, label, in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, in label.GetPinnableReference(), language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, in label.GetPinnableReference(), language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, in label.GetPinnableReference(), in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, in label.GetPinnableReference(), in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, in label.GetPinnableReference(), language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, in label.GetPinnableReference(), language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, label, in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, label, in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, IMFByteStream* byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(byteStream, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), in label.GetPinnableReference(), language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), in label.GetPinnableReference(), language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), in label.GetPinnableReference(), in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), in label.GetPinnableReference(), in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), in label.GetPinnableReference(), language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), in label.GetPinnableReference(), language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSource(this ComPtr<IMFTimedText> thisVtbl, Span<IMFByteStream> byteStream, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSource(ref byteStream.GetPinnableReference(), label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), in label.GetPinnableReference(), language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), in label.GetPinnableReference(), language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), in label.GetPinnableReference(), in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), in label.GetPinnableReference(), in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), in label.GetPinnableReference(), language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), in label.GetPinnableReference(), language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(in url.GetPinnableReference(), label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), language, kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, in label.GetPinnableReference(), language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, uint* trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, in language.GetPinnableReference(), kind, isDefault, trackId);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, in language.GetPinnableReference(), kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddDataSourceFromUrl(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string url, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, Silk.NET.Core.Bool32 isDefault, Span<uint> trackId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataSourceFromUrl(url, label, language, kind, isDefault, ref trackId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack<TI0>(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTrack(label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrack(label, in language.GetPinnableReference(), kind, track);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack<TI0>(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTrack(label, in language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrack(label, in language.GetPinnableReference(), kind, ref track);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack<TI0>(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTrack(label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrack(in label.GetPinnableReference(), language, kind, track);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack<TI0>(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTrack(in label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrack(in label.GetPinnableReference(), language, kind, ref track);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrack(in label.GetPinnableReference(), in language.GetPinnableReference(), kind, track);
    }

    /// <summary>To be documented.</summary>
    public static int AddTrack<TI0>(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTrack(in label, in language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrack(in label.GetPinnableReference(), in language.GetPinnableReference(), kind, ref track);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrack(in label.GetPinnableReference(), language, kind, track);
    }

    /// <summary>To be documented.</summary>
    public static int AddTrack<TI0>(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTrack(in label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrack(in label.GetPinnableReference(), language, kind, ref track);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack<TI0>(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTrack(label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrack(label, in language.GetPinnableReference(), kind, track);
    }

    /// <summary>To be documented.</summary>
    public static int AddTrack<TI0>(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTrack(label, in language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrack(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> language, TimedTextTrackKind kind, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrack(label, in language.GetPinnableReference(), kind, ref track);
    }

    /// <summary>To be documented.</summary>
    public static int AddTrack<TI0>(this ComPtr<IMFTimedText> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string language, TimedTextTrackKind kind, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTrack(label, language, kind, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int RemoveTrack<TI0>(this ComPtr<IMFTimedText> thisVtbl, ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RemoveTrack((IMFTimedTextTrack*) track.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveTrack(this ComPtr<IMFTimedText> thisVtbl, Span<IMFTimedTextTrack> track)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveTrack(ref track.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCueTimeOffset(this ComPtr<IMFTimedText> thisVtbl, Span<double> offset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCueTimeOffset(ref offset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTracks<TI0>(this ComPtr<IMFTimedText> thisVtbl, ref ComPtr<TI0> tracks) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrackList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTracks((IMFTimedTextTrackList**) tracks.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetActiveTracks<TI0>(this ComPtr<IMFTimedText> thisVtbl, ref ComPtr<TI0> activeTracks) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrackList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetActiveTracks((IMFTimedTextTrackList**) activeTracks.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetTextTracks<TI0>(this ComPtr<IMFTimedText> thisVtbl, ref ComPtr<TI0> textTracks) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrackList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTextTracks((IMFTimedTextTrackList**) textTracks.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataTracks<TI0>(this ComPtr<IMFTimedText> thisVtbl, ref ComPtr<TI0> metadataTracks) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrackList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMetadataTracks((IMFTimedTextTrackList**) metadataTracks.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedText> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
