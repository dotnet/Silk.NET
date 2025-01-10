// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IAppHostMappingExtension"/> struct.</summary>
public static unsafe partial class IAppHostMappingExtensionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppHostMappingExtension"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IAppHostMappingExtension).GUID,
            Is.EqualTo(IID_IAppHostMappingExtension)
        );
    }

    /// <summary>Validates that the <see cref = "IAppHostMappingExtension"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IAppHostMappingExtension>(),
            Is.EqualTo(sizeof(IAppHostMappingExtension))
        );
    }

    /// <summary>Validates that the <see cref = "IAppHostMappingExtension"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppHostMappingExtension).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppHostMappingExtension"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppHostMappingExtension), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppHostMappingExtension), Is.EqualTo(4));
        }
    }
}
