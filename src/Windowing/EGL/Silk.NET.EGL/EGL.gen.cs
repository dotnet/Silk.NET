// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Loader;
using Ultz.SuperInvoke;

namespace Silk.NET.EGL
{
    public abstract unsafe partial class EGL : NativeAPI
    {

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglChooseConfig")]
        public abstract unsafe bool ChooseConfig([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int* attrib_list, [Flow(FlowDirection.Out)] IntPtr* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglChooseConfig")]
        public abstract bool ChooseConfig([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] Span<int> attrib_list, [Flow(FlowDirection.Out)] Span<IntPtr> configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] Span<int> num_config);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCopyBuffers")]
        public abstract bool CopyBuffers([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] IntPtr target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateContext")]
        public abstract unsafe IntPtr CreateContext([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] IntPtr share_context, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateContext")]
        public abstract IntPtr CreateContext([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] IntPtr share_context, [Flow(FlowDirection.In)] Span<int> attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePbufferSurface")]
        public abstract unsafe IntPtr CreatePbufferSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePbufferSurface")]
        public abstract IntPtr CreatePbufferSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] Span<int> attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePixmapSurface")]
        public abstract unsafe IntPtr CreatePixmapSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] IntPtr pixmap, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePixmapSurface")]
        public abstract IntPtr CreatePixmapSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] IntPtr pixmap, [Flow(FlowDirection.In)] Span<int> attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateWindowSurface")]
        public abstract unsafe IntPtr CreateWindowSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] IntPtr win, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateWindowSurface")]
        public abstract IntPtr CreateWindowSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] IntPtr win, [Flow(FlowDirection.In)] Span<int> attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglDestroyContext")]
        public abstract bool DestroyContext([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr ctx);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglDestroySurface")]
        public abstract bool DestroySurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetConfigAttrib")]
        public abstract unsafe bool GetConfigAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetConfigAttrib")]
        public abstract bool GetConfigAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetConfigs")]
        public abstract unsafe bool GetConfigs([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] IntPtr* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetConfigs")]
        public abstract bool GetConfigs([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] Span<IntPtr> configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] Span<int> num_config);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetCurrentDisplay")]
        public abstract IntPtr GetCurrentDisplay();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetCurrentSurface")]
        public abstract IntPtr GetCurrentSurface([Flow(FlowDirection.In)] int readdraw);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetDisplay")]
        public abstract IntPtr GetDisplay([Flow(FlowDirection.In)] IntPtr display_id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetError")]
        public abstract int GetError();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetProcAddress")]
        public abstract unsafe FuncPtr GetProcAddress([Flow(FlowDirection.In)] char* procname);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetProcAddress")]
        public abstract FuncPtr GetProcAddress([Flow(FlowDirection.In)] Span<char> procname);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglInitialize")]
        public abstract unsafe bool Initialize([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] int* major, [Flow(FlowDirection.Out)] int* minor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglInitialize")]
        public abstract bool Initialize([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] Span<int> major, [Flow(FlowDirection.Out)] Span<int> minor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglMakeCurrent")]
        public abstract bool MakeCurrent([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr draw, [Flow(FlowDirection.In)] IntPtr read, [Flow(FlowDirection.In)] IntPtr ctx);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryContext")]
        public abstract unsafe bool QueryContext([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr ctx, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryContext")]
        public abstract bool QueryContext([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr ctx, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryString")]
        public abstract unsafe char* QueryString([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQuerySurface")]
        public abstract unsafe bool QuerySurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQuerySurface")]
        public abstract bool QuerySurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglSwapBuffers")]
        public abstract bool SwapBuffers([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglTerminate")]
        public abstract bool Terminate([Flow(FlowDirection.In)] IntPtr dpy);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglWaitGL")]
        public abstract bool WaitGL();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglWaitNative")]
        public abstract bool WaitNative([Flow(FlowDirection.In)] int engine);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetProcAddress")]
        public abstract FuncPtr GetProcAddress([Flow(FlowDirection.In)] string procname);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryString")]
        public abstract string QueryStringS([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglBindTexImage")]
        public abstract bool BindTexImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglReleaseTexImage")]
        public abstract bool ReleaseTexImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglSurfaceAttrib")]
        public abstract bool SurfaceAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.In)] int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglSwapInterval")]
        public abstract bool SwapInterval([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int interval);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglBindAPI")]
        public abstract bool BindApi([Flow(FlowDirection.In)] EGLEnum api);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePbufferFromClientBuffer")]
        public abstract unsafe IntPtr CreatePbufferFromClientBuffer([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] EGLEnum buftype, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePbufferFromClientBuffer")]
        public abstract IntPtr CreatePbufferFromClientBuffer([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] EGLEnum buftype, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] Span<int> attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryAPI")]
        public abstract EGLEnum QueryApi();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglReleaseThread")]
        public abstract bool ReleaseThread();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglWaitClient")]
        public abstract bool WaitClient();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetCurrentContext")]
        public abstract IntPtr GetCurrentContext();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglClientWaitSync")]
        public abstract int ClientWaitSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] int flags, [Flow(FlowDirection.In)] ulong timeout);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateImage")]
        public abstract unsafe IntPtr CreateImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr ctx, [Flow(FlowDirection.In)] EGLEnum target, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateImage")]
        public abstract IntPtr CreateImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr ctx, [Flow(FlowDirection.In)] EGLEnum target, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurface")]
        public abstract unsafe IntPtr CreatePlatformPixmapSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.Out)] void* native_pixmap, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurface")]
        public abstract IntPtr CreatePlatformPixmapSurface<T0>([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.Out)] Span<T0> native_pixmap, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurface")]
        public abstract unsafe IntPtr CreatePlatformWindowSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.Out)] void* native_window, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurface")]
        public abstract IntPtr CreatePlatformWindowSurface<T0>([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.Out)] Span<T0> native_window, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateSync")]
        public abstract unsafe IntPtr CreateSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] EGLEnum type, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateSync")]
        public abstract IntPtr CreateSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] EGLEnum type, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglDestroyImage")]
        public abstract bool DestroyImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr image);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglDestroySync")]
        public abstract bool DestroySync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetPlatformDisplay")]
        public abstract unsafe IntPtr GetPlatformDisplay([Flow(FlowDirection.In)] EGLEnum platform, [Flow(FlowDirection.Out)] void* native_display, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetPlatformDisplay")]
        public abstract IntPtr GetPlatformDisplay<T0>([Flow(FlowDirection.In)] EGLEnum platform, [Flow(FlowDirection.Out)] Span<T0> native_display, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetSyncAttrib")]
        public abstract unsafe bool GetSyncAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetSyncAttrib")]
        public abstract bool GetSyncAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglWaitSync")]
        public abstract bool WaitSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] int flags);

        public unsafe bool ChooseConfig([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int* attrib_list, [Flow(FlowDirection.Out)] IntPtr* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config)
        {
            // IntPtrOverloader
            return ChooseConfig(new IntPtr(dpy), attrib_list, configs, config_size, num_config);
        }

        public unsafe bool ChooseConfig([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] Span<int> attrib_list, [Flow(FlowDirection.Out)] Span<IntPtr> configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] Span<int> num_config)
        {
            // IntPtrOverloader
            return ChooseConfig(new IntPtr(dpy), attrib_list, configs, config_size, num_config);
        }

        public unsafe bool CopyBuffers([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int target)
        {
            // IntPtrOverloader
            return CopyBuffers(new IntPtr(dpy), new IntPtr(surface), new IntPtr(target));
        }

        public unsafe IntPtr CreateContext([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int share_context, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreateContext(new IntPtr(dpy), new IntPtr(config), new IntPtr(share_context), attrib_list);
        }

        public unsafe IntPtr CreateContext([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int share_context, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreateContext(new IntPtr(dpy), new IntPtr(config), new IntPtr(share_context), attrib_list);
        }

        public unsafe IntPtr CreatePbufferSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreatePbufferSurface(new IntPtr(dpy), new IntPtr(config), attrib_list);
        }

        public unsafe IntPtr CreatePbufferSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreatePbufferSurface(new IntPtr(dpy), new IntPtr(config), attrib_list);
        }

        public unsafe IntPtr CreatePixmapSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int pixmap, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreatePixmapSurface(new IntPtr(dpy), new IntPtr(config), new IntPtr(pixmap), attrib_list);
        }

        public unsafe IntPtr CreatePixmapSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int pixmap, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreatePixmapSurface(new IntPtr(dpy), new IntPtr(config), new IntPtr(pixmap), attrib_list);
        }

        public unsafe IntPtr CreateWindowSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int win, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreateWindowSurface(new IntPtr(dpy), new IntPtr(config), new IntPtr(win), attrib_list);
        }

        public unsafe IntPtr CreateWindowSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int win, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreateWindowSurface(new IntPtr(dpy), new IntPtr(config), new IntPtr(win), attrib_list);
        }

        public unsafe bool DestroyContext([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int ctx)
        {
            // IntPtrOverloader
            return DestroyContext(new IntPtr(dpy), new IntPtr(ctx));
        }

        public unsafe bool DestroySurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface)
        {
            // IntPtrOverloader
            return DestroySurface(new IntPtr(dpy), new IntPtr(surface));
        }

        public unsafe bool GetConfigAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value)
        {
            // IntPtrOverloader
            return GetConfigAttrib(new IntPtr(dpy), new IntPtr(config), attribute, value);
        }

        public unsafe bool GetConfigAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // IntPtrOverloader
            return GetConfigAttrib(new IntPtr(dpy), new IntPtr(config), attribute, value);
        }

        public unsafe bool GetConfigs([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] IntPtr* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config)
        {
            // IntPtrOverloader
            return GetConfigs(new IntPtr(dpy), configs, config_size, num_config);
        }

        public unsafe bool GetConfigs([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] Span<IntPtr> configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] Span<int> num_config)
        {
            // IntPtrOverloader
            return GetConfigs(new IntPtr(dpy), configs, config_size, num_config);
        }

