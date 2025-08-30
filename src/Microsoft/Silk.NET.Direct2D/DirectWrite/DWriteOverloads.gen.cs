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

namespace Silk.NET.DirectWrite
{
    public static class DWriteOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5123, Column 32 in DWrite.h")]
        public static unsafe int DWriteCreateFactory(this DWrite thisApi, FactoryType factoryType, Span<Guid> iid, Silk.NET.Core.Native.IUnknown** factory)
        {
            // SpanOverloader
            return thisApi.DWriteCreateFactory(factoryType, ref iid.GetPinnableReference(), factory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5123, Column 32 in DWrite.h")]
        public static unsafe int DWriteCreateFactory(this DWrite thisApi, FactoryType factoryType, Span<Guid> iid, ref Silk.NET.Core.Native.IUnknown* factory)
        {
            // SpanOverloader
            return thisApi.DWriteCreateFactory(factoryType, ref iid.GetPinnableReference(), ref factory);
        }

    }
}

