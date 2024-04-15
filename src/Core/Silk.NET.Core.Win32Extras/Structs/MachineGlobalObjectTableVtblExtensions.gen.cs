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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class MachineGlobalObjectTableVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMachineGlobalObjectTable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMachineGlobalObjectTable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifier, @object, token);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifier, @object, tokenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifier, @objectPtr, token);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
        {
            fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifier, @objectPtr, tokenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* identifierPtr = &identifier)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @object, token);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* identifierPtr = &identifier)
        {
            fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @object, tokenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* identifierPtr = &identifier)
        {
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, token);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* identifierPtr = &identifier)
        {
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, tokenPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @object, token);
        SilkMarshal.Free((nint)identifierPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
        fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @object, tokenPtr);
        }
        SilkMarshal.Free((nint)identifierPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, token);
        }
        SilkMarshal.Free((nint)identifierPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
        {
            fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifierPtr, @objectPtr, tokenPtr);
            }
        }
        SilkMarshal.Free((nint)identifierPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifier, @object, token);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifier, @object, tokenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifier, @objectPtr, token);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifier, @objectPtr, tokenPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (char* identifierPtr = &identifier)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, token);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (char* identifierPtr = &identifier)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, tokenPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, token);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
                {
                    fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, tokenPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, token);
        SilkMarshal.Free((nint)identifierPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @object, tokenPtr);
            }
        SilkMarshal.Free((nint)identifierPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, token);
            }
        SilkMarshal.Free((nint)identifierPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Silk.NET.Core.Native.IUnknown @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Native.IUnknown* @objectPtr = &@object)
            {
                fixed (MachineGlobalObjectTableRegistrationToken** tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsidPtr, identifierPtr, @objectPtr, tokenPtr);
                }
            }
        SilkMarshal.Free((nint)identifierPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifier, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifier, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifier, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifier, riidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* identifierPtr = &identifier)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riid, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* identifierPtr = &identifier)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riid, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* identifierPtr = &identifier)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* identifierPtr = &identifier)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riid, ppv);
        SilkMarshal.Free((nint)identifierPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riid, ppvPtr);
        }
        SilkMarshal.Free((nint)identifierPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppv);
        }
        SilkMarshal.Free((nint)identifierPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifierPtr, riidPtr, ppvPtr);
            }
        }
        SilkMarshal.Free((nint)identifierPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifier, riid, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifier, riid, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifier, riidPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifier, riidPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (char* identifierPtr = &identifier)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (char* identifierPtr = &identifier)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppv);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (char* identifierPtr = &identifier)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppvPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppv);
        SilkMarshal.Free((nint)identifierPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riid, ppvPtr);
            }
        SilkMarshal.Free((nint)identifierPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppv);
            }
        SilkMarshal.Free((nint)identifierPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
        var identifierPtr = (byte*) SilkMarshal.StringToPtr(identifier, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsidPtr, identifierPtr, riidPtr, ppvPtr);
                }
            }
        SilkMarshal.Free((nint)identifierPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RevokeObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, MachineGlobalObjectTableRegistrationToken*, int>)@this->LpVtbl[5])(@this, token);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RevokeObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref MachineGlobalObjectTableRegistrationToken token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MachineGlobalObjectTableRegistrationToken* tokenPtr = &token)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, MachineGlobalObjectTableRegistrationToken*, int>)@this->LpVtbl[5])(@this, tokenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Span<Silk.NET.Core.Native.IUnknown> @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(clsid, identifier, ref @object.GetPinnableReference(), token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Span<Silk.NET.Core.Native.IUnknown> @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(clsid, identifier, ref @object.GetPinnableReference(), ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(clsid, in identifier.GetPinnableReference(), @object, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(clsid, in identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(clsid, in identifier.GetPinnableReference(), @object, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(clsid, in identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Span<Silk.NET.Core.Native.IUnknown> @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(clsid, in identifier.GetPinnableReference(), ref @object.GetPinnableReference(), token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Span<Silk.NET.Core.Native.IUnknown> @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(clsid, in identifier.GetPinnableReference(), ref @object.GetPinnableReference(), ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Span<Silk.NET.Core.Native.IUnknown> @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(clsid, identifier, ref @object.GetPinnableReference(), token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Span<Silk.NET.Core.Native.IUnknown> @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(clsid, identifier, ref @object.GetPinnableReference(), ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), identifier, @object, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(ref clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), identifier, @object, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(ref clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Span<Silk.NET.Core.Native.IUnknown> @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), identifier, ref @object.GetPinnableReference(), token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Span<Silk.NET.Core.Native.IUnknown> @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), identifier, ref @object.GetPinnableReference(), ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), in identifier.GetPinnableReference(), @object, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(ref clsid, in identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), in identifier.GetPinnableReference(), @object, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(ref clsid, in identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Span<Silk.NET.Core.Native.IUnknown> @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), in identifier.GetPinnableReference(), ref @object.GetPinnableReference(), token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Span<Silk.NET.Core.Native.IUnknown> @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), in identifier.GetPinnableReference(), ref @object.GetPinnableReference(), ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), identifier, @object, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ComPtr<TI0> @object, MachineGlobalObjectTableRegistrationToken** token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(ref clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Silk.NET.Core.Native.IUnknown* @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), identifier, @object, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, ComPtr<TI0> @object, ref MachineGlobalObjectTableRegistrationToken* token) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObject(ref clsid, identifier, (Silk.NET.Core.Native.IUnknown*) @object.Handle, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Span<Silk.NET.Core.Native.IUnknown> @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), identifier, ref @object.GetPinnableReference(), token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Span<Silk.NET.Core.Native.IUnknown> @object, ref MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObject(ref clsid.GetPinnableReference(), identifier, ref @object.GetPinnableReference(), ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetObjectA(clsid, identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(clsid, identifier, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(clsid, identifier, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(clsid, in identifier.GetPinnableReference(), riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetObjectA(clsid, in identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(clsid, in identifier.GetPinnableReference(), riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(clsid, in identifier.GetPinnableReference(), ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(clsid, in identifier.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetObjectA(clsid, identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(clsid, identifier, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(clsid, identifier, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), identifier, riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetObjectA(ref clsid, identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), identifier, riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), identifier, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), identifier, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), in identifier.GetPinnableReference(), riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetObjectA(ref clsid, in identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), in identifier.GetPinnableReference(), riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), in identifier.GetPinnableReference(), ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> identifier, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), in identifier.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), identifier, riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetObjectA(ref clsid, identifier, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), identifier, riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), identifier, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<Guid> clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref clsid.GetPinnableReference(), identifier, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static int RevokeObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Span<MachineGlobalObjectTableRegistrationToken> token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RevokeObject(ref token.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetObjectA(clsid, identifier, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetObjectA(clsid, in identifier, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetObjectA(clsid, identifier, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetObjectA(ref clsid, identifier, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char identifier) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetObjectA(ref clsid, in identifier, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetObjectA<TI0>(this ComPtr<IMachineGlobalObjectTable> thisVtbl, ref Guid clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string identifier) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetObjectA(ref clsid, identifier, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
