// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IUserDataAccountManagerForUser"/> struct.</summary>
public static unsafe partial class IUserDataAccountManagerForUserTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IUserDataAccountManagerForUser"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IUserDataAccountManagerForUser).GUID,
            Is.EqualTo(IID_IUserDataAccountManagerForUser)
        );
    }

    /// <summary>Validates that the <see cref = "IUserDataAccountManagerForUser"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IUserDataAccountManagerForUser>(),
            Is.EqualTo(sizeof(IUserDataAccountManagerForUser))
        );
    }

    /// <summary>Validates that the <see cref = "IUserDataAccountManagerForUser"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IUserDataAccountManagerForUser).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IUserDataAccountManagerForUser"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IUserDataAccountManagerForUser), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IUserDataAccountManagerForUser), Is.EqualTo(4));
        }
    }
}
