// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_read_buffer")]
    public abstract unsafe partial class NVReadBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_read_buffer";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReadBufferNV")]
        public abstract void ReadBuffer([Flow(FlowDirection.In)] NV mode);

        public NVReadBuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

