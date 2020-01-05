// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// An interface that provides windowing for its respective native backend.
    /// </summary>
    public interface IWindowPlatform
    {
        bool IsViewOnly { get; }
        
        /// <summary>
        /// Gets a value indicating whether this <see cref="IWindowPlatform"/> should be used, based on the
        /// current runtime/environment.
        /// </summary>
        bool IsApplicable { get; }

        /// <summary>
        /// Creates a window with the given options.
        /// </summary>
        /// <param name="options">The initial settings this window should open with.</param>
        /// <returns>An implementation of <see cref="IWindow"/></returns>
        IWindow GetWindow(WindowOptions options);

        /// <summary>
        /// Gets or creates a window view.
        /// On desktop platforms, this mimics GetWindow unless you pass null to the opts parameter. In which case,
        /// this will return the last created window.
        /// On mobile platforms, this will create a view for the given platform if one doesn't exist, or 
        /// </summary>
        /// <param name="opts"></param>
        /// <returns></returns>
        IView GetView(ViewOptions? opts = null);
    }
}
