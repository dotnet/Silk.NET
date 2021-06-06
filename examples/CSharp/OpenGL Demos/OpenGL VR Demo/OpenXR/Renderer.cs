// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Core;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.OpenXR;
using Silk.NET.Windowing;
using static OpenGL_VR_Demo.OpenXR.OpenGLXRGame;
using Action = System.Action;

namespace OpenGL_VR_Demo.OpenXR
{
    public class Renderer : IDisposable
    {
        // API objects
        public GL Gl { get; private set; }
        public XR Xr { get; init; }
        
        // OpenXR handles & info
        public Session Session;
        public Space ReferenceSpace;
        public Swapchain Swapchain;
        public SwapchainCreateInfo SwapchainCreateInfo;
        public EventDataBuffer EventData;
        public SessionState State { get; private set; }
        public bool IsStage { get; private set; }
        
        // OpenGL handles & info
        public (uint Framebuffer, uint Renderbuffer) Framebuffers;
        public uint[] SwapchainImages;
        
        // Eye Info - for use in games!
        private Posef[] RawViews { get; set; } = new Posef[2];
        private Matrix4x4[] Projections { get; set; } = new Matrix4x4[2];
        public View[] ViewStates { get; private set; } = new View[2];
        public Matrix4x4 GetViewMatrix(int eye, Vector3 offset = default)
        {
            if (!Matrix4x4.Invert(RawViews[eye].ToView(offset), out var inverse))
            {
                throw new("Couldn't create inverse pose view matrix.");
            }

            return inverse;
        }

        public Matrix4x4 GetProjectionMatrix(int eye) => Projections[eye];

        // Misc
        private IView _view;
        private OpenGLXRGame _game;
        private bool _unmanagedResourcesFreed;

        public Renderer(OpenGLXRGame game)
        {
            _game = game;

            Xr = game.Xr;
            
            var opts = ViewOptions.Default;
            opts.VSync = false;
            opts.FramesPerSecond = 0;
            opts.PreferredBitDepth = new(8, 8, 8, 8);
            opts.PreferredDepthBufferBits = 24;
            opts.ShouldSwapAutomatically = false;
            if (game.IsGles)
            {
                GraphicsRequirementsOpenGLESKHR esReqs = new();
                CheckResult
                    (game.GlesEnable!.GetOpenGlesgraphicsRequirements(game.Instance, game.System.Id, ref esReqs));
                var version = (Version64) (game.UseMinimumVersion
                    ? esReqs.MinApiVersionSupported
                    : esReqs.MaxApiVersionSupported);
                opts.API = new
                (
                    ContextAPI.OpenGLES, ContextProfile.Core,
                    Debugger.IsAttached ? ContextFlags.Debug : ContextFlags.Default,
                    new((int) version.Major, (int) version.Minor)
                );
            }
            else
            {
                GraphicsRequirementsOpenGLKHR reqs = new();
                CheckResult(game.GlEnable!.GetOpenGlgraphicsRequirements(game.Instance, game.System.Id, ref reqs));
                var version = (Version64) (game.UseMinimumVersion
                    ? reqs.MinApiVersionSupported
                    : reqs.MaxApiVersionSupported);
                opts.API = new
                (
                    ContextAPI.OpenGL, ContextProfile.Core,
                    Debugger.IsAttached ? ContextFlags.Debug : ContextFlags.Default,
                    new((int) version.Major, (int) version.Minor)
                );
            }

            if (Window.IsViewOnly)
            {
                _view = Window.GetView(opts);
            }
            else
            {
                var wOpts = new WindowOptions(opts)
                {
                    Position = -Vector2D<int>.One,
                    Size = new
                        ((int) (game.System.RenderTargetSize.X / ((float) game.System.RenderTargetSize.Y / 720)), 720)
                };

                _view = Window.Create(wOpts);
            }
            
            _view.Load += ViewOnLoad;
            _view.Update += ViewOnUpdate;
            _view.Render += ViewOnRender;
            _view.Closing += ViewOnUnload;
        }

        public event Action? Load;
        public event Action<double>? Update;
        public event Action<int, double>? Render;
        public event Action? Unload;
        
