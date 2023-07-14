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

namespace Silk.NET.OpenGL.Extensions.EXT
{
    public static class ExtEglImageStorageOverloads
    {
        public static unsafe void EglimageTargetTexStorage(this ExtEglImageStorage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.EglimageTargetTexStorage(target, image, in attrib_list.GetPinnableReference());
        }

        public static unsafe void EglimageTargetTextureStorage(this ExtEglImageStorage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.EglimageTargetTextureStorage(texture, image, in attrib_list.GetPinnableReference());
        }

    }
}

