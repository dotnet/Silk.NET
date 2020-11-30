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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_driver_control")]
    public unsafe partial class QComDriverControl : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_driver_control";
        [NativeApi(EntryPoint = "glDisableDriverControlQCOM")]
        public partial void DisableDriverControl([Flow(FlowDirection.In)] uint driverControl);

        [NativeApi(EntryPoint = "glEnableDriverControlQCOM")]
        public partial void EnableDriverControl([Flow(FlowDirection.In)] uint driverControl);

        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        public unsafe partial void GetDriverControl([Flow(FlowDirection.Out)] int* num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] uint* driverControls);

        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        public unsafe partial void GetDriverControl([Flow(FlowDirection.Out)] int* num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] out uint driverControls);

        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        public unsafe partial void GetDriverControl([Flow(FlowDirection.Out)] out int num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] uint* driverControls);

        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        public partial void GetDriverControl([Flow(FlowDirection.Out)] out int num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] out uint driverControls);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public unsafe partial void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public unsafe partial void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public unsafe partial void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public unsafe partial void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public partial void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public partial void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string driverControlString);

        public QComDriverControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

