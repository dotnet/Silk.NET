// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Sourced from https://github.com/john-h-k/SpinLockSlim under the MIT license

// MIT License
// 
// Copyright (c) 2019 John Kelly
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// ReSharper disable RedundantAssignment

namespace Silk.NET.Core
{
    /// <summary>
    /// Provided a lightweight spin lock for synchronization in high performance
    /// scenarios with a low hold time
    /// </summary>
    /// <remarks>
    /// This lock is very performant, but it is very dangerous (hence breakneck).
    /// It's recommended to use the framework-provided locks where possible.
    /// </remarks>
    public struct BreakneckLock
    {
        private static int True => 1;
        private static int False => 0;

        private const MethodImplOptions MaxOpt = (MethodImplOptions) 768;

        private volatile int _acquired; // either 1 or 0

        /// <summary>
        /// Creates a new <see cref="BreakneckLock"/>
        /// </summary>
        /// <returns>A new <see cref="BreakneckLock"/></returns>
        [MethodImpl(MaxOpt)]
        public static BreakneckLock Create() => new();

        /// <summary>
        /// Returns <c>true</c> if the lock is acquired, else <c>false</c>
        /// </summary>
#pragma warning disable 420 // Unsafe.As<,> doesn't read the reference so the lack of volatility is not an issue, but we do need to treat the returned reference as volatile
        public bool IsAcquired => Volatile.Read(ref Unsafe.As<int, bool>(ref _acquired));
#pragma warning restore 420

        /// <summary>
        /// Enter the lock. If this method returns, <paramref name="taken"/>
        /// will be <c>true</c>. If an exception occurs, <paramref name="taken"/> will indicate
        /// whether the lock was taken and needs to be released using <see cref="Exit()"/>.
        /// This method may never exit
        /// </summary>
        /// <param name="taken">A reference to a bool that indicates whether the lock is taken. Must
        /// be <c>false</c> when passed, else the internal state or return state may be corrupted.
        /// If the method returns, this is guaranteed to be <c>true</c></param>
        [MethodImpl(MaxOpt)]
        public void Enter(ref bool taken)
        {
            // while acquired == 1, loop, then when it == 0, exit and set it to 1
            while (!TryAcquire())
            {
                // NOP
            }

            taken = true;
        }

        /// <summary>
        /// Enter the lock if it not acquired, else, do not. <paramref name="taken"/> will be
        /// <c>true</c> if the lock was taken, else <c>false</c>. If <paramref name="taken"/> is
        /// <c>true</c>, <see cref="Exit()"/> must be called to release it, else, it must not be called
        /// </summary>
        /// <param name="taken">A reference to a bool that indicates whether the lock is taken. Must
        /// be <c>false</c> when passed, else the internal state or return state may be corrupted</param>
        [MethodImpl(MaxOpt)]
        public void TryEnter(ref bool taken)
        {
            taken = TryAcquire();
        }

        /// <summary>
        /// Try to safely enter the lock a certain number of times (<paramref name="iterations"/>).
        /// <paramref name="taken"/> will be <c>true</c> if the lock was taken, else <c>false</c>.
        /// If <paramref name="taken"/> is <c>true</c>, <see cref="Exit()"/> must be called to release
        /// it, else, it must not be called
        /// </summary>
        /// <param name="taken">A reference to a bool that indicates whether the lock is taken. Must
        /// be <c>false</c> when passed, else the internal state or return state may be corrupted</param>
        /// <param name="iterations">The number of attempts to acquire the lock before returning
        /// without the lock</param>
        [MethodImpl(MaxOpt)]
        public void TryEnter(ref bool taken, uint iterations)
        {
            // if it acquired == 0, change it to 1 and return true, else return false
            while (!TryAcquire())
            {
                if (unchecked(iterations--) == 0) // postfix decrement, so no issue if iterations == 0 at first
                {
                    return;
                }
            }

            taken = true;
        }

        /// <summary>
        /// Try to safely enter the lock for a certain <see cref="TimeSpan"/> (<paramref name="timeout"/>).
        /// <paramref name="taken"/> will be <c>true</c> if the lock was taken, else <c>false</c>.
        /// If <paramref name="taken"/> is <c>true</c>, <see cref="Exit()"/> must be called to release
        /// it, else, it must not be called
        /// </summary>
        /// <param name="taken">A reference to a bool that indicates whether the lock is taken. Must
        /// be <c>false</c> when passed, else the internal state or return state may be corrupted</param>
        /// <param name="timeout">The <see cref="TimeSpan"/> to attempt to acquire the lock for before
        /// returning without the lock. A negative <see cref="TimeSpan"/>will cause undefined behaviour</param>
        [MethodImpl(MaxOpt)]
        public void TryEnter(ref bool taken, TimeSpan timeout)
        {
            long start = Stopwatch.GetTimestamp();
            long end = unchecked((long)timeout.TotalMilliseconds * Stopwatch.Frequency + start);

            // if it acquired == 0, change it to 1 and return true, else return false
            while (!TryAcquire())
            {
                if (Stopwatch.GetTimestamp() >= end)
                {
                    return;
                }
            }

            taken = true;
        }

        /// <summary>
        /// Exit the lock. This method is dangerous and must be called only once the caller is sure they have
        /// ownership of the lock.
        /// </summary>
        [MethodImpl(MaxOpt)]
        public void Exit()
        {
            // release the lock - int32 write will always be atomic
            _acquired = False;
        }

        /// <summary>
        /// Exit the lock with an optional post-release memory barrier. This method is dangerous and must be called only
        /// once the caller is sure they have ownership of the lock.
        /// </summary>
        /// <param name="insertMemBarrier">Whether a memory barrier should be inserted after the release</param>
        [MethodImpl(MaxOpt)]
        public void Exit(bool insertMemBarrier)
        {
            Exit();

            if (insertMemBarrier)
                Thread.MemoryBarrier();
        }

        /// <summary>
        /// Exit the lock with a post-release memory barrier. This method is dangerous and must be called only once the
        /// caller is sure they have ownership of the lock.
        /// </summary>
        [MethodImpl(MaxOpt)]
        public void ExitWithBarrier()
        {
            Exit();
            Thread.MemoryBarrier();
        }

        [MethodImpl(MaxOpt)]
        private bool TryAcquire()
        {
            // if it acquired == 0, change it to 1 and return true, else return false
            return Interlocked.CompareExchange(ref _acquired, True, False) == False;
        }
    }
}
