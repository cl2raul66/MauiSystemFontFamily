﻿using UIKit;

namespace MauiSystemFontFamily;

internal class PlatformFontFamilies : IPlatformFontFamilies
{
    readonly HashSet<string> fontFamilies;

    public PlatformFontFamilies()
    {
        try
        {
            fontFamilies = [.. UIFont.FamilyNames.OrderBy(x => x)];
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error getting iOS font families: {ex.Message}");
            fontFamilies = [];
        }
    }

    public bool Exists(string familyName) => fontFamilies.Contains(familyName);

    public HashSet<string> FontFamilies() => fontFamilies;
}