        private void ViewOnLoad()
        {
            Gl = _view.CreateOpenGL();
            PrepareOpenXR();
            PrepareOpenGL();
            Load?.Invoke();
        }

        private void ViewOnUnload()
        {
            ReleaseUnmanagedResources();
            Unload?.Invoke();
            Gl.Dispose();
            Gl = null!;
        }

        private unsafe void PrepareOpenXR()
        {
            var binding = _game.IsGles ? _view.CreateOpenGLESBinding() : _view.CreateOpenGLBinding();
            var sessionCreateInfo = new SessionCreateInfo(systemId: _game.System.Id, next: &binding);
            CheckResult(Xr.CreateSession(_game.Instance, in sessionCreateInfo, ref Session));

            // Now, let's create the reference space that describes the real-world environment where the VR game is
            // being played.

            // First we need to check what kinds of spaces we have. OpenXR (OOTB) has:
            // - view, where the content doesn't take into any physical attributes such as eye orientation and
            //   physical location. could be useful for head-up-displays.
            // - local, where the content knows about the user's eye orientation but not about their physical location.
            //   i'll refer to this as "seated-scale", as you're unlikely to move in a seat and this is what the spec
            //   calls it.
            // - stage, where the content knows about both eye orientation and physical location. this can be used for
            //   "room-scale" and "standing-scale" content, where the user's physical movements affect the content.
            var numRefSpaces = 0u;
            CheckResult(Xr.EnumerateReferenceSpaces(Session, numRefSpaces, ref numRefSpaces, null));
            Span<ReferenceSpaceType> refSpaces = stackalloc ReferenceSpaceType[(int) numRefSpaces];
            CheckResult(Xr.EnumerateReferenceSpaces(Session, ref numRefSpaces, refSpaces));

            var refSpaceCreateInfo = new ReferenceSpaceCreateInfo();
            foreach (var referenceSpaceType in refSpaces)
            {
                if (referenceSpaceType == ReferenceSpaceType.Stage)
                {
                    refSpaceCreateInfo.ReferenceSpaceType = ReferenceSpaceType.Stage;
                    IsStage = true;
                }
            }

            if (!IsStage)
            {
                // use seated-scale instead. all OpenXR runtimes MUST support seated-scale content.
                refSpaceCreateInfo.ReferenceSpaceType = ReferenceSpaceType.Local;
            }
            else
            {
                refSpaceCreateInfo.PoseInReferenceSpace = new(new(0, 0, 0, 1));
            }

            CheckResult(Xr.CreateReferenceSpace(Session, in refSpaceCreateInfo, ref ReferenceSpace));

            // Next up, the swapchain.
            // First and foremost, let's make sure OpenXR actually supports the pixel format we're going to be using in
            // this example (GL_SRGB8_ALPHA8)
            const long theFormat = (long) GLEnum.Rgba16;
            var numFormats = 0u;
            CheckResult(Xr.EnumerateSwapchainFormats(Session, numFormats, ref numFormats, null));
            var formats = numFormats * sizeof(long) > 256 ? new long[numFormats] : stackalloc long[(int) numFormats];
            CheckResult(Xr.EnumerateSwapchainFormats(Session, ref numFormats, formats));

            var formatSupported = false;
            
            foreach (var format in formats)
            {
                if (format == theFormat)
                {
                    formatSupported = true;
                    break;
                }
            }

            if (!formatSupported)
            {
                throw new($"OpenXR does not support the {(GLEnum) theFormat} pixel format ({theFormat})");
            }
            
            // Now that we know that the format we want to use is actually supported by OpenXR, we're ready to create
            // our swapchain.
            SwapchainCreateInfo = new
            (
                usageFlags: SwapchainUsageFlags.SwapchainUsageTransferDstBit,
                format: theFormat,
                sampleCount: 1, arraySize: 1, faceCount: 1, mipCount: 1,
                width: _game.System.RenderTargetSize.X,
                height: _game.System.RenderTargetSize.Y
            );

            CheckResult(Xr.CreateSwapchain(Session, in SwapchainCreateInfo, ref Swapchain));
            
            // Now we have to get the swapchain images. That is, the OpenGL texture handles which OpenXR creates itself.
            var numImages = 0u;
            CheckResult(Xr.EnumerateSwapchainImages(Swapchain, numImages, ref numImages, null));
            var images = numImages * sizeof(SwapchainImageOpenGLKHR) > 256
                ? new SwapchainImageOpenGLKHR[(int) numImages]
                : stackalloc SwapchainImageOpenGLKHR[(int) numImages];
            CheckResult
            (
                Xr.EnumerateSwapchainImages
                (
                    Swapchain, numImages, ref numImages,
                    ref Unsafe.As<SwapchainImageOpenGLKHR, SwapchainImageBaseHeader>(ref images[0])
                )
            );

            SwapchainImages = new uint[numImages];
            for (var i = 0; i < numImages; i++)
            {
                SwapchainImages[i] = images[i].Image;
            }
        }

