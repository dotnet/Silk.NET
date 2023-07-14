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

namespace Silk.NET.WGL.Extensions.I3D
{
    public static class I3DSwapFrameLockOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 IsEnabledFrameLockI3D(this I3DSwapFrameLock thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Silk.NET.Core.Bool32> pFlag)
        {
            // SpanOverloader
            return thisApi.IsEnabledFrameLockI3D(out pFlag.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryFrameLockMasterI3D(this I3DSwapFrameLock thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Silk.NET.Core.Bool32> pFlag)
        {
            // SpanOverloader
            return thisApi.QueryFrameLockMasterI3D(out pFlag.GetPinnableReference());
        }

    }
}

