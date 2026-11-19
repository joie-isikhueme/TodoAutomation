using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using TodoAutomation.Pages;

namespace TodoAutomation.Tests;

public class SmokeTests : PageTest
{
    [Test]
    public async Task HerokuPageLoads()
    {
        var addRemove = new AddRemovePage(Page);
        await addRemove.NavigateAsync();
        await Expect(Page).ToHaveTitleAsync("The Internet");   }

    [Test]
    public async Task HerokuAddElement()
    {
        var addRemove = new AddRemovePage(Page);
        await addRemove.NavigateAsync();
        await addRemove.ClickAddAsync();
        await Expect(addRemove.DeleteButtons).ToBeVisibleAsync();
            
    }

    [Test]
    public async Task HerokuAddTwoElements()
    {
        var addRemove = new AddRemovePage(Page);
        await addRemove.NavigateAsync();
        await addRemove.ClickAddAsync();
        await addRemove.ClickAddAsync();
        await Expect(addRemove.DeleteButtons).ToHaveCountAsync(2);

    }

}

