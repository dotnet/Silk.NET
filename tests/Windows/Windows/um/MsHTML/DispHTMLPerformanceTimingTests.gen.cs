// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DispHTMLPerformanceTiming"/> struct.</summary>
public static unsafe partial class DispHTMLPerformanceTimingTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DispHTMLPerformanceTiming"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispHTMLPerformanceTiming).GUID, Is.EqualTo(IID_DispHTMLPerformanceTiming));
    }

    /// <summary>Validates that the <see cref = "DispHTMLPerformanceTiming"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispHTMLPerformanceTiming>(), Is.EqualTo(sizeof(DispHTMLPerformanceTiming)));
    }

    /// <summary>Validates that the <see cref = "DispHTMLPerformanceTiming"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispHTMLPerformanceTiming).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DispHTMLPerformanceTiming"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispHTMLPerformanceTiming), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispHTMLPerformanceTiming), Is.EqualTo(4));
        }
    }
}