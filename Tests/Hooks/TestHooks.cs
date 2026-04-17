using TechTalk.SpecFlow;
using Tests.Drivers;

namespace Tests.Hooks;

[Binding]
public class TestHooks
{
    private readonly PlaywrightDriver _driver;

    public TestHooks(PlaywrightDriver driver)
    {
        _driver = driver;
    }

    [BeforeScenario]
    public async Task BeforeScenario()
    {
        await _driver.Init();
    }

    [AfterScenario]
    public async Task AfterScenario()
    {
        await _driver.Dispose();
    }
}