        public unsafe IntPtr GetDisplay([Flow(FlowDirection.In)] int display_id)
        {
            // IntPtrOverloader
            return GetDisplay(new IntPtr(display_id));
        }

        public unsafe bool Initialize([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] int* major, [Flow(FlowDirection.Out)] int* minor)
        {
            // IntPtrOverloader
            return Initialize(new IntPtr(dpy), major, minor);
        }

        public unsafe bool Initialize([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] Span<int> major, [Flow(FlowDirection.Out)] Span<int> minor)
        {
            // IntPtrOverloader
            return Initialize(new IntPtr(dpy), major, minor);
        }

        public unsafe bool MakeCurrent([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int draw, [Flow(FlowDirection.In)] int read, [Flow(FlowDirection.In)] int ctx)
        {
            // IntPtrOverloader
            return MakeCurrent(new IntPtr(dpy), new IntPtr(draw), new IntPtr(read), new IntPtr(ctx));
        }

        public unsafe bool QueryContext([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int ctx, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value)
        {
            // IntPtrOverloader
            return QueryContext(new IntPtr(dpy), new IntPtr(ctx), attribute, value);
        }

        public unsafe bool QueryContext([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int ctx, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // IntPtrOverloader
            return QueryContext(new IntPtr(dpy), new IntPtr(ctx), attribute, value);
        }

        public unsafe char* QueryString([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int name)
        {
            // IntPtrOverloader
            return QueryString(new IntPtr(dpy), name);
        }

        public unsafe bool QuerySurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value)
        {
            // IntPtrOverloader
            return QuerySurface(new IntPtr(dpy), new IntPtr(surface), attribute, value);
        }

        public unsafe bool QuerySurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // IntPtrOverloader
            return QuerySurface(new IntPtr(dpy), new IntPtr(surface), attribute, value);
        }

        public unsafe bool SwapBuffers([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface)
        {
            // IntPtrOverloader
            return SwapBuffers(new IntPtr(dpy), new IntPtr(surface));
        }

        public unsafe bool Terminate([Flow(FlowDirection.In)] int dpy)
        {
            // IntPtrOverloader
            return Terminate(new IntPtr(dpy));
        }

        public unsafe string QueryStringS([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int name)
        {
            // IntPtrOverloader
            return QueryStringS(new IntPtr(dpy), name);
        }

        public unsafe bool BindTexImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int buffer)
        {
            // IntPtrOverloader
            return BindTexImage(new IntPtr(dpy), new IntPtr(surface), buffer);
        }

        public unsafe bool ReleaseTexImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int buffer)
        {
            // IntPtrOverloader
            return ReleaseTexImage(new IntPtr(dpy), new IntPtr(surface), buffer);
        }

        public unsafe bool SurfaceAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.In)] int value)
        {
            // IntPtrOverloader
            return SurfaceAttrib(new IntPtr(dpy), new IntPtr(surface), attribute, value);
        }

        public unsafe bool SwapInterval([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int interval)
        {
            // IntPtrOverloader
            return SwapInterval(new IntPtr(dpy), interval);
        }

        public unsafe IntPtr CreatePbufferFromClientBuffer([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] EGLEnum buftype, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreatePbufferFromClientBuffer(new IntPtr(dpy), buftype, new IntPtr(buffer), new IntPtr(config), attrib_list);
        }

        public unsafe IntPtr CreatePbufferFromClientBuffer([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] EGLEnum buftype, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreatePbufferFromClientBuffer(new IntPtr(dpy), buftype, new IntPtr(buffer), new IntPtr(config), attrib_list);
        }

        public unsafe int ClientWaitSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] int flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            return ClientWaitSync(new IntPtr(dpy), new IntPtr(sync), flags, timeout);
        }

        public unsafe IntPtr CreateImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int ctx, [Flow(FlowDirection.In)] EGLEnum target, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return CreateImage(new IntPtr(dpy), new IntPtr(ctx), target, new IntPtr(buffer), attrib_list);
        }

        public unsafe IntPtr CreateImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int ctx, [Flow(FlowDirection.In)] EGLEnum target, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list)
        {
            // IntPtrOverloader
            return CreateImage(new IntPtr(dpy), new IntPtr(ctx), target, new IntPtr(buffer), attrib_list);
        }

        public unsafe IntPtr CreatePlatformPixmapSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.Out)] void* native_pixmap, [Flow(FlowDirection.In)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return CreatePlatformPixmapSurface(new IntPtr(dpy), new IntPtr(config), native_pixmap, attrib_list);
        }

        public unsafe IntPtr CreatePlatformPixmapSurface<T0>([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.Out)] Span<T0> native_pixmap, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreatePlatformPixmapSurface(new IntPtr(dpy), new IntPtr(config), native_pixmap, attrib_list);
        }

        public unsafe IntPtr CreatePlatformWindowSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.Out)] void* native_window, [Flow(FlowDirection.In)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return CreatePlatformWindowSurface(new IntPtr(dpy), new IntPtr(config), native_window, attrib_list);
        }

        public unsafe IntPtr CreatePlatformWindowSurface<T0>([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.Out)] Span<T0> native_window, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreatePlatformWindowSurface(new IntPtr(dpy), new IntPtr(config), native_window, attrib_list);
        }

        public unsafe IntPtr CreateSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] EGLEnum type, [Flow(FlowDirection.In)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return CreateSync(new IntPtr(dpy), type, attrib_list);
        }

        public unsafe IntPtr CreateSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] EGLEnum type, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list)
        {
            // IntPtrOverloader
            return CreateSync(new IntPtr(dpy), type, attrib_list);
        }

        public unsafe bool DestroyImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int image)
        {
            // IntPtrOverloader
            return DestroyImage(new IntPtr(dpy), new IntPtr(image));
        }

        public unsafe bool DestroySync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return DestroySync(new IntPtr(dpy), new IntPtr(sync));
        }

        public unsafe bool GetSyncAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value)
        {
            // IntPtrOverloader
            return GetSyncAttrib(new IntPtr(dpy), new IntPtr(sync), attribute, value);
        }

        public unsafe bool GetSyncAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value)
        {
            // IntPtrOverloader
            return GetSyncAttrib(new IntPtr(dpy), new IntPtr(sync), attribute, value);
        }

        public unsafe bool WaitSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] int flags)
        {
            // IntPtrOverloader
            return WaitSync(new IntPtr(dpy), new IntPtr(sync), flags);
        }

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new EGLLibraryNameContainer();

        public EGL(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }

        static EGL()
        {
            LibraryLoader.CreateBuilder<EGL>(Ultz.SuperInvoke.Loader.LibraryLoader.GetPlatformDefaultLoader());
        }
    }
}

