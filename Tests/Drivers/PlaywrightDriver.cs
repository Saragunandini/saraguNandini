using Microsoft.Playwright;

namespace Tests.Drivers;

public class PlaywrightDriver
{
    public IPlaywright Playwright;
    public IBrowser Browser;
    public IBrowserContext Context;
    public IPage Page;

    public async Task Init()
    {
        Playwright = await Microsoft.Playwright.Playwright.CreateAsync();

        Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = true
        });

        Context = await Browser.NewContextAsync();
        Page = await Context.NewPageAsync();
    }

    public async Task Dispose()
    {
        await Browser.CloseAsync();
    }
}