        private void PrepareOpenGL()
        {
            // First create a depth renderbuffer compatible with the swapchain sample count and size
            Framebuffers.Renderbuffer = Gl.GenRenderbuffer();
            Gl.BindRenderbuffer(GLEnum.Renderbuffer, Framebuffers.Renderbuffer);
            if (SwapchainCreateInfo.SampleCount == 1)
            {
                Gl.RenderbufferStorage
                (
                    GLEnum.Renderbuffer,
                    GLEnum.Depth24Stencil8,
                    SwapchainCreateInfo.Width, SwapchainCreateInfo.Height
                );
            }
            else
            {
                Gl.RenderbufferStorageMultisample
                (
                    GLEnum.Renderbuffer,
                    SwapchainCreateInfo.SampleCount,
                    GLEnum.Depth24Stencil8,
                    SwapchainCreateInfo.Width, SwapchainCreateInfo.Height
                );
            }
            
            // Now, create the actual framebuffer.
            Framebuffers.Framebuffer = Gl.GenFramebuffer();
            Gl.BindFramebuffer(GLEnum.DrawFramebuffer, Framebuffers.Framebuffer);
            
            // Attach the depth renderbuffer to the framebuffer
            Gl.FramebufferRenderbuffer
            (
                GLEnum.DrawFramebuffer,
                GLEnum.DepthStencilAttachment,
                GLEnum.Renderbuffer,
                Framebuffers.Renderbuffer
            );
            
            // Unbind the framebuffer and renderbuffer now we're done with them
            Gl.BindFramebuffer(GLEnum.DrawFramebuffer, 0);
            Gl.BindRenderbuffer(GLEnum.Renderbuffer, 0);
        }

        public unsafe void ViewOnUpdate(double delta)
        {
            while (CheckResult(Xr.PollEvent(_game.Instance, ref EventData)) != Result.EventUnavailable)
            {
                switch (EventData.Type)
                {
                    case StructureType.TypeEventDataInstanceLossPending:
                    {
                        Console.WriteLine("[INFO] Application: Instance loss pending, shutting down...");
                        _view.Close();
                        break;
                    }

                    case StructureType.TypeEventDataSessionStateChanged:
                    {
                        ref var sessionStateChanged = ref Unsafe.As<EventDataBuffer, EventDataSessionStateChanged>
                        (
                            ref EventData
                        );

                        if (sessionStateChanged.Session.Handle != Session.Handle || Session.Handle is 0)
                        {
                            break;
                        }

                        State = sessionStateChanged.State;
                        
                        // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
                        switch (sessionStateChanged.State)
                        {
                            case SessionState.Ready:
                            {
                                if (!_view.IsClosing)
                                {
                                    var sessionBeginInfo = new SessionBeginInfo
                                    (
                                        primaryViewConfigurationType: ViewConfigurationType.PrimaryStereo
                                    );

                                    CheckResult(Xr.BeginSession(Session, in sessionBeginInfo));
                                    Console.WriteLine("[INFO] Application: Session ready!");
                                }

                                break;
                            }
                            case SessionState.Stopping:
                            {
                                Console.WriteLine("[INFO] Application: OpenXR is stopping, ending session...");
                                Xr.EndSession(Session);
                                _view.Close();
                                break;
                            }
                            case SessionState.LossPending:
                            {
                                // NB: A loss of the session doesn't necessarily mean it's game over, you can recreate
                                //     the session but I've left it out for this demo. As I understand it, this might
                                //     happen if a wired VR headset were to accidentally become unplugged, for example.
                                Console.WriteLine("[INFO] Application: Session loss pending, shutting down...");
                                Xr.DestroySession(Session);
                                Session = default;
                                _view.Close();
                                break;
                            }
                            case SessionState.Exiting:
                            {
                                Console.WriteLine("[INFO] Application: OpenXR is exiting...");
                                _view.Close();
                                break;
                            }
                        }

                        break;
                    }
                }
            
                // reset the event data to eliminate potential for strange behaviour when passing it back to OpenXR
                EventData = default;
            }

            if (_view.IsClosing || Session.Handle is 0)
            {
                return;
            }
            
            Update?.Invoke(delta);
        }

