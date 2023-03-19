// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace Silk.NET.Input
{
    /// <summary>
    /// An interface representing a keyboard.
    /// </summary>
    public interface IKeyboard : IInputDevice
    {
        /// <summary>
        /// The keys this keyboard has available.
        /// </summary>
        IReadOnlyList<Key> SupportedKeys { get; }
        
        /// <summary>
        /// The text currently in the clipboard.
        /// </summary>
        string ClipboardText { get; set; }

        /// <summary>
        /// Checks if a specific key is pressed.
        /// </summary>
        /// <param name="key">The key to check.</param>
        /// <returns>Whether or not the key is pressed.</returns>
        bool IsKeyPressed(Key key);

        /// <summary>
        /// Checks if a specific scancode is pressed.
        /// </summary>
        /// <param name="scancode">The scancode to check.</param>
        /// <returns>Whether or not the scancode is pressed.</returns>
        bool IsScancodePressed(int scancode);

        /// <summary>
        /// Called when a key is pressed.
        /// </summary>
        event Action<IKeyboard, Key, int>? KeyDown;

        /// <summary>
        /// Called when a key is released.
        /// </summary>
        event Action<IKeyboard, Key, int>? KeyUp;

        /// <summary>
        /// Called when a character is received.
        /// </summary>
        event Action<IKeyboard, char>? KeyChar;

        /// <summary>
        /// Begins taking keyboard input. Required on mobile, where keyboard input is usually delivered via an on-screen
        /// keyboard.
        /// Not required on desktop (it does nothing), but recommended to ensure easy porting to other platforms.
        /// </summary>
        /// <seealso cref="EndInput"/>
        void BeginInput();

        /// <summary>
        /// Ends taking keyboard input. Required on mobile, where this method closes the on-screen keyboard.
        /// Not required on desktop (it does nothing), but recommended to ensure easy porting to other platforms.
        /// </summary>
        /// <seealso cref="BeginInput"/>
        void EndInput();
    }
}
