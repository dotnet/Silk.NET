// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ICallFactory"/> struct.</summary>
public static unsafe partial class ICallFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICallFactory"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICallFactory).GUID, Is.EqualTo(IID_ICallFactory));
    }

    /// <summary>Validates that the <see cref = "ICallFactory"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICallFactory>(), Is.EqualTo(sizeof(ICallFactory)));
    }

    /// <summary>Validates that the <see cref = "ICallFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICallFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICallFactory"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICallFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICallFactory), Is.EqualTo(4));
        }
    }
}
