// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;

namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the context-related functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface IContext
    {
        /// <summary>
        /// Creates a context using a specified device.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="attributeList">The context's attribute list.</param>
        /// <returns>The context handle.</returns>
        unsafe Context* CreateContext(Device* device, int* attributeList);

        /// <summary>
        /// Makes the specified context current for the current process.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>true if the context was made current; otherwise, false.</returns>
        unsafe bool MakeContextCurrent(Context* context);

        /// <summary>
        /// Instructs the context to begin processing data.
        /// </summary>
        /// <param name="context">The context.</param>
        unsafe void ProcessContext(Context* context);

        /// <summary>
        /// Instructs the context to suspend data processing.
        /// </summary>
        /// <param name="context">The context.</param>
        unsafe void SuspendContext(Context* context);

        /// <summary>
        /// Destroys a context, freeing its resources.
        /// </summary>
        /// <param name="context">The context.</param>
        unsafe void DestroyContext(Context* context);

        /// <summary>
        /// Gets the current context.
        /// </summary>
        /// <returns>The context.</returns>
        unsafe Context* GetCurrentContext();

        /// <summary>
        /// Gets the given context's device pointer.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>The device.</returns>
        unsafe Device* GetContextsDevice(Context* context);
    }
}