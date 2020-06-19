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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_map_object_buffer")]
    public abstract unsafe partial class AtiMapObjectBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_map_object_buffer";
        [NativeApi(EntryPoint = "glMapObjectBufferATI")]
        public abstract unsafe void* MapObjectBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glUnmapObjectBufferATI")]
        public abstract void UnmapObjectBuffer([Flow(FlowDirection.In)] uint buffer);

        public AtiMapObjectBuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

