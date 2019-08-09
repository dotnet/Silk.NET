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
        private EGLConfig _config;
        private AutoResetEvent _runEvent;
        private ISurfaceHolder _holder;
        private VSyncMode _vsync;

        private static readonly int[] Attribs =
        {
            EGL14.EglSurfaceType, EGL14.EglWindowBit,
            EGL14.EglBlueSize, 8,
            EGL14.EglGreenSize, 8,
            EGL14.EglRedSize, 8,
            EGL14.EglNone
        };

        // IWindow
        public bool IsVisible { get; set; }
        public bool UseSingleThreadedWindow { get; }

        public Point Position
        {
            get => default;
            set { }
        }

        public unsafe Size Size
        {
            get => Handle == IntPtr.Zero
                ? new Size(Android.GetWidth(_windowPtr), Android.GetHeight(_windowPtr))
                : default;
            set { }
        }

        /// <inheritdoc />
        public double FramesPerSecond
        {
            get => 1.0 / _renderPeriod;
            set
            {
                if (value <= double.Epsilon)
                {
                    _renderPeriod = 0.0;
                    return;
                }

                _renderPeriod = 1.0 / value;
            }
        }

        /// <inheritdoc />
        public double UpdatesPerSecond
        {
            get => 1.0 / _updatePeriod;
            set
            {
                if (value <= double.Epsilon)
                {
                    _updatePeriod = 0.0;
                    return;
                }

                _updatePeriod = 1.0 / value;
            }
        }

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

        public VSyncMode VSync
        {
            get => _vsync;
            set
            {
                if (_running)
                {
                    switch (value)
                    {
                        case VSyncMode.Off:
                        {
                            EGL14.EglSwapInterval(_display, 0);
                            break;
                        }
                        case VSyncMode.On:
                        {
                            EGL14.EglSwapInterval(_display, 1);
                            break;
                        }
                        case VSyncMode.Adaptive:
                        {
                            EGL14.EglSwapInterval(_display, IsRunningSlowly ? 0 : 1);
                            break;
                        }
                        default:
                            throw new ArgumentOutOfRangeException(nameof(value), value, null);
                    }
                }

                _vsync = value;
            }
        }

        public int RunningSlowTolerance { get; set; }
        public event Action<Point> Move; // never called
        public event Action<Size> Resize;
        public event Action Closing;
        public event Action<WindowState> StateChanged; // never called
        public event Action<bool> FocusChanged; // todo
        public event Action<string[]> FileDrop; // never called
        public event Action Load;
        public event Action<double> Update;
        public event Action<double> Render;
        unsafe IntPtr IWindow.Handle => (IntPtr) _windowPtr;
        public bool IsRunningSlowly => _isRunningSlowlyTries > RunningSlowTolerance;

        public unsafe void Run()
        {
            _running = true;
            _runEvent.WaitOne();
            _windowPtr = Android.CreateNativeWindow(JNIEnv.Handle, _holder.Surface.Handle);
            _invokeQueue = new ConcurrentQueue<Task>();
            _mainThread = Thread.CurrentThread.ManagedThreadId;
            if ((_display = EGL14.EglGetDisplay(EGL14.EglDefaultDisplay)) == EGL14.EglNoDisplay)
            {
                throw new EglException("Couldn't get the default display, error code " + EGL14.EglGetError());
            }

            if (!EGL14.EglInitialize(_display, null, 0, null, 0))
            {
                throw new EglException("Couldn't initialize, error code " + EGL14.EglGetError());
            }

            var configs = new EGLConfig[1];
            var numConfigs = new int[1];
            if (!EGL14.EglChooseConfig(_display, Attribs, 0, configs, 0, 1, numConfigs, 0))
            {
                throw new EglException("Couldn't choose config, error code " + EGL14.EglGetError());
            }

            _config = configs[0];

            var formats = new int[1];
            if (!EGL14.EglGetConfigAttrib(_display, _config, EGL14.EglNativeVisualId, formats, 0))
            {
                throw new EglException("Couldn't get config attribute, error code " + EGL14.EglGetError());
            }

            Android.SetBuffersGeometry(_windowPtr, 0, 0, formats[0]);
            var win = new Java.Lang.Object((IntPtr) _windowPtr, JniHandleOwnership.DoNotTransfer);

            if ((_surface = EGL14.EglCreateWindowSurface(_display, _config, win, null, 0)) == EGL14.EglNoSurface)
            {
                throw new EglException("Couldn't create surface, error code " + EGL14.EglGetError());
            }

            if ((_context = EGL14.EglCreateContext(_display, _config, EGL14.EglNoContext, null, 0)) ==
                EGL14.EglNoContext)
            {
                throw new EglException("Couldn't create context, error code " + EGL14.EglGetError());
            }

            if (!EGL14.EglMakeCurrent(_display, _surface, _surface, _context))
            {
                throw new EglException("Couldn't make context current, error code " + EGL14.EglGetError());
            }

            VSync = _vsync; // inform EGL about the VSync preference

            // Run OnLoad.
            Load?.Invoke();

            // Initialize some variables
            _isRunningSlowlyTries = 0;

            _renderStopwatch = new Stopwatch();
            _updateStopwatch = new Stopwatch();

            _mainThread = Thread.CurrentThread.ManagedThreadId;

            // Start the update loop.
            while (!_windowShouldClose)
            {
                if (UseSingleThreadedWindow)
                {
                    RaiseUpdateFrame();
                    RaiseRenderFrame();
                }
                else
                {
                    // Raise UpdateFrame, but don't await it yet.
                    var task = Task.Run((Action) RaiseUpdateFrame); // cast to action, ambiguous call

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
                    EGL14.EglSwapInterval(_display, IsRunningSlowly ? 0 : 1);
                }
            }

            EGL14.EglDestroyContext(_display, _context);
            EGL14.EglDestroySurface(_display, _surface);
            EGL14.EglTerminate(_display);
            Android.ReleaseNativeWindow(_windowPtr);
            _holder.Surface.Release();
            _running = false;
        }

        public void Close()
        {
            _windowShouldClose = true;
        }

        public Point PointToClient(Point point)
        {
            return point;
        }

        public Point PointToScreen(Point point)
        {
            return point;
        }

        public object Invoke(Delegate d)
        {
            return Invoke(d, new object[0]);
        }

        public object Invoke(Delegate d, params object[] args)
        {
            if (!_running)
            {
                throw new InvalidOperationException("The window must be running to be able to invoke it.");
            }

            if (Thread.CurrentThread.ManagedThreadId == _mainThread)
            {
                return d.DynamicInvoke(args);
            }

            var task = new Task<object>(() => d.DynamicInvoke(args));
            _invokeQueue.Enqueue(task);
            SpinWait.SpinUntil(() => task.IsCompleted);
            return task.Result;
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
            if (!EGL14.EglSwapBuffers(_display, _surface))
            {
                throw new EglException("Couldn't swap buffers, error code " + EGL14.EglGetError());
            }

            _renderStopwatch.Restart();

            // This has to be called on the thread with the graphics context
            if (VSync == VSyncMode.Adaptive)
            {
                EGL14.EglSwapInterval(EGL14.EglGetCurrentDisplay(), IsRunningSlowly ? 0 : 1);
            }
        }

        // SurfaceView
        void IDisposable.Dispose()
        {
        }

        public void SurfaceChanged(ISurfaceHolder holder, Format format, int width, int height)
        {
            Resize?.Invoke(new Size(width, height));
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            _holder = holder;
            _runEvent.Set();
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            _windowShouldClose = true;
            Closing?.Invoke();
        }

        public AndroidWindow(Context context, WindowOptions opts) : base(context)
        {
            _runEvent = new AutoResetEvent(false);
            UseSingleThreadedWindow = opts.UseSingleThreadedWindow;
            RunningSlowTolerance = opts.RunningSlowTolerance;
            _vsync = opts.VSync;
            API = opts.API;
        }
    }

    public class EglException : Exception
    {
        public EglException(string str) : base(str)
        {
        }
    }
}
