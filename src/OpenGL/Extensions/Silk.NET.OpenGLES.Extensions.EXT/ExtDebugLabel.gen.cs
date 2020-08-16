// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_debug_label")]
    public unsafe partial class ExtDebugLabel : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_debug_label";
        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label);

        [NativeApi(EntryPoint = "glLabelObjectEXT")]
        public unsafe partial void LabelObject([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glLabelObjectEXT")]
        public partial void LabelObject([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] Span<byte> label);

        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glLabelObjectEXT")]
        public partial void LabelObject([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        public ExtDebugLabel(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

