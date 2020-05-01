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

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [Extension("NVX_progress_fence")]
    public abstract unsafe partial class NvxProgressFence : NativeExtension<GL>
    {
        public const string ExtensionName = "NVX_progress_fence";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fenceObjectCount">
        /// To be added.
        /// </param>
        /// <param name="semaphoreArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        /// <param name="fenceValueArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        [NativeApi(EntryPoint = "glClientWaitSemaphoreui64NVX")]
        public abstract unsafe void ClientWaitSemaphore([Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] uint* semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ulong* fenceValueArray);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fenceObjectCount">
        /// To be added.
        /// </param>
        /// <param name="semaphoreArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        /// <param name="fenceValueArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        [NativeApi(EntryPoint = "glClientWaitSemaphoreui64NVX")]
        public abstract void ClientWaitSemaphore([Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] Span<uint> semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] Span<ulong> fenceValueArray);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCreateProgressFenceNVX")]
        public abstract uint CreateProgressFence();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="signalGpu">
        /// To be added.
        /// </param>
        /// <param name="fenceObjectCount">
        /// To be added.
        /// </param>
        /// <param name="semaphoreArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        /// <param name="fenceValueArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        [NativeApi(EntryPoint = "glSignalSemaphoreui64NVX")]
        public abstract unsafe void SignalSemaphore([Flow(FlowDirection.In)] uint signalGpu, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] uint* semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ulong* fenceValueArray);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="signalGpu">
        /// To be added.
        /// </param>
        /// <param name="fenceObjectCount">
        /// To be added.
        /// </param>
        /// <param name="semaphoreArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        /// <param name="fenceValueArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        [NativeApi(EntryPoint = "glSignalSemaphoreui64NVX")]
        public abstract void SignalSemaphore([Flow(FlowDirection.In)] uint signalGpu, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] Span<uint> semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] Span<ulong> fenceValueArray);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="waitGpu">
        /// To be added.
        /// </param>
        /// <param name="fenceObjectCount">
        /// To be added.
        /// </param>
        /// <param name="semaphoreArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        /// <param name="fenceValueArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        [NativeApi(EntryPoint = "glWaitSemaphoreui64NVX")]
        public abstract unsafe void WaitSemaphore([Flow(FlowDirection.In)] uint waitGpu, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] uint* semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ulong* fenceValueArray);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="waitGpu">
        /// To be added.
        /// </param>
        /// <param name="fenceObjectCount">
        /// To be added.
        /// </param>
        /// <param name="semaphoreArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        /// <param name="fenceValueArray">
        /// To be added.
        /// This parameter's element count is taken from fenceObjectCount.
        /// </param>
        [NativeApi(EntryPoint = "glWaitSemaphoreui64NVX")]
        public abstract void WaitSemaphore([Flow(FlowDirection.In)] uint waitGpu, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] Span<uint> semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] Span<ulong> fenceValueArray);

        public NvxProgressFence(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

