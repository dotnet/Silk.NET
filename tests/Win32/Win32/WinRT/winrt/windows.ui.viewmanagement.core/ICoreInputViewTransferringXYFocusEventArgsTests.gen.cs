// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/> struct.</summary>
public static unsafe partial class ICoreInputViewTransferringXYFocusEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ICoreInputViewTransferringXYFocusEventArgs).GUID,
            Is.EqualTo(IID_ICoreInputViewTransferringXYFocusEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ICoreInputViewTransferringXYFocusEventArgs>(),
            Is.EqualTo(sizeof(ICoreInputViewTransferringXYFocusEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICoreInputViewTransferringXYFocusEventArgs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICoreInputViewTransferringXYFocusEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICoreInputViewTransferringXYFocusEventArgs), Is.EqualTo(4));
        }
    }
}
