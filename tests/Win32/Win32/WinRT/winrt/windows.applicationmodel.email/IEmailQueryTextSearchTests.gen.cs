// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IEmailQueryTextSearch"/> struct.</summary>
public static unsafe partial class IEmailQueryTextSearchTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IEmailQueryTextSearch"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEmailQueryTextSearch).GUID, Is.EqualTo(IID_IEmailQueryTextSearch));
    }

    /// <summary>Validates that the <see cref = "IEmailQueryTextSearch"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IEmailQueryTextSearch>(),
            Is.EqualTo(sizeof(IEmailQueryTextSearch))
        );
    }

    /// <summary>Validates that the <see cref = "IEmailQueryTextSearch"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEmailQueryTextSearch).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IEmailQueryTextSearch"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEmailQueryTextSearch), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEmailQueryTextSearch), Is.EqualTo(4));
        }
    }
}
