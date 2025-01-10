// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IContactAnnotationList"/> struct.</summary>
public static unsafe partial class IContactAnnotationListTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IContactAnnotationList"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IContactAnnotationList).GUID, Is.EqualTo(IID_IContactAnnotationList));
    }

    /// <summary>Validates that the <see cref = "IContactAnnotationList"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IContactAnnotationList>(),
            Is.EqualTo(sizeof(IContactAnnotationList))
        );
    }

    /// <summary>Validates that the <see cref = "IContactAnnotationList"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IContactAnnotationList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IContactAnnotationList"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IContactAnnotationList), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IContactAnnotationList), Is.EqualTo(4));
        }
    }
}
