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

public unsafe static class PrintDocumentPackageTargetFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* jobNamePtr = &jobName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        SilkMarshal.Free((nint)jobNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
        }
        SilkMarshal.Free((nint)jobNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
        }
        SilkMarshal.Free((nint)jobNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
            }
        }
        SilkMarshal.Free((nint)jobNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
        }
        SilkMarshal.Free((nint)jobNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
            }
        }
        SilkMarshal.Free((nint)jobNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
            }
        }
        SilkMarshal.Free((nint)jobNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
        }
        SilkMarshal.Free((nint)jobNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (char* jobNamePtr = &jobName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        SilkMarshal.Free((nint)jobNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
            }
        SilkMarshal.Free((nint)jobNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
            }
        SilkMarshal.Free((nint)jobNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
        SilkMarshal.Free((nint)jobNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
            }
        SilkMarshal.Free((nint)jobNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
        SilkMarshal.Free((nint)jobNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
        SilkMarshal.Free((nint)jobNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* printerNamePtr = &printerName)
        {
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)jobNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (char* jobNamePtr = &jobName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        fixed (char* jobNamePtr = &jobName)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        SilkMarshal.Free((nint)jobNamePtr);
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
        }
        SilkMarshal.Free((nint)jobNamePtr);
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
        }
        SilkMarshal.Free((nint)jobNamePtr);
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
            }
        }
        SilkMarshal.Free((nint)jobNamePtr);
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
        }
        SilkMarshal.Free((nint)jobNamePtr);
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
            }
        }
        SilkMarshal.Free((nint)jobNamePtr);
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
            }
        }
        SilkMarshal.Free((nint)jobNamePtr);
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
        var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
        }
        SilkMarshal.Free((nint)jobNamePtr);
        SilkMarshal.Free((nint)printerNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), jobOutputStream, jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), jobOutputStream, jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, jobOutputStream, jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), in jobName.GetPinnableReference(), jobOutputStream, jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), in jobName.GetPinnableReference(), jobOutputStream, jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), in jobName.GetPinnableReference(), jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), in jobName.GetPinnableReference(), jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, jobOutputStream, jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(in printerName.GetPinnableReference(), jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), jobOutputStream, jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), jobOutputStream, jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName.GetPinnableReference(), ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, jobOutputStream, ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0, TI1>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), jobPrintTicketStream, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDocumentPackageTargetForPrintJob<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDocumentPackageTargetForPrintJob(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Span<Silk.NET.Core.Win32Extras.IStream> jobOutputStream, Span<Silk.NET.Core.Win32Extras.IStream> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream.GetPinnableReference(), ref jobPrintTicketStream.GetPinnableReference(), ref docPackageTarget);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPrintDocumentPackageTargetFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
