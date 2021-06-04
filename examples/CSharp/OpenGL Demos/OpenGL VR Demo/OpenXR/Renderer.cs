// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
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
        private IView _view;
        private OpenGLXRGame _game;
        
        // OpenXR handles
        public Session Session;
        public Space ReferenceSpace;
        
        public GL Gl { get; private set; }
        public XR Xr { get; init; }
        public bool IsStage { get; private set; }

        public Renderer(OpenGLXRGame game)
        {
            _game = game;

            Xr = game.Xr;
            
            var opts = ViewOptions.Default;
            opts.VSync = false;
            opts.FramesPerSecond = 0;
            opts.PreferredBitDepth = new(8, 8, 8, 8);
            opts.PreferredDepthBufferBits = 24;
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
        }

        public event Action<Renderer>? Load;
        public event Action<double>? Render;
        public event Action? Unload;
        
        private void ViewOnLoad()
        {
            Gl = _view.CreateOpenGL();
            Load?.Invoke(this);
        }

        private unsafe void PrepareSession()
        {
            var binding = _game.IsGles ? _view.CreateOpenGLESBinding() : _view.CreateOpenGLBinding();
            var sessionCreateInfo = new SessionCreateInfo(systemId: _game.System.Id, next: &binding);
            CheckResult(Xr.CreateSession(_game.Instance, in sessionCreateInfo, ref Session));

            // Now, let's create the reference space that describes the real-world environment where the VR game is
            // being played.
            
            // First we need to check what kinds of spaces we have. OpenXR (OOTB) has:
            // - view, where the content doesn't take into account eye orientation.
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

            CheckResult(Xr.CreateReferenceSpace(Session, in refSpaceCreateInfo, ref ReferenceSpace));
            
            // Next up, the swapchain.
        }

        public void Run() => _view.Run();

    }
}
