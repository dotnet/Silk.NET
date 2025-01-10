// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IAppxBlockMapBlock"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IAppxBlockMapBlockTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppxBlockMapBlock"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppxBlockMapBlock).GUID, Is.EqualTo(IID_IAppxBlockMapBlock));
    }

    /// <summary>Validates that the <see cref = "IAppxBlockMapBlock"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppxBlockMapBlock>(), Is.EqualTo(sizeof(IAppxBlockMapBlock)));
    }

    /// <summary>Validates that the <see cref = "IAppxBlockMapBlock"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxBlockMapBlock).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppxBlockMapBlock"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxBlockMapBlock), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxBlockMapBlock), Is.EqualTo(4));
        }
    }
}
