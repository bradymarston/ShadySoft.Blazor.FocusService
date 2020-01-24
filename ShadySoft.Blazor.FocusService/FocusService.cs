using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace ShadySoft.Blazor.FocusService
{
    public class FocusService
    {
        private readonly IJSRuntime _jSRuntime;

        public FocusService(IJSRuntime jSRuntime)
        {
            _jSRuntime = jSRuntime;
        }
        public async Task SetFocusAsync(ElementReference element)
        {
            await _jSRuntime.InvokeVoidAsync("shadySoftFocusService.setFocus", element);
        }
    }
}
