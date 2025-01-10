// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IBackEasingFunction"/> struct.</summary>
public static unsafe partial class IBackEasingFunctionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IBackEasingFunction"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IBackEasingFunction).GUID, Is.EqualTo(IID_IBackEasingFunction));
    }

    /// <summary>Validates that the <see cref = "IBackEasingFunction"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IBackEasingFunction>(), Is.EqualTo(sizeof(IBackEasingFunction)));
    }

    /// <summary>Validates that the <see cref = "IBackEasingFunction"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBackEasingFunction).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IBackEasingFunction"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBackEasingFunction), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBackEasingFunction), Is.EqualTo(4));
        }
    }
}
