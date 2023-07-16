// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IObjectWithSite"/> struct.</summary>
public static unsafe partial class IObjectWithSiteTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IObjectWithSite"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IObjectWithSite).GUID, Is.EqualTo(IID_IObjectWithSite));
    }

    /// <summary>Validates that the <see cref = "IObjectWithSite"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IObjectWithSite>(), Is.EqualTo(sizeof(IObjectWithSite)));
    }

    /// <summary>Validates that the <see cref = "IObjectWithSite"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IObjectWithSite).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IObjectWithSite"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IObjectWithSite), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IObjectWithSite), Is.EqualTo(4));
        }
    }
}