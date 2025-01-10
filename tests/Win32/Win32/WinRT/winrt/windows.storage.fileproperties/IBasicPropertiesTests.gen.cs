// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IBasicProperties"/> struct.</summary>
public static unsafe partial class IBasicPropertiesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IBasicProperties"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IBasicProperties).GUID, Is.EqualTo(IID_IBasicProperties));
    }

    /// <summary>Validates that the <see cref = "IBasicProperties"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IBasicProperties>(), Is.EqualTo(sizeof(IBasicProperties)));
    }

    /// <summary>Validates that the <see cref = "IBasicProperties"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBasicProperties).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IBasicProperties"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBasicProperties), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBasicProperties), Is.EqualTo(4));
        }
    }
}
