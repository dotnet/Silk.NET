// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Core.UnitTests;

public class BreakneckRequestTests
{
    [Test]
    public void NoParams()
    {
        var req = new BreakneckRequest<int>();

        // Simulate an overflow.
        Unsafe.As<BreakneckRequest<int>, int>(ref req) = int.MaxValue - 8;
        Unsafe.Add(ref Unsafe.As<BreakneckRequest<int>, int>(ref req), 1) = int.MaxValue - 8;

        var barrier = new Barrier(5);
        var rspCnt = 0;
        for (var i = 0; i < 4; i++)
        {
            // var i1 = i;
            new Thread(() =>
            {
                barrier.SignalAndWait();
                for (int j = 0; j < 4; j++)
                {
                    // Console.WriteLine($"Requesting for {i1}");
                    if (req.Request() == 69)
                    {
                        // Console.WriteLine($"Got response for {i1}.");
                        Interlocked.Increment(ref rspCnt);
                    }
                }
            })
            {
                IsBackground = true,
            }.Start();
        }

        barrier.SignalAndWait();
        var misses = 0;
        bool missed;
        for (var i = 0; i < 16; i += missed ? 0 : 1)
        {
            if (!req.IsRequested && misses <= int.MaxValue - 1)
            {
                misses++;
                missed = true;
                continue;
            }
            Assert.That(req.IsRequested, Is.True);
            misses = 0;
            missed = false;
            // Console.WriteLine("providing");
            req.Provide(69);
        }

        Thread.Sleep(50);
        Assert.That(rspCnt, Is.EqualTo(16));
        Assert.That(req.IsRequested, Is.False);
    }

    [Test]
    public void Params()
    {
        var req = new BreakneckRequest<int, int>();

        // Simulate an overflow.
        Unsafe.As<BreakneckRequest<int, int>, int>(ref req) = int.MaxValue - 8;
        Unsafe.Add(ref Unsafe.As<BreakneckRequest<int, int>, int>(ref req), 1) = int.MaxValue - 8;

        var barrier = new Barrier(5);
        var rspCnt = 0;
        for (var i = 0; i < 4; i++)
        {
            var i1 = i;
            new Thread(() =>
            {
                barrier.SignalAndWait();
                for (var j = 0; j < 4; j++)
                {
                    // Console.WriteLine($"Requesting for {i1}");
                    if (req.Request(i1) == i1)
                    {
                        // Console.WriteLine($"Got response for {i1}.");
                        Interlocked.Increment(ref rspCnt);
                    }
                }
            })
            {
                IsBackground = true,
            }.Start();
        }

        barrier.SignalAndWait();
        var misses = 0;
        bool missed;
        for (var i = 0; i < 16; i += missed ? 0 : 1)
        {
            var isRequested = req.TryGetRequest(out var echo);
            if (!isRequested && misses <= int.MaxValue - 1)
            {
                misses++;
                missed = true;
                continue;
            }
            Assert.That(isRequested, Is.True);
            misses = 0;
            missed = false;
            // Console.WriteLine("providing");
            req.Provide(echo);
        }

        Thread.Sleep(50);
        Assert.That(rspCnt, Is.EqualTo(16));
        Assert.That(req.TryGetRequest(out _), Is.False);
    }
}
