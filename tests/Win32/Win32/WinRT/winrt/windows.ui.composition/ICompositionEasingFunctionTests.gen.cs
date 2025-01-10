// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ICompositionEasingFunction"/> struct.</summary>
public static unsafe partial class ICompositionEasingFunctionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICompositionEasingFunction"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ICompositionEasingFunction).GUID,
            Is.EqualTo(IID_ICompositionEasingFunction)
        );
    }

    /// <summary>Validates that the <see cref = "ICompositionEasingFunction"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ICompositionEasingFunction>(),
            Is.EqualTo(sizeof(ICompositionEasingFunction))
        );
    }

    /// <summary>Validates that the <see cref = "ICompositionEasingFunction"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICompositionEasingFunction).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICompositionEasingFunction"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICompositionEasingFunction), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICompositionEasingFunction), Is.EqualTo(4));
        }
    }
}
