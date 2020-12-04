// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtEglImageStorageOverloads
    {
        public static unsafe void EglimageTargetTexStorage(this ExtEglImageStorage thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.EglimageTargetTexStorage(target, image, in attrib_list.GetPinnableReference());
        }

        public static unsafe void EglimageTargetTextureStorage(this ExtEglImageStorage thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.EglimageTargetTextureStorage(texture, image, in attrib_list.GetPinnableReference());
        }

    }
}

