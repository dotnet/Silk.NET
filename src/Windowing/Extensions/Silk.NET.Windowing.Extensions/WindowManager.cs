using System;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.Core.Platform;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Extensions
{
    /// <summary>
    /// Contains APIs for managing multiple windows within one render loop.
    /// </summary>
    public class WindowManager : IDisposable
    {
        private object _syncRoot = new object();

        /// <summary>
        /// The windows managed by this instance.
        /// </summary>
        // ReSharper disable once ReturnTypeCanBeEnumerable.Global
        public ICollection<IWindow> Windows { get; } = new List<IWindow>();

        /// <summary>
        /// Gets or sets a value indicating whether this manager's render loop is active.
        /// </summary>
        public bool IsRunning { get; set; }

        /// <summary>
        /// Gets the window with a context current on this thread.
        /// </summary>
        /// <returns>The window with a context current on this thread.</returns>
        public IWindow GetCurrent() => Windows.FirstOrDefault(x => x.IsCurrentContext);

        /// <summary>
        /// Adds a window to this manager.
        /// </summary>
        /// <param name="window">The window to add.</param>
        public void AddWindow(IWindow window) { lock (_syncRoot) { Windows.Add(window); } }

        /// <summary>
        /// Removes the given window from this manager.
        /// </summary>
        /// <param name="window">The window to remove.</param>
        /// <returns>
        /// Whether the removal was successful or not. One reason why this might return false is that the given window
        /// isn't being managed by this manager.
        /// </returns>
        public bool RemoveWindow(IWindow window) { lock (_syncRoot) { return Windows.Remove(window); } }

        /// <summary>
        /// Creates a window and adds it to this manager.
        /// </summary>
        /// <param name="opts">The options to initialize the new window with.</param>
        /// <param name="host">
        /// The window host to use. If null, the current windowing platform will be
        /// fetched using the <see cref="SilkManager"/>.
        /// </param>
        public void CreateWindow(WindowOptions opts, IWindowHost host = null)
            => AddWindow((host ?? SilkManager.Get<IWindowPlatform>()).CreateWindow(opts));

        /// <summary>
        /// Executes a render loop encompassing all windows within this manager.
        /// </summary>
        /// <param name="open">Indicates whether the window manager should open the child windows.</param>
        public void Run(bool open = true)
        {
            IsRunning = true;
            if (open)
            {
                lock (_syncRoot)
                {
                    foreach (var window in Windows)
                    {
                        window.Initialize();
                    }
                }
            }

            var removals = new List<IWindow>();
            while (IsRunning)
            {
                lock (_syncRoot)
                {
                    foreach (var window in Windows)
                    {
                        if (window.IsClosing)
                        {
                            removals.Add(window);
                        }

                        if (window.API.API == ContextAPI.OpenGL || window.API.API == ContextAPI.OpenGLES)
                        {
                            window.MakeCurrent();
                        }

                        window.DoEvents();
                        window.DoUpdate();
                        window.DoRender();
                    }

                    foreach (var window in removals)
                    {
                        Windows.Remove(window);
                        window.Reset();
                    }
                }
            }

            IsRunning = false;
        }

        /// <summary>
        /// Stops the manager's render loop. This doesn't do anything to the windows managed by it.
        /// </summary>
        public void Stop()
        {
            IsRunning = false;
        }

        /// <summary>
        /// Restarts this manager's render loop without reopening the windows.
        /// </summary>
        public void Restart()
        {
            Run(false);
        }

        /// <summary>
        /// Closes all windows managed by this manager.
        /// </summary>
        public void CloseAll()
        {
            lock (_syncRoot)
            {
                foreach (var window in Windows)
                {
                    window.Close();
                }
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            IsRunning = false;
        }
    }
}
