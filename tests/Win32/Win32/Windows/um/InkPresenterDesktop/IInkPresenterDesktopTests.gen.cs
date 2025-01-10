// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InkPresenterDesktop.h and um/InkPresenterDesktop_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IInkPresenterDesktop"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IInkPresenterDesktopTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IInkPresenterDesktop"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IInkPresenterDesktop).GUID, Is.EqualTo(IID_IInkPresenterDesktop));
    }

    /// <summary>Validates that the <see cref = "IInkPresenterDesktop"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IInkPresenterDesktop>(),
            Is.EqualTo(sizeof(IInkPresenterDesktop))
        );
    }

    /// <summary>Validates that the <see cref = "IInkPresenterDesktop"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IInkPresenterDesktop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IInkPresenterDesktop"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IInkPresenterDesktop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IInkPresenterDesktop), Is.EqualTo(4));
        }
    }
}