        private void ViewOnRender(double delta)
        {
            if (_view.IsClosing)
            {
                return;
            }

            if (TryStartFrame(out var frameState))
            {
                UpdateViews(in frameState);
                if ((Bool32) frameState.ShouldRender)
                {
                    DoRender(delta);
                    _view.SwapBuffers();
                }
                
                EndFrame(in frameState);
            }
        }

        private unsafe void DoRender(double delta)
        {
            // Get the swapchain image
            var swapchainIndex = 0u;
            var acquireInfo = new SwapchainImageAcquireInfo();
            CheckResult(Xr.AcquireSwapchainImage(Swapchain, in acquireInfo, ref swapchainIndex));

            var waitInfo = new SwapchainImageWaitInfo(timeout: long.MaxValue);
            CheckResult(Xr.WaitSwapchainImage(Swapchain, in waitInfo));
            
            // Bind the framebuffer we created earlier, using the acquired image as the texture to render the
            // framebuffer into.
            Gl.BindFramebuffer(GLEnum.Framebuffer, Framebuffers.Framebuffer);
            Gl.FramebufferTexture(GLEnum.Framebuffer, GLEnum.ColorAttachment0, SwapchainImages[swapchainIndex], 0);
            
            // Render each eye
            Gl.Enable(GLEnum.ScissorTest);
            for (var eye = 0; eye < 2; eye++)
            {
                // Set the scissor rectangle to the appropriate half of the image
                Gl.Scissor
                (
                    (int)(_game.System.RenderTargetSize.X / 2) * eye, 0,
                    _game.System.RenderTargetSize.X / 2, _game.System.RenderTargetSize.Y
                );
                
                Gl.Viewport
                (
                    (int)(_game.System.RenderTargetSize.X / 2) * eye, 0,
                    _game.System.RenderTargetSize.X / 2, _game.System.RenderTargetSize.Y
                );
                
                Render?.Invoke(eye, delta);
            }
            
            // Quickly blit the swapchain image/texture to the window's framebuffer
            Gl.Disable(GLEnum.ScissorTest);
            Gl.BindFramebuffer(GLEnum.DrawFramebuffer, 0);
            Gl.BlitFramebuffer
            (
                0, 0,
                (int) _game.System.RenderTargetSize.X, (int) _game.System.RenderTargetSize.Y,
                0, 0,
                _view.Size.X, _view.Size.Y,
                ClearBufferMask.ColorBufferBit,
                GLEnum.Nearest
            );
            
            // Release the swapchain image
            var releaseInfo = new SwapchainImageReleaseInfo();
            CheckResult(Xr.ReleaseSwapchainImage(Swapchain, in releaseInfo));
        }

        private bool TryStartFrame(out FrameState frameState)
        {
            frameState = new FrameState();
            var done = State switch
            {
                SessionState.Ready => WaitFrame(ref frameState),
                SessionState.Focused => WaitFrame(ref frameState),
                SessionState.Synchronized => WaitFrame(ref frameState),
                SessionState.Visible => WaitFrame(ref frameState),
                _ => false
            };

            if (done)
            {
                var beginInfo = new FrameBeginInfo();
                CheckResult(Xr.BeginFrame(Session, in beginInfo));
            }
            
            return done;
        }

