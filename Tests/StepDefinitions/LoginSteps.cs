using TechTalk.SpecFlow;
using Tests.Drivers;

namespace Tests.StepDefinitions;

[Binding]
public class LoginSteps
{
    private readonly PlaywrightDriver _driver;

    public LoginSteps(PlaywrightDriver driver)
    {
        _driver = driver;
    }

    [Given(@"I open login page")]
    public async Task GivenIOpenLoginPage()
    {
        await _driver.Page.GotoAsync("https://example.com/login");
    }

    [When(@"I enter credentials")]
    public async Task WhenIEnterCredentials()
    {
        await _driver.Page.FillAsync("#username", "test");
        await _driver.Page.FillAsync("#password", "test123");
    }

    [Then(@"I should see dashboard")]
    public async Task ThenIShouldSeeDashboard()
    {
        await _driver.Page.WaitForURLAsync("**/dashboard");
    }
}

