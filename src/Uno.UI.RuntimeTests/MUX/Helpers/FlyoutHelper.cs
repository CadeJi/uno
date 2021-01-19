﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Uno.UI.RuntimeTests.MUX.Helpers
{
	internal static class FlyoutHelper
	{
		public static FrameworkElement GetOpenFlyoutPresenter()
		{
			var popups = VisualTreeHelper.GetOpenPopupsForXamlRoot(XamlRoot.Current);
			if(popups.Count != 1)
			{
				throw new InvalidOperationException("Expected exactly one open Popup.");
			}

			return popups[0] ?? throw new InvalidOperationException("Popup child should not be null.");
		}
	}
}
