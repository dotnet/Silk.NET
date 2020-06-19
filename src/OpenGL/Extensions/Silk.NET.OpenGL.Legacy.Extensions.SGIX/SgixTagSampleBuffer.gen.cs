// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_tag_sample_buffer")]
    public abstract unsafe partial class SgixTagSampleBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_tag_sample_buffer";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glTagSampleBufferSGIX")]
        public abstract void TagSampleBuffer();

        public SgixTagSampleBuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

