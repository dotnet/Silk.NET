// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Silk.NET.SilkTouch.Utility
{
    /// <summary>
    /// Class that provides some simple functions for displaying a progress bar for the generator
    /// </summary>
    public static class ProgressBarUtility
    {
        /// <summary>
        /// Are these Presentation commands not functional on this system
        /// </summary>
        public static bool IsNotAvailable =>
            Console.IsOutputRedirected || Console.IsErrorRedirected;

        /// <summary>
        /// The Generators current log level
        /// </summary>
        public static LogLevel CurrentLogLevel = LogLevel.Information;

        /// <summary>
        /// Whether the progress bar is showing
        /// </summary>
        public static bool IsShowing => showing;

        private static int remove = 1;

        private static bool showing = false;
        private static float currentPercentage;

        /// <summary>
        /// Shows a progress bar as the last line of the console
        /// Use RemoveLastLine before writing anything thing else in the console
        /// </summary>
        /// <param name="logLevel">log level intended to show at</param>
        /// <return>original console position</return>
        public static void Show(LogLevel logLevel)
        {
            if (IsNotAvailable || CurrentLogLevel < logLevel || showing)
                return;

            Interlocked.Decrement(ref remove);
            if (remove > 0)
                return;
            Interlocked.Exchange(ref remove, 0);

            showing = true;
            rewrite();
        }

        /// <summary>
        /// Clears last line of the console and moves to the end of the previous line
        /// </summary>
        /// <param name="logLevel">log level intended to show at</param>
        public static void Hide(LogLevel logLevel)
        {
            if (IsNotAvailable || CurrentLogLevel < logLevel || !showing)
                return;

            showing = false;

            Interlocked.Increment(ref remove);

            (int count, int line) = Console.GetCursorPosition();

            Console.SetCursorPosition(0, line);
            Console.Write(new string(' ', count));
            Console.SetCursorPosition(0, line);
        }

        /// <summary>
        /// Sets the current progress bar percentage
        /// </summary>
        /// <param name="percentage"></param>
        public static void SetPercentage(float percentage)
        {
            currentPercentage = percentage;

            if (showing)
            {
                rewrite();
            }
        }

        private static void rewrite()
        {
            Console.SetCursorPosition(0, Console.GetCursorPosition().Top);
            Console.Write(
                $"({GetProgressBarByPercent(currentPercentage)}) ({(currentPercentage * 100).ToString("F2")}%)"
            );
        }

        private static string GetProgressBarByPercent(float percent) =>
            new string('|', (int)(percent * 25)) + new string('-', 25 - (int)(percent * 25));
    }
}
