// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.GREMEDY
{
    [Extension("GREMEDY_string_marker")]
    public unsafe partial class GremedyStringMarker : NativeExtension<GL>
    {
        public const string ExtensionName = "GREMEDY_string_marker";
        [NativeApi(EntryPoint = "glStringMarkerGREMEDY")]
        public unsafe partial void StringMarker([Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string);

        [NativeApi(EntryPoint = "glStringMarkerGREMEDY")]
        public partial void StringMarker<T0>([Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] in T0 @string) where T0 : unmanaged;

        public GremedyStringMarker(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

