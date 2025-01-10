// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ITensorNative"/> struct.</summary>
public static unsafe partial class ITensorNativeTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITensorNative"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITensorNative).GUID, Is.EqualTo(IID_ITensorNative));
    }

    /// <summary>Validates that the <see cref = "ITensorNative"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITensorNative>(), Is.EqualTo(sizeof(ITensorNative)));
    }

    /// <summary>Validates that the <see cref = "ITensorNative"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITensorNative).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITensorNative"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITensorNative), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITensorNative), Is.EqualTo(4));
        }
    }
}
