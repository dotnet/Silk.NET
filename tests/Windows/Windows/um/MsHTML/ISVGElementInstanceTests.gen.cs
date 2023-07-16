// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISVGElementInstance"/> struct.</summary>
public static unsafe partial class ISVGElementInstanceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISVGElementInstance"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISVGElementInstance).GUID, Is.EqualTo(IID_ISVGElementInstance));
    }

    /// <summary>Validates that the <see cref = "ISVGElementInstance"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISVGElementInstance>(), Is.EqualTo(sizeof(ISVGElementInstance)));
    }

    /// <summary>Validates that the <see cref = "ISVGElementInstance"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISVGElementInstance).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISVGElementInstance"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISVGElementInstance), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISVGElementInstance), Is.EqualTo(4));
        }
    }
}