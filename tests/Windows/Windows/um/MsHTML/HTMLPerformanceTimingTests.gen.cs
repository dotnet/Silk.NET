// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLPerformanceTiming"/> struct.</summary>
public static unsafe partial class HTMLPerformanceTimingTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLPerformanceTiming"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLPerformanceTiming).GUID, Is.EqualTo(IID_HTMLPerformanceTiming));
    }

    /// <summary>Validates that the <see cref = "HTMLPerformanceTiming"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLPerformanceTiming>(), Is.EqualTo(sizeof(HTMLPerformanceTiming)));
    }

    /// <summary>Validates that the <see cref = "HTMLPerformanceTiming"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLPerformanceTiming).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLPerformanceTiming"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLPerformanceTiming), Is.EqualTo(1));
    }
}