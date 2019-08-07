// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Android.Content;
using Android.Graphics;
using Android.Opengl;
using Android.Runtime;
using Android.Views;
using Silk.NET.Windowing.Common;
using static Android.Opengl.EGL14;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace Silk.NET.Windowing.Android
{
    [Register("uk/co/ultz/SilkDotNet/AndroidWindow")]
    public class AndroidWindow : SurfaceView, IWindow, ISurfaceHolderCallback
    {
        private bool _running;
        private bool _windowShouldClose;
        private ConcurrentQueue<Task> _invokeQueue;
        private int _mainThread;
        private int _isRunningSlowlyTries;
        private Stopwatch _renderStopwatch;
        private Stopwatch _updateStopwatch;
        private unsafe ANativeWindow* _windowPtr;
        private EGLContext _context;
        private double _updatePeriod;
        private double _renderPeriod;
        private EGLDisplay _display;
        private EGLSurface _surface;
        private static readonly int[] _attribs = {
            EglSurfaceType, EglWindowBit,
            EglBlueSize, 8,
            EglGreenSize, 8,
            EglRedSize, 8,
            EglNone
        };

        private EGLConfig _config;


        // IWindow
        public bool IsVisible { get; set; }
        public bool UseSingleThreadedWindow { get; }
        public Point Position
        {
            get => default;
            set {}
        }

        public unsafe Size Size
        {
            get => Handle == IntPtr.Zero ? new Size(Android.GetWidth(_windowPtr), Android.GetHeight(_windowPtr)) : default;
            set { }
        }

        public double FramesPerSecond { get; set; }
        public double UpdatesPerSecond { get; set; }
        public GraphicsAPI API { get; }
        public string Title { get; set; }

        public WindowState WindowState
        {
            get => WindowState.Fullscreen;
            set { }
        }

        public WindowBorder WindowBorder
        {
            get => WindowBorder.Hidden;
            set { }
        }

        public VSyncMode VSync { get; set; }
        public int RunningSlowTolerance { get; set; }
        public event Action<Point> Move;
        public event Action<Size> Resize;
        public event Action Closing;
        public event Action<WindowState> StateChanged;
        public event Action<bool> FocusChanged;
        public event Action<string[]> FileDrop;
        public event Action Load;
        public event Action<double> Update;
        public event Action<double> Render;
        public unsafe IntPtr Handle => (IntPtr) _windowPtr;
        public bool IsRunningSlowly { get; }
        public unsafe void Run()
        {
            _running = true;

            _invokeQueue = new ConcurrentQueue<Task>();
            _mainThread = Thread.CurrentThread.ManagedThreadId;
            if ((_display = EglGetDisplay(EglDefaultDisplay)) == EglNoDisplay)
            {
                throw new EglException("Couldn't get the default display, error code " + EglGetError());
            }

            if (!EglInitialize(_display, null, 0, null, 0))
            {
                throw new EglException("Couldn't initialize, error code " + EglGetError());
            }

            var configs = new EGLConfig[1];
            var numConfigs = new int[1];
            if (!EglChooseConfig(_display, _attribs, 0, configs, 0, 1, numConfigs, 0)) {
                throw new EglException("Couldn't choose config, error code " + EglGetError());
            }

            _config = configs[0];

            var formats = new int[1];
            if (!EglGetConfigAttrib(_display, _config, EglNativeVisualId, formats, 0)) {
                throw new EglException("Couldn't get config attribute, error code " + EglGetError());
            }

            Android.SetBuffersGeometry(_windowPtr, 0, 0, formats[0]);
            var win = new Java.Lang.Object((IntPtr)_windowPtr, JniHandleOwnership.DoNotTransfer);

            if ((_surface = EglCreateWindowSurface(_display, _config, win, null, 0)) == EglNoSurface) {
                throw new EglException("Couldn't create surface, error code " + EglGetError());
            }
    
            if ((_context = EglCreateContext(_display, _config, EglNoContext, null, 0)) == EglNoContext) {
                throw new EglException("Couldn't create context, error code " + EglGetError());
            }
    
            if (!EglMakeCurrent(_display, _surface, _surface, _context)) {
                throw new EglException("Couldn't make context current, error code " + EglGetError());
            }
            
            // todo vsync

            InitializeCallbacks();

            // Run OnLoad.
            Load?.Invoke();

            // Initialize some variables
            _isRunningSlowlyTries = 0;

            _renderStopwatch = new Stopwatch();
            _updateStopwatch = new Stopwatch();

            _mainThread = Thread.CurrentThread.ManagedThreadId;

            // Start the update loop.
            while (!_windowShouldClose && !AndroidPlatform.Activity.IsFinishing)
            {
                // TODO events
                
                if (UseSingleThreadedWindow)
                {
                    RaiseUpdateFrame();
                    RaiseRenderFrame();
                }
                else
                {
                    // Raise UpdateFrame, but don't await it yet.
                    var task = Task.Run((Action)RaiseUpdateFrame); // cast to action, ambiguous call

                    // Loop while we're still updating - the Update thread might be calling the main thread
                    while (!task.IsCompleted)
                    {
                        if (!_invokeQueue.IsEmpty && _invokeQueue.TryDequeue(out var invokeCall))
                        {
                            invokeCall.GetAwaiter().GetResult();
                        }
                    }

                    // Raise render.
                    RaiseRenderFrame();
                }

                if (VSync == VSyncMode.Adaptive)
                {
                    EglSwapInterval(_display, IsRunningSlowly ? 0 : 1);
                }
            }

            _running = false;
        }

        private void InitializeCallbacks()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public Point PointToClient(Point point)
        {
            throw new NotImplementedException();
        }

        public Point PointToScreen(Point point)
        {
            throw new NotImplementedException();
        }

        public object Invoke(Delegate d)
        {
            throw new NotImplementedException();
        }

        public object Invoke(Delegate d, params object[] args)
        {
            throw new NotImplementedException();
        }
        
        // Implementation
        
        /// <summary>
        /// Run an OnUpdate event.
        /// </summary>
        private void RaiseUpdateFrame()
        {
            // If using a capped framerate without vsync, we have to do some synchronization-related things
            // before rendering.
            if (UpdatesPerSecond > double.Epsilon
                && (VSync == VSyncMode.Off || VSync == VSyncMode.Adaptive && IsRunningSlowly))
            {
                // Calculate the amount of time to sleep.
                var sleepTime = _updatePeriod - _updateStopwatch.Elapsed.TotalSeconds;

                // If the result is negative, that means the frame is running slowly. Mark as such and don't sleep.
                if (sleepTime < 0.0)
                {
                    _isRunningSlowlyTries += 1;
                }
                // Else, sleep for that amount of time.
                else
                {
                    _isRunningSlowlyTries = 0;
                    Thread.Sleep((int) (1000 * sleepTime));
                }
            }

            // Calculate delta and run frame.
            var delta = _updateStopwatch.Elapsed.TotalSeconds;
            Update?.Invoke(delta);
            _updateStopwatch.Restart();
        }

        /// <summary>
        /// Run an OnRender event.
        /// </summary>
        private void RaiseRenderFrame()
        {
            // Identical to RaiseUpdateFrame.
            if (FramesPerSecond > double.Epsilon
                && (VSync == VSyncMode.Off || VSync == VSyncMode.Adaptive && IsRunningSlowly))
            {
                var sleepTime = _renderPeriod - _renderStopwatch.Elapsed.TotalSeconds;

                if (sleepTime > 0.0)
                {
                    Thread.Sleep((int) (1000 * sleepTime));
                }
            }

            var delta = _renderStopwatch.Elapsed.TotalSeconds;
            Render?.Invoke(delta);
            if (!EglSwapBuffers(_display, _surface))
            {
                throw new EglException("Couldn't swap buffers, error code " + EglGetError());
            }
            _renderStopwatch.Restart();

            // This has to be called on the thread with the graphics context
            if (VSync == VSyncMode.Adaptive)
            {
                EglSwapInterval(EglGetCurrentDisplay(), IsRunningSlowly ? 0 : 1);
            }
        }
        
        // SurfaceView
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SurfaceChanged(ISurfaceHolder holder, Format format, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            throw new NotImplementedException();
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            throw new NotImplementedException();
        }

        [Register(".ctor", "(Landroid/content/Context;)V", "")]
        public AndroidWindow(Context context, WindowOptions opts) : base(context)
        {
            // todo opts
        }
    }

    public class EglException : Exception
    {
        public EglException(string str) : base(str){}
    }
}
