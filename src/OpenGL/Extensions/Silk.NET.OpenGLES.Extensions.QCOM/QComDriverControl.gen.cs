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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_driver_control")]
    public abstract unsafe partial class QComDriverControl : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_driver_control";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableDriverControlQCOM")]
        public abstract void DisableDriverControl([Flow(FlowDirection.In)] uint driverControl);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableDriverControlQCOM")]
        public abstract void EnableDriverControl([Flow(FlowDirection.In)] uint driverControl);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="num">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="driverControls">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        public abstract unsafe void GetDriverControl([Flow(FlowDirection.Out)] int* num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] uint* driverControls);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="num">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="driverControls">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        public abstract void GetDriverControl([Flow(FlowDirection.Out)] Span<int> num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<uint> driverControls);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="driverControlString">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract unsafe void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* driverControlString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="driverControlString">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> driverControlString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="driverControlString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract unsafe void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string driverControlString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="driverControlString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        public abstract void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string driverControlString);

        public QComDriverControl(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

