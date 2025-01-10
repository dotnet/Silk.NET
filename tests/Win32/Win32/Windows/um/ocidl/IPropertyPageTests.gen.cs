// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IPropertyPage"/> struct.</summary>
public static unsafe partial class IPropertyPageTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPropertyPage"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPropertyPage).GUID, Is.EqualTo(IID_IPropertyPage));
    }

    /// <summary>Validates that the <see cref = "IPropertyPage"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPropertyPage>(), Is.EqualTo(sizeof(IPropertyPage)));
    }

    /// <summary>Validates that the <see cref = "IPropertyPage"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPropertyPage).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPropertyPage"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPropertyPage), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPropertyPage), Is.EqualTo(4));
        }
    }
}
