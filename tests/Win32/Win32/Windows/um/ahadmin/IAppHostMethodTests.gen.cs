// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IAppHostMethod"/> struct.</summary>
public static unsafe partial class IAppHostMethodTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppHostMethod"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppHostMethod).GUID, Is.EqualTo(IID_IAppHostMethod));
    }

    /// <summary>Validates that the <see cref = "IAppHostMethod"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppHostMethod>(), Is.EqualTo(sizeof(IAppHostMethod)));
    }

    /// <summary>Validates that the <see cref = "IAppHostMethod"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppHostMethod).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppHostMethod"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppHostMethod), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppHostMethod), Is.EqualTo(4));
        }
    }
}
