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

}
