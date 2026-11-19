using Microsoft.Playwright;
namespace TodoAutomation.Pages;

public class AddRemovePage
{
   private readonly IPage _page;
   private readonly ILocator _addButton; 

   public AddRemovePage(IPage page)
    {
        _page = page;
        _addButton = _page.GetByRole(AriaRole.Button, new() {Name = "Add Element"});
    }

    public async Task ClickAddAsync()
    {
        await _addButton.ClickAsync();
    }

    public async Task NavigateAsync()
    {
        await _page.GotoAsync("https://the-internet.herokuapp.com/add_remove_elements/");
    }

    public ILocator DeleteButtons => _page.GetByRole(AriaRole.Button, new() { Name = "Delete"});
}