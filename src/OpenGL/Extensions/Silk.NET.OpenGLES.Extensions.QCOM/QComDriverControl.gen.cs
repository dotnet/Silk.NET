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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_driver_control")]
    public abstract unsafe partial class QComDriverControl : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableDriverControlQCOM")]
        public abstract void DisableDriverControl([Flow(FlowDirection.In)] uint driverControl);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableDriverControlQCOM")]
        public abstract void EnableDriverControl([Flow(FlowDirection.In)] uint driverControl);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        public abstract unsafe void GetDriverControl([Flow(FlowDirection.Out)] int* num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] uint* driverControls);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        public abstract void GetDriverControl([Flow(FlowDirection.Out)] Span<int> num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<uint> driverControls);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract unsafe void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* driverControlString);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> driverControlString);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract unsafe void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string driverControlString);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string driverControlString);

        public QComDriverControl(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

