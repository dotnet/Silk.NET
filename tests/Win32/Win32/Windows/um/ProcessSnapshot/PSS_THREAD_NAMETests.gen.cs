// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PSS_THREAD_NAME"/> struct.</summary>
public static unsafe partial class PSS_THREAD_NAMETests
{
    /// <summary>Validates that the <see cref = "PSS_THREAD_NAME"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PSS_THREAD_NAME>(), Is.EqualTo(sizeof(PSS_THREAD_NAME)));
    }

    /// <summary>Validates that the <see cref = "PSS_THREAD_NAME"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PSS_THREAD_NAME).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PSS_THREAD_NAME"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PSS_THREAD_NAME), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(PSS_THREAD_NAME), Is.EqualTo(8));
        }
    }
}
