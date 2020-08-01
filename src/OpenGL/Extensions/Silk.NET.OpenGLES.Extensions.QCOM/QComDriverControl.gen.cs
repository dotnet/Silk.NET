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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_driver_control")]
    public abstract unsafe partial class QComDriverControl : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_driver_control";
        [NativeApi(EntryPoint = "glDisableDriverControlQCOM")]
        public abstract void DisableDriverControl([Flow(FlowDirection.In)] uint driverControl);

        [NativeApi(EntryPoint = "glEnableDriverControlQCOM")]
        public abstract void EnableDriverControl([Flow(FlowDirection.In)] uint driverControl);

        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        public abstract unsafe void GetDriverControl([Flow(FlowDirection.Out)] int* num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] uint* driverControls);

        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        public abstract void GetDriverControl([Flow(FlowDirection.Out)] Span<int> num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<uint> driverControls);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract unsafe void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract unsafe void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out)] out string driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Flow(FlowDirection.Out)] out string driverControlString);

        public QComDriverControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

