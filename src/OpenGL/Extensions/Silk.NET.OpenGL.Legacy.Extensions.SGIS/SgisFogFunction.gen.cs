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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_fog_function")]
    public unsafe partial class SgisFogFunction : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_fog_function";
        [NativeApi(EntryPoint = "glFogFuncSGIS")]
        public unsafe partial void FogFunc([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glFogFuncSGIS")]
        public partial void FogFunc([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float points);

        [NativeApi(EntryPoint = "glGetFogFuncSGIS")]
        public unsafe partial void GetFogFunc([Count(Count = 0), Flow(FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetFogFuncSGIS")]
        public partial void GetFogFunc([Count(Count = 0), Flow(FlowDirection.Out)] out float points);

        public unsafe float GetFogFunc()
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFogFunc(&ret);
            return ret;
        }

        public SgisFogFunction(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

