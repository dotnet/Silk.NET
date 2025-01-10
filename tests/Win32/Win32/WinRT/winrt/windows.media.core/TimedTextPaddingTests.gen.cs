// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "TimedTextPadding"/> struct.</summary>
public static unsafe partial class TimedTextPaddingTests
{
    /// <summary>Validates that the <see cref = "TimedTextPadding"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TimedTextPadding>(), Is.EqualTo(sizeof(TimedTextPadding)));
    }

    /// <summary>Validates that the <see cref = "TimedTextPadding"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TimedTextPadding).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TimedTextPadding"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TimedTextPadding), Is.EqualTo(40));
    }
}
