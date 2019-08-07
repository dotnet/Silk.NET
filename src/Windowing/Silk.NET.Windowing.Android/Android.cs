// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Silk.NET.Windowing.Android
{
    public static class Android
    {
        /// <summary>
        /// Acquire a reference on the given <see cref="ANativeWindow"/> object. This prevents the object from being
        /// deleted until the reference is removed.
        /// </summary>
        /// <param name="window"></param>
        [DllImport("android", EntryPoint = "ANativeWindow_acquire")]
        public static extern unsafe void Acquire(ANativeWindow* window);

        /// <summary>
        /// Return the ANativeWindow associated with a Java Surface object, for interacting with it through native code.
        /// </summary>
        /// <param name="jni">The JNI environment.</param>
        /// <param name="surface">The Java surface.</param>
        /// <returns></returns>
        [DllImport("android", EntryPoint = "ANativeWindow_fromSurface")]
        public static extern unsafe ANativeWindow* CreateNativeWindow(IntPtr jni, IntPtr surface);

        /// <summary>
        /// Get the dataspace of buffers in window.
        /// </summary>
        /// <param name="window">The window to get the dataspace of.</param>
        /// <returns>The dataspace.</returns>
        [DllImport("android", EntryPoint = "ANativeWindow_getBuffersDataSpace")]
        public static extern unsafe int GetBuffersDataSpace(ANativeWindow* window);
        
        /// <summary>
        /// Gets the current pixel format of the window surface.
        /// </summary>
        /// <param name="anw"></param>
        /// <returns></returns>
        [DllImport("android", EntryPoint = "ANativeWindow_getFormat")]
        public static extern unsafe int GetFormat(ANativeWindow* anw);
        
        /// <summary>
        /// Gets the current width in pixels of the window surface.
        /// </summary>
        /// <param name="anw"></param>
        /// <returns></returns>
        [DllImport("android", EntryPoint = "ANativeWindow_getWidth")]
        public static extern unsafe int GetWidth(ANativeWindow* anw);
        
        /// <summary>
        /// Gets the current height in pixels of the window surface.
        /// </summary>
        /// <param name="anw"></param>
        /// <returns></returns>
        [DllImport("android", EntryPoint = "ANativeWindow_getHeight")]
        public static extern unsafe int GetHeight(ANativeWindow* anw);
        
        /// <summary>
        /// Lock the window's next drawing surface for writing.
        /// </summary>
        /// <param name="anw">The window.</param>
        /// <param name="outBuffer">The output buffer.</param>
        /// <param name="inOutDirtyBounds">The region the caller intends to redraw.</param>
        /// <returns></returns>
        [DllImport("android", EntryPoint = "ANativeWindow_lock")]
        public static extern unsafe int LockWindow(ANativeWindow* anw, ANativeWindow.Buffer* outBuffer, ARect* inOutDirtyBounds);
        
        /// <summary>
        /// Remove a reference that was previously acquired with <see cref="Acquire"/>.
        /// </summary>
        /// <param name="window"></param>
        [DllImport("android", EntryPoint = "ANativeWindow_release")]
        public static extern unsafe void ReleaseNativeWindow(ANativeWindow* window);

        /// <summary>
        /// All buffers queued after this call will be associated with the dataSpace parameter specified.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <param name="dataSpace">Data space of all buffers queued after this call.</param>
        /// <returns></returns>
        [DllImport("android", EntryPoint = "ANativeWindow_setBuffersDataSpace")]
        public static extern unsafe int SetBuffersDataSpace(ANativeWindow* window, int dataSpace);

        /// <summary>
        /// Change the format and size of the window buffers.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <param name="width">The new width.</param>
        /// <param name="height">The new height.</param>
        /// <param name="format">The new format.</param>
        /// <returns></returns>
        [DllImport("android", EntryPoint = "ANativeWindow_setBuffersGeometry")]
        public static extern unsafe int SetBuffersGeometry(ANativeWindow* window, int width, int height, int format);

        /// <summary>
        /// Set a transform that will be applied to future buffers posted to the window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="transform"></param>
        /// <returns></returns>
        [DllImport("android", EntryPoint = "ANativeWindow_setBuffersTransform")]
        public static extern unsafe int SetBuffersTransform(ANativeWindow* window, int transform);
        
        /// <summary>
        /// Unlock the window's drawing surface after previously locking it, posting the new buffer to the display.
        /// </summary>
        /// <param name="anw"></param>
        /// <returns></returns>
        [DllImport("android", EntryPoint = "ANativeWindow_unlockAndPost")]
        public static extern unsafe int SwapBuffers(ANativeWindow* anw);
    }
}
