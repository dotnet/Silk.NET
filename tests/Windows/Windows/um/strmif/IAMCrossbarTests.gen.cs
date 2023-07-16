// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAMCrossbar"/> struct.</summary>
public static unsafe partial class IAMCrossbarTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAMCrossbar"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAMCrossbar).GUID, Is.EqualTo(IID_IAMCrossbar));
    }

    /// <summary>Validates that the <see cref = "IAMCrossbar"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAMCrossbar>(), Is.EqualTo(sizeof(IAMCrossbar)));
    }

    /// <summary>Validates that the <see cref = "IAMCrossbar"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAMCrossbar).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAMCrossbar"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAMCrossbar), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAMCrossbar), Is.EqualTo(4));
        }
    }
}