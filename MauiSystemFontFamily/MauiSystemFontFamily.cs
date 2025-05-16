namespace MauiSystemFontFamily;

public class MauiSystemFontFamily : IMauiSystemFontFamily
{
    readonly IPlatformFontFamilies platformFontFamilies;

    public MauiSystemFontFamily()
    {
        platformFontFamilies = new PlatformFontFamilies();
    }

    public IEnumerable<string> GetFontFamilyNames => platformFontFamilies.FontFamilies();
}
