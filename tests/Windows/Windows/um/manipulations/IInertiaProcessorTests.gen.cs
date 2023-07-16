// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IInertiaProcessor"/> struct.</summary>
public static unsafe partial class IInertiaProcessorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IInertiaProcessor"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IInertiaProcessor).GUID, Is.EqualTo(IID_IInertiaProcessor));
    }

    /// <summary>Validates that the <see cref = "IInertiaProcessor"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IInertiaProcessor>(), Is.EqualTo(sizeof(IInertiaProcessor)));
    }

    /// <summary>Validates that the <see cref = "IInertiaProcessor"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IInertiaProcessor).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IInertiaProcessor"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IInertiaProcessor), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IInertiaProcessor), Is.EqualTo(4));
        }
    }
}