        private unsafe bool WaitFrame(ref FrameState frameState)
        {
            return Xr.WaitFrame(Session, null, ref frameState) == Result.Success;
        }

        private unsafe void UpdateViews(in FrameState frameState)
        {
            var viewState = new ViewState();
            var viewLocateInfo = new ViewLocateInfo
            (
                viewConfigurationType: ViewConfigurationType.PrimaryStereo,
                displayTime: frameState.PredictedDisplayTime,
                space: ReferenceSpace
            );

            var eyeViewStateCount = 0u;
            CheckResult
            (
                Xr.LocateView(Session, in viewLocateInfo, ref viewState, eyeViewStateCount, ref eyeViewStateCount, null)
            );

            if (ViewStates.Length != eyeViewStateCount)
            {
                ViewStates = new View[eyeViewStateCount];
            }
            
            CheckResult(Xr.LocateView(Session, in viewLocateInfo, ref viewState, ref eyeViewStateCount, ViewStates));

            for (var eye = 0; eye < 2; eye++)
            {
                var view = ViewStates[eye];
                Projections[eye] = view.Fov.ToProjection();
                RawViews[eye] = view.Pose;
            }
        }

        private unsafe void EndFrame(in FrameState frameState)
        {
            var frameEndInfo = new FrameEndInfo
            (
                displayTime: frameState.PredictedDisplayTime,
                environmentBlendMode: EnvironmentBlendMode.Opaque
            );

            if ((Bool32) frameState.ShouldRender)
            {
                var projectionLayerViews = stackalloc CompositionLayerProjectionView[2];
                var projectionLayer = new CompositionLayerProjection
                (
                    viewCount:2,
                    views:projectionLayerViews,
                    space:ReferenceSpace
                );

                var layerPointer = (CompositionLayerBaseHeader*) &projectionLayer;
                for (var eye = 0; eye < 2; eye++)
                {
                    ref var layerView = ref projectionLayerViews[eye];
                    layerView.SubImage.Swapchain = Swapchain;
                    layerView.SubImage.ImageRect.Extent = new
                    (
                        (int) _game.System.RenderTargetSize.X / 2,
                        (int) _game.System.RenderTargetSize.Y
                    );

                    layerView.SubImage.ImageRect.Offset.X = (int)(_game.System.RenderTargetSize.X / 2) * eye;
                    layerView.Fov = ViewStates[eye].Fov;
                    layerView.Pose = ViewStates[eye].Pose;
                    Debug.WriteLine($"FOV: {Unsafe.As<Fovf, Vector4>(ref layerView.Fov)}");
                    Debug.WriteLine($"Pose Pos: {Unsafe.As<Vector3f, Vector3>(ref layerView.Pose.Position)}");
                    Debug.WriteLine($"Pose Orientation: {Unsafe.As<Quaternionf, Quaternion>(ref layerView.Pose.Orientation)}");
                }

                frameEndInfo.LayerCount = 1;
                frameEndInfo.Layers = &layerPointer;
            }

            CheckResult(Xr.EndFrame(Session, in frameEndInfo));
        }

        public void Run() => _view.Run();

        private void ReleaseUnmanagedResources()
        {
            if (_unmanagedResourcesFreed)
            {
                return;
            }

            CheckResult(Xr.DestroySwapchain(Swapchain));
            CheckResult(Xr.DestroySpace(ReferenceSpace));
            CheckResult(Xr.DestroySession(Session));
            
            Gl.DeleteFramebuffer(Framebuffers.Framebuffer);
            Gl.DeleteRenderbuffer(Framebuffers.Renderbuffer);
            
            _unmanagedResourcesFreed = true;
        }

        private void Dispose(bool disposing)
        {
            ReleaseUnmanagedResources();
            if (disposing)
            {
                _view.Dispose();
                Gl.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Renderer()
        {
            Dispose(false);
        }
    }
}